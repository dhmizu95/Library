﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.API.Entities;
using Library.API.Helpers;
using Library.API.Models;

namespace Library.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Name, 
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}" ))
                .ForMember(dest => dest.Age, 
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
        }
    }
}