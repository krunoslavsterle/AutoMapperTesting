using AutoMapper;
using AutoMapperTest.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
   class Program
   {
      static void Main(string[] args)
      {
         // Create maps - only need to be called once.
         MapperResolver.ConfigureMappings();

         // Gets the instance of IMapper - stored as static property, created only once.
         var mapper = MapperResolver.GetMapper();

         // Source data creation.
         var sourceMaker = new SourceMaker { Id = Guid.NewGuid(), Name = "Fiat_Source", Description = "From source"};
         var sourceCar = new SourceCar { Id = Guid.NewGuid(), Name = "Punto_Source", MakerId = sourceMaker.Id, Maker = sourceMaker };

         // Mapp source car to destination the car.
         DestinationCar destinationCar = mapper.Map<DestinationCar>(sourceCar);

         PrintDestinationCar(destinationCar);
         Console.ReadLine();
      }

      private static void PrintDestinationCar(DestinationCar car)
      {
         string str = String.Format("car neme: {0}\ncar id: {1}\ncar maker name: {2}\ncar maker description: {3}", car.Name, car.Id.ToString(), car.Maker.Name, car.Maker.Description);
         Console.WriteLine(str);
      }
   }
}
