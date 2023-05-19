

using DemoNetOOTechnobel;
using DemoNetOOTechnobel.Interfaces;

BackPack backPack = new BackPack();

Armoire armoire = new Armoire();

Socks socks = new Socks();

void AddToContainer(IContainer container, Item item)
{
    container.AddItem(item);
}

AddToContainer(armoire, socks);