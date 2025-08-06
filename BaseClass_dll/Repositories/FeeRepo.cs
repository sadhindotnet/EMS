using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IFee : IBaseRepo<Fee> { }


    public class FeeRepo : BaseRepo<Fee>, IFee
    {
        public FeeRepo(ApplicationDbContext context) : base(context) { }
    }
}
