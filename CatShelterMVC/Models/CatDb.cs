using System.Data.Entity;

namespace CatShelterMVC.Models
{
    public class CatDb:DbContext
    {
        public DbSet<Cat> Cats { get; set; }

    }
}