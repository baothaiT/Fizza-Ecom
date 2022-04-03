﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinh_Ecom.Entities;
using Thinh_Ecom.EntitiesThinh_Ecom.Entities;

namespace Thinh_Ecom.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {


            //var hasher = new PasswordHasher<AppUsers>();

            //Create id for product
            var productId1 = Guid.NewGuid().ToString();
            var productId2 = Guid.NewGuid().ToString();
            var productId3 = Guid.NewGuid().ToString();
            var productId4 = Guid.NewGuid().ToString();
            var productId5 = Guid.NewGuid().ToString();
            var productId6 = Guid.NewGuid().ToString();
            var productId7 = Guid.NewGuid().ToString();
            var productId8 = Guid.NewGuid().ToString();
            var productId9 = Guid.NewGuid().ToString();
            var productId10 = Guid.NewGuid().ToString();
            var productId11 = Guid.NewGuid().ToString();
            var productId12 = Guid.NewGuid().ToString();
            var productId13 = Guid.NewGuid().ToString();
            var productId14 = Guid.NewGuid().ToString();
            var productId15 = Guid.NewGuid().ToString();
            var productId16 = Guid.NewGuid().ToString();
            var productId17 = Guid.NewGuid().ToString();
            var productId18 = Guid.NewGuid().ToString();

            //Table Products
            builder.Entity<Products>().HasData(
                new Products()
                {
                    pd_Id = productId1,
                    pd_Name = "Pizza",
                    pd_Description = "pizza-bo",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/pizza-bo.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId2,
                    pd_Name = "Cocacola Zero",
                    pd_Description = "coca-zero",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/coca-zero.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId3,
                    pd_Name = "Extravaganza",
                    pd_Description = "Extravaganza",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Extravaganza.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId4,
                    pd_Name = "fanta-1.5L",
                    pd_Description = "pfanta-15",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/fanta-15.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId5,
                    pd_Name = "Haft-haft",
                    pd_Description = "Haft-haft",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Haft-haft.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId6,
                    pd_Name = "Meat-lover",
                    pd_Description = "Meat-lover",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Meat-lover.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId7,
                    pd_Name = "MENU-PC",
                    pd_Description = "MENU-PC",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/MENU-PC.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId8,
                    pd_Name = "MENU-PC-BBQ",
                    pd_Description = "MENU-PC-BBQ",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/MENU-PC-BBQ.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId9,
                    pd_Name = "MENU-PC-my",
                    pd_Description = "MENU-PC-my",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/MENU-PC-my.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId10,
                    pd_Name = "MENU-PC-Pho-Mai",
                    pd_Description = "MENU-PC-Pho-Mai",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/MENU-PC-Pho-Mai.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId11,
                    pd_Name = "Ocean-mania",
                    pd_Description = "Ocean-mania",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Ocean-mania.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId12,
                    pd_Name = "Okonomiyaki",
                    pd_Description = "Okonomiyaki",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Okonomiyaki.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId13,
                    pd_Name = "pasta",
                    pd_Description = "pasta-bo-bam",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/pasta-bo-bam.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId14,
                    pd_Name = "pasta-hai-san",
                    pd_Description = "pasta-hai-san",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/pasta-hai-san.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId15,
                    pd_Name = "pasta-rau-cu",
                    pd_Description = "pasta-rau-cu",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/pasta-rau-cu.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId16,
                    pd_Name = "pizza-bo",
                    pd_Description = "pizza-bo",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/pizza-bo.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId17,
                    pd_Name = "Pizzaminsea",
                    pd_Description = "Pizzaminsea",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Pizzaminsea.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                },
                new Products()
                {
                    pd_Id = productId18,
                    pd_Name = "Sprite-15L",
                    pd_Description = "Sprite-15L",
                    pd_Price = 10,
                    pd_ReducePrice = 5,
                    pd_Img1 = "/img/pizza-300x300/Sprite-15L.png",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 5,
                    pd_ShortDescription = "",
                    pd_Size = ""
                }
                );




