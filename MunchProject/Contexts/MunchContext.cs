using MunchProject.Models;
using System.Data.Entity;

namespace MunchProject.Contexts
{
    public class MunchContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MunchProject.Models.WeaponContext>());

        public DbSet<MunchModel> Munches { get; set; }
        public DbSet<WeaponModel> Weapons { get; set; }
        public DbSet<SuitModel> Suits { get; set; }
        public DbSet<PantsModel> PantsList { get; set; }
    }
}
