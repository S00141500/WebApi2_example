namespace Web_API_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web_API_2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web_API_2.Models.Web_API_2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web_API_2.Models.Web_API_2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Authors.AddOrUpdate(x => x.ID,
         new Author() { ID = 1, Name = "Jane Austen" },
         new Author() { ID = 2, Name = "Charles Dickens" },
         new Author() { ID = 3, Name = "Miguel de Cervantes" }
         );

            context.Books.AddOrUpdate(x => x.ID,
                new Book()
                {
                    ID = 1,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    AuthorID = 1,
                    Price = 9.99M,
                    Genre = "Comedy of manners"
                },
                new Book()
                {
                    ID = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    AuthorID = 1,
                    Price = 12.95M,
                    Genre = "Gothic parody"
                },
                new Book()
                {
                    ID = 3,
                    Title = "David Copperfield",
                    Year = 1850,
                    AuthorID = 2,
                    Price = 15,
                    Genre = "Bildungsroman"
                },
                new Book()
                {
                    ID = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    AuthorID = 3,
                    Price = 8.95M,
                    Genre = "Picaresque"
                }
                );
        }
    }
}
