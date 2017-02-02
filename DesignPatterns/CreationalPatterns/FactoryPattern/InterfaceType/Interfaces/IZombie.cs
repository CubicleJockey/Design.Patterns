namespace DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType.Interfaces
{
    /// <summary>
    /// The basic definition of a Zombie
    /// 
    /// This is an example and not 100% realistic. 
    /// i.e: Dealing damage would have to know to what etc.
    /// </summary>
    public interface IZombie
    {
        string Name { get; }
        int Speed { get; }
        double Health { get; }

        void TakeDamage(double damage);
        double DealDamage();
    }
}