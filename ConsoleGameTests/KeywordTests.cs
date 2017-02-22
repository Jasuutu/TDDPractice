using ConsoleGame;
using NUnit.Framework;

namespace ConsoleGameTests
{
    [Category("KeywordTests")]
    [TestFixture]
    public class KeywordTests
    {
        #region Properties

        private Keyword _keyword;

        #endregion

        #region Constants
        private const string KeywordName = "North";
        #endregion

        [OneTimeSetUp]
        public void SetupTests()
        {
            this._keyword = new Keyword(KeywordName);
        }

        [Test]
        public void KeywordConstructorTest()
        {
            Assert.IsNotNull(this._keyword);
        }

        [Test]
        public void KeywordDisposeTest()
        {
            this._keyword.Dispose();
            Assert.IsNull(this._keyword.GetName());
        }

        [Test]
        public void GetNameTest()
        {
            Assert.AreEqual(KeywordName, this._keyword.GetName()); 
        }
    }

}