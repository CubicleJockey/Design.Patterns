using System;
using DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType.Interfaces;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType.Zombies
{
    public class RunnerZombie : IZombie
    {
        private readonly Random random;
        public RunnerZombie()
        {
            random = new Random();

            Name = "Runner Zombie";
            Speed = random.Next(6, 12);
            Health = (random.NextDouble() * 100);
        }

        #region Implementation of IZombie

        public string Name { get; }
        public int Speed { get; }
        public double Health { get; private set; }
        public void TakeDamage(double damage)
        {
            if (Math.Abs(Health) <= 0) { return; }
            if (damage > Health) { Health = 0.0; }

            Health = Health - damage;
        }

        public double DealDamage()
        {
            return 10;
        }

        #endregion
    }
}
