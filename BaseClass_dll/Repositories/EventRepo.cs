using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IEvent : IBaseRepo<Event> { }


    public class EventRepo : BaseRepo<Event>, IEvent
    {
        public EventRepo(ApplicationDbContext context) : base(context) { }
    }
}
