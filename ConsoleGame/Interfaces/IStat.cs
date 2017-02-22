namespace ConsoleGame.Interfaces
{
    public interface IStat
    {
        void SetName(string name);
        string GetName();
        void SetValue(int value);
        int GetValue();
    }
}