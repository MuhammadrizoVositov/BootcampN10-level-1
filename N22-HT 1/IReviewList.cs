using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT_1
{
    public interface IReviewList<TReview>where TReview : IReview
    {
        void Add(TReview review);
        void Updating(Guid id,int star,string message);
        void Remove(Guid id);
        void Remove(TReview review);
        TReview GetReview(Guid id);
        TReview GetReview(string message);
        string GetOverallReview();
    }
}
