using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IAdmitCard : IBaseRepo<AdmitCard> { }


    public class AdmitCardRepo : BaseRepo<AdmitCard>, IAdmitCard
    {
        public AdmitCardRepo(ApplicationDbContext context) : base(context) { }
    }


}
