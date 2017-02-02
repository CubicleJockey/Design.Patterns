using DesignPatterns.CreationalPatterns.FactoryPattern.AbstractFactories;
using DesignPatterns.CreationalPatterns.FactoryPattern.Zombies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests.CreationalPatterns.FactoryPattern.AbstractFactory
{
    /// <summary>
    /// For test test runs the BeforeTurning action outputs to the console. 
    /// So check there for the factory specific response.
    /// </summary>
    [TestClass]
    public class ZombieWorld
    {
        [TestMethod]
        public void SlowZombieFactory()
        {
            var factory = new SlowZombieFactory();;

            factory.Should().NotBeNull();
            factory.Should().BeAssignableTo<ZombieFactoryBase>();
            factory.Should().BeOfType<SlowZombieFactory>();

            //Check console output for the BeforeTurning messages
            var zombie = factory.GetZombie();

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<WalkerZombie>();
            zombie.Should().NotBeOfType<RunnerZombie>();
            zombie.Should().NotBeOfType<AlterZombie>();

            zombie.Should().BeOfType<SlowZombie>();
        }

        [TestMethod]
        public void WalkerZombieFactory()
        {
            var factory = new WalkerZombieFactory();

            factory.Should().NotBeNull();
            factory.Should().BeAssignableTo<ZombieFactoryBase>();
            factory.Should().BeOfType<WalkerZombieFactory>();

            //Check console output for the BeforeTurning messages
            var zombie = factory.GetZombie();

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<SlowZombie>();
            zombie.Should().NotBeOfType<RunnerZombie>();
            zombie.Should().NotBeOfType<AlterZombie>();

            zombie.Should().BeOfType<WalkerZombie>();
        }

        [TestMethod]
        public void RunnerZombieFactory()
        {
            var factory = new RunnerZombieFactory(); ;

            factory.Should().NotBeNull();
            factory.Should().BeAssignableTo<ZombieFactoryBase>();
            factory.Should().BeOfType<RunnerZombieFactory>();

            //Check console output for the BeforeTurning messages
            var zombie = factory.GetZombie();

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<WalkerZombie>();
            zombie.Should().NotBeOfType<SlowZombie>();
            zombie.Should().NotBeOfType<AlterZombie>();

            zombie.Should().BeOfType<RunnerZombie>();
        }

        [TestMethod]
        public void AlterZombieFactory()
        {
            var factory = new AlterZombieFactory(); ;

            factory.Should().NotBeNull();
            factory.Should().BeAssignableTo<ZombieFactoryBase>();
            factory.Should().BeOfType<AlterZombieFactory>();

            //Check console output for the BeforeTurning messages
            var zombie = factory.GetZombie();

            zombie.Should().NotBeNull();
            zombie.Should().BeAssignableTo<IZombie>();

            zombie.Should().NotBeOfType<WalkerZombie>();
            zombie.Should().NotBeOfType<SlowZombie>();
            zombie.Should().NotBeOfType<RunnerZombie>();

            zombie.Should().BeOfType<AlterZombie>();
        }
    }
}
