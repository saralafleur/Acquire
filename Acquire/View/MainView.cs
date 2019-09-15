using Acquire.View;
using Acquire.ViewModel;
using System;
using System.Windows.Forms;
using AcquireLibrary.Model;
using System.Collections.Generic;
using Acquire.Controls;

namespace Acquire
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();
            ViewModel.View = this;

            Players = new List<PlayerControl>();

            Players.Add(Player1);
            Players.Add(Player2);
            Players.Add(Player3);
            Players.Add(Player4);
            Players.Add(Player5);
            Players.Add(Player6);

            foreach (var item in Players)
            {
                item.ViewModel = ViewModel;
            }
        }

        public MainViewModel ViewModel { get; set; }

        internal void StartGame(Game model)
        {
        }

        internal void UpdateBoard(Game model)
        {
            board1.Update(model);
            undoToolStripMenuItem.Enabled = ViewModel.Controller.UndoGame.Count > 0;
            undoToolStripMenuItem.Text = string.Format("Undo ({0})", ViewModel.Controller.UndoGame.Count);
        }

        public List<PlayerControl> Players { get; set; }

        private void starrtGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = new StartGameView();

            if (view.ShowDialog() == DialogResult.OK)
            {
                // Start Game
                ViewModel.StartGame(view.Args);
            }
        }

        internal void UpdatePlayers(Game model)
        {
            foreach (var item in Players)
            {
                item.Reset();
            }
            for (int i = 0; i < 6; i++)
            {
                Players[i].PlayerName = model.Players[i].Name;
            }

            for (int i = 0; i < model.NumberOfPlayers; i++)
            {
                Players[i].Visible = true;
                Players[i].UpdateTiles(model.Players[i].TileBag);
                Players[i].Active = model.ActivePlayer == i;
            }

            Players[model.ActivePlayer].SetFocus();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.Undo();
        }
    }
}
