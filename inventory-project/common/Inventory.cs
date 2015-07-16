using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace common
{
    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void ReadData()
        {
            if (!File.Exists(@".\inventory.dat"))
            {
                return;
            }

            // deserialize the file
        }

        public void SaveData()
        {
            // serialize the file
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Change(Item changedItem)
        {
            // Delete the old item
            Delete(changedItem.ItemNumber);

            Add(changedItem);
        }

        public void Delete(int itemNumber)
        {
            items.RemoveAll(item => item.ItemNumber == itemNumber);
        }

        public string[] ListAll()
        {
            var strings = new string[items.Count];

            for (var index = 0; index < items.Count; index++)
            {
                strings[index] = items[index].ToString();
            }

            return strings;
        }

        public void ListAllBelow()
        {
            Console.WriteLine("List All Below");
            // Ask for a quantity
            // Display all items that have a quantity less than that
        }

        public bool ItemExists(int itemNumber)
        {
            //LINQ: return items.Any(item => item.ItemNumber == itemNumber);

            foreach (var item in items)
            {
                if (item.ItemNumber == itemNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public Item Find(int itemNumber)
        {
            foreach (var item in items)
            {
                if (item.ItemNumber == itemNumber)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
