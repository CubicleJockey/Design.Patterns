using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;
using static System.Console;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.AbstractFactories
{
    public class AlterZombieFactory : ZombieFactoryBase
    {
        #region Overrides of ZombieFactoryBase

        protected override IZombie BeforeTurning()
        {
            WriteLine($"This person was sick with an illness before catching the virus and turned in {random.Next(3, 100)} day(s) with non standard attributes.");
            return new AlterZombie();
        }

        #endregion
    }
}
