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

            var data = controller.Get();
            Console.WriteLine("------------- categories----------");
            foreach (var item in data)
            {
                Console.WriteLine($"the category Id {item.Id} and category name {item.Name} ");
            }

            Console.ReadLine();
           

           
        }
    }
}
