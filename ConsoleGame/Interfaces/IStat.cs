namespace ConsoleGame.Interfaces
{
    public interface IStat
    {
        void SetName(string name);
        string GetName();
        void ChangeStatValue(int value);
        int GetValue();
    }
}