using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT_1
{


    public class Review : IReview
    {
        public Guid Id { get; set; }
        public int Star { get; set; }
        public string Message { get; set; }

        public Review(int star, string message)
        {
            Id = Guid.NewGuid();
            Star = star;
            Message = message;
        }
    }

}
