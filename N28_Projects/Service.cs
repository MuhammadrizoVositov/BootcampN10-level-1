using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace N28_Projects
{
    public class Service
    {
        public const string filepath = "D:\\video.mp4";
        using (var httpClient = new HttpClient())
    {
        var videoData = await httpClient.GetByteArrayAsync(videoUrl);
    await File.WriteAllBytesAsync("video.mp4", filePath);
    }
}
}
