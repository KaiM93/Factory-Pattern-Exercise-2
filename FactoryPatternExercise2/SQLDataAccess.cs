using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product (){ Name= "Xbox", Price = 350},
            new Product (){ Name= "Guitar", Price = 100 },
            new Product (){ Name= "Katana", Price = 250},
            new Product (){ Name= "Laptop", Price= 300},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am reading data from SQL Data Access");
        }
    }
}

