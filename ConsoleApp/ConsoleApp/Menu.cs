using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge34Library.Models
{
    class Menu
    {
        private const int MENU_ARRAY_SIZE = 5;
        private string Title;
        private int ItemCount = 0;
        private MenuItem[] MenuItems = new MenuItem[MENU_ARRAY_SIZE];


        public Menu(string menuTitle)
        {
            this.Title = menuTitle;
        }

        public void Show()
        {
            Console.WriteLine(Title + "\n");
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine("  " + MenuItems[i].Title);
            }
            //Console.WriteLine("\nTryk menupunkt eller 0 for at afslutte");
        }

        public void AddMenuItem(string title)
        {
            MenuItem menuLine = new MenuItem();
            menuLine.Title = title;
            MenuItems[ItemCount] = menuLine;
            ItemCount++;
        }
    }
}
