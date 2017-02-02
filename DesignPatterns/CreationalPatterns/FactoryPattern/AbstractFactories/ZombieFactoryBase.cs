using System;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.AbstractFactories
{
    public abstract class ZombieFactoryBase
    {
        protected readonly Random random;

        protected ZombieFactoryBase()
        {
            random = new Random();
        }

        protected abstract IZombie BeforeTurning();

        public IZombie GetZombie()
        {
            return BeforeTurning();
        }

    }
}
