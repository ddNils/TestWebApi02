using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApi02.Entities;

namespace TestWebApi02.Repos
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private ApplicationDbContext _ctx;

        public BlogPostRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public Blogpost GetBlogPostById(int blogId)
        {
            return _ctx.BlogPosts.Where(b => b.Id == blogId).FirstOrDefault();
        }

        public IQueryable<Blogpost> GetBlogPosts()
        {
            return _ctx.BlogPosts.AsQueryable();
        }
    }
}
