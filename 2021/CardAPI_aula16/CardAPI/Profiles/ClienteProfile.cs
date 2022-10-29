using System;
using System.Linq;
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
            CreateMap<Cliente, ReadClienteDto>()
                .ForMember(cliente => cliente.Cards, opts => opts
                .MapFrom(cliente => cliente.Cards.Select
                (card => new { card.Id, card.Number})));
            CreateMap<UpdateClienteDto, Cliente>();
        }
    }
}
