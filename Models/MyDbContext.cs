using dreamstarter_web.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace dreamstarter_web.Models 
{ 
    public class MyDbContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Campaign> Campaigns {get; set;}
        public DbSet<LikeCampaign> CampaignLikes {get; set;}
        public DbSet<CommentCampaign> CampaignComments {get; set;}


        /* 
            Setting up Primary Keys or Composite Key
        */
        //http://blog.staticvoid.co.nz/2012/entity_framework-navigation_property_basics_with_code_first/
        //https://coding.abel.nu/2012/03/ef-code-first-navigation-properties-and-foreign-keys/
        
        /* 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<Rented>().HasKey(t => t.RentId);
        }
        */
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./dreamstarter.db");

        } 

    }
}

