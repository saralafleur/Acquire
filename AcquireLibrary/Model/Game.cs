using System;
using System.Collections.Generic;

namespace AcquireLibrary.Model
{
    public class Game
    {
        public Game()
        {
            TileBag = new TileBag();
            Players = new List<Player>();
            Board = new List<Tile>();
            Hotels = new List<Hotel>();
            for (int i = 0; i < 6; i++)
            {
                Players.Add(new Player() { Index = i });
            }
            Reset();
            for (int i = 0; i < Defaults.HotelCount; i++)
            {
                Hotels.Add(new Hotel() { Property = (HotelEnum)i });
            }
        }
        public void Reset()
        {
            for (int i = 0; i < Defaults.TileCount; i++)
            {
                Board.Add(new Tile() { Index = (TileEnum)i });
            }
        }
        public List<Hotel> Hotels { get; set; }
        public List<Tile> Board { get; set; }
        public TileBag TileBag { get; set; }
        public List<Player> Players { get; set; }

        public int NumberOfPlayers { get; set; }
        public int ActivePlayer { get; internal set; }
        public TileEnum LastTilePlaced { get; internal set; }

        internal Game DeepCopy()
        {
            Game copy = new Game();
            copy.NumberOfPlayers = NumberOfPlayers;
            copy.ActivePlayer = ActivePlayer;
            copy.LastTilePlaced = LastTilePlaced;
            copy.TileBag = TileBag.DeepCopy();
            copy.Players.Clear();
            foreach (var item in Players)
            {
                copy.Players.Add(item.DeepCopy());
            }
            copy.Board.Clear();
            foreach (var item in Board)
            {
                copy.Board.Add(item.DeepCopy());
            }
            copy.Hotels.Clear();
            foreach (var item in Hotels)
            {
                copy.Hotels.Add(item.DeepCopy());
            }

            return copy;
        }
    }
}
