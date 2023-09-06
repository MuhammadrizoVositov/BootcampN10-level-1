using System.ComponentModel.DataAnnotations;

namespace T5
{
    public class BolgServise
    {
        List<Blog> _blogs=new List<Blog>();
        
        public void Create(Blog model)
        {
            if(model==null && string.IsNullOrEmpty(model.Title) && string.IsNullOrEmpty(model.Body))
            {
                throw new ValidationException();
            }
            
        }
        public Blog GetBlog(int id) 
        {
            var blog = _blogs.FirstOrDefault(b => b.Id == id);
            if(blog == null)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Blog not found");
            }
            return blog;
        }
        public void Update(Blog model)
        {
            if (model==null&& string.IsNullOrEmpty(model.Title)&& string.IsNullOrEmpty(model.Body))
            {
                throw new ValidationException();
            }
            var exsit=_blogs.FirstOrDefault(x=>x.Id==model.Id);
            if(exsit==null) 
            {
                throw new InvalidOperationException();
            }

        }
        public void Delete(int id) 
        {
            var blog=_blogs.FirstOrDefault(a => a.Id==id);
            if(blog==null )
            {
                throw new  ArgumentException();
            }
            _blogs.Remove(blog);
        }
        

        
    }
}
