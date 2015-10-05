using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Demo_on__DriveInfo__class___For_a_Single_Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the drive letter (a to z):"); 
     
            string driveletter = Console.ReadLine(); 
            DriveInfo d = new DriveInfo(driveletter);
            if (d.IsReady) 
            { 
                Console.WriteLine(d.Name); 
                Console.WriteLine(d.DriveType); 
                Console.WriteLine(d.VolumeLabel);
                Console.WriteLine(d.DriveFormat);
                Console.WriteLine(d.TotalSize + " bytes.");
                Console.WriteLine(d.TotalFreeSpace + " bytes.");

                Console.WriteLine(d.TotalSize/1024+ " kbytes.");
                Console.WriteLine(d.TotalFreeSpace/1024 + " Kbytes.");

                Console.WriteLine((d.TotalSize / 1024)/1024 + " MB.");
                Console.WriteLine((d.TotalFreeSpace / 1024)/1024 + " MB.");

                Console.WriteLine(((d.TotalSize / 1024)/1024)/1024 + " GB.");
                Console.WriteLine(((d.TotalFreeSpace / 1024)/1024)/1024 + " Gb.");


            }
            else Console.WriteLine(d.Name + " - " + " Not Ready."); 
            Console.Read(); 
        }
        }
    }
