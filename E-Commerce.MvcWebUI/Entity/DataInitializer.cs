using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>()
            {
                new Category(){Name = "Camera", Description = "Camera related products"},
                new Category(){Name = "Computer", Description = "Computer related products"},
                new Category(){Name = "Electronic", Description = "Electronic related products"},
                new Category(){Name = "Phone", Description = "Phone related products"},
                new Category(){Name = "White Good", Description = "White Good related products"}
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();


            var products = new List<Product>()
            {
                new Product()
                {
                    Name = "Canon EOS 4000D DSLR Camera w/Canon EF-S 18-55mm F/3.5-5.6 III Zoom Lens + Case + 32GB SD Card (15pc Bundle)",
                    Description = "This Jerry’s Photo Bundle Comes with:\r\nCanon EOS 4000D Camera Body\r\n\r\nCanon EF-S 18-55mm f/3.5-5.6 III Lens\r\n\r\n32GB SD Memeory Card\r\n\r\nUSB SD Card Reader\r\n\r\nDeluxe GAdget Bag\r\n\r\n58mm UV Filter\r\n\r\nLens Cleaning Cloth\r\n\r\nSpider Tripod",
                    Price = 346.00,
                    Stock = 65,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 1,
                    Image = "1.jpg"

                },
                new Product()
                {
                    Name = "Canon PowerShot SX420 Digital Camera w/ 42x Optical Zoom - Wi-Fi & NFC Enabled (Black)",
                    Description = "Capture your family's precious moments with the PowerShot SX420 IS camera, whether it's a vacation, a party or just every day life. With a powerful 42x Optical Zoom (24–1008mm) and 24mm wide-angle lens, the PowerShot SX420 IS is primed to capture the shots you need, and can easily share them with the addition of built-in Wi-Fi* and NFC** connectivity for quick broadcast of your favorite shots. Whether shooting landscapes or faraway wildlife, the camera is ready to take on a versatile array of subjects thanks to its 20.0 Megapixel*** sensor and Canon DIGIC 4+ Image Processor, which help create crisp resolution and beautiful, natural images. You can also create 720p HD video at the press of a button, zooming in and out while shooting. Images you'll want to keep and share are easy to achieve with Smart AUTO that intelligently selects the most appropriate camera settings to capture incredible images in a variety of situations. Fun is on the table with effects such as Fisheye, Toy Camera and Monochrome. For versatility and quality, you can't go wrong with the PowerShot SX420 IS camera.",
                    Price = 72,
                    Stock = 105,
                    IsApproved = false,
                    IsHome= false,
                    CategoryId = 1,
                    Image = "2.jpg"

                },
                new Product()
                {
                    Name = "CYBERPOWERPC Gamer Xtreme VR Gaming PC, Intel Core i5-9400F 2.9GHz, NVIDIA GeForce GTX 1660 6GB, 8GB DDR4, 240GB SSD, 1TB HDD, WiFi Ready & Win 10 Home (GXiVR8060A8, Black)",
                    Description = "Destroy the competition with the Cyber PowerPC Gamer Extreme VR series of gaming desktops. The Gamer Extreme VR series features the latest generation of high performance Intel Core processors and ultra-quick DDR RAM to easily handle system-intensive tasks, such as high definition video playback and gaming. Coupled with powerful discreet video cards, the Gamer Extreme series provides a smooth gaming and multimedia experience.",
                    Price = 749.99,
                    Stock = 340,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 2,
                    Image = "3.jpg"

                },
                new Product()
                {
                    Name = "Acer Aspire Z24-890-UA91 AIO Desktop, 23.8 inches Full HD, 9th Gen Intel Core i5-9400T, 12GB DDR4, 512GB SSD, 802.11ac Wifi, USB 3.1 Type C, Wireless Keyboard and Mouse, Windows 10 Home, Silver",
                    Description = "A Modern Design for the Modern World\r\nThe Aspire Z24 All-in-One PC packs all the essential computing features you need in an ultra-slim, space-saving design that's simple to use, functional and looks great on your desk. This All-in-One houses a super powerful 9th Gen Intel Core processor ensuring amazing performance and maximum fun. Enjoy a crisp and clear experience on the Full HD display with wide viewing angles, special protection screen to reduce eye strain, and its remarkably amazing sound. It’s here—to help you do more.",
                    Price = 799.99,
                    Stock = 300,
                    IsApproved = false,
                    IsHome= true,
                    CategoryId = 2,
                    Image = "4.jpg"

                },
                new Product()
                {
                    Name = "Samsung 860 EVO 500GB 2.5 Inch SATA III Internal SSD (MZ-76E500B/AM)",
                    Description = "The SSD you trust\r\nThe Samsung 860 EVO is specially designed to enhance performance of mainstream PCs and laptops. With the latest V-NAND technology, this fast and reliable SSD comes in a wide range of compatible form factors and capacities.",
                    Price = 79.99,
                    Stock = 84,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 3,
                    Image = "5.jpg"

                },
                new Product()
                {
                    Name = "Nintendo Switch with Neon Blue and Neon Red Joy‑Con - HAC-001(-01)",
                    Description = "Get the gaming system that lets you play the games you want, wherever you are, however you like. Includes the Nintendo Switch console and Nintendo Switch dock in black, with contrasting left and right Joy‑Con controllers-one red, one blue. Also includes all the extras you need to get started. Model number: HAC-001(-01) (product serial number begins with “XKW”) This model includes battery life of approximately 4.5 - 9 hours . The battery life will depend on the games you play. For instance, the battery will last approximately 5.5 hours for The Legend of Zelda: Breath of the Wild (games sold separately).\r\n\r\nIntroducing Nintendo Switch, the new home video game system from Nintendo. In addition to providing single and multiplayer thrills at home, the Nintendo Switch system can be taken on the go so players can enjoy a full home console experience anytime, anywhere. The mobility of a handheld is now added to the power of a home gaming system, with unprecedented new play styles brought to life by the two new Joy-Con controllers.\r\n\r\nPLAY ANYWHERE",
                    Price = 318.95,
                    Stock = 138,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 3,
                    Image = "6.jpg"

                },
                new Product()
                {
                    Name = "Samsung Galaxy S10 Factory Unlocked Phone with 128GB (U.S. Warranty), Prism Blue",
                    Description = "Cinematic display\r\nA nearly frameless Cinematic Infinity Display for more detail and clarity, more immersive and uninterrupted content, in a slim, balanced form.\r\n\r\nA camera that sees what you see\r\nPro-grade Camera effortlessly captures epic, pro-quality images of the world as you see it.\r\n\r\nFirst-touch unlock\r\nThe in-display sensor opens seamlessly with one hand in almost any light, rain or shine. This next-generation Ultrasonic Fingerprint ID keeps your phone and data secure using sound waves to detect the unique peaks and valleys of your fingertip in three dimensions.",
                    Price = 749.99,
                    Stock = 2400,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 4,
                    Image = "7.jpg"

                },
                new Product()
                {
                    Name = "Xiaomi Mi 9T (128GB, 6GB RAM) 6.39\" AMOLED FHD + Full Screen Display, 48MP Triple Camera, Global 4G LTE Dual SIM GSM Factory Unlocked (Carbon Black)",
                    Description = "Advanced performance.\r\nEquipped with the Qualcomm Snapdragon 730 processor with 8nm process technology, CPU single-core performance is improved by 35%, and power consumption is reduced by 10%. In addition, the AI algorithm improves processor efficiency by up to 2.6 times. Whether gaming or snapping photos, this performance won't let you down.\r\n\r\n4000mAh high-capacity battery and 18W fast charger.\r\nUse all day and stay charged with a 4000mAh battery, then revive in flash with the 18W charger.\r\n\r\nAI triple camera. \r\nWith a Sony 48MP ultra high-resolution wide camera + 8MP telephoto camera + 13MP ultra-wide-angle camera, you can take any shot with ease. Seamlessly zoom in from 0.6x to 10x and discover your true photography potential.\r\n\r\n20MP selfie camera.\r\nNow with panorama selfies, everyone can join in. Have everyone gather around - there's no need for a selfie stick! Simply turn the phone from side to side to capture the whole group.\r\n\r\nBreaking boundaries for an unlimited view.\r\nThe 6.39\" AMOLED display give you a stunning visual experience every time you unlock your phone. In environments with intense light, slide to enable bright mode for a screen that is 39% brighter than normal.\r\n\r\nFierey dynamic rear finish.\r\nThe back of the Mi 9T is graceful and contemplative until th",
                    Price = 307.43,
                    Stock = 3800,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 4,
                    Image = "8.jpg"

                },
                new Product()
                {
                    Name = "Xiaomi Redmi Note 8 6.3\" 64GB 4GB RAM (GSM Only, No CDMA) Internationa Version - No Warranty (Neptune Blue)",
                    Description = "International Model - No Warranty in US. Compatible with Most GSM Carriers like T-Mobile, AT&T, MetroPCS, etc. Will NOT work with CDMA Carriers Such as Verizon, Sprint, Boost. - FCC ID: 2AFZZG7G\r\n\r\n",
                    Price = 181.48,
                    Stock = 1500,
                    IsApproved = false,
                    IsHome= false,
                    CategoryId = 4,
                    Image = "9.jpg"

                },
                new Product()
                {
                    Name = "COSTWAY Compact Refrigerator",
                    Description = "This 3.4 Cu. Ft. Compact Refrigerator w/ Internal Freezer is ideal for smaller spaces like a dorm room, teen's bedroom or office. This appliance also suit for hotels, offices, household etc. It is sized perfectly to keep drinks and small amounts of food cold and in a convenient location.",
                    Price = 229.99,
                    Stock = 124,
                    IsApproved = true,
                    IsHome= false,
                    CategoryId = 5,
                    Image = "10.jpg"

                },
                new Product()
                {
                    Name = "Midea WHS-65LSS1, 1.6 Cu. Ft. Compact Refrigerator, Stainless Steel",
                    Description = "Midea is a leading global manufacturer of compact refrigerators, kegerators, and wine coolers. The Midea compact refrigerator has a streamlined look that will complement any room style or setting. They're perfect for European kitchens, galley kitchens, small apartments, mini bars, offices, dorm rooms, bedrooms, nurseries, home theaters, garages, boats, tiny homes, cabins and RVs.",
                    Price = 186.99,
                    Stock = 146,
                    IsApproved = true,
                    IsHome= true,
                    CategoryId = 5,
                    Image = "11.jpg"

                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}