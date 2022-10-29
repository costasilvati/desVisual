using System;
using AutoMapper;
using CardAPI.Data.Dtos.Banco;
using CardAPI.Model;

namespace CardAPI.Profiles
{
    public class BancoProfile : Profile
    {
        public BancoProfile()
        {
            CreateMap<CreateBancoDto, Banco>();
            CreateMap<Banco, ReadBancoDto>();
            CreateMap<UpdateBancoDto, Banco>();
        }
    }
}