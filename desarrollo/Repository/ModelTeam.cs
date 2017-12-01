namespace desarrollo.Repository
{
    using desarrollo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class ModelTeam : DbContext
    {
        public DbSet<team> Team { get; set; }
        public DbSet<Player> Player { get; set; }
        public ModelTeam()
            : base("name=ModelTeam")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                 .Remove<PluralizingTableNameConvention>();
        }


    }

   
}