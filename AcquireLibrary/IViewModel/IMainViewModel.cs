using AcquireLibrary.Model;

namespace AcquireLibrary.IViewModel
{
    public interface IMainViewModel
    {
        void UpdatePlayers(Game model);
        void StartGame(Game model);
        void UpdateBoard(Game model);
    }
}
