using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {

        //Inicializamos
        public List<Product> Products { get; set; } = new List<Product>();

        //Carga de productos
        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                 new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                  new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                   new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                    new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                     new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                      new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },
                       new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Alienware M15",
                    Description = "Alienware es un ordenador enfocado para juegos de alta calidad grafica y performance",
                    Image = "https://i.blogs.es/a41017/cap_006/450_1000.jpg",
                    Price = 9.9m,
                    OriginalPrice = 20.20m,
                },

            };
        }
    }
}
