using System;

namespace DesignPatterns.CreationalPatterns.FactoryPattern.Zombies
{
    public class AlterZombie : IZombie
    {
        private readonly Random random;

        public AlterZombie()
        {
            random = new Random();

            Name = "Alter Zombie";
            Speed = random.Next(0, 20); //Wide Range of Speed
            Health = (random.NextDouble() * 150); //Health Beyond 100

        }

        #region Implementation of IZombie

        public string Name { get; }
        public int Speed { get; }
        public double Health { get; private set; }
        public void TakeDamage(double damage)
        {
            if(Math.Abs(Health) <= 0)
            {
                return;}
            if(random.Next(1, 2) == 1)
            {
                damage = (damage + (random.NextDouble() * 20)); // damage boost
            }
            else
            {
                damage = (damage - (random.NextDouble() * 20)); // damage boost
                if(damage < 0.0)
                {
                    damage = 0.0;
                }
            }

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
            return (random.NextDouble() * 90); //Damage varies widely from no damage to 90% damage.
        }

        #endregion
    }
}
