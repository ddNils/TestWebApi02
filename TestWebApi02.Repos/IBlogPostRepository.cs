using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApi02.Repos
{
    public interface IBlogPostRepository
    {
        IQueryable<Entities.Blogpost> GetBlogPosts();
        Entities.Blogpost GetBlogPostById(int blogId);
    }
}
