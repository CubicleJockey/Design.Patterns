using System;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.AbstractFactories
{
    public class SlowZombieFactory : ZombieFactoryBase
    {
        #region Overrides of ZombieFactoryBase

        protected override IZombie BeforeTurning()
        {
            Console.WriteLine($"Stuggled with the virus in bed for {random.Next(0, 20)} day(s), before becoming a {nameof(SlowZombie)}.");
            return new SlowZombie();
        }

        #endregion
    }
}
