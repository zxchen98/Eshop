using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;

namespace Infrastructure.Data
{
    public class Mapping : Profile
    {
        public MappingProfile()
        {

            CreateMap<Product, ProductResponse>();
            CreateMap<ProductRequest, Product>();
        }
    }
}
