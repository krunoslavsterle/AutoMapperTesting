using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
   public class DestinationCar
   {
      public Guid Id { get; set; }

      public String Name { get; set; }

      public Guid MakerId { get; set; }

      public DestinationMaker Maker { get; set; }
   }
}
