using DemoNetOOTechnobel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetOOTechnobel
{
    internal class Armoire : Furniture, IContainer
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public int Volume { get; set; }

        public void AddItem(Item item)
        {
            Console.WriteLine("Ajout de l'item dans l'armoire");
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Console.WriteLine("suppression de l'item dans l'armoire");
            Items.Remove(item);
        }
    }
}
