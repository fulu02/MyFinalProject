using Business.Cocrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (Business.Abstract.product product in ProductManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
