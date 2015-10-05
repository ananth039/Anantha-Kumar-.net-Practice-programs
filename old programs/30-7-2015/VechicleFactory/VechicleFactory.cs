using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleFactory
{
    public static class VechicleFactory
    {
        public static  IVechicle Create(VechicleEnum Totype)
         { 
           IVechicle vechiclebeCreated=null;
           switch(Totype)
            {
                case VechicleEnum.Bike:
                    vechiclebeCreated = new Bike();
                    break;
               case VechicleEnum.Car:
                    vechiclebeCreated = new Car();
                   break;
               case VechicleEnum.Bus:
                   vechiclebeCreated = new Bus();
                   break;
              
        }
           return vechiclebeCreated;
           }

         }
    }

