using ConsoleGame.Interfaces;

namespace ConsoleGame
{
    public class Stat : IStat
    {
        #region Properties

        private string _name;
        private int _value;
        #endregion

        public Stat(string name)
        {
            this._name = name;
            this._value = 0;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public int GetValue()
        {
            return this._value;
        }

        public void ChangeStatValue(int value)
        {
            this._value += value;
        }
    }
}