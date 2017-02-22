using ConsoleGame;
using ConsoleGame.Interfaces;
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
        private const int Mp = 100;

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
            var moqStat = new Mock<IStat>(MockBehavior.Strict);
            //moqStat
            //    .Setup(x => x.SetName(It.IsAny<string>()) & x.SetValue(It.IsAny<int>()));
            
                
            var Hp = new Stat(StatName, StatValue);
            Hp.SetName(StatName);
            this._character.AddStatToCharacter(Hp);
        }
        [Test]
        public void NameCharacterTest()
        {
            this._character.NameCharacter(Name);
        }

        [Test]
        public void GetStat()
        {
            
        }
    }
}