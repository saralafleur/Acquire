using System.Drawing;

namespace AcquireLibrary.Model
{
    public enum HotelEnum
    {
        Tower,
        Luxor,
        American,
        WorldWide,
        Festival,
        Imperial,
        Continental,
        NotUsed,
        Used,
        NotPlayable
    }
    public enum HotelColor
    {
        Yellow,
        Red,
        HotTrack,
        Brown,
        Green,
        Pink,
        Aqua,
        WhiteSmoke,
        DarkGray,
        MediumOrchid
    }
    public class Hotel
    {
        public bool Active { get; set; }
        public HotelEnum Property { get; set; }
        public int TileCount { get; set; }
        public bool Permanent {  get { return TileCount >= Defaults.PermanentCount; } }
        public Color HotelColor
        {
            get
            {
                return Color.FromName(((HotelColor)Property).ToString());
            }
        }
        public string HotelName
        {
            get
            {
                return Property.ToString();
            }
        }
        public string ShortName
        {
            get
            {
                return Property.ToString()[0].ToString();
            }
        }
        public Color HotelFontColor
        {
            get
            {
                if (Property == HotelEnum.Tower ||
                    Property == HotelEnum.Imperial ||
                    Property == HotelEnum.Continental ||
                    Property == HotelEnum.NotUsed ||
                    Property == HotelEnum.Used)
                    return Color.Black;
                return Color.White;
            }
        }

        internal Hotel DeepCopy()
        {
            return new Hotel()
            {
                Active = this.Active,
                Property = this.Property
            };
        }
    }
}
