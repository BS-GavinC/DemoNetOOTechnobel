using DemoNetOOTechnobel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetOOTechnobel
{
    internal class BackPack : Clothe, IContainer
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public int Volume { get; set; }

    }
}
