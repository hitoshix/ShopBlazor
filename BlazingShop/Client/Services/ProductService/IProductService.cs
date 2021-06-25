using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public interface IProductService
    {

        //Lista de propiedades de los productos
        List<Product> Products { get; set; }

        //Llamamos Metodo de cargar Productos
        void LoadProducts();

    }
}
