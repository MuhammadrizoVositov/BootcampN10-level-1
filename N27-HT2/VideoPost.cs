using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT2
{
    public class VideoPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public string Topic { get; set; }


       
    }
    
}
