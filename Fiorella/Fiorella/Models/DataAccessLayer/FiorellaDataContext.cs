using Fiorella.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.DataAccessLayer
{
    public class FiorellaDataContext : DbContext
    {
        public FiorellaDataContext(DbContextOptions<FiorellaDataContext> options)
            :base(options)
        {

        }

        public DbSet<Slider> slider { get; set; }
        public DbSet<About> about { get; set; }
        public DbSet<AboutDetails> aboutDetails { get; set; }
        public DbSet<SliderImage> sliderImage { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Experts> experts { get; set; }
        public DbSet<ContactSection> contactSection { get; set; }
        public DbSet<LayoutInfo> layouts { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<MiniSlider> miniSliders { get; set; }
        public DbSet<SliderImage> instaSlider { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(b =>
            {
                b.Property(p => p.CreatedDate).HasDefaultValueSql("DATEADD(HOUR,4,GETUTCDATE())");
            });

            modelBuilder.Ignore<BaseEntity>();
        }
    }
}
