using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{
    enum SeriesName { NowShowing, Celebration, Discovery, Jazz, Organ, StringQuartet };

    class Serie
    {
        public SeriesName seriesName;
        public Concert[] concerts;

        public void Populate(int i)
        {
            switch (i)
            {
                case 0:
                    seriesName = SeriesName.NowShowing;
                    ConcertName nextConcert = NextConcert();
                    concerts = new Concert[] { new Concert(nextConcert) };
                    break;
                case 1:
                    seriesName = SeriesName.Celebration;
                    concerts = new Concert[] { new Concert(ConcertName.BlackbirdSings), new Concert(ConcertName.HyphenatedLizst)
                        , new Concert(ConcertName.SchubertWinterreise), new Concert(ConcertName.LiteraryLiszt), new Concert(ConcertName.OldVsNew) };
                    break;
                case 2:
                    seriesName = SeriesName.Discovery;
                    concerts = new Concert[] { new Concert(ConcertName.ContemporaryCanada), new Concert(ConcertName.HistoireDuTango), 
                        new Concert(ConcertName.PersianZeal) };
                    break;
                case 3:
                    seriesName = SeriesName.Celebration;
                    concerts = new Concert[] { new Concert(ConcertName.TommyBanks), new Concert(ConcertName.BillEvans), new Concert(ConcertName.MariaSchneider),
                        new Concert(ConcertName.ChrisAndrew), new Concert(ConcertName.Verismo), new Concert(ConcertName.GoodmanMahQuartet) };
                    break;
                case 4:
                    seriesName = SeriesName.Organ;
                    concerts = new Concert[] { new Concert(ConcertName.GermanySeduced), new Concert(ConcertName.FrenchSymphonic), new Concert(ConcertName.LivreDOrgue) };
                    break;
                case 5:
                    seriesName = SeriesName.StringQuartet;
                    concerts = new Concert[] { new Concert(ConcertName.BrahmsI), new Concert(ConcertName.BrahmsII), new Concert(ConcertName.BrahmsIII) };;
                    break;
                default:
                    break;
            }
        }

        public ConcertName NextConcert()
        {
            //TODO find the next concert
            return ConcertName.HyphenatedLizst;
        }

    }
}
