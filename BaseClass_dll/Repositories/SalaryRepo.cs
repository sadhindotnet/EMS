using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISalary : IBaseRepo<Salary> { }


    public class SalaryRepo : BaseRepo<Salary>, ISalary
    {
        public SalaryRepo(ApplicationDbContext context) : base(context) { }
    }
   
}
