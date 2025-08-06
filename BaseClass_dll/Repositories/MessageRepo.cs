using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IMessage : IBaseRepo<Message> { }
    public class MessageRepo : BaseRepo<Message>, IMessage
    {
        public MessageRepo(ApplicationDbContext context) : base(context) { }
    }
}
