using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetOOTechnobel.Interfaces
{
    public interface IContainer
    {
        public List<Item> Items { get; set; }

        public int Volume { get; set; }

        public void AddItem(Item item)
        {
            Console.WriteLine("Element ajouter");
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

    }
}
