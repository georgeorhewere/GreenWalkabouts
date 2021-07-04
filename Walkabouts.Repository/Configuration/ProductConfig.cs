using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Walkabouts.Data.Domain;

namespace Walkabouts.Repository.Configuration
{
    internal class ProductConfig : BaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            
            builder
               .Property(m => m.UnitPrice)
               .HasColumnType("decimal(18,2)")
               .IsRequired();
            builder
               .Property(m => m.ProductName)
               .IsRequired();                
            builder
               .Property(m => m.Description);
            builder
               .Property(m => m.StockLevel)
               .IsRequired();          

          
            builder.HasData(
                    new Product
                    {
                        Id=1,
                        ProductName = "Samsung 50 inch",
                        Description = "",
                        UnitPrice = (decimal)3400.00,
                        StockLevel = 15,
                        CreatedOn= DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Speechless: Controlling Words, Controlling Minds Hardcover",
                        Description = "Every single American needs to read Michael Knowles’s Speechless. I don’t mean ‘read it eventually.’ I mean: stop what you’re doing and pick up this boo",
                        UnitPrice = (decimal)24.49,
                        StockLevel = 11,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Oculus Quest 2 — Advanced All-In-One Virtual Reality Headset ",
                        Description = @"Next-level Hardware - Make every move count with a blazing-fast processor and our highest-resolution display
All-In-One Gaming - With backward compatibility, you can explore new titles and old favorites in the expansive Quest content library",
                        UnitPrice = (decimal)299.00,
                        StockLevel = 5,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "LG 65''Smart UHD 4K Satellite Ai ThinQ TV ",
                        Description = @"The Real 4K TV for all your entertainment needsLG UHD TV was made to entertain by taking everything you watch to a new level. Whether it's cinema, sports, or games, it delivers real 4K images with vivid color and fine detail. Enjoy more realistic images in four times the resolution of Full HD.",
                        UnitPrice = (decimal)378.89,
                        StockLevel = 15,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Power Strip with USB ",
                        Description = "2 Outlets 3 USB Charging Ports(3.1A, 15W)",
                        UnitPrice = (decimal)9.38,
                        StockLevel = 15,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "SUNGAIT Ultra Lightweight Rectangular Polarized Sunglasses",
                        Description = "",
                        UnitPrice = (decimal)300.00,
                        StockLevel = 15,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Disposable Face Masks, Face Masks of 50 Pack Disposable Mask",
                        Description = @"[Face Masks]: Mouth Face Mask 3-ply With Elastic Earloops for Day-to-day protection
                                      [Disposable Masks]: The disposable face mask is made from a supportive and powerful 3 - layered fabric for 3 - Way filter
                                      [Disposable Face Masks]: Designed for a softer and smoother feel for Breathability all day long",
                        UnitPrice = (decimal)12.99,
                        StockLevel = 100,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "VIVOHOME Electric Portable Compact Countertop Automatic Ice Cube Maker Machine",
                        Description = @"Lightweight feature makes it portable for using anywhere; Compact design performs well on any occasion; Perfect for RVs, boats, kitchens, tea shops, KTVs, offices, bars, restaurants, parties, gatherings, holidays, etc",
                        UnitPrice = (decimal)96.78,
                        StockLevel = 73,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 9,
                        ProductName = "Venture Pal Large 1 Gallon/128 OZ Motivational BPA Free Leakproof Water Bottle with Straw & Time Marker",
                        Description = @"With unique inspirational quote and time marker on it, this water bottle is great for measuring your daily intake of water, reminding you stay hydrated and drink enough water throughout the day. A must have for any fitness goals including weight loss and overall health.",
                        UnitPrice = (decimal)14.99,
                        StockLevel = 57,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 10,
                        ProductName = "SparkPod Shower Head",
                        Description = @"High pressure rainfall shower head: Our luxury bathroom rainhead is the perfect replacement that will jet out high-pressure rain of hot water so your whole body is doused with the downpour. You won’t go back to a normal shower again",
                        UnitPrice = (decimal)29.72,
                        StockLevel = 132,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 11,
                        ProductName = "Lamicall Cell Phone Stand, Phone Dock",
                        Description = @"The iPhone stand is made of high-quality aluminum alloy with a nice finish. Stable and easy to watch Youtube or FaceTime. Besides, rubber non-slip pads protect the surface of your phone case and desk from scratches.",
                        UnitPrice = (decimal)7.99,
                        StockLevel = 84,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 12,
                        ProductName = "Acer Swift 3 Thin & Light Laptop, 14 Full HD IPS",
                        Description = @"AMD Ryzen 7 4700U Octa-Core Mobile Processor (Up to 4.1 GHz) with Radeon Graphics; 8GB LPDDR4 Memory; 512GB PCIe NVMe SSD
                                        14 Full HD Widescreen IPS LED - backlit display(1920 x 1080 resolution; 16:9 aspect ratio)
                                        Intel wireless Wi - Fi 6 AX200 802.11ax; HD webcam(1280 x 720); Backlit keyboard; Fingerprint reader",
                        UnitPrice = (decimal)618.92,
                        StockLevel = 5,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 13,
                        ProductName = "Tablet 10.1 inch Android 9.0 Tablet PC",
                        Description = @"The 10.1 inch Tablet PC is equipped with high-performance 1.6GHz Quad-Core processor & Android 9.0 operating systems, capable of guaranteeing an extremely fluid gaming experience and a fast multimedia experience. With 2GB RAM and 32 GB internal storage, it's very suitable for running a number of entertainment applications without stucking, such as Netflix, Amazon Prime and Youtube",
                        UnitPrice = (decimal)99.99,
                        StockLevel = 39,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 14,
                        ProductName = "Apple IPhone 7 4.7 Inch 2GB",
                        Description = "iPhone 7 is the 10th generation of Apple (Apple) mobile phone, released at 1:00 am Beijing time on September 8, 2016 at the San Francisco Graham Municipal Auditorium 2016 Apple Autumn New Product Launch Conference",
                        UnitPrice = (decimal)230.30,
                        StockLevel = 46,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 15,
                        ProductName = "Nintendo Switch with Neon Blue and Neon Red Joy‑Con",
                        Description = @"3 Play Styles: TV Mode, Tabletop Mode, Handheld Mode
                                         6.2-inch, multi-touch capacitive touch screen
                                         4.5-9+ Hours of Battery Life will vary depending on software usage conditions
                                         Connects over Wi-Fi for multiplayer gaming; Up to 8 consoles can be connected for local wireless multiplayer",
                        UnitPrice = (decimal)314.95,
                        StockLevel = 15,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 16,
                        ProductName = "Odoland Portable LED Camping Lantern with Ceiling Fan",
                        Description = @"Versatile light/fan: Ultra Bright 18 individual low powered LED bulbs. The fan has high and low settings to provide nice air circulation and lit up the tent nicely. You can orient in so many positions.",
                        UnitPrice = (decimal)16.67,
                        StockLevel = 15,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 17,
                        ProductName = "Diamond Drill Bit Set Hole, 15PCS Hole Saw Set",
                        Description = @"Used on Drill Glass,Wood,Tile Bottles,Blocks Jars, Ceramic,Slate Mable, Granite Light Stone, and other hard surfaces",
                        UnitPrice = (decimal)12.99,
                        StockLevel = 186,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 18,
                        ProductName = "Camping Hammock for Outdoors Travel Backpacking",
                        Description = @"Our hammocks are well made of 210T parachute nylon fabric, to be soft while breathable and quick dry, triple stitching to strength durability and security.",
                        UnitPrice = (decimal)19.99,
                        StockLevel = 95,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    },
                    new Product
                    {
                        Id = 19,
                        ProductName = "General Tools 72 Leather Hole Punch Tool",
                        Description = "tool is self-opening; revolving punch is powerful and easy, giving you the capability to cleaning punch holes every time",
                        UnitPrice = (decimal)9.25,
                        StockLevel = 83,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    }

                    );

        }

        protected override string EntityName { get => $"{nameof(Product)}s"; }
    }
}