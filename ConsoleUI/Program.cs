using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {//open closed principle S-O-LID
        static void Main(string[] args)
        {
             Test1();
           // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new
                            CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.Name);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new
                            ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            
        }
        private static void Test1()
        {

            EfRecipeDal efRecipeDal = new EfRecipeDal();
           var result= efRecipeDal.GetRecipeDetails();
            foreach (var item in result)
            {
                
                Console.WriteLine(item.RecipeID);
                Console.WriteLine(item.RecipeName);
                Console.WriteLine(item.Ingredients);
                Console.WriteLine(item.CategoryName);
            }
           
            //Console.WriteLine(context.RecipeDetailsByIngredients.ToList());



        }
        }
        //{
        //    RecipeManager recipeManager = new RecipeManager(new EfRecipeDal());
        //    foreach (var item in recipeManager.GetAll().Data)
        //    {
        //        Console.WriteLine(item.Name);
        //        Console.WriteLine(item.CategoryId);
        //        Console.WriteLine(item.Category.Name);
        //    }
        }
   

