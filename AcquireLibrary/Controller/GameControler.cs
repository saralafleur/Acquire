using AcquireLibrary.IViewModel;
using AcquireLibrary.Model;
using System;
using System.Collections.Generic;

namespace AcquireLibrary.Controller
{
    public class GameControler
    {
        public GameControler()
        {
            Model = new Game();
            UndoGame = new List<Game>();
        }

        public Game Model { get; set; }
        public List<Game> UndoGame { get; set; }
        public IMainViewModel ViewModel { get; set; }

        public void StartGame(StartGameArgs args)
        {
            UndoGame.Clear();
            Model.NumberOfPlayers = args.NumberOfPlayers;
            Model.Players[0].Name = args.Player1;
            Model.Players[1].Name = args.Player2;
            Model.Players[2].Name = args.Player3;
            Model.Players[3].Name = args.Player4;
            Model.Players[4].Name = args.Player5;
            Model.Players[5].Name = args.Player6;

            Model.TileBag.Reset();

            // Reset Hotels
            foreach (var item in Model.Hotels)
            {
                item.Active = false;
            }

            // Reset the Board
            foreach (var item in Model.Board)
            {
                item.Hotel = HotelEnum.NotUsed;
            }

            for (int i = 0; i < args.NumberOfPlayers; i++)
            {
                Model.Players[i].Prepare(Model.TileBag);
            }

            Model.ActivePlayer = 0;

            ViewModel.UpdateBoard(Model);
            ViewModel.UpdatePlayers(Model);

            ViewModel.StartGame(Model);
        }

        public void Undo()
        {
            if (UndoGame.Count > 0)
            {
                var temp = UndoGame[UndoGame.Count - 1];
                UndoGame.Remove(temp);
                Model = temp;

                ViewModel.UpdateBoard(Model);
                ViewModel.UpdatePlayers(Model);
            }
        }

        public void PlaceTile(TileEnum tile)
        {
            UndoGame.Add(Model.DeepCopy());

            var item = Model.Board[(int)tile];
            if (item.Hotel != HotelEnum.NotUsed)
                throw new Exception("Tile has already been placed!");

            item.Hotel = HotelEnum.Used;

            // Remove Tile from Player
            Model.Players[Model.ActivePlayer].TileBag.Remove(tile);

            // Get a New Tile
            PlayerGetNextTile(Model.Players[Model.ActivePlayer]);

            var adjacentTiles = GetAdjacent(tile);
            if (adjacentTiles.Count > 0)
            {
                var Hotel = HotelEnum.NotUsed;
                // Look for a Hotel
                foreach (var test in adjacentTiles)
                {
                    if (Model.Board[(int)test].Hotel.IsHotel())
                    {
                        Hotel = Model.Board[(int)test].Hotel;
                        // If we find a hotel then break out of our search and use the Hotel found
                        break;
                    }
                    if (Model.Board[(int)test].Hotel == HotelEnum.Used)
                        Hotel = HotelEnum.Used;
                }

                if (!Hotel.IsHotel()) Hotel = GetNextHotel();
                if (Hotel.IsHotel())
                {
                    item.Hotel = Hotel;
                    ExpandTiles(adjacentTiles, Hotel);
                }
            }

            // Move to Next Player
            NextPlayer();

            Model.LastTilePlaced = (TileEnum)item.Index;

            ViewModel.UpdateBoard(Model);
            ViewModel.UpdatePlayers(Model);
        }

        private void NextPlayer()
        {
            for (int i = 0; i < Model.NumberOfPlayers; i++)
            {
                Model.ActivePlayer++;
                if (Model.ActivePlayer > Model.NumberOfPlayers - 1)
                    Model.ActivePlayer = 0;
                // If the Player has Tiles then stop, if not go to the next player
                if (Model.Players[Model.ActivePlayer].TileBag.Count > 0)
                    break;
            }
        }

