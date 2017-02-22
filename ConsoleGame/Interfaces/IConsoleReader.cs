using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public interface IConsoleReader : IDisposable
    {
        string ParseText(string input);
        void AddKeyword(IKeyword keyword);
        void RemoveKeyword(IKeyword keyword);
        List<IKeyword> GetKeywords();
        List<string> CheckString(string input);
    }
}
