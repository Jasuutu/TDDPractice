using System;
using System.Collections.Generic;
using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public class Character : ICharacter
    {
        private readonly List<IStat> _stats;
        private string _name;

        public Character()
        {
            this._stats = new List<IStat>();
            this._name = string.Empty;
        }

        public void AddStatToCharacter(IStat stat)
        {
            this._stats.Add(stat);
        }

        public void NameCharacter(string name)
        {
            this._name = name;
        }

        public IStat GetStatBasedOnName(string name)
        {
            throw new NotImplementedException();
        }
    }
}