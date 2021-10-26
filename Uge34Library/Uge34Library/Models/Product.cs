using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public Basket Basket { get; set; }

        public void CreateProduct()
        {
            Console.Clear();
            Console.WriteLine("Indtast produkt id\n");
            ProductId = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Indtast Kategori\n");
            Category = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Indtast Pris\n");
            Price = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Indtast Produkt Navn\n");
            ProductName = Console.ReadLine();

            Console.Clear() ;
            Console.WriteLine("Indtast Beskrivelse\n");
            Description = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Indtast mængde\n");
            Amount = int.Parse(Console.ReadLine());

            string text = ("Id: " + ProductId + "\nKateogri: " + Category + "\nPris: " + Price + "\nNavn: " + ProductName + "\nBeskrivelse: " + Description + "\nMængde: " + Amount).ToString();
            string path = ("produkt.txt");
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(Path.Combine(docPath, "Produkt.txt"), text);
            //string[] text = { "New Line 1", "New Line 2" };
           // File.AppendAllLines(Path.Combine(docPath, "Produkt.txt"), text.Split());


          //  using (StreamWriter sw = new StreamWriter("path"))
           //     sw.WriteLine("Id : " + ProductId + "\nKateogri : " + Category + "\nPris : " + Price + "\nNavn : " + ProductName + "\nBeskrivelse : " + Description + "\nMængde : " + Amount);
            //Writer writer = new StreamWriter("Produkt\\" + ProductId + " " + Category + " " + Price + " " + ProductName + " " + Description + " " + Amount);
            //writer.WriteLine("Id : " + ProductId + "\nKateogri : " + Category + "\nPris : " + Price + "\nNavn : " + ProductName + "\nBeskrivelse : " + Description + "\nMængde : " + Amount);
            //writer.Close();
            //Console.Clear();
            //Console.ReadLine();

        }
        public void ShowProduct()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("produkt.txt"))
            {
                while ((line = sr.ReadLine()) !=null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
