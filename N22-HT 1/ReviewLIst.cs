using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT_1
{
    public class ReviewLIst<TReview> : IReviewList<TReview> where TReview : IReview
    {
        private List<TReview> _reviewList = new List<TReview>();
        public void Add(TReview review)

        {
            _reviewList.Add(review);
        }

        public string GetOverallReview()
        {
            if (_reviewList.Count == 0)
                return "Be the first to leave a review for this product";
            else
                if (_reviewList.Any(item => item.Star == 1))
            {
                return _reviewList.Find(item => item.Star == 1).Message;
            }
            else
            if (_reviewList.Any(item => item.Star == 5))
             {
                return "Great news! All reviews for this product are 5-star ratings.";
            }
            return " ";
        }

        public TReview GetReview(Guid id)
        {
            return _reviewList.Find(item => item.Id == id);
            
        }
        

        public TReview GetReview(string message)
        {
            return _reviewList.Find(item => item.Message == message);
        }

        public void Remove(Guid id)
        {
            var num = _reviewList.Find(item=> item.Id == id);
            if(num != null) 
            {
                _reviewList.Remove(num);
            }
        }

        public void Remove(TReview review)
        {
            var son=_reviewList.Find(item=>item.Id==review.Id);
            if(son != null)
            {
                _reviewList.Remove(son);
            }
        }

        public void Updating(Guid id, int star, string message)
        {

            var luboy = _reviewList.Find(item => item.Id == id);
            luboy.Star = star;
            luboy.Message = message;
            
        }
    }
}
