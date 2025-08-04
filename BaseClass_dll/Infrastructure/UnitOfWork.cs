using BaseClass_dll.Models;
using BaseClass_dll.Repositories;
using BaseClass_dll.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext db)
        {
            context = db;
        }

        //public IUser user;
        //public IUser UserRepo
        //{
        //    get
        //    {
        //        if (user == null)
        //        {
        //            user = new UserRepo(context);
        //        }
        //        return user;
        //    }

        //}
        private IUser user;
        public IUser UserRepo => user ??= new UserRepo(context);

        private IAcademyClass academyClass;
        public IAcademyClass AcademyClassRepo => academyClass ??= new AcademyClassRepo(context);



        private IAdmitCard admitCard;
        public IAdmitCard AdmitCardRepo => admitCard ??= new AdmitCardRepo(context);

        public Modelmessage Save()
        {
            Modelmessage modelMessage = new Modelmessage();
            try
            {
                if (context.SaveChanges() > 0)
                {
                    modelMessage.Message = $"Operation successful";
                    modelMessage.IsSucces = true;
                }
                else
                {
                    modelMessage.Message = $"Operation Failled ";
                    modelMessage.IsSucces = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    modelMessage.Message = ex.InnerException.Message;
                    modelMessage.IsSucces = false;
                }
                else
                {
                    modelMessage.Message = ex.Message;
                    modelMessage.IsSucces = false;
                }
            }
            return modelMessage;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

    }
}
