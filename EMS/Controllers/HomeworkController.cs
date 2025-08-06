using BaseClass_dll.Infrastructure;
using BaseClass_dll.Utility;
using BaseClass_dll;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private Modelmessage message;

        public HomeworkController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;           // loosely coupled
            message = new Modelmessage();       // tightly coupled
        }

        // GET: api/Users
        [HttpGet]
        public Task<IEnumerable<Homework>> Get()
        {
            return _unitOfWork.HomeworkRepo.GetAll();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _unitOfWork.HomeworkRepo.GetById(id);
            if (user == null)
                return NotFound($"User with ID = {id} not found");

            return Ok(user);
        }

        // POST: api/Users
        [HttpPost]
        public IActionResult Post(Homework entity)
        {
            _unitOfWork.HomeworkRepo.Add(entity);
            message = _unitOfWork.Save();

            if (message.IsSucces)
                return Created("", entity);
            else
                return Problem(message.Message);
        }

        // PUT: api/AcademyClass/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Homework entity)
        {
            var existing = await _unitOfWork.HomeworkRepo.GetById(id);
            if (existing == null)
                return NotFound($"User with ID = {id} not found");

            // Update necessary fields
            existing.SubjectId = entity.SubjectId;
            existing.TeacherId = entity.TeacherId;
            existing.Title = entity.Title;
            existing.Description = entity.Description;
            existing.AssignedDate = entity.AssignedDate;
            existing.DueDate = entity.DueDate;
            existing.AcademyClassId = entity.AcademyClassId;


            //base class fields
            existing.CreatedBy = entity.CreatedBy;
            existing.CreatedDate = entity.CreatedDate;
            existing.UpdatedBy = entity.UpdatedBy;
            existing.UpdatedDate = entity.UpdatedDate;
            existing.IsActive = entity.IsActive;


            // Add more field updates as required

            _unitOfWork.HomeworkRepo.Update(existing);
            message = _unitOfWork.Save();

            if (message.IsSucces)
                return Ok(existing);
            else
                return Problem(message.Message);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _unitOfWork.HomeworkRepo.GetById(id);
            if (existing == null)
                return NotFound($"User with ID = {id} not found");

            _unitOfWork.HomeworkRepo.Delete(existing);
            message = _unitOfWork.Save();

            if (message.IsSucces)
                return Ok($"User with ID = {id} deleted");
            else
                return Problem(message.Message);
        }
    }
}
