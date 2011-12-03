using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{

    public class Concert
    {
        public string name;
        public string date;
        public string time;
        public string otherInfos;

        public List<Seat> seatPurchased;
        public int numberSeatPurchased = 0;
        public int numberAdultSeat = 0;
        public int numberStudentSeat = 0;
        public int numberUofCSeat = 0;


        //Constructor
        public Concert(string name)
        {
            this.name = name;
            seatPurchased = new List<Seat>();
        }

        public void addAPurchasedSeat(SeatType seatType, System.Windows.Forms.CheckBox checkBox)
        {
            seatPurchased.Add(new Seat(seatType,checkBox));
            numberSeatPurchased += 1;
            if (seatType == SeatType.Adult)
            {
                numberAdultSeat += 1;
            }
            else if (seatType == SeatType.StudentSenior)
            {
                numberStudentSeat += 1;
            }
            else
            {
                numberUofCSeat += 1;
            }         
        }
 
    }
    
}
