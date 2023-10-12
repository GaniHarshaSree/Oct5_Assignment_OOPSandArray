using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct5_Assignment
{
    internal class ProductItems
    {
        static void Main(string[] args)
        {

            Products p1 = new Products();

            p1.productid = 001;
            p1.productname = "Shirt";
            p1.price = 100;
            p1.unitofMeasurement = "Large";
            p1.quantity = 5;

            Products p2 = new Products();
            p2.productid = 002;
            p2.productname = "jeans";
            p2.price = 600;
            p2.unitofMeasurement = "Small";
            p2.quantity = 2;

            Products p3 = new Products();
            p3.productid = 003;
            p3.productname = "Milk";
            p3.price = 100;
            p3.unitofMeasurement = "litre";
            p3.quantity = 5;

            Products p4 = new Products();
            p4.productid = 004;
            p4.productname = "Mobile Phone";
            p4.price = 50000;
            p4.unitofMeasurement = "KG";
            p4.quantity = 1;

            Products p5 = new Products();
            p5.productid = 005;
            p5.productname = "laptop";
            p5.price = 100000;
            p5.unitofMeasurement = "KG";
            p5.quantity = 1;

            Console.WriteLine("Product Details :");
            Console.WriteLine($" ProductId:{p1.productid}\n ProductName:{p1.productname}\n Price:{p1.price}\n UnitoFMeasurements:{p1.unitofMeasurement}\n Quantity:{p1.quantity}");
            Console.ReadLine();



        }
    }
}
