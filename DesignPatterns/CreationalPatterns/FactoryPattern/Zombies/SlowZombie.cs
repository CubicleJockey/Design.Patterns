using System;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.Zombies
{
    public class SlowZombie : IZombie
    {
        private readonly Random random;

        public SlowZombie()
        {
            random = new Random();

            Name = "Slow Zombie";
            Speed = random.Next(0, 2);
            Health = (random.NextDouble() * 100);
        }


        #region Implementation of IZombie

        public string Name { get; }
        public int Speed { get; }
        public double Health { get; private set; }

        public void TakeDamage(double damage)
        {
            if(Math.Abs(Health) <= 0) { return; }
            if(damage > Health) { Health = 0.0; }

            Health = Health - damage;
        }

        public double DealDamage()
        {
            return 2;
        }

        #endregion
    }
}
