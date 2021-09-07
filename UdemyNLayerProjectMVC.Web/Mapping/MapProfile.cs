using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayerProjectMVC.Web.DTOs;
using UdemyNLayerProjectMVC.Core.Models;

namespace UdemyNLayerProjectMVC.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {

            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, CategoryDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }

    }
}
