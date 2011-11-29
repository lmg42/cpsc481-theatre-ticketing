using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheatreTicketing
{
    public enum SeriesName { NowShowing, Celebration, Discovery, Jazz, Organ, StringQuartet };

    public class Serie
    {
        public SeriesName seriesName;
        public Concert[] concerts;

        public void Populate(int i)
        {
            switch (i)
            {
                case 0:
                    seriesName = SeriesName.NowShowing;
                    string nextConcert = NextConcert();
                    concerts = new Concert[] { new Concert(nextConcert) };
                    break;
                case 1:
                    seriesName = SeriesName.Celebration;
                    concerts = new Concert[] { new Concert("The Blackbird Sings: Music for Flute and Piano "), new Concert("The Hyphenated Liszt ")
                        , new Concert("Schubert's Winterreise "), new Concert("The Literary Liszt "), new Concert("Old vs New ") };
                    break;
                case 2:
                    seriesName = SeriesName.Discovery;
                    concerts = new Concert[] { new Concert("Contemporary Canada "), new Concert("Histoire du Tango "), 
                        new Concert("Persian Zeal ") };
                    break;
                case 3:
                    seriesName = SeriesName.Celebration;
                    concerts = new Concert[] { new Concert("Tommy Banks Quartet "), new Concert("Bill Evans Tribute "), new Concert("Maria Schneider "),
                        new Concert("Chris Andrew Quintet "), new Concert("Verismo with Chris Tarry "), new Concert("Alex Goodman/Brent Mah Quartet ") };
                    break;
                case 4:
                    seriesName = SeriesName.Organ;
                    concerts = new Concert[] { new Concert("Romance: Germany Seduced by the South "), new Concert("French Symphonic Music of the 20th and 21st Centuries "), new Concert("Livre d'orgue de Montreal ") };
                    break;
                case 5:
                    seriesName = SeriesName.StringQuartet;
                    concerts = new Concert[] { new Concert("A Celebration of Brahms I "), new Concert("A Celebration of Brahms II "), new Concert("A Celebration of Brahms III ") };;
                    break;
                default:
                    break;
            }
        }

        public static string NextConcert()
        {
            //TODO find the next concert
            return "The Hyphenated Liszt ";
        }

        public Concert findAConcert(string name)
        {
            for (int i=0; i < this.concerts.Length; i++)
            {
                if (concerts[i].name == name)
                {
                    return concerts[i];
                }
            }
            return null;
        }

    }
}
