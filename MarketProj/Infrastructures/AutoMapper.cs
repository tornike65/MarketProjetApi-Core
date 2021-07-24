using AutoMapper;
using MarketProj.DAL.Queries.ProductAgregate;
using MarketProj.Models.DTOs.InputDTOs;
using MarketProj.Models.DTOs.OutDTOs;
using MarketProj.Models.Entities;
using MarketProj.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketProj.Infrastructures
{
    public class AutoMaper : Profile
    {
        public AutoMaper()
        {
            CreateMap<ProductInputDTO, Product>();
            CreateMap<Product, ProductOutDTOs>();

            CreateMap<AssetsInputDTO, Assets>();
            CreateMap<Assets, AssetsOutDTOs>();

            CreateMap<UserInputDTO, User>();
            CreateMap<User, UserOutDTOs>();

            CreateMap<TemporaryUser, UserOutDTOs>();
        }


    }
}
