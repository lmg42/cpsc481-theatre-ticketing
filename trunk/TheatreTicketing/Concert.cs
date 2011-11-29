using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{
    enum ConcertName
    {
        BlackbirdSings, HyphenatedLizst, SchubertWinterreise, LiteraryLiszt, OldVsNew,
        ContemporaryCanada, HistoireDuTango, PersianZeal,
        TommyBanks, BillEvans, MariaSchneider, ChrisAndrew, Verismo, GoodmanMahQuartet,
        GermanySeduced, FrenchSymphonic, LivreDOrgue,
        BrahmsI, BrahmsII, BrahmsIII
    };

    class Concert
    {
        public ConcertName name;
        public List<Seat> seatPurchased;
        public int numberOfSeatPurchased = 0;

        //Constructor
        public Concert(ConcertName name)
        {
            this.name = name;
            seatPurchased = new List<Seat>();
        }

        public void addAPurchasedSeat(SeatType seatType, System.Windows.Forms.CheckBox checkBox)
        {
            seatPurchased.Add(new Seat(seatType,checkBox);
            numberOfSeatPurchased += 1;
        }
 
    }
    
}
