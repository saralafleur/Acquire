using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.Model
{
    public enum HotelEnum
    {
        Tower,
        Luxor,
        American,
        WorldWide,
        Festival,
        Imperial,
        Continental
    }
    public enum HotelColor
    {
        Yellow,
        Red,
        HotTrack,
        Brown,
        Green,
        Pink,
        Aqua
    }
    public class Hotel
    {
        public HotelEnum Property { get; set; }
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
                    Property == HotelEnum.Continental)
                    return Color.Black;
                return Color.White;
            }
        }
    }
}
