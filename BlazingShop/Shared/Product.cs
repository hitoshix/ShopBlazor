﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazingShop.Shared
{
    public class Product
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description {get; set;}
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        //Microsoft recomienda utilizar decimal para cosas financieras y monetarias
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool isPublic { get; set; }
        public bool isDeleted { get; set; }
        public Category Category { get; set; }

        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }


    
    }
}
