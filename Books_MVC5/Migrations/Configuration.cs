namespace Books_MVC5.Migrations
{
    using Books_MVC5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Books_MVC5.DAL.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Books_MVC5.DAL.BookContext context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
                new Category { Id = 1, Name = "Art/Bsiness", IsActive = true },
                new Category { Id = 2, Name = "Biography", IsActive = true },
                new Category { Id = 3, Name = "Diary", IsActive = true },
                new Category { Id = 4, Name = "Novel", IsActive = true }, new Category { Id = 5, Name = "Travel", IsActive = true },
                new Category { Id = 6, Name = "Science", IsActive = true },
                new Category { Id = 7, Name = "Journal", IsActive = true },
                new Category { Id = 8, Name = "Math", IsActive = true },
                new Category { Id = 9, Name = "Crime", IsActive = true },
                new Category { Id = 10, Name = "Cook Book", IsActive = true },
                new Category { Id = 11, Name = "Health/Fitness", IsActive = true },
                new Category { Id = 12, Name = "Philosophy", IsActive = true },
                new Category { Id = 13, Name = "Religion", IsActive = true },
                new Category { Id = 14, Name = "Architecture", IsActive = true },
                new Category { Id = 15, Name = "Humor", IsActive = true },
                new Category { Id = 16, Name = "Self-Help", IsActive = true },
                new Category { Id = 17, Name = "Funny", IsActive = true },
                new Category { Id = 18, Name = "Cartoon", IsActive = true });





        }
    }
}
