using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IEventImage : IBaseRepo<EventImage> { }


    public class EventImageRepo : BaseRepo<EventImage>, IEventImage
    {
        public EventImageRepo(ApplicationDbContext context) : base(context) { }
    }
}
