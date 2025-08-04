using BaseClass_dll.Repositories;
using BaseClass_dll.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        public IUser? UserRepo { get; }
        public IAcademyClass? AcademyClassRepo { get; }
        public IAdmitCard? AdmitCardRepo { get; }
        public Modelmessage Save();

    }
}
