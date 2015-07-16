using System;

namespace programming_project_i
{
    public class Menu
    {
        private string[] menuItems;

        public Menu(string[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public void Display()
        {
            for (var index = 0; index < menuItems.Length; index++)
            {
                Console.WriteLine("{0}. {1}", index + 1, menuItems[index]);
            }
        }

        public string GetMenuOption()
        {
            Console.Write("Select (1-{0}):", menuItems.Length - 1);

            var input = Console.ReadLine();

            return input;
        }
    }
}
