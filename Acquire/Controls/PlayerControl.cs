using AcquireLibrary.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Acquire.ViewModel;
using AcquireLibrary;

namespace Acquire.Controls
{
    public partial class PlayerControl : UserControl
    {
        const string ShowConst = "[+]";
        const string HideConst = "[-]";

        public PlayerControl()
        {
            InitializeComponent();

            TileButtons = new List<Button>();

            TileButtons.Add(btnTile1);
            TileButtons.Add(btnTile2);
            TileButtons.Add(btnTile3);
            TileButtons.Add(btnTile4);
            TileButtons.Add(btnTile5);
            TileButtons.Add(btnTile6);

            // Temp for debugging = Travis
            btnShowHide.Text = HideConst;
            pnlOptions.Visible = true;


        }

        private List<Button> TileButtons { get; set; }

        public MainViewModel ViewModel;

        public string PlayerName { get
            {
                return lblPlayerName.Text;
            }
            set
            {
                lblPlayerName.Text = value;
            }
        }
        private bool _active;
        public bool Active { get
            {
                return _active;
            }
            set
            {
                _active = value;
                foreach (var item in TileButtons)
                {
                    item.Enabled = _active;
                }
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (btnShowHide.Text == ShowConst)
            {
                btnShowHide.Text = HideConst;
                pnlOptions.Visible = true;
            }
            else
            {
                btnShowHide.Text = ShowConst;
                pnlOptions.Visible = false;
            }
        }

        internal void Reset()
        {
            lblMoney.Text = Defaults.StartingMoney.ToString();
            btnAmerican.Text = "A0";
            btnTower.Text = "T0";
            btnLuxor.Text = "L0";
            btnWorldWide.Text = "W0";
            btnFestival.Text = "F0";
            btnImperial.Text = "I0";
            btnContential.Text = "C0";
        }

        internal void SetFocus()
        {
            btnTile1.Focus();
        }

        internal void UpdateTiles(List<TileEnum> tileBag)
        {
            foreach (var item in TileButtons)
            {
                item.Visible = false;
            }

            for (int i = 0; i < tileBag.Count; i++)
            {
                TileButtons[i].Visible = true;
                TileButtons[i].Text = tileBag[i].ToString().ToTile();
                TileButtons[i].Tag = tileBag[i];
            }    
        }

        private void PlaceTile(object sender, EventArgs e)
        {
            ViewModel.PlaceTile((TileEnum)((Button)sender).Tag);
        }
    }
}
