using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<Core.DataContracts.User, Services.Models.User>();
            Mapper.CreateMap<Services.Models.User, Core.DataContracts.User>();

            Mapper.CreateMap<Core.DataContracts.Post, Services.Models.Post>().
                ForMember(p => p.PostedOn, opt => opt.MapFrom(src => ((DateTime)src.PostedOn).ToString()));
        }
    }
}