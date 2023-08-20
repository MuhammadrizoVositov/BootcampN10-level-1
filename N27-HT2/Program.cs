




using N27_HT2;
using System.Text.Json;

List<VideoPost> posts = new List<VideoPost>
{
    new VideoPost{Title="czxczx",Topic="sdsa",Id=Guid.NewGuid(),Description="Adasd",Like=10,Dislike=29},
    new VideoPost{Title="czxczx",Topic="sdsa",Id=Guid.NewGuid(),Description="Adasd",Like=100,Dislike=59},
    new VideoPost{Title="czxczx",Topic="sdsa",Id=Guid.NewGuid(),Description="Adasd",Like=50,Dislike=99},
    new VideoPost{Title="czxczx",Topic="sdsa",Id=Guid.NewGuid(),Description="Adasd",Like=70,Dislike=89},
    new VideoPost{Title="czxczx",Topic="sdsa",Id=Guid.NewGuid(),Description="Adasd",Like=60,Dislike=39}
};

Console.WriteLine(JsonSerializer.Serialize( posts.MaxBy(x => x.Like)));
Console.WriteLine(JsonSerializer.Serialize( posts.MinBy(x => x.Dislike)));
Console.WriteLine(posts.Average(x => x.Like));
Console.WriteLine(posts.Sum(x => x.Dislike));

posts.Select(x => new { Title = x.Title, Description = x.Description }).ToList().ForEach(x =>Console.WriteLine(x.Title+" "+x.Description));
Console.WriteLine(JsonSerializer.Serialize(posts.DistinctBy(x=>x.Topic)));
Console.WriteLine(JsonSerializer.Serialize( posts.GroupBy(x => x.Topic)));

