using System.Net.NetworkInformation;
using ConsoleGame;
using ConsoleGame.Interfaces;
using NUnit.Framework;

namespace ConsoleGameTests
{
    [Category("StatTests")]
    [TestFixture]
    public class StatTests
    {
        #region Constants

        private const string Name = "HP";
        private const int Value = 100;
        #endregion

        #region Properties

        private Stat _stat;

        #endregion

        [OneTimeSetUp]
        public void SetupTests()
        {
            this._stat = new Stat(Name);
        }
        [Test]
        public void StatConstrutorTest()
        {
            
            Assert.IsInstanceOf<IStat>(this._stat);
        }

        [Test]
        public void SetNameTest()
        {
            this._stat.SetName(Name);
        }

        [Test]
        public void GetNameTest()
        {

            Assert.AreEqual(this._stat.GetName(), Name);
        }

        [Test]
        public void GetValueTest()
        {
            Assert.AreEqual(this._stat.GetValue(), Value);
        }

        [Test]
        public void ChangeStatValueTest()
        {
            this._stat.ChangeStatValue(Value);
            Assert.NotZero(this._stat.GetValue());

        }
    }
}