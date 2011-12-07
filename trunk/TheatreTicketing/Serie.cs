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
                        new Concert("The Hyphenated Liszt ", "October 28, 2011", "8pm - 11pm", "The Hyphenated Liszt is the third in a programme of six featuring the celebrated works of Franz Liszt and will include Schubert and Chopin Transcriptions, A Night at the Opera and the extraordinary Danse Macabre.", TheatreTicketing.Properties.Resources.The_Hyphenated_Liszt),
                        new Concert("Schubert's Winterreise ", "November 19, 2011", "8pm - 11pm", "Tenor soloist Timothy Shantz is joined by pianist Marilyn Engle and performs the Winterreise song cycle. The 24 poems of Wilhelm Müller, set for voice and piano by Franz Schubert, are described as epic in sadness, the blending of two moods of beauty - in verse and in music - overshadowed by death.", TheatreTicketing.Properties.Resources.Schubert_Winterreise), 
                        new Concert("The Literary Liszt ", "January 14, 20121", "8pm - 11pm", "Programme four of six, featuring more works by the legendary Franz Liszt, focuses on the cycle of piano pieces entitled Harmonies poétiques et religieuses. Concerts five and six of Liszt’s works will be performed next season. ", TheatreTicketing.Properties.Resources.The_Hyphenated_Liszt), 
                        new Concert("Old vs New ", "March 24, 2012", "8pm - 11pm", "Ensemble Made in Canada is one of Canada’s premier piano quartets and performs on a collection of rare Italian instruments. Their program will feature traditional piano quartets, including the Schumann piano quartet, and a new commission by Canadian composer and scholar John Burge.", TheatreTicketing.Properties.Resources.Old_vs_New) };
                    break;
                case 2:
                    seriesName = SeriesName.Discovery;
                    concerts = new Concert[] { new Concert("Contemporary Canada ", "November 5, 2011", "8pm - 11pm", "Japanese/Canadian pianist Yoko Hirota will perform a concert of music by contemporary Canadian composers. Her performance will include pieces by Gary Kulesha, Francois Morel and our very own Laurie Radford. Praised as one of the leading interpreters of contemporary piano repertory of her generation, Yoko’s performance vows to be \"concise and keenly projective.\"", TheatreTicketing.Properties.Resources.Contemporary_Canada), 
                        new Concert("Histoire du Tango ", "February 11, 2012", "8pm - 11pm", "Violinist Renée-Paule Gauthier and guitarist Andrew Mah join forces in Duo Aperio to perform Histoire du Tango. Their dynamic live performance will embrace pieces by Argentine tango composer Astor Piazzolla whose compositions revolutionized the traditional tango into a new style, Nuevo Tango.", TheatreTicketing.Properties.Resources.Histoire_du_Tango), 
                        new Concert("Persian Zeal ", "April 14, 2012", "8pm - 11pm", "Inspired by the profound passion of an ancient Persian repertoire, these BC performers bring contemporary improvisations and neo-traditional settings that unfold in rhythmic play. Their work can be spirited and humorous, and at other times saturated with an intense joy that transports listeners to another world.", TheatreTicketing.Properties.Resources.Persian_Zeal) };
                    break;
                case 3:
                    seriesName = SeriesName.Jazz;
                    concerts = new Concert[] { new Concert("Tommy Banks Quartet ", " Monday, October 30, 2011", "8pm - 11pm", "Juno award winner, Senator Tommy Banks began his musical career in Edmonton 58 years ago in jazz, big band and orchestra. Among other talents, he is a renowned pianist, conductor, arranger and composer who was made an Officer of the Order of Canada and was awarded the Alberta Order of Excellence.", TheatreTicketing.Properties.Resources.Tommy_Banks_Quartet), 
                        new Concert("Bill Evans Tribute ", "Monday, November 7, 2011", "8pm - 11pm", "Donato-Bourassa-Lozano-Tanguay are four major Montreal jazzmen who will join together to pay tribute to the great pianist Bill Evans. Drawing from their collective life experience, these seasoned musicians praise one of the most important figures in jazz history, adding their own spin to the now-classic repertoire.", TheatreTicketing.Properties.Resources.Bill_Evans_Tribute), 
                        new Concert("Maria Schneider ", "Monday, January 23, 2012", "8pm - 11pm", "New York-based Maria Schneider is an acclaimed American jazz composer and big band conductor who, like her mentor, the late Gil Evans, creates unique and celebrated musical pieces for large bands. Her music is exceptionally original and has been described as a mix between avant-garde jazz and modern classical.", TheatreTicketing.Properties.Resources.Maria_Schneider),
                        new Concert("Chris Andrew Quintet ", "Monday, February 27, 2012", "8pm - 11pm", "As a key pianist in the Alberta music scene, Chris Andrews’s musical diversity is ever present in his many performances of jazz, funk, pop, Latin and musical theatre. He has performed with numerous well-known groups including Bomba and Sillan & Young, and is now heading up his own quintet.", TheatreTicketing.Properties.Resources.Chris_Andrew_Quintet), 
                        new Concert("Verismo with Chris Tarry ", "Monday, March 26, 2012", "8pm - 11pm", "The Calgary jazz quintet Verismo, co-founded by saxophonists Jeremy Brown and Pat Belliveau, consists of some of Western Canada’s best instrumentalists, known for their exploration of new, original compositions. Joining them for this show will be Chris Tarry, an internationally celebrated electric bass player.", TheatreTicketing.Properties.Resources.Verismo_with_Chris_Tarry), 
                        new Concert("Alex Goodman/Brent Mah Quartet ", "Monday, April 23, 2012", "8pm - 11pm", "The Alex Goodman/Brent Mah Quartet is a contemporary jazz group that brings together some of Canada's top young jazz talent. The group is comprised of musicians from both Calgary and Toronto with fresh, original compositions that have an individual yet cohesive style.", TheatreTicketing.Properties.Resources.Alex_Goodman_Brent_Mah_Quartet) };
                    break;
                case 4:
                    seriesName = SeriesName.Organ;
                    concerts = new Concert[] { new Concert("Romance: Germany Seduced by the South ", "October 31, 2011", "8pm - 11pm", "The University of Calgary Music Department is proud to present Christina Hutten as part of the Calgary Organ Festival, in partnership with Mount Royal University Conservatory.\r\n\r\nChristina Hutten is an exceptional young Canadian concert organist. The works that she has chosen to perform will feature music by German masters such as Bach and Buxtehude along with music by the Italian composers who inspired them.", TheatreTicketing.Properties.Resources.Romance), 
                        new Concert("French Symphonic Music of the 20th and 21st Centuries ", "November 29, 2011", "8pm - 11pm", "Montreal organist Jean-Willy Kunz first discovered the subtleties of the piano and the organ in the course of his early training at the Grenoble Conservatory. He has won numerous awards including a second prize at the Grand Prix de Chartres international organ competition in 2008. For this performance, he has chosen to perform French Symphonic works from the 20th and 21st centuries.", TheatreTicketing.Properties.Resources.French_Symphonic), 
                        new Concert("Livre d'orgue de Montreal ", "February 7, 2012", "8pm - 11pm", "Neil Cockburn will reconstruct liturgical settings for a selection of the 398 pieces of Livre d’orgue de Montréal. Brought from France to Montreal in 1724 by the Sulpician Jean Girard, this collection was rediscovered in 1978 and is the largest existing manuscript volume of organ music from the time of Louis XIV.", TheatreTicketing.Properties.Resources.Livre_orgue) };
                    break;
                case 5:
                    seriesName = SeriesName.StringQuartet;
                    concerts = new Concert[] { new Concert("A Celebration of Brahms I ", "Friday, December 2, 2011", "8pm - 11pm", "String quartets by Haydn, Prokofiev, and Brahms.", TheatreTicketing.Properties.Resources.Celebration_Brahms_I), 
                        new Concert("A Celebration of Brahms II ", "Friday, March 2, 20121", "8pm - 11pm", "String quartets by Mozart, Brahms, and a new work by George Fenwick, commissioned by the UCalgary String Quartet.", TheatreTicketing.Properties.Resources.Celebration_Brahms_I), 
                        new Concert("A Celebration of Brahms III ", "Friday, May 18, 2012", "8pm - 11pm", "String quartets by Schubert, Mendelssohn and a piano quartet by Brahms with special guest Anton Kuerti.", TheatreTicketing.Properties.Resources.Celebration_Brahms_II) };;
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
            return new Concert("The Blackbird Sings ", "September 17, 2011", "8pm - 11pm", "Christie Reside, Principal Flute with the Vancouver Symphony Orchestra, joins pianist Kathleen van Mourik to perform Philippe Gaubert’s Sonata for flute and piano, along with other superb works such as Jean Francaix’s Divertimento and Olivier Messiaen’s Le merle noir.", TheatreTicketing.Properties.Resources.The_Blackbird_Sings);
        }
    }
}
