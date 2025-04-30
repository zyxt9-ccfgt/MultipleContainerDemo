using MediatR;
using SampleContainerization.Application.Blogs.Queries.GetBlogs;

namespace SampleContainerization.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommand : IRequest<BlogVm>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
