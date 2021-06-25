using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CategoryService
{
    interface ICategoryService
    {

        //Propiedades de Categorias
        public List<Category> Categories { get; set; }
        //Cargamos las categorias
        void LoadCategories();
        
    }
}
