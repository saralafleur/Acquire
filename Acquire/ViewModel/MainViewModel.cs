using System;
using AcquireLibrary.Model;
using AcquireLibrary.Controller;
using AcquireLibrary.IViewModel;

namespace Acquire.ViewModel
{
    public class MainViewModel : IMainViewModel
    {
        public MainViewModel()
        {
            Controller = new GameControler();
            Controller.ViewModel = this;
        }

        public MainView View { get; set; }
        public GameControler Controller { get; set; }
        internal void StartGame(StartGameArgs args)
        {
            Controller.StartGame(args);
        }

        public void UpdatePlayers(Game model)
        {
            View.UpdatePlayers(model);
        }

        public void StartGame(Game model)
        {
            View.StartGame(model);
        }

        internal void PlaceTile(TileEnum tile)
        {
            Controller.PlaceTile(tile);
        }

        public void UpdateBoard(Game model)
        {
            View.UpdateBoard(model);
        }

        internal void Undo()
        {
            Controller.Undo();
        }
    }
}
