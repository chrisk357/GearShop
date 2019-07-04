﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;
        public FeedbackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Feedback> GetFeedbacksForGear(int gearId)
        {
            throw new NotImplementedException();
        }

        /*        public IEnumerable<Feedback> GetFeedbacksForGear(int gearId)
                {
                    return _appDbContext.Feedbacks.Where(f => f.Feedback.FeedbackIdd == gearId);
                }*/
    }
}
