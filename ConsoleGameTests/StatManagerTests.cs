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

        #region Constants

        private const string TestStatName = "Test";
        private const int TestStatValue = 10;
        #endregion

        private StatManager _statManager;
        [SetUp]
        public void SetUpTests()
        {
            this._statManager = new StatManager();
        }
        [Test]
        public void StatManagerConstructorTest()
        {
            
            Assert.IsNotNull(this._statManager);
        }

        [Test]
        public void AddStatTest()
        {
            var testStat = new Stat(TestStatName, TestStatValue);
            this._statManager.AddStat(testStat);

        }

        [Test]
        public void ListStatsTest()
        {
            var testStat = new Stat(TestStatName, TestStatValue);
            this._statManager.AddStat(testStat);
            Assert.IsNotNull(this._statManager.ListStats());

        }

        [TearDown]
        public void TestCleanup()
        {
            this._statManager = null;
        }
    }
}