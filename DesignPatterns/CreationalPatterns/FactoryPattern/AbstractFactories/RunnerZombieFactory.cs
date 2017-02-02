using System;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.AbstractFactories
{
    public class RunnerZombieFactory : ZombieFactoryBase
    {
        #region Overrides of ZombieFactoryBase

        protected override IZombie BeforeTurning()
        {
            Console.WriteLine($"Ran around in a blind rage for {random.Next(1, 3)} day(s) before turning.");
            return new RunnerZombie();
        }

        #endregion
    }
}
