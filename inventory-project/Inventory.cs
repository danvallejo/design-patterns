using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace programming_project_i
{
    public class Inventory
    {
        private const string FileName = "inventory.dat";
        private List<Item> items = new List<Item>();

        public void ReadData()
        {
            if (File.Exists(FileName))
            {
                var stream = File.Open(FileName, FileMode.Open);
                var formatter = new BinaryFormatter();
                items = (List<Item>) formatter.Deserialize(stream);
                stream.Close();
            }
        }

        public void SaveData()
        {
            var stream = File.Create(FileName);
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, items);
            stream.Close();
        }

        public IEnumerable<string> ListAllBelow(int quantity)
        {
            foreach (var item in items)
            {
                if (item.Quantity < quantity)
                {
                    yield return item.ToString();
                }
            }
        }

        public IEnumerable<string> ListAll()
        {
            foreach (var item in items)
            {
                yield return item.ToString();
            }
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public Item Find(int itemNumber)
        {
            var item = items.SingleOrDefault(t => t.ItemNumber == itemNumber);

            return item;
        }

        public void Change(Item item)
        {
        }

        public void Delete(int itemNumber)
        {
           var count = items.RemoveAll(t => t.ItemNumber == itemNumber);
        }
    }
}
