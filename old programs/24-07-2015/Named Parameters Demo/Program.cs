using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters_Demo
{
    class User 
    {
        //fields 
        public string FirstName; 
        public string LastName;
        //methods
        public void SetUserName(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName; 
        }
  
    public void ShowUserName() 
{
    Console.WriteLine(FirstName + " " + LastName);
} 
}
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.SetUserName(LastName: "kumar", FirstName: "Anantha");
            //call a method, with named parameters
            u.ShowUserName(); 
            Console.Read();
        }
    }
}