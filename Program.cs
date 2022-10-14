using System.Collections;
using System;
using Curso8.Entities;
using Curso8.Services;
using System.ComponentModel.DataAnnotations;

namespace Curso8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double Price = double.Parse(Console.ReadLine());
                products.Add(new Product(name, Price));
            }

            Console.WriteLine(CalculationService.Max(products));
        }
    }
}
