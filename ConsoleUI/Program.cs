using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{

    //SOLİD
    //open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductText();
            //CategoryText();

        }

        private static void CategoryText()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductText()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine("{0}/{1}", product.ProductName, product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
