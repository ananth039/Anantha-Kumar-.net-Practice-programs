using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetDrivesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] dinfo = DriveInfo.GetDrives(); 
            Console.WriteLine(dinfo.Length + " drives found on this computer."); 
            foreach (DriveInfo d in dinfo) 
            { 
                Console.WriteLine();
                if (d.IsReady)
                {
                    Console.WriteLine(d.Name);
                    Console.WriteLine(d.DriveType); 
                    Console.WriteLine(d.VolumeLabel); 
                    Console.WriteLine(d.DriveFormat);
                    Console.WriteLine(d.TotalSize + " bytes."); 
                    Console.WriteLine(d.TotalFreeSpace + " bytes.");
                } 
                else
                    Console.WriteLine(d.Name + " - " + d.DriveType + " - Not Ready.");
            }
            Console.Read();
        }

    }
}
