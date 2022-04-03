﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Thinh_Ecom.Entities
{
    public class Products
    {

        [DisplayName("Id")]
        public string pd_Id { set; get; }


        [DisplayName("Name Product")]
        public string pd_Name { set; get; }


        [DisplayName("Description")]
        public string pd_Description { set; get; }


        [DisplayName("Price")]
        public int pd_Price { set; get; }



        [DisplayName("ReducePrice")]
        public int pd_ReducePrice { set; get; }

        public string pd_NameImg1 { set; get; }
        public string pd_NameImg2 { set; get; }
        public string pd_NameImg3 { set; get; }
        public string pd_NameImg4 { set; get; }

        [DisplayName("Img1")]
        public string pd_Img1 { set; get; }

        [DisplayName("Img2")]
        public string pd_Img2 { set; get; }

        [DisplayName("Img3")]

        public string pd_Img3 { set; get; }

        [DisplayName("Img4")]
        public string pd_Img4 { set; get; }


        [DisplayName("Rate")]
        public int pd_Rate { set; get; }

        public string pd_MenuFacturer { set; get; }


        [DisplayName("ShortDescription")]
        public string pd_ShortDescription { set; get; }

        [DisplayName("Size")]
        public string pd_Size { set; get; }

        

        public string CategoriesFK  { set; get; }
        public Categories Categories { get; set; }

        public List<ProductInCart> ProductInCartP { get; set; }
        public List<CommentInproduct> ReviewInproductP { get; set; }

        public List<ProductInCartDevices> ProductInCartDevicesP { get; set; }

    }
}
