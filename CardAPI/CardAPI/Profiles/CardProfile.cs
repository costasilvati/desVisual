using System;
using AutoMapper;
using CardAPI.Data.Dtos;
using CardAPI.Model;

namespace CardAPI.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<CreateCardDto, Card>();
            CreateMap<Card, ReadCardDto>();
            CreateMap<UpdateCardDto, Card>();
        }
    }
}
