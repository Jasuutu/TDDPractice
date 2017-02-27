namespace ConsoleGame.Interfaces
{
    public interface ICharacter
    {
        void AddStatToCharacter(IStat stat);
        void NameCharacter(string name);
        IStat GetStatBasedOnName(string name);
    }
}