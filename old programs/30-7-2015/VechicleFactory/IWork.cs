using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleFactory
{
   public interface IWork:IVechicle
    {
       void start();
     
       void stop();
    }
}
