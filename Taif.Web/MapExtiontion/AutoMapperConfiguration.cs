using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taif.Web.MapExtiontion
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Mapper { get; private set; }


        public static MapperConfiguration MapperConfiguration { get; private set; }


        public static void Init(MapperConfiguration config)
        {
            MapperConfiguration = config;
            Mapper = config.CreateMapper();

        }


    }
}
