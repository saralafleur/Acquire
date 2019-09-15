using System.Windows.Forms;
using AcquireLibrary.Model;
using System.Collections.Generic;
using Acquire.Controls;
using AcquireLibrary;

namespace Acquire
{
    public partial class Board : UserControl
    {
        public Board()
        {
            InitializeComponent();

            BoardTiles = new List<TileControl>();

            for (int i = 0; i < Defaults.TileCount; i++)
            {
                var item = FindTile((TileEnum)i);

                if (item == null)
                    throw new System.Exception("Unable to find Tile!");

                BoardTiles.Add(item);
            }

        }

        public TileControl FindTile(TileEnum tile)
        {
            foreach (TileControl item in Controls)
            {
                if (item == null) continue;
                if (item.Tile == tile)
                {
                    return item;
                }
            }

            return null;
        }

        protected List<TileControl> BoardTiles { get; set; }

        public void Update(Game model)
        {
            foreach (var item in model.Board)
            {
                TileControl tile = FindTile(item.Index);
                tile.Permanent = item.Hotel.IsHotel() ? model.Hotels[(int)item.Hotel].Permanent : false; 
                tile.Hotel = item.Hotel;
                tile.SetLastTilePlayed(item.Index == model.LastTilePlaced);
            }
        }

        private void Board_Load(object sender, System.EventArgs e)
        {

        }
    }
}
