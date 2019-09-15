using AcquireLibrary.Model;
using System.Windows.Forms;
using AcquireLibrary;
using System;

namespace Acquire.Controls
{
    [Serializable]
    public partial class TileControl : UserControl
    {
        public TileControl()
        {
            InitializeComponent();
        }

        public TileEnum Tile
        {
            get
            {
                return (TileEnum)Tag;
            }
            set
            {
                lblTile.Text = value.ToString().ToTile();
                Tag = value;
            }
        }

        private HotelEnum _hotel;

        private System.Drawing.Color _backColor;
        private System.Drawing.Color _foreColor;
        public HotelEnum Hotel
        {
            get
            {
                return _hotel;
            }
            set
            {
                _hotel = value;
                var hotel = new Hotel();
                hotel.Property = value;

                _backColor = hotel.HotelColor;
                _foreColor = hotel.HotelFontColor;
                SetStyle();
            }
        }

        private bool _permanent;
        public bool Permanent { get { return _permanent;  } set
            {
                _permanent = value;
            }
        }

        private bool _lastTilePlayed;
        internal void SetLastTilePlayed(bool v)
        {
            _lastTilePlayed = v;
        }

        private void SetStyle()
        {
            BackColor = _backColor;
            lblTile.ForeColor = _foreColor;
            lblTile.Font = new System.Drawing.Font(lblTile.Font.FontFamily, 12);
            if (_lastTilePlayed)
            {
                lblTile.ForeColor = _hotel == HotelEnum.Luxor ? System.Drawing.Color.White : System.Drawing.Color.Red;
                lblTile.Font = new System.Drawing.Font(lblTile.Font.FontFamily, 12, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            }
            if (_permanent)
                BackColor = System.Drawing.Color.Black;
        }
    }
}
