using System;
using System.IO;
using Uge34Library;

namespace Uge34Library.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Webshop Menu");
            //DirectoryInfo[] Prod = new DirectoryInfo(@"c:\").GetDirectories();


            mainMenu.AddMenuItem("1. Vis Produkt");
            mainMenu.AddMenuItem("2. Opret Produkt");
            mainMenu.AddMenuItem("3. Slet Produkt");
            mainMenu.AddMenuItem("4. Rediger Produkt");
            mainMenu.AddMenuItem("5. Afslut\n");

            startOver:
            mainMenu.Show();
            string userInput = Console.ReadLine();
            switch (userInput) 
            {
                case "1":
                    {
                        Product product = new Product();
                        product.ShowProduct();
                        break;
                    }
                case "2":
                    {

                        Product product= new Product();
                        product.CreateProduct();
                        break;
                    }





            }

        }
    }
}
