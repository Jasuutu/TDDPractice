using System.Net.NetworkInformation;
using ConsoleGame;
using ConsoleGame.Interfaces;
using ConsoleGameTests.Moqs;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ConsoleGameTests
{

    // TODO: Concidering taking this class out since I think it can be replaced by just a List<IStas>.
    // Holding off on contineing this untill a later time

    [Category("StatManagerTests")]
    [TestFixture]
    public class StatManagerTests
    {
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
            IStat stat = new StatMock().Object;
            this._statManager.AddStat(stat);

        }

        [Test]
        public void ListStatsTest()
        {
            IStat stat = new StatMock().Object;
            this._statManager.AddStat(stat);
            Assert.IsNotNull(this._statManager.ListStats());

        }

        [TearDown]
        public void TestCleanup()
        {
            this._statManager = null;
        }
    }
}