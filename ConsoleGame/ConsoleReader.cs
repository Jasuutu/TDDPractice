using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public class ConsoleReader : IConsoleReader
    {
        #region Properties

        private List<IKeyword> Keywords { get; }
        #endregion

        public ConsoleReader()
        {
            this.Keywords = new List<IKeyword>();
            

        }

        public string ParseText(string input)
        {
            return input;
        }

        public void AddKeyword(IKeyword keyword)
        {
            this.Keywords.Add(keyword);
        }
        public void RemoveKeyword(IKeyword keyword)
        {
            this.Keywords.Remove(keyword);
        }

        public List<IKeyword> GetKeywords()
        {
            return this.Keywords;
        }

        public List<string> CheckString(string input)
        {
            var resultsList = new List<string>();
            string[] splitInputList = input.Split();
            foreach (string word in splitInputList)
            {
                if (this.Keywords.Any(x => x.GetName() == word))
                {
                    resultsList.Add(word);
                }
            }

            return resultsList;

        }

        public void Dispose()
        {
            this.Keywords.Clear();
        }
    }
}
