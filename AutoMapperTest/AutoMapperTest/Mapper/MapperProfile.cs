using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
   public class MapperProfile : Profile
   {
      protected override void Configure()
      {
         CreateMap<SourceCar, DestinationCar>();
         CreateMap<SourceMaker, DestinationMaker>();
      }
   }
}
