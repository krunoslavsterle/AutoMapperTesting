using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperTest
{
   public class SourceCar
   {
      public Guid Id { get; set; }

      public String Name { get; set; }

      public Guid MakerId { get; set; }

      public SourceMaker Maker { get; set; }
   }
}
