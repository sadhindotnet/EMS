using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IUser : IBaseRepo<User> { }


    public class UserRepo : BaseRepo<User>, IUser
    {
        public UserRepo(ApplicationDbContext context) : base(context) { }
    }
}
