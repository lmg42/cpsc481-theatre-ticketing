using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{
    enum ConcertSeries { NowShowing, Celebration, Discovery, Jazz, Organ, StringQuartet };
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
        Concert[] concertName;
        List<Seats> seatingChart;
        bool ticketsSelected;

        public void Populate(int i)
        {
            switch (i)
            {
                case 0:
                    seriesName = ConcertSeries.NowShowing;
                    Concert nextConcert = NextConcert();
                    concertName = new Concert[] { nextConcert };
                    ticketsSelected = false;
                    break;
                case 1:
                    seriesName = ConcertSeries.Celebration;
                    concertName = new Concert[] { Concert.BlackbirdSings, Concert.HyphenatedLizst, Concert.SchubertWinterreise, Concert.LiteraryLiszt, Concert.OldVsNew };
                    ticketsSelected = false;
                    break;
                case 2:
                    seriesName = ConcertSeries.Discovery;
                    concertName = new Concert[] { Concert.ContemporaryCanada, Concert.HistoireDuTango, Concert.PersianZeal };
                    ticketsSelected = false;
                    break;
                case 3:
                    seriesName = ConcertSeries.Celebration;
                    concertName = new Concert[] { Concert.TommyBanks, Concert.BillEvans, Concert.MariaSchneider, Concert.ChrisAndrew, Concert.Verismo, Concert.GoodmanMahQuartet };
                    ticketsSelected = false;
                    break;
                case 4:
                    seriesName = ConcertSeries.Organ;
                    concertName = new Concert[] { Concert.GermanySeduced, Concert.FrenchSymphonic, Concert.LivreDOrgue };
                    ticketsSelected = false;
                    break;
                case 5:
                    seriesName = ConcertSeries.StringQuartet;
                    concertName = new Concert[] { Concert.BrahmsI, Concert.BrahmsII, Concert.BrahmsIII };
                    ticketsSelected = false;
                    break;
                default:
                    break;
            }
        }

        public Concert NextConcert()
        {
            //TODO find the next concert
            return Concert.HyphenatedLizst;
        }

        class Seats
        {
            string seatCode;
            SeatType seatType;
            bool seatPurchased;
        }
    }
}
