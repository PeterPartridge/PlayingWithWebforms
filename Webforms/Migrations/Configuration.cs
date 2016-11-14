namespace Webforms.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Webforms.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Webforms.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Webforms.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.catagories.AddOrUpdate(c => c.CategoryName,
           new catagoryModel
           {
               CategoryID = 1,
               CategoryName = "Cars"
           },
           new Models.catagoryModel
           {
               CategoryID = 2,
               CategoryName = "Planes"
           },
           new Models.catagoryModel
           {
               CategoryID = 3,
               CategoryName = "Trucks"
           },
           new Models.catagoryModel
           {
               CategoryID = 4,
               CategoryName = "Boats"
           },
           new Models.catagoryModel
           {
               CategoryID = 5,
               CategoryName = "Rockets"
           }
  );



            context.products.AddOrUpdate(c => c.productName,

                     new ProductModel
                     {
                         productId = 1,
                         productName = "Convertible Car",
                         description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                                       "Power it up and let it go!",
                         imagePath = "carconvert.png",
                         unitPrice = 22.50,
                         catagoryId = 1
                     },
                     new ProductModel
                     {
                         productId = 2,
                         productName = "Old-time Car",
                         description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                         imagePath = "carearly.png",
                         unitPrice = 15.95,
                         catagoryId = 1
                     },
                     new ProductModel
                     {
                         productId = 3,
                         productName = "Fast Car",
                         description = "Yes this car is fast, but it also floats in water.",
                         imagePath = "carfast.png",
                         unitPrice = 32.99,
                         catagoryId = 1
                     },
                     new ProductModel
                     {
                         productId = 4,
                         productName = "Super Fast Car",
                         description = "Use this super fast car to entertain guests. Lights and doors work!",
                         imagePath = "carfaster.png",
                         unitPrice = 8.95,
                         catagoryId = 1
                     },
                     new ProductModel
                     {
                         productId = 5,
                         productName = "Old Style Racer",
                         description = "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                                       "No batteries required.",
                         imagePath = "carracer.png",
                         unitPrice = 34.95,
                         catagoryId = 1
                     },
                   
            new Models.ProductModel
            {
                productId = 6,
                productName = "Ace Plane",
                description = "Authentic airplane toy. Features realistic color and details.",
                imagePath = "planeace.png",
                unitPrice = 95.00,
                catagoryId = 2
            },
                     new Models.ProductModel
                     {
                         productId = 7,
                         productName = "Glider",
                         description = "This fun glider is made from real balsa wood. Some assembly required.",
                         imagePath = "planeglider.png",
                         unitPrice = 4.95,
                         catagoryId = 2
                     },
                     new Models.ProductModel
                     {
                         productId = 8,
                         productName = "Paper Plane",
                         description = "This paper plane is like no other paper plane. Some folding required.",
                         imagePath = "planepaper.png",
                         unitPrice = 2.95,
                         catagoryId = 2
                     },
                     new Models.ProductModel
                     {
                         productId = 9,
                         productName = "Propeller Plane",
                         description = "Rubber band powered plane features two wheels.",
                         imagePath = "planeprop.png",
                         unitPrice = 32.95,
                         catagoryId = 2
                     },
                     new Models.ProductModel
                     {
                         productId = 10,
                         productName = "Early Truck",
                         description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                         imagePath = "truckearly.png",
                         unitPrice = 15.00,
                         catagoryId = 3
                     },
            new Models.ProductModel
            {
                productId = 11,
                productName = "Fire Truck",
                description = "You will have endless fun with this one quarter sized fire truck.",
                imagePath = "truckfire.png",
                unitPrice = 26.00,
                catagoryId = 3
            },
                              new Models.ProductModel
                              {
                                  productId = 12,
                                  productName = "Big Truck",
                                  description = "This fun toy truck can be used to tow other trucks that are not as big.",
                                  imagePath = "truckbig.png",
                                  unitPrice = 29.00,
                                  catagoryId = 3
                              },
                              new Models.ProductModel
                              {
                                  productId = 13,
                                  productName = "Big Ship",
                                  description = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                                                "artifically intelligent computer brain!",
                                  imagePath = "boatbig.png",
                                  unitPrice = 95.00,
                                  catagoryId = 4
                              },
                              new Models.ProductModel
                              {
                                  productId = 14,
                                  productName = "Paper Boat",
                                  description = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" +
                                                "Some folding required.",
                                  imagePath = "boatpaper.png",
                                  unitPrice = 4.95,
                                  catagoryId = 4
                              },
                              new Models.ProductModel
                              {
                                  productId = 15,
                                  productName = "Sail Boat",
                                  description = "Put this fun toy sail boat in the water and let it go!",
                                  imagePath = "boatsail.png",
                                  unitPrice = 42.95,
                                  catagoryId = 4

                              },
                     new Models.ProductModel
                     {
                         productId = 16,
                         productName = "Rocket",
                         description = "This fun rocket will travel up to a height of 200 feet.",
                         imagePath = "rocket.png",
                         unitPrice = 122.95,
                         catagoryId = 5
                     }
                 );


        }
    }
}
