using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public class Keyword : IKeyword
    {
        #region Properties
        private string Name { get; set; }
        #endregion

        public Keyword(string name)
        {
            this.Name = name;
        }

        public void Dispose()
        {
            this.Name = null;
        }

        public string GetName()
        {
            return this.Name;
   ;    }
    }
}
