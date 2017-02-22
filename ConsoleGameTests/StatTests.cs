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
            this._stat = new Stat(Name, Value);
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
        public void SetValueTest()
        {
            this._stat.SetValue(Value);
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
    }
}