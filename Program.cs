using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan s1 = new SalesMan();
            s1.Name = "Juan";
            s1.Age = 26;

            SalesMan s2 = new SalesMan();
            s2.Name = "Pablo";
            s2.Age = 30;

            SalesMan s3 = new SalesMan();
            s3.Name = "Pedro";
            s3.Age = 20;

            Product p1 = new Product();
            p1.Name = "Shirt";
            p1.Price = 100;

            Product p2 = new Product();
            p2.Name = "Pants";
            p2.Price = 200;

            Product p3 = new Product();
            p3.Name = "Shoes";
            p3.Price = 150;

            Sale v1 = new Sale();
            v1.Product.Name = "Sale 1";
            v1.SalesMan.Name = "Juan";
            v1.Comments = "Excelent service";

            Sale v2 = new Sale();
            v2.Product.Name = "Sale 2";
            v2.SalesMan.Name = "Pablo";
            v2.Comments = "Very good";

            Sale v3 = new Sale();
            v3.Product.Name = "Sale 3";
            v3.SalesMan.Name = "Pedro";
            v3.Comments = "Good. Thanks";

            double total;

            total = 100 + 200 + 150;

            System.Console.WriteLine("Sales information:" + v1.Product, v1.SalesMan, v1.Comments);
            System.Console.WriteLine("SalesMan name:" + s1.Name, "Age" + s1.Age);
            System.Console.WriteLine("Product name:" + p1.Name);
            System.Console.WriteLine("Price product:" + p1.Price);

            System.Console.WriteLine();

            System.Console.WriteLine("Sales information:" + v2.Product, v2.SalesMan, v2.Comments);
            System.Console.WriteLine("SalesMan name:" + s2.Name, "Age" + s2.Age);
            System.Console.WriteLine("Product name:" + p2.Name);
            System.Console.WriteLine("Price product:" + p2.Price);

            System.Console.WriteLine();

            System.Console.WriteLine("Sales information:" + v3.Product, v3.SalesMan, v3.Comments);
            System.Console.WriteLine("SalesMan name:" + s3.Name, "Age" + s3.Age);
            System.Console.WriteLine("Product name:" + p3.Name);
            System.Console.WriteLine("Price product:" + p3.Price);

            System.Console.WriteLine();

            System.Console.WriteLine("Total sale:" + total);

            //Question: Who's the seller, who has sold the cheapest product?,
            int CountNewMethod = Reports.CountChespestProduct();
            System.Console.WriteLine("The cheapest product is: " + CountNewMethod);

            //Question: Products price average.
            int CountNewMethod = Reports.CountProductsPriceAverage();
            System.Console.WriteLine("Products price average is: " + CountNewMethod);

            //Question: How many unit of the product has been sold?,
            int CountNewMethod = Reports.CountProductsSold();
            System.Console.WriteLine("The products sold were: " + CountNewMethod);

            //Question: What's the most expensive product?,
            int CountNewMethod = Reports.CountExpensiveProduct();
            System.Console.WriteLine("The most expensive product is: " + CountNewMethod);
        }
    }
}
