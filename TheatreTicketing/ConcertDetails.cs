using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{
    enum ConcertSeries { Celebration, Discovery, Jazz, Organ, StringQuartet };
    enum Concert
    {
        BlackbirdSings, HyphenatedLizst, SchubertWinterreise, LiteraryLiszt, OldVsNew,
        ContemporaryCanada, HistoireDuTango, PersianZeal,
        TommyBanks, BillEvans, MariaSchneider, ChrisAndrew, Verismo, GoodmanMahQuartet,
        GermanySeduced, FrenchSymphonic, LivreDOrgue,
        BrahmsI, BrahmsII, BrahmsIII
    };
    enum SeatType { Empty, Adult, StudentSenior, UofCStudent };

    class ConcertDetails
    {
        ConcertSeries seriesName;
        Concert concertName;
        List<Seats> seatingChart;

        class Seats
        {
            string seatCode;
            SeatType seatTypeValue;
            bool seatPurchased;
        }
    }
}