        private void SetHotel(TileEnum tile, HotelEnum hotel)
        {
            if (hotel.IsHotel())
            {
                // If the Tile was already a Hotel then decrement that Hotel
                if (Model.Board[(int)tile].Hotel.IsHotel())
                    Model.Hotels[(int)Model.Board[(int)tile].Hotel].TileCount--;

                Model.Hotels[(int)hotel].TileCount++;
            }

            Model.Board[(int)tile].Hotel = hotel;
        }

        private void ExpandTiles(List<TileEnum> tiles, HotelEnum hotel)
        {
            List<TileEnum> changed = new List<TileEnum>();
            foreach (var i in tiles)
            {
                if (Model.Board[(int)i].Hotel == HotelEnum.Used)
                {
                    SetHotel(i, hotel);
                    changed.Add(Model.Board[(int)i].Index);
                }
            }

            CheckForNonPlayable();

            foreach (var item in changed)
            {
                var adjacentTiles = GetAdjacent(item);
                ExpandTiles(adjacentTiles, hotel);
            }
            
        }

        private void PlayerGetNextTile(Player player)
        {
            var newTile = Model.TileBag.Take();
            if (newTile != null)
                player.TileBag.Add(newTile.Value);
        }

        private void CheckForNonPlayable()
        {
            foreach (var item in Model.Board)
            {
                if (item.Hotel == HotelEnum.NotUsed)
                {
                    var adjacentTiles = GetAdjacent(item.Index);

                    if (adjacentTiles.Count >= 2)
                    {
                        List<HotelEnum> found = new List<HotelEnum>();
                        foreach (TileEnum item2 in adjacentTiles)
                        {
                            var adjTile = Model.Board[(int)item2];
                            // Check if this is a hotel
                            if (adjTile.Hotel.IsHotel())
                            {
                                if (!found.Contains(adjTile.Hotel))
                                    found.Add(adjTile.Hotel);
                            }
                        }
                        if (found.Count >= 2)
                        {
                            item.Hotel = HotelEnum.NotPlayable;
                            Model.TileBag.Remove(item.Index);
                            for (int i = 0; i < Model.NumberOfPlayers; i++)
                            {
                                var player = Model.Players[i];
                                player.TileBag.Remove(item.Index);
                                if (player.TileBag.Count != 6)
                                    PlayerGetNextTile(player);
                            }
                        }
                    }
                }
            }
        }

        private HotelEnum GetNextHotel()
        {
            foreach (var item in Model.Hotels)
            {
                if (!item.Active)
                {
                    item.Active = true;
                    return item.Property;
                }
            }
            return HotelEnum.Used;
        }

        private List<TileEnum> GetAdjacent(TileEnum tile)
        {
            var result = new List<TileEnum>();

            int number = tile.ToTileNumber();
            char character = tile.ToTileChar();

            // LEFT
            if (number != 1)
            {
                var newNumber = number - 1;
                var target = Model.Board[(int)GetTile(newNumber, character)];
                if (target.Hotel != HotelEnum.NotUsed)
                {
                    result.Add(target.Index);
                }
            }
            // RIGHT
            if (number != 12)
            {
                var newNumber = number + 1;
                var target = Model.Board[(int)GetTile(newNumber, character)];
                if (target.Hotel != HotelEnum.NotUsed)
                {
                    result.Add(target.Index);
                }
            }
            // UP
            if (character != 'A')
            {
                var newCharacter = character;
                newCharacter--;
                var target = Model.Board[(int)GetTile(number, newCharacter)];
                if (target.Hotel != HotelEnum.NotUsed)
                {
                    result.Add(target.Index);
                }
            }
            // DOWN
            if (character != 'I')
            {
                var newCharacter = character;
                newCharacter++;
                var target = Model.Board[(int)GetTile(number, newCharacter)];
                if (target.Hotel != HotelEnum.NotUsed)
                {
                    result.Add(target.Index);
                }
            }

            return result;
        }
        private TileEnum GetTile(int number, char character)
        {
            var value = string.Format("_{0}{1}", number, character);
            for (int i = 0; i < Defaults.TileCount; i++)
            {
                if (value == ((TileEnum)i).ToString())
                {
                    return (TileEnum)i;
                }
            }
            throw new Exception(string.Format("{0}{1} is not a valid Tile!", number, character));
        }
    }
}
