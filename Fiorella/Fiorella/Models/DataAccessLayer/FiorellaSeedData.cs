using Fiorella.Models.Data;
using Fiorella.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Models.DataAccessLayer
{
    static public class FiorellaSeedData
    {
        static async public Task<IApplicationBuilder> Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<FiorellaDataContext>();

                var role = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
               
                db.Database.Migrate();
                InitSlider(db);
                InitSlideImages(db);
                InitAbout(db);
                InitAboutDetails(db);
                InitCategories(db);
                InitProducts(db);
                InitExperts(db);
                InitContactSection(db);
                InitLayoutInfo(db);
                InitBlog(db);
                InitInstaSlide(db);
                await InitRoles(role,db);
            }
            return app;
        }

        private static async Task InitRoles(RoleManager<IdentityRole> role, FiorellaDataContext db)
        {
            if (!db.Roles.Any())
            {

                await role.CreateAsync(new IdentityRole { Name = RoleConstant.Admin });
                await role.CreateAsync(new IdentityRole { Name = RoleConstant.User });
                await role.CreateAsync(new IdentityRole { Name = RoleConstant.Moderator });

            
            }
          await  db.SaveChangesAsync();
        }

        //private static void InitRoles(FiorellaDataContext db)
        //{
        //    if (!db.Roles.Any())
        //    {
        //        role
        //        db.Roles.AddRange(
        //            new IdentityRole {Name =  RoleConstant.Admin }, 
        //            new IdentityRole { Name = RoleConstant.User }, 
        //            new IdentityRole { Name = RoleConstant.Moderator});
        //    }
        //    db.SaveChanges();
        //}

        private static  void InitInstaSlide(FiorellaDataContext db)
        {
            if (!db.instaSlider.Any())
            {
                db.instaSlider.AddRange(
                    new SliderImage { Image = "instagram1.jpg" },
                    new SliderImage { Image = "instagram2.jpg" },
                    new SliderImage { Image = "instagram3.jpg" },
                    new SliderImage { Image = "instagram4.jpg" },
                    new SliderImage { Image = "instagram5.jpg" },
                    new SliderImage { Image = "instagram6.jpg" },
                    new SliderImage { Image = "instagram7.jpg" });
            }
            db.SaveChanges();
        }


        private static void InitBlog(FiorellaDataContext db)
        {
            if (!db.blogs.Any())
            {
                db.blogs.AddRange(
                    new Blog
                    {
                        Title = "Flower Power",
                        Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",

                        Image = "blog-feature-img-1.jpg"
                    },
                      new Blog
                      {
                          Title = "Flower Power",
                          Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",

                          Image = "blog-feature-img-4.jpg"
                      },
                        new Blog
                        {
                            Title = "Flower Power",
                            Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",

                            Image = "blog-feature-img-3.jpg"
                        }
                    );
            };

            db.SaveChanges();
        }
        private static void InitLayoutInfo(FiorellaDataContext db)
        {
            if (!db.layouts.Any())
            {
                db.layouts.Add(new LayoutInfo
                {
                    Logo = "logo.png",
                    Facebook = "https://www.linkedin.com/in/bakhtiyar-shamilzada-145159185/",
                    LinkedId = "https://www.facebook.com/shamilzada.bakhtiyar"
                });
            }
            db.SaveChanges();
        }
        private static void InitContactSection(FiorellaDataContext db)
        {
            if (!db.contactSection.Any())
            {
                db.contactSection.Add(new ContactSection { Title = "Join The Colorful Bunch!", Image = "h3-background-img.jpg" });
            }

            db.SaveChanges();
        }
        private static void InitExperts(FiorellaDataContext db)
        {
            if (!db.experts.Any())
            {
                db.experts.AddRange(new Experts
                {
                    Name = "SHIRLEY",
                    Surname = "HARRIS",
                    Position = "Manager",
                    Image = "h3-team-img-1.png"
                },
                    new Experts
                    {
                        Name = "Brook",
                        Surname = "Christal",
                        Position = "Manager",
                        Image = "h3-team-img-2.png"
                    },
                     new Experts
                     {
                         Name = "Brook",
                         Surname = "Christal",
                         Position = "Manager",
                         Image = "h3-team-img-3.png"
                     }, new Experts
                     {
                         Name = "Brook",
                         Surname = "Christal",
                         Position = "Manager",
                         Image = "h3-team-img-4.png"
                     }
                    );
            }

            db.SaveChanges();
        }
        private static void InitProducts(FiorellaDataContext db)
        {
            if (!db.products.Any())
            {
                db.products.AddRange(
                    new Product
                    {
                        Name = "MAJESTY PALM",
                        CategoryId = 1,
                        Price = 99,
                        Image = "shop-13-img.jpg"
                    },
                      new Product
                      {
                          Name = "MAJESTY PALM",
                          CategoryId = 3,
                          Price = 109,
                          Image = "shop-11-img.jpg"
                      },
                        new Product
                        {
                            Name = "MAJESTY PALM",
                            CategoryId = 2,
                            Price = 99,
                            Image = "shop-10-img.jpg"
                        },
                            new Product
                            {
                                Name = "MAJESTY PALM",
                                CategoryId = 3,
                                Price = 109,
                                Image = "shop-9-img.jpg"
                            },
                        new Product
                        {
                            Name = "MAJESTY PALM",
                            CategoryId = 1,
                            Price = 99,
                            Image = "shop-8-img.jpg"
                        }
                    );
            }
            db.SaveChanges();
        }
        private static void InitCategories(FiorellaDataContext db)
        {
            if (!db.categories.Any())
            {
                db.categories.AddRange(
                    new Category
                    {
                        Name = "Winter",
                        Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per"

                    },
                     new Category
                     {
                         Name = "Popular",
                         Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",

                     },
                      new Category
                      {
                          Name = "Season",
                          Description = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per",

                      }
                    );
            }
            db.SaveChanges();
        }
        private static void InitAboutDetails(FiorellaDataContext db)
        {
            if (!db.aboutDetails.Any())
            {
                db.aboutDetails.AddRange(
                 new AboutDetails
                 {
                     Name = "Hand picked just for you.",
                     AboutId = 1
                 },
                new AboutDetails
                {
                    Name = "Hand picked just for you.",
                    AboutId = 1
                },
                new AboutDetails
                {
                    Name = "Hand picked just for you.",
                    AboutId = 1
                });

            }; db.SaveChanges();
        }
        private static void InitAbout(FiorellaDataContext db)
        {

            if (!db.about.Any())
            {
                db.about.Add(new About
                {
                    Title = "<h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>",
                    Desc = "Where flowers are our inspiration to create lasting memories. Whatever the" +
                                "occasion...",
                    Icon = "h1-custom-icon.png",
                    Image = "h3-video-img.jpg"
                });

            }
            db.SaveChanges();
        }
        private static void InitSlider(FiorellaDataContext db)
        {
            if (!db.slider.Any())
            {
                db.slider.Add(new Slider
                {
                    Title = " <h1>Send <span>flowers</span> like</h1><h1>you mean it</h1>",
                    Desc = "Where flowers are our inspiration to create lasting memories. Whatever the occasion, our flowers will" +
                                "make it special cursus a sit amet mauris.",
                    Signature = "h2-sign-img.png"
                });

            }
            db.SaveChanges();
        }
        private static void InitSlideImages(FiorellaDataContext db)
        {
            if (!db.sliderImage.Any())
            {
                db.sliderImage.AddRange(new SliderImage
                {
                    Image = "h3-slider-background.jpg",
                    SliderId = 1,
                    IsChosen = true

                },
                new SliderImage
                {
                    Image = "h3-slider-background-2.jpg",
                    SliderId = 1,
                    IsChosen = true

                },
                 new SliderImage
                 {
                     Image = "h3-slider-background-3.jpg",
                     SliderId = 1,
                     IsChosen = false
                 }
                );


            }
            db.SaveChanges();
        }
    }
}
