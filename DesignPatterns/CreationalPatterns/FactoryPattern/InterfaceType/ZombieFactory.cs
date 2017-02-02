using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType.Interfaces;
using DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType.Zombies;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType
{
    public class ZombieFactory
    {
        private readonly int MaxZombieId;
        private readonly Random random;

        public ZombieFactory()
        {
            random = new Random();
            MaxZombieId = Enum.GetValues(typeof(ZombieType)).Cast<int>().Max();
        }

        public IZombie GetZombie(ZombieType type)
        {
            switch(type)
            {
                case ZombieType.Slow:
                    return new SlowZombie();
                case ZombieType.Walker:
                    return new WalkerZombie();
                case ZombieType.Runner:
                    return new RunnerZombie();
                case ZombieType.Alter:
                    return new AlterZombie();
                default:
                    return new SlowZombie();
            }
        }

        public IEnumerable<IZombie> GetZombieHerd(int size)
        {
            IList<IZombie> herd = new List<IZombie>();
            for(var i = 0; i < size; i++)
            {
                herd.Add(GetZombie((ZombieType)random.Next(0, MaxZombieId + 1))); //The +1 was the random was never spitting out an alter.
            }
            return herd;
        }
    }
}
