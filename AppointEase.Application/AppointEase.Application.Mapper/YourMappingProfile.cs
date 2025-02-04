﻿using AppointEase.Domain.AppointEase.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppointEase.Application.AppointEase.Application.Mapper
{
    public class YourMappingProfile : Profile
    {
        public YourMappingProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
        }
    }
}
