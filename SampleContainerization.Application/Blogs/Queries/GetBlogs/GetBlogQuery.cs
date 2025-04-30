using MediatR;

namespace SampleContainerization.Application.Blogs.Queries.GetBlogs
{
    //public class GetBlogQuery : IRequest<List<BlogVm>>
    //{
    //}

    public record GetBlogQuery : IRequest<List<BlogVm>>
    {

    }
}