        //Table About
        builder.Entity<About>().HasData(
                new About()
                {
                    about_id=1,
                    about_Url= "https://www.youtube.com/watch?v=F1vcruph8JA",
                    about_Title = "Footwear the leading eCommerce Store around the Globe",
                    about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
                });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 2222222222222222222222222222222222222222222222222222222222222222222

            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name ="staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "admin",
                    Description = "admin"
                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser 2222222222222222222222222222222222222222222222222222222222222222222

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "admin",
                LastName = "admin",
                DoB = new DateTime(2020, 01, 02)

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "staff",
                LastName = "staff",
                DoB = new DateTime(2020, 03, 02)

            });


            //Table AppUser - role 2222222222222222222222222222222222222222222222222222222222222222222
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });





            var IdCart1 = "72309286-ECBB-4D20-AD95-2819D31E3400";
            var IdCart2 = "D355458F-1DD3-4834-AA28-6DA34B6357FF";


            //Table Cart

            builder.Entity<Cart>().HasData(
                new Cart()
                {
                    cart_Id = IdCart1,
                    cart_UserID = IdStaff

                },
                new Cart()
                {
                    cart_Id = IdCart2,
                    cart_UserID = IdAdmin

                });


            //Table Product In Cart

            builder.Entity<ProductInCart>().HasData(
                new ProductInCart()
                {
                     pic_CartId = IdCart2,
                     pic_ProductId = productId1,
                     pic_amount = 2
                });


            //Table Categories





            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    cg_Id = 1,
                    cg_Name = "Pizza",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 2,
                    cg_Name = "Spaghetti",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 3,
                    cg_Name = "Side dishes",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 4,
                    cg_Name = "Drink",
                    cg_Type = "",
                    cg_Sale = ""

                });





            //Table ContactSystem

            builder.Entity<SystemContact>().HasData(
                new SystemContact()
                {
                    Contact_Id = 1,
                    Contact_Address = " 123, An Lac A Ward, Binh Tan District, HCM",
                    Contact_Phone = "0123456789",
                    Contact_Email = "admin@gmail.com",
                    Contact_Website = "https://shoes.com"


                });



            //Table ContactUsers


            builder.Entity<ContactForm>().HasData(
                new ContactForm()
                {
                    cu_Id = 1,
                    cu_FirstName = "FirstName",
                    cu_LastName = "LastName",
                    cu_Email = "Email",
                    cu_Subject = "Subject",
                    cu_Description = "Description"
                });


            var ReviewId1 = "EEBA6608-AB75-4E83-909F-604B1A06F16C";
            var ReviewId2 = "9EED8607-D2BB-45EE-AEE3-C59D858A7F97";
            var ReviewId3 = "C2A543C2-B1E2-4DC5-A131-9137E4673FA6";




            //Table Reviews new DateTime(2020, 01, 02)


            builder.Entity<Comment>().HasData(
                new Comment()
                {
                    review_id = ReviewId1,
                    review_Comment = "Good1",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Comment()
                {
                    review_id = ReviewId2,
                    review_Comment = "Good2",
                    review_UserId = IdStaff,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Comment()
                {
                    review_id = ReviewId3,
                    review_Comment = "Good3",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                });


            var SubReviewId1 = Guid.NewGuid().ToString(); 
            var SubReviewId2 = Guid.NewGuid().ToString();
            var SubReviewId3 = Guid.NewGuid().ToString();

            // Table SubReview 

            builder.Entity<SubReview>().HasData(
                new SubReview()
                {
                    subReview_Id = SubReviewId1,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 1",
                    subReview_DateCommnet = new DateTime(2020, 01, 02),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId2,
                    subReview_UserId = IdStaff,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId3,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                }
                );

            builder.Entity<SubReviewInReview>().HasData(
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId1
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId2
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId2,
                    SRiR_SubReviewId = SubReviewId3
                }
                );





            //Table ProductInCategories



            builder.Entity<ProductsInCategories>().HasData(
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId1
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId3
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId5
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId6
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId11
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId12
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId16
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = productId17
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = productId17
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = productId13
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = productId14
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = productId15
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = productId7
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = productId8
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = productId9
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 3,
                    pic_productId = productId10
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = productId2
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = productId4
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 4,
                    pic_productId = productId18
                }
                );




            //Table ReviewInproduct



            builder.Entity<CommentInproduct>().HasData(
                new CommentInproduct()
                {
                    rip_ProductId = productId1,
                    rip_ReviewId = ReviewId1,
                },
                new CommentInproduct()
                {
                    rip_ProductId = productId1,
                    rip_ReviewId = ReviewId2,
                },
                new CommentInproduct()
                {
                    rip_ProductId = productId1,
                    rip_ReviewId = ReviewId3,
                });


            builder.Entity<Coupons>().HasData(
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode ="code10",
                    couponPrice = 10
                },
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code50",
                    couponPrice = 50
                });



            string billId1 = "D269BF93-A5E2-4C4A-8146-9967DDE80D30";
            string billId2 = "AFD66490-12F5-4EA7-BFF6-425624290D6D";

            //Table Bills

            builder.Entity<Bills>().HasData(
                new Bills()
                {
                    bill_Id = billId1,
                    bill_UserId = IdStaff,
                    bill_PaidTotal = 2000,
                    bill_ProductIdlist = "1|2|3|4",
                    bill_ProductNamelist = "product 1|product 2| product 3| product 4",
                    bill_ProductSizelist = "7|8|9|14",
                    bill_ProductColorlist = "Blue|Red|Black|Green",
                    bill_ProductPricelist = "550|450|350|640",
                    bill_Shipping = 10,
                    bill_Discount = 0,
                    bill_Confirmation = true,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Check Payment",
                    bill_Note = "",
                    bill_Quantity = "1|1|2|1",
                    bill_HideStatus = false,
                    bill_WaitForConfirmation = false,
                    bill_WaitPickup = false,
                    bill_Delivering = false,
                    bill_Delivered =  false,
                    bill_Cancelled = false
                }); ;

            //Table Shiping

            string shipId = "7CF94A7D-9239-446E-A404-086518F84652";

            builder.Entity<Shipping>().HasData(
                new Shipping()
                {
                    ship_Id = shipId,
                    ship_Name ="Ship",
                    ship_Price = 5
                });


        }    
                
               
    }   
}
