using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {//open closed principle S-O-LID
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("-----------------------");
            foreach (var product in productManager.GetByUnitPrice(2,1000))
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}
