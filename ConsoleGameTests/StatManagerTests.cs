using System.Net.NetworkInformation;
using ConsoleGame;
using ConsoleGame.Interfaces;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ConsoleGameTests
{
    [Category("StatManagerTests")]
    [TestFixture]
    public class StatManagerTests
    {
        private StatManager statManager;
        [SetUp]
        public void SetUpTests()
        {
            this.statManager = new StatManager();
        }
        [Test]
        public void StatManagerConstructorTest()
        {
            
            Assert.IsNotNull(statManager);
        }

        [Test]
        public void AddStatTest()
        {
            var testStat = new Stat("Test", 10);
            this.statManager.AddStat(testStat);

        }

        [TearDown]
        public void TestCleanup()
        {
            this.statManager = null;
        }
    }
}