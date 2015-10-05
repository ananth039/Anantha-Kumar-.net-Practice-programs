using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VechicleFactory;

namespace VechicleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tobeContinue = true;
            do
            {
                Console.WriteLine("Enter your choice 0-->Bike  1-->Car 2-->Bus .press 3->exit ");
                int value;
                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Enter valid Value");
                    // continue;
                    break;
                }
                VechicleEnum Totype;
                if (value == 0)
                {
                    Totype = VechicleEnum.Bike;
                }
                else if (value == 1)
                {
                    Totype = VechicleEnum.Car;
                }
                else if (value == 2)
                {
                    Totype = VechicleEnum.Bus;
                }
                else if(value==3)
                {
                    break;
                }
                else
                {
                    break;
                }
                IVechicle vechicle = VechicleFactory.VechicleFactory.Create(Totype);

                if (vechicle is IWork)
                {
                    if (vechicle is IVechicleSpecialization)
                    {
                        
                        DisplayIVechicleSpecialization(vechicle as IVechicleSpecialization);
                        DisplayVechcle(vechicle);
                        StopWork(vechicle as IWork);
                    }
                    else
                    {
                        
                        StartWork(vechicle as IWork);
                        DisplayVechcle(vechicle);
                      
                        StopWork(vechicle as IWork);
                        
                    }
                }

            } while (tobeContinue);
        }


        static void DisplayWork(IWork work)
        {
            StartWork(work);
            StopWork(work);
        }
        
       
        private static void StopWork(IWork work)
        {
            work.stop();
        }
        private static void StartWork(IWork work)
        {
            work.start();
        }




        static void DisplayIVechicleSpecialization(IVechicleSpecialization vechcileSpecialization)
        {
            StartWork(vechcileSpecialization);
            vechcileSpecialization.steeringCapability();
        }


        static void DisplayVechcle(IVechicle vechciles)
        {

          
            vechciles.Run();
            vechciles.seatCapability();
            vechciles.NumberOfWheels();
        }
    }
  } 
   
