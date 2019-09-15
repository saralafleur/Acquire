using AcquireLibrary.Model;
using System;
using System.Windows.Forms;

namespace Acquire.View
{
    public partial class StartGameView : Form
    {
        public StartGameView()
        {
            InitializeComponent();
            btnStart.Focus();
        }

        public StartGameArgs Args { get
            {
                return new StartGameArgs
                {
                    NumberOfPlayers = cbNumberOfPlayers.SelectedIndex + 1,
                    Player1 = tbPlayer1.Text,
                    Player2 = tbPlayer2.Text,
                    Player3 = tbPlayer3.Text,
                    Player4 = tbPlayer4.Text,
                    Player5 = tbPlayer5.Text,
                    Player6 = tbPlayer6.Text
                };
            }
        }

        private void cbNumberOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var n = cbNumberOfPlayers.SelectedIndex;
            lblPlayer6.Visible = n == 5;
            tbPlayer6.Visible = n == 5;
            lblPlayer5.Visible = n >= 4;
            tbPlayer5.Visible = n >= 4;
            lblPlayer4.Visible = n >= 3;
            tbPlayer4.Visible = n >= 3;
            lblPlayer3.Visible = n >= 2;
            tbPlayer3.Visible = n >= 2;
            lblPlayer2.Visible = n >= 1;
            tbPlayer2.Visible = n >= 1;
        }

        private void StartGameView_Load(object sender, EventArgs e)
        {
            // Default to 2 Players
            cbNumberOfPlayers.SelectedIndex = 1;
        }
    }
}
