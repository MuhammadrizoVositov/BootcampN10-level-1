using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N31_HT1
{
    public class ShortenedLink
    {
        public int Id { get; set; }
        public string OriginalUrl { get; set; }

        public string ShortenedUrl { get; set; }

        public ShortenedLink( int id,string originalUrl,string shortenedUrl)
        {
            Id = Id;
            OriginalUrl = originalUrl;
            ShortenedUrl = shortenedUrl;

        }
    }
    

}
