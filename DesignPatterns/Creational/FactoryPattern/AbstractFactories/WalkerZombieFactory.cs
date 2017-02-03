using System;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.AbstractFactories
{
    public class WalkerZombieFactory : ZombieFactoryBase
    {
        #region Overrides of ZombieFactoryBase

        protected override IZombie BeforeTurning()
        {
            Console.WriteLine($"Managed to walk around infected {random.Next(13, 25)} day(s) before turning.");
            return new WalkerZombie();
        }

        #endregion
    }
}
