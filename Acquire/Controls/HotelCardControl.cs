using System.Windows.Forms;
using AcquireLibrary.Model;

namespace Acquire.Controls
{
    public partial class HotelCardControl : UserControl
    {
        public HotelCardControl()
        {
            InitializeComponent();
        }

        private HotelEnum _hotelName;

        public HotelEnum HotelName
        {
            get
            {
                return _hotelName;
            }
            set
            {
                _hotelName = value;
                var hotel = new Hotel();
                hotel.Property = value;

                BackColor = hotel.HotelColor;
                lblHotelName.Text = hotel.HotelName;
                lblHotelName.ForeColor = hotel.HotelFontColor;
                lblHotelCount.ForeColor = hotel.HotelFontColor;
            }
        }
    }
}
