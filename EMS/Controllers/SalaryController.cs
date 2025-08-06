using BaseClass_dll.Infrastructure;
using BaseClass_dll.Utility;
using BaseClass_dll;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private Modelmessage message;

        public SalaryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;           // loosely coupled
            message = new Modelmessage();       // tightly coupled
        }

        // GET: api/Users
        [HttpGet]
        public Task<IEnumerable<Salary>> Get()
        {
            return _unitOfWork.SalaryRepo.GetAll();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _unitOfWork.SalaryRepo.GetById(id);
            if (user == null)
                return NotFound($"User with ID = {id} not found");

            return Ok(user);
        }

        // POST: api/Users
        [HttpPost]
        public IActionResult Post(Salary entity)
        {
            _unitOfWork.SalaryRepo.Add(entity);
            message = _unitOfWork.Save();

            if (message.IsSucces)
                return Created("", entity);
            else
                return Problem(message.Message);
        }

        // PUT: api/Salary/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Salary entity)
        {
            var existing = await _unitOfWork.SalaryRepo.GetById(id);
            if (existing == null)
                return NotFound($"User with ID = {id} not found");

            // Update necessary fields
            existing.UserId = entity.UserId;
            existing.User = entity.User;
            existing.Year = entity.Year;
            existing.Month = entity.Month;
            existing.BasicSalary = entity.BasicSalary;
            existing.Allowance = entity.Allowance;
            existing.Bonus = entity.Bonus;
            existing.OvertimeAmount = entity.OvertimeAmount;
            existing.PermittedLeaveDays = entity.PermittedLeaveDays;
            existing.TotalLeaveDays = entity.TotalLeaveDays;
            existing.LeaveDeduction = entity.LeaveDeduction;
            //existing.NetSalary = entity.NetSalary;
            existing.PaymentDate = entity.PaymentDate;
            existing.PaymentMethod = entity.PaymentMethod;

            //base class fields
            existing.CreatedBy = entity.CreatedBy;
            existing.CreatedDate = entity.CreatedDate;
            existing.UpdatedBy = entity.UpdatedBy;
            existing.UpdatedDate = entity.UpdatedDate;
            existing.IsActive = entity.IsActive;


            // Add more field updates as required

            _unitOfWork.SalaryRepo.Update(existing);
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
            var existing = await _unitOfWork.SalaryRepo.GetById(id);
            if (existing == null)
                return NotFound($"User with ID = {id} not found");

            _unitOfWork.SalaryRepo.Delete(existing);
            message = _unitOfWork.Save();

            if (message.IsSucces)
                return Ok($"User with ID = {id} deleted");
            else
                return Problem(message.Message);
        }
    }
}
