using System.Collections.Generic;
using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public class StatManager : IStatManager
    {
        List<IStat> _stats;

        public StatManager()
        {
            this._stats = new List<IStat>();
        }
        public void AddStat(IStat stat)
        {
            this._stats.Add(stat);
        }
    }
}