using System.Runtime.InteropServices;
using ConsoleGame;
using ConsoleGame.Interfaces;
using ConsoleGameTests.Moqs;
using Moq;
using NUnit.Framework;


namespace ConsoleGameTests
{
    [Category("CharacterTests")]
    [TestFixture]
    public class ChacracterTests
    {
        #region Constants

        private const string Name = "Test";
        private const string StatName = "TestStat";
        private const int StatValue = 100;

        #endregion
        #region Properties

        private Character _character;

        #endregion

        [OneTimeSetUp]
        public void SetupTests()
        {
            this._character = new Character();
        }
        [Test]
        public void CharacterConstructorTest()
        {

            Assert.IsInstanceOf<ICharacter>(this._character);
        }

        [Test]
        public void AddStatToCharcterTest()
        {
            IStat stat = new StatMock().Object;
            this._character.AddStatToCharacter(stat);
        }
        [Test]
        public void NameCharacterTest()
        {
            this._character.NameCharacter(Name);
        }

        [Test]
        public void GetStat()
        {
            IStat stat = new StatMock().Object;
            this._character.AddStatToCharacter(stat);

            // TODO: Needs to be finished
            // Assert.IsNotNull(_character.GetStatBasedOnName(stat.GetName()));
        }
    }
}