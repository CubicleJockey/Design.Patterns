using System;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.Zombies
{
    public class WalkerZombie : IZombie
    {
        private readonly Random random;

        public WalkerZombie()
        {
            random = new Random();

            Name = "Walker Zombie";
            Speed = random.Next(2, 5);
            Health = (random.NextDouble() * 100);
        }

        #region Implementation of IZombie

        public string Name { get; }
        public int Speed { get; }
        public double Health { get; private set; }
        public void TakeDamage(double damage)
        {
            if(Math.Abs(Health) <= 0) { return; } //Already Dead
            if(damage > Health)
            {
                Health = 0.0;
            }
            else
            {
                Health = Health - damage; 
            }
        }

        public double DealDamage()
        {
            return 7;
        }

        #endregion
    }
}
