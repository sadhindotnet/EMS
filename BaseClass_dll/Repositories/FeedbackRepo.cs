using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IFeedback : IBaseRepo<Feedback> { }


    public class FeedbackRepo : BaseRepo<Feedback>, IFeedback
    {
        public FeedbackRepo(ApplicationDbContext context) : base(context) { }
    }
}
