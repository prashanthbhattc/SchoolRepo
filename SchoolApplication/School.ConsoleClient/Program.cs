using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ConsoleClient
{ 
    class Program
    {
        static void Main(string[] args)
        {

            CategoryController controller = new CategoryController();

            Category C = new Category();
            C.Name = "Vegitarian";
            controller.Create(C);

            Console.ReadLine();
           

           
        }
    }
}
