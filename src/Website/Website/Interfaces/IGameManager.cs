using Website.Models.Input;

namespace Website.Interfaces
{
    public interface IGameManager
    {
        bool CreateNewGame(NewGameModel model);
    }
}
