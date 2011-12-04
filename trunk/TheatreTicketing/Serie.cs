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
                    concerts = new Concert [] { NextConcert() };
                    break;
                case 1:
                    seriesName = SeriesName.Celebration;
                    concerts = new Concert[] { NextConcert(), 
                        new Concert("The Hyphenated Liszt ", "October 28, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.")
                        , new Concert("Schubert's Winterreise ", "November 19, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("The Literary Liszt ", "January 14, 20121", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Old vs New ", "March 24, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.") };
                    break;
                case 2:
                    seriesName = SeriesName.Discovery;
                    concerts = new Concert[] { new Concert("Contemporary Canada ", "November 5, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Histoire du Tango ", "February 11, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Persian Zeal ", "April 14, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.") };
                    break;
                case 3:
                    seriesName = SeriesName.Jazz;
                    concerts = new Concert[] { new Concert("Tommy Banks Quartet ", " Monday, October 30, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Bill Evans Tribute ", "Monday, November 7, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Maria Schneider ", "Monday, January 23, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."),
                        new Concert("Chris Andrew Quintet ", "Monday, February 27, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Verismo with Chris Tarry ", "Monday, March 26, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Alex Goodman/Brent Mah Quartet ", "Monday, April 23, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.") };
                    break;
                case 4:
                    seriesName = SeriesName.Organ;
                    concerts = new Concert[] { new Concert("Romance: Germany Seduced by the South ", "October 31, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("French Symphonic Music of the 20th and 21st Centuries ", "November 29, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("Livre d'orgue de Montreal ", "February 7, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.") };
                    break;
                case 5:
                    seriesName = SeriesName.StringQuartet;
                    concerts = new Concert[] { new Concert("A Celebration of Brahms I ", "Friday, December 2, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("A Celebration of Brahms II ", "Friday, March 2, 20121", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre."), 
                        new Concert("A Celebration of Brahms III ", "Friday, May 18, 2012", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.") };;
                    break;
                default:
                    break;
            }
        }

        public Concert findAConcert(string name)
        {
            for (int i = 0; i < this.concerts.Length; i++)
            {
                if (concerts[i].name == name)
                {
                    return concerts[i];
                }
            }
            return null;
        }

        public static Concert NextConcert()
        {
            return new Concert("The Blackbird Sings ", "October 22, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include\n Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.");
        }
    }
}
