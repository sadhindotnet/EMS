using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISection : IBaseRepo<Section> { }


    public class SectionRepo : BaseRepo<Section>, ISection
    {
        public SectionRepo(ApplicationDbContext context) : base(context) { }
    }
}
