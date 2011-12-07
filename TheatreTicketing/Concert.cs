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
        public System.Drawing.Bitmap image;

        public List<Seat> seatPurchased;
        public int numberSeatPurchased = 0;
        public int numberAdultSeat = 0;
        public int numberStudentSeat = 0;
        public int numberUofCSeat = 0;

        public int numberSeatReserved = 0;
        public int numberAdultSeatReserved = 0;
        public int numberStudentSeatReserved = 0;
        public int numberUofCSeatReserved = 0;
        public List<Seat> seatReserved;


        //Constructor
        public Concert(string name, string date, string time, string otherInfos, System.Drawing.Bitmap image)
        {
            this.name = name;
            this.date = date;
            this.time = time;
            this.otherInfos = otherInfos;
            this.image = image;

            seatPurchased = new List<Seat>();
            seatReserved = new List<Seat>();
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

        public void updateReservedSeats(int adult, int student, int uOfC)
        {
            //seatReserved = null;

            numberAdultSeatReserved = adult;
            numberStudentSeatReserved = student;
            numberUofCSeatReserved = uOfC;
        }

        public bool reservedSeatsExist()
        {
            return ((numberAdultSeatReserved+numberStudentSeatReserved+numberUofCSeatReserved == 0) ? false : true);
        }
 
    }
    
}
