using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROYECT_2._0
{
    public class ProductInventary : Products
    {
        List<Products> ProductsList = new List<Products>();

        public void Menu()
        {
            int stopCount = 0;
            while(stopCount != 1)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------\n"+
                                  "[1 - Add Product] | [2 - Update Product] | [3 - Details Product] | [4 - Delete Product] | [5 - Exit]\n"+
                                  "----------------------------------------------------------------------------------------------------");
                string answwer = Console.ReadLine();

                switch (answwer)
                {
                    case "1":
                        AddMenu();
                        break;

                    case "2":
                        UpdateMenu();
                        break;

                    case "3":
                        DetailsMenu();
                        break;

                    case "4":
                        DeleteMenu();
                        break;

                    case "5":
                        stopCount = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            }
        }

        public void DeleteMenu()
        {
            Console.WriteLine("--------------------------------------------\n" +
                              "Give me the ID of the Product: \n" +
                              "--------------------------------------------");
            int IdProductUpdate = int.Parse(Console.ReadLine());

            if (IdProductUpdate > ProductsList.Count || IdProductUpdate == 0)
            {
                Console.WriteLine($"The Object With The ID {IdProductUpdate} Doesnt Exits");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            List<Products> productsToRemove = new List<Products>();

            foreach (Products Product in ProductsList)
            {
                if (Product.id == IdProductUpdate)
                {
                    productsToRemove.Add(Product);
                    Console.WriteLine($"The element {Product.name} Have been Found");
                }
            }

            foreach (Products productToRemove in productsToRemove)
            {
                ProductsList.Remove(productToRemove);
                Console.WriteLine($"The element {productToRemove.name} Have been Deleted");
            }

        }
        public void DetailsMenu()
        {
            Console.WriteLine("--------------------------------------------\n" +
                  "[1 - See One Specific Product] [2 - See All the Product] \n" +
                  "--------------------------------------------");
            int IdProductUpdate = int.Parse(Console.ReadLine());

            switch (IdProductUpdate)
            {
                case 1:
                    DetailsOneProductMenu();
                    break;
                case 2:
                    DetailsAllProducts();
                    break;
            }

        }
        public void DetailsOneProductMenu()
        {
            Console.WriteLine("--------------------------------------------\n" +
                              "Give me the ID of the Product: \n" +
                              "--------------------------------------------");
            int IdProductUpdate = int.Parse(Console.ReadLine());

            if (IdProductUpdate > ProductsList.Count || IdProductUpdate == 0)
            {
                Console.WriteLine($"The Object With The ID {IdProductUpdate} Doesnt Exits");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            foreach (Products Product in ProductsList)
            {
                if (Product.id == IdProductUpdate)
                {
                    Console.WriteLine($"I found it: " +
                                      $"\nID: {Product.id} " +
                                      $"\nName: {Product.name}" +
                                      $"\nDescripcion: {Product.description}" +
                                      $"\nCategory: {Product.category} ");
                }
            }
        }
        public void DetailsAllProducts()
        {
            if (ProductsList.Count == 0)
            {
                Console.WriteLine($"There arent any Product in the Inventary");
            }
            else
            {
                Console.WriteLine("-------------List Of Products-----------\n");
                foreach (Products Product in ProductsList)
                {
                    Console.WriteLine(
                                      $"\nID: {Product.id} " +
                                      $"\nName: {Product.name}" +
                                      $"\nDescripcion: {Product.description}" +
                                      $"\nCategory: {Product.category}"+
                                      $"\n----------------------------------");
                }
            }
        }
        public void UpdateMenu()
        {
            DetailsAllProducts();
            Console.WriteLine("--------------------------------------------\n" +
                              "Give me the ID of the Product: \n" +
                              "--------------------------------------------");
            int IdProductUpdate = int.Parse(Console.ReadLine());

            if (IdProductUpdate > ProductsList.Count || IdProductUpdate == 0)
            {
                Console.WriteLine($"The Object With The ID {IdProductUpdate} Doesnt Exits");
            }

            foreach (Products Product in ProductsList)
            {
                if (IdProductUpdate == Product.id)
                {
                    UpdateProcess(Product, IdProductUpdate);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again, and put a correct ID");
                    DetailsAllProducts();
                }
            }
        }
        public void UpdateProcess(Products Product, int IdProductUpdate)
        {
            if (Product.id == IdProductUpdate)
            {
                Console.WriteLine($"I found it: " +
                                  $"\nID: {Product.id} " +
                                  $"\nName: {Product.name}" +
                                  $"\nDescripcion: {Product.description}" +
                                  $"\nCategory: {Product.category} ");

                Console.WriteLine("--------------------------------------------\n" +
                                  "Complete the following datas of the product: \n" +
                                  "--------------------------------------------");

                Console.WriteLine("name");
                string NewName = Console.ReadLine();
                Console.WriteLine("descripcion");
                string NewDescripcion = Console.ReadLine();
                Console.WriteLine("category");
                string NewCategopry = Console.ReadLine();

                if (string.IsNullOrEmpty(NewName))
                {
                    Product.name = Product.name;
                }
                else
                {
                    Product.name = NewName;
                }

                if (string.IsNullOrEmpty(NewDescripcion))
                {
                    Product.description = Product.description;
                }
                else
                {
                    Product.description = NewDescripcion;
                }

                if (string.IsNullOrEmpty(NewCategopry))
                {
                    Product.category = Product.category;
                }
                else
                {
                    Product.category = NewCategopry;
                }

                Console.WriteLine($"I found it: " +
                                  $"\nID: {Product.id} " +
                                  $"\nName: {Product.name}" +
                                  $"\nDescripcion: {Product.description}" +
                                  $"\nCategory: {Product.category} ");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
        public void AddMenu()
        {
            Console.WriteLine("--------------------------------------------\n" + 
                              "Complete the following datas of the product: \n" + 
                              "--------------------------------------------");

            Console.WriteLine("[ Name of the product: ]");
            string AnswerOne = Console.ReadLine();

            Console.WriteLine("[ Description of the product: ]");
            string AnswerOTwo = Console.ReadLine();

            Console.WriteLine("[ Category: ]");
            string AnswerThree = Console.ReadLine();

            if (ProductsList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id++;
            }

            Products NewProduct = new()
            {
                name = AnswerOne,
                id = id,
                description = AnswerOTwo,
                category = AnswerThree
            };

            ProductsList.Add(NewProduct);

            Console.WriteLine($"-------------------------------------------------\n" +
                  $"The ProductID {NewProduct.id} Have been created \n" +
                  $"-------------------------------------------------\n" +
                  $"Name: {NewProduct.name} \nDescripcion: {NewProduct.description} " +
                  $"\nCategory: {NewProduct.category}" +
                  $"\n-------------------------------------------------");
        }
    }
}
