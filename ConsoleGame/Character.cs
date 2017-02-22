using System;
using System.Collections.Generic;
using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public class Character : ICharacter
    {
        private List<IStat> _stats;
        private string _name;

        public void AddStatToCharacter(IStat stat)
        {
            if (this._stats == null)
            {
                this._stats = new List<IStat>();
            }
            this._stats.Add(stat);
        }

        public void NameCharacter(string name)
        {
            this._name = name;
        }
    }
}