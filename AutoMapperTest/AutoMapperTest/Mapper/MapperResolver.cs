using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest.Mapper
{
   static class MapperResolver
   {
      private static IMapper mapper = null;
     
      public static IMapper GetMapper()
      {
         return mapper;         
      }

      public static void ConfigureMappings()
      {
         var config = new MapperConfiguration(cfg =>
         {
            cfg.AddProfile<MapperProfile>();
         });

         mapper = config.CreateMapper();
      }
   }
}
