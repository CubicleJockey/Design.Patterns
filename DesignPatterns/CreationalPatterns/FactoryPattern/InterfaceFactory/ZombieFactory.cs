using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType
{
    public class ZombieFactory
    {
        private readonly int MaxZombieId;
        private readonly Random random;

        public ZombieFactory()
        {
            random = new Random();
            MaxZombieId = Enum.GetValues(typeof(ZombieTypes)).Cast<int>().Max();
        }

        public IZombie GetZombie(ZombieTypes type)
        {
            switch(type)
            {
                case ZombieTypes.Slow:
                    return new SlowZombie();
                case ZombieTypes.Walker:
                    return new WalkerZombie();
                case ZombieTypes.Runner:
                    return new RunnerZombie();
                case ZombieTypes.Alter:
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
                herd.Add(GetZombie((ZombieTypes)random.Next(0, MaxZombieId + 1))); //The +1 was the random was never spitting out an alter.
            }
            return herd;
        }
    }
}
