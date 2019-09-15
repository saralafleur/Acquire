using System.Collections.Generic;

namespace AcquireLibrary.Model
{
    public class Player
    {
        public Player()
        {
            TileBag = new List<TileEnum>();
        }

        public int Index { get; set; }
        public string Name { get; set; }
        public List<TileEnum> TileBag { get; set; }

        internal void Prepare(TileBag tileBag)
        {
            TileBag.Clear();
            for (int i = 0; i < 6; i++)
            {
                var tile = tileBag.Take().Value;
                TileBag.Add(tile);
            }
        }

        internal Player DeepCopy()
        {
            var temp = new Player()
            {
                Index = this.Index,
                Name = this.Name,
            };

            temp.TileBag.Clear();
            foreach (var item in TileBag)
            {
                temp.TileBag.Add(item);
            }

            return temp;
        }
    }
}
