using Fiorella.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Fiorella.Models.DataAccessLayer
{
    static public class FiorellaSeedData
    {
        static public IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<FiorellaDataContext>();

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
              // InitUser(db);
                InitRole(db);
                InitInstaSlide(db);
            }
            return app;
        }

        private static void InitInstaSlide(FiorellaDataContext db)
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
        private static void InitRole(FiorellaDataContext db)
        {
            if (!db.roles.Any())
            {
                db.roles.AddRange(
                    new Role { RoleName = "User" },
                    new Role { RoleName = "Admin" });
            }
            db.SaveChanges();
        }
        private static void InitUser(FiorellaDataContext db)
        {
            if (!db.users.Any())
            {
                db.users.AddRange(
                    new User { Name = "Cintia", Surname = "Nixon", RoleId = 1 },
                    new User { Name = "Carrie", Surname = "Parker", RoleId = 2 });
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

                },
                new SliderImage
                {
                    Image = "h3-slider-background-2.jpg"
                },
                 new SliderImage
                 {
                     Image = "h3-slider-background-3.jpg"
                 }
                );


            }
            db.SaveChanges();
        }
    }
}
