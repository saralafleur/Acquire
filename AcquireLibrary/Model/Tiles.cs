using System;
using System.Collections.Generic;

namespace AcquireLibrary.Model
{
    public enum TileEnum
    {
        _1A,
        _1B,
        _1C,
        _1D,
        _1E,
        _1F,
        _1G,
        _1H,
        _1I,
        _2A,
        _2B,
        _2C,
        _2D,
        _2E,
        _2F,
        _2G,
        _2H,
        _2I,
        _3A,
        _3B,
        _3C,
        _3D,
        _3E,
        _3F,
        _3G,
        _3H,
        _3I,
        _4A,
        _4B,
        _4C,
        _4D,
        _4E,
        _4F,
        _4G,
        _4H,
        _4I,
        _5A,
        _5B,
        _5C,
        _5D,
        _5E,
        _5F,
        _5G,
        _5H,
        _5I,
        _6A,
        _6B,
        _6C,
        _6D,
        _6E,
        _6F,
        _6G,
        _6H,
        _6I,
        _7A,
        _7B,
        _7C,
        _7D,
        _7E,
        _7F,
        _7G,
        _7H,
        _7I,
        _8A,
        _8B,
        _8C,
        _8D,
        _8E,
        _8F,
        _8G,
        _8H,
        _8I,
        _9A,
        _9B,
        _9C,
        _9D,
        _9E,
        _9F,
        _9G,
        _9H,
        _9I,
        _10A,
        _10B,
        _10C,
        _10D,
        _10E,
        _10F,
        _10G,
        _10H,
        _10I,
        _11A,
        _11B,
        _11C,
        _11D,
        _11E,
        _11F,
        _11G,
        _11H,
        _11I,
        _12A,
        _12B,
        _12C,
        _12D,
        _12E,
        _12F,
        _12G,
        _12H,
        _12I
    }
    public class TileBag
    {
        public TileBag()
        {
            Tiles = new List<TileEnum>();
            Reset();
        }

        public void Reset()
        {
            Tiles.Clear();

            for (int i = 0; i < Defaults.TileCount; i++)
            {
                Tiles.Add((TileEnum)i);
            }

            // Shuffle the TileBag
            Tiles.Shuffle();
        }

        /// <summary>
        /// Removes a Tile from the TileBag and returns it
        /// </summary>
        public TileEnum? Take()
        {
            if (Tiles.Count == 0)
                return null;
            var result = Tiles[Tiles.Count-1];
            Tiles.Remove(result);
            return result;
        }

        public void Remove(TileEnum tile)
        {
            Tiles.Remove(tile);
        }

        internal TileBag DeepCopy()
        {
            var result = new TileBag();
            result.Tiles.Clear();
            foreach (var item in Tiles)
            {
                result.Tiles.Add(item);
            }
            return result;
        }

        public List<TileEnum> Tiles { get; set; }
    }
}
