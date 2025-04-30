using SampleContainerization.Domain.Entity;

namespace SampleContainerization.Infrastructure.Data
{
    public static class DBInitializerSeedData
    {
        public static void InitializeDatabase(BlogDbContext bLogDbContext)
        {
            if (bLogDbContext.Blogs.Any())
                return;

            var blogOne = new Blog
            {
                Name = "c#",
                Author = "kartik",
                Description = "C sharp is a good langauge",

            };
            var blogTwo = new Blog
            {
                Name = "web api",
                Author = "kartik",
                Description = "web apiis a good langauge",

            };
            var blogThree = new Blog
            {
                Name = "Blazor",
                Author = "kartik",
                Description = "Blazor is a good langauge",

            };

            bLogDbContext.Blogs.Add(blogOne);
            bLogDbContext.Blogs.Add(blogTwo);
            bLogDbContext.Blogs.Add(blogThree);

            bLogDbContext.SaveChanges();
        }
    }
}
