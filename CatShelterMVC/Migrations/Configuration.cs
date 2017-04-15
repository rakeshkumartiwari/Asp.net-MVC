namespace CatShelterMVC.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CatShelterMVC.Models.CatDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CatShelterMVC.Models.CatDb";
        }

        protected override void Seed(CatShelterMVC.Models.CatDb context)
        {
            context.Cats.AddOrUpdate(c => c.Name,
                new Cat { Name="Lucy", Color="Black", City="Hyderabad" },
                new Cat { Name = "Micky", Color = "White", City = "Kolkata" },
                new Cat { Name = "Tiny", Color = "Brown", City = "Mumbai" },
                new Cat { Name = "Puppy", Color = "Black", City = "Delhi" }
                );
        }
    }
}
