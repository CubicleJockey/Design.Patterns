using System;
using System.Linq;
using DesignPatterns.CreationalPatterns.FactoryPattern.InterfaceType;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.CreationalPatterns.FactoryPattern.InterfaceFactory
{
    [TestClass]
    public class ZombieWorld
    {
        private readonly ZombieFactory zFactory;

        public ZombieWorld()
        {
            zFactory = new ZombieFactory();
        }

        [TestMethod]
        public void GetSlowZombie()
        {
            var zombie = zFactory.GetZombie(ZombieTypes.Slow);

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<WalkerZombie>();
            zombie.Should().NotBeOfType<RunnerZombie>();
            zombie.Should().NotBeOfType<AlterZombie>();

            zombie.Should().BeOfType<SlowZombie>();

            zombie.Name.Should().BeEquivalentTo("Slow Zombie");
            zombie.Speed.Should().BeInRange(0, 2);
            zombie.Health.Should().BeInRange(0, 100);

            zombie.DealDamage().ShouldBeEquivalentTo(2);

            var attack = zombie.Health - 2.2;
            var originalHealth = zombie.Health;
            zombie.TakeDamage(attack);

            if (Math.Abs(zombie.Health) > 0)
            {
                zombie.Health.ShouldBeEquivalentTo(originalHealth - attack);
            }
        }

        [TestMethod]
        public void GetWalkerZombie()
        {
            var zombie = zFactory.GetZombie(ZombieTypes.Walker);

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<SlowZombie>();
            zombie.Should().NotBeOfType<RunnerZombie>();
            zombie.Should().NotBeOfType<AlterZombie>();

            zombie.Should().BeOfType<WalkerZombie>();

            zombie.Name.Should().BeEquivalentTo("Walker Zombie");
            zombie.Speed.Should().BeInRange(2, 5);
            zombie.Health.Should().BeInRange(0, 100);

            zombie.DealDamage().ShouldBeEquivalentTo(7);

            var attack = zombie.Health - 2.2;
            var originalHealth = zombie.Health;
            zombie.TakeDamage(attack);

            if (Math.Abs(zombie.Health) > 0)
            {
                zombie.Health.ShouldBeEquivalentTo(originalHealth - attack);
            }
        }

        [TestMethod]
        public void GetRunnerZombie()
        {
            var zombie = zFactory.GetZombie(ZombieTypes.Runner);

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<SlowZombie>();
            zombie.Should().NotBeOfType<WalkerZombie>();
            zombie.Should().NotBeOfType<AlterZombie>();

            zombie.Should().BeOfType<RunnerZombie>();

            zombie.Name.Should().BeEquivalentTo("Runner Zombie");
            zombie.Speed.Should().BeInRange(6, 12);
            zombie.Health.Should().BeInRange(0, 100);

            zombie.DealDamage().ShouldBeEquivalentTo(10);

            var attack = zombie.Health - 2.2;
            var originalHealth = zombie.Health;
            zombie.TakeDamage(attack);

            if (Math.Abs(zombie.Health) > 0)
            {
                zombie.Health.ShouldBeEquivalentTo(originalHealth - attack);
            }
        }

        [TestMethod]
        public void GetAlterZombie()
        {
            var zombie = zFactory.GetZombie(ZombieTypes.Alter);

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<SlowZombie>();
            zombie.Should().NotBeOfType<WalkerZombie>();
            zombie.Should().NotBeOfType<RunnerZombie>();

            zombie.Should().BeOfType<AlterZombie>();

            zombie.Name.Should().BeEquivalentTo("Alter Zombie");
            zombie.Speed.Should().BeInRange(0, 20);
            zombie.Health.Should().BeInRange(0, 150);

            zombie.DealDamage().Should().BeInRange(0, 90);

            var attack = zombie.Health - 2.2;
            var originalHealth = zombie.Health;
            zombie.TakeDamage(attack);

            if(Math.Abs(zombie.Health) > 0)
            {
                zombie.Health.ShouldBeEquivalentTo(originalHealth - attack);
            }
        }

        [TestMethod]
        public void GetZombieHerd()
        {
            const int HERDSIZE = 20;
            var herd = zFactory.GetZombieHerd(HERDSIZE).ToArray();

            herd.Should().NotBeNull();
            herd.Length.ShouldBeEquivalentTo(HERDSIZE);

            herd.Should().AllBeAssignableTo<IZombie>();

            //Hoping that 20 is enough to get one of each type
            foreach(var zombie in herd)
            {
                Console.WriteLine(zombie.Name);
            }
        }
    }
}
