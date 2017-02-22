using ConsoleGame;
using NUnit.Framework;

namespace ConsoleGameTests
{
    [Category("ConsoleReader")]
    [TestFixture]
    public class ConsoleReaderTests
    {
        private ConsoleReader reader;

        #region Constants
        const string Name = "North";
        #endregion

        [SetUp]
        public void SetupTest()
        {
            this.reader = new ConsoleReader();
        }

        
        [Test]
        public void ConsoleReaderConstructorTest()
        {
            const string input = "This is a test string";
            
            string output = reader.ParseText(input);
            Assert.AreEqual(input,output);
        }

        [Test]
        public void AddKeywordTest()
        {
            
            var keyword = new Keyword(Name);
            this.reader.AddKeyword(keyword);

            Assert.IsNotNull(this.reader.GetKeywords());
        }

        [Test]
        public void RemoveKeywordTest()
        {
            var keyword = new Keyword(Name);
            this.reader.AddKeyword(keyword);
            this.reader.RemoveKeyword(keyword);
            Assert.IsEmpty(this.reader.GetKeywords());
        }

        [Test]
        public void CheckStringTest()
        {
            var keyword = new Keyword(Name);
            this.reader.AddKeyword(keyword);
            Assert.Contains(Name, this.reader.CheckString("This string contains the keyword North"));
        }


        [TearDown]
        public void TearDown()
        {
            this.reader.Dispose();
        }
    }
}