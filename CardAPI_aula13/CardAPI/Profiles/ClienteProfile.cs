﻿using System;
using AutoMapper;
using CardAPI.Data.Dtos.Cliente;
using CardAPI.Model;

namespace CardAPI.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
        }
    }
}
