using MediatR;
using SampleContainerization.Application.Blogs.Queries.GetBlogs;

namespace SampleContainerization.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQuery : IRequest<BlogVm>
    {
        public int BlogId { get; set; }
    }
}
