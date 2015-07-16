using System;

namespace programming_project_i
{
    class Program
    {
        static void Main()
        {
            var inventory = new Inventory();

            inventory.ReadData();

            var menuItems = new[]
            {
                "Add an item",
                "Change an item (by giving its item number)",
                "Delete an item (by giving its item number)",
                "List all items in the database",
                "List items below a user-given quantity (for re-ordering purposes)",
                "Quit",
            };

            var menu = new Menu(menuItems);

            var quitting = false;

            while (!quitting)
            {
                menu.Display();

                var menuOption = menu.GetMenuOption();

                switch (menuOption)
                {
                    case "1":
                    {
                        Console.WriteLine("Add Item");

                        Console.Write("Item#       :");
                        var itemNumber = Console.ReadLine();

                        Console.Write("Description :");
                        var description = Console.ReadLine();

                        Console.Write("Price       :");
                        var price = Console.ReadLine();

                        Console.Write("Quantity    :");
                        var quantity = Console.ReadLine();

                        var item = new Item
                        {
                            ItemNumber = int.Parse(itemNumber),
                            Description = description,
                            Price = float.Parse(price),
                            Quantity = int.Parse(quantity),
                        };

                        inventory.Add(item);
                        break;
                    }

                    case "2":
                    {
                        Console.WriteLine("Change Item");

                        Console.Write("Enter Item#");
                        var itemNumber = Console.ReadLine();

                        var existingItem = inventory.Find(int.Parse(itemNumber));
                        if (existingItem == null)
                        {
                            Console.WriteLine("Item not found.");
                        }
                        else
                        {
                            Console.Write("Item#            : {0}", itemNumber);

                            Console.WriteLine("OLD Description  : {0}", existingItem.Description);
                            Console.Write(    "New Description  : ");
                            var description = Console.ReadLine();

                            Console.WriteLine("OLD Price        : {0}", existingItem.Price);
                            Console.Write(    "Price            : ");
                            var price = Console.ReadLine();

                            Console.WriteLine("OLD Quantity     : {0}", existingItem.Quantity);
                            Console.Write(    "Quantity         : ");
                            var quantity = Console.ReadLine();

                            var item = new Item
                            {
                                ItemNumber = int.Parse(itemNumber),
                                Description = description,
                                Price = float.Parse(price),
                                Quantity = int.Parse(quantity),
                            };  

                            inventory.Change(item);
                        }
                        break;
                    }

                    case "3":
                    {
                        Console.WriteLine("Delete");

                        // Ask for the item#
                        Console.Write("Enter Item#");
                        var itemNumber = Console.ReadLine();

                          var existingItem = inventory.Find(int.Parse(itemNumber));
                        if (existingItem == null)
                        {
                            Console.WriteLine("Item not found.");
                        }
                        else
                        {
                            inventory.Delete(existingItem.ItemNumber);
                        }
                        break;
                    }

                    case "4":
                    {
                        Console.WriteLine("List All");

                        var lines = inventory.ListAll();

                        foreach (var line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        break;
                    }

                    case "5":
                    {
                        var lines = inventory.ListAllBelow(5);

                        foreach (var line in lines)
                        {
                            Console.WriteLine(line);
                        } break;
                    }

                    case "6":
                    {
                        Console.WriteLine("Quit");
                        quitting = true;
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
                }
            }

            inventory.SaveData();
        }
    }
}
