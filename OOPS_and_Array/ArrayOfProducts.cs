using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct5_Assignment
{
    internal class ArrayOfProducts
    {
        static void Main(string[] args)
        {
            Products[] products = new Products[5];

            products[0] = new Products
            {
                productid = 1,
                productname = "rice",
                price = 1000,  
                unitofMeasurement = "Kilograms", 
                quantity = 1 
            };


            products[1] = new Products
            {
                productid = 2, 
                productname = "shirt", 
                price = 600, 
                unitofMeasurement = "medium", 
                quantity = 3  
            };

            products[2] = new Products
            {
                productid = 3, 
                productname = "oil",  
                price = 110, 
                unitofMeasurement = "litre", 
                quantity = 4  
            };

            products[3] = new Products
            {
                productid = 4, 
                productname = "television",  
                price = 70000, 
                unitofMeasurement = "inches",
                quantity = 1 
            };

            products[4] = new Products
            {
                productid = 105, 
                productname = "shoes",  
                price = 800, 
                unitofMeasurement = "inches",  
                quantity = 1 
            };

            foreach (var item in products)
            {
                Console.WriteLine(item.productid);
                Console.WriteLine(item.productname);
                Console.WriteLine(item.price);
                Console.WriteLine(item.unitofMeasurement);
                Console.WriteLine(item.quantity);
            }
            Console.ReadLine();

        }
    }
}
