using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ITransaction : IBaseRepo<Transaction> { }


    public class TransactionRepo : BaseRepo<Transaction>, ITransaction
    {
        public TransactionRepo(ApplicationDbContext context) : base(context) { }
    }
}
