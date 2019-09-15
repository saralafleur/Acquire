
using System;

namespace AcquireLibrary.Model
{
    public class Tile
    {
        public Tile()
        {
            Hotel = HotelEnum.NotUsed;
        }
        public TileEnum Index { get; set; }
        public HotelEnum Hotel { get; set; }

        internal Tile DeepCopy()
        {
            return new Tile()
            {
                Index = this.Index,
                Hotel = this.Hotel
            };
        }
    }
}
