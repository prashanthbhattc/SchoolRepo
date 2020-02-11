
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
           
           /*var Category = controller.Get();
            foreach( var item in Category)
                {
                Console.WriteLine("the Id is "+item.Id+"name is "+item.Name);
            }*/
            Category C = new Category();
             Category C1= new Category();
           //C.Name = "Vegitarian";
           //controller.Create(C);
            // C1.Name = "NonVegitarian";
            //controller.Create(C1);
            //controller.Delete(1);
            //controller.Get();
           C.Name = "Vegitarian";
           controller.Update(2,C);

            // FOODITEM REPO

             //FoodItemController fcontroller =new FoodItemController();
              //FoodItem F=new FoodItem();
          // F.Name="Idly";
           //fcontroller.Create(F);
          //fcontroller.Delete(2);

            // we are getting exception error in Get method 
           /*var FoodItem = fcontroller.Get();
            foreach( var item in FoodItem)
                {
                Console.WriteLine("the FoodId is "+item.Id+"Foodname is "+item.Name);
            }*/
              //fcontroller.Get();
             // F.Name="Dosa";
              //fcontroller.Update(2,F);


            Console.ReadLine();
           

           
        }
    }
}