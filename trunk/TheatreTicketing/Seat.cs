using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{

    enum SeatType { Empty, Adult, StudentSenior, UofCStudent };

    class Seat
    {
        public SeatType seatType;
        public System.Windows.Forms.CheckBox checkBox;

        //Constructor
        public Seat(SeatType type, System.Windows.Forms.CheckBox checkBox) {
            this.seatType = type;
            this.checkBox = checkBox;
        }
    }
}
