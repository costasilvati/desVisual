using System;
using AutoMapper;
using CardAPI.Data.Dtos.Administra;
using CardAPI.Data.Dtos.Banco;
using CardAPI.Model;

namespace CardAPI.Profiles
{
    public class AdministraProfile : Profile
    {
        public AdministraProfile()
        {
            CreateMap<CreateAdministraDto, Administra>();
            CreateMap<Administra, ReadAdministraDto>();
        }
    }
}
