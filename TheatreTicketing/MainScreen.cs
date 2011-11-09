using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace TheatreTicketing
{
    public partial class MainScreen : Form
    {
        public MainScreen()
            : this(new DockContentFormFactory())
        {
        }

        public MainScreen(IDockContentFormFactory dockContentFactory)
        {
            InitializeComponent();

            DockContent dockedConcertList = dockContentFactory.Create("Concerts", DockState.DockRight, Color.DarkSeaGreen);
            dockedConcertList.Show(dockPanel1);
            //dockedConcertList.DockHandler.FloatPane.DockTo(dockPanel1.DockWindows[DockState.DockRight]);
            dockedConcertList.AutoScroll = true;

            //Current concert is shown at the top of the list
            Label currentConcertLabel = new Label();
            currentConcertLabel.Text = "Now Showing";
            currentConcertLabel.Size = new Size(225, 15);
            dockedConcertList.Controls.Add(currentConcertLabel);

            Label currentConcertLabel1 = new Label();
            currentConcertLabel1.Text = "The Hyphenated Liszt - October 22, 2011";
            currentConcertLabel1.Size = new Size(225, 15);
            currentConcertLabel1.Location = new Point(20, 20);
            currentConcertLabel1.Click += new EventHandler(this.celebrationLabel2_Click);
            dockedConcertList.Controls.Add(currentConcertLabel1);
            Button moreInfo_currentConcert = new Button();
            moreInfo_currentConcert.Text = "More Info";
            moreInfo_currentConcert.Size = new Size(60, 20);
            moreInfo_currentConcert.Location = new Point(245, 15);
            moreInfo_currentConcert.BackColor = Color.WhiteSmoke;
            dockedConcertList.Controls.Add(moreInfo_currentConcert);

            #region Celebration Series
            //title
            Label celebrationLabel = new Label();
            celebrationLabel.Text = "Celebration";
            celebrationLabel.Size = new Size(70, 15);
            celebrationLabel.Location = new Point(0, 40);
            dockedConcertList.Controls.Add(celebrationLabel);
            //concerts
            Label celebrationLabel1 = new Label();
            celebrationLabel1.Text = "The Blackbird Sings: Music for Flute and Piano - September 17, 2011";
            celebrationLabel1.Size = new Size(350, 15);
            //celebrationLabel1.BorderStyle = BorderStyle.FixedSingle;
            celebrationLabel1.Location = new Point(20, 60);
            celebrationLabel1.Click += new EventHandler(this.celebrationLabel1_Click);
            dockedConcertList.Controls.Add(celebrationLabel1);
            Button moreInfo_celebration1 = new Button();
            moreInfo_celebration1.Text = "More Info";
            moreInfo_celebration1.Size = new Size(60, 20);
            moreInfo_celebration1.BackColor = Color.WhiteSmoke;
            moreInfo_celebration1.Location = new Point(370, 55);
            dockedConcertList.Controls.Add(moreInfo_celebration1);

            Label celebrationLabel2 = new Label();
            celebrationLabel2.Text = "The Hyphenated Liszt - October 22, 2011";
            celebrationLabel2.Size = new Size(225, 15);
            //celebrationLabel2.BorderStyle = BorderStyle.FixedSingle;
            celebrationLabel2.Location = new Point(20, 80);
            celebrationLabel2.Click += new EventHandler(this.celebrationLabel2_Click);
            dockedConcertList.Controls.Add(celebrationLabel2);
            Button moreInfo_celebration2 = new Button();
            moreInfo_celebration2.Text = "More Info";
            moreInfo_celebration2.Size = new Size(60, 20);
            moreInfo_celebration2.BackColor = Color.WhiteSmoke;
            moreInfo_celebration2.Location = new Point(245, 75);
            dockedConcertList.Controls.Add(moreInfo_celebration2);

            Label celebrationLabel3 = new Label();
            celebrationLabel3.Text = "Schubert's Winterreise - November 19, 2011";
            celebrationLabel3.Size = new Size(225, 15);
            celebrationLabel3.Location = new Point(20, 100);
            celebrationLabel3.Click += new EventHandler(this.celebrationLabel3_Click);
            dockedConcertList.Controls.Add(celebrationLabel3);
            Button moreInfo_celebration3 = new Button();
            moreInfo_celebration3.Text = "More Info";
            moreInfo_celebration3.Size = new Size(60, 20);
            moreInfo_celebration3.BackColor = Color.WhiteSmoke;
            moreInfo_celebration3.Location = new Point(245, 95);
            dockedConcertList.Controls.Add(moreInfo_celebration3);

            Label celebrationLabel4 = new Label();
            celebrationLabel4.Text = "The Literary Liszt - January 14, 2012";
            celebrationLabel4.Size = new Size(200, 15);
            celebrationLabel4.Location = new Point(20, 120);
            celebrationLabel4.Click += new EventHandler(this.celebrationLabel4_Click);
            dockedConcertList.Controls.Add(celebrationLabel4);
            Button moreInfo_celebration4 = new Button();
            moreInfo_celebration4.Text = "More Info";
            moreInfo_celebration4.Size = new Size(60, 20);
            moreInfo_celebration4.BackColor = Color.WhiteSmoke;
            moreInfo_celebration4.Location = new Point(245, 115);
            dockedConcertList.Controls.Add(moreInfo_celebration4);

            Label celebrationLabel5 = new Label();
            celebrationLabel5.Text = "Old vs New - March 24, 2012";
            celebrationLabel5.Size = new Size(175, 15);
            celebrationLabel5.Location = new Point(20, 140);
            celebrationLabel5.Click += new EventHandler(this.celebrationLabel5_Click);
            dockedConcertList.Controls.Add(celebrationLabel5);
            Button moreInfo_celebration5 = new Button();
            moreInfo_celebration5.Text = "More Info";
            moreInfo_celebration5.Size = new Size(60, 20);
            moreInfo_celebration5.BackColor = Color.WhiteSmoke;
            moreInfo_celebration5.Location = new Point(245, 135);
            dockedConcertList.Controls.Add(moreInfo_celebration5);
            #endregion

            #region Discovery Series
            //title
            Label discoveryLabel = new Label();
            discoveryLabel.Text = "Discovery";
            discoveryLabel.Size = new Size(70, 15);
            discoveryLabel.Location = new Point(0, 160);
            dockedConcertList.Controls.Add(discoveryLabel);
            //concerts
            Label discoveryLabel1 = new Label();
            discoveryLabel1.Text = "Contemporary Canada - November 5, 2011";
            discoveryLabel1.Size = new Size(225, 15);
            discoveryLabel1.Location = new Point(20, 180);
            discoveryLabel1.Click += new EventHandler(this.discoveryLabel1_Click);
            dockedConcertList.Controls.Add(discoveryLabel1);
            Button moreInfo_discovery1 = new Button();
            moreInfo_discovery1.Text = "More Info";
            moreInfo_discovery1.Size = new Size(60, 20);
            moreInfo_discovery1.BackColor = Color.WhiteSmoke;
            moreInfo_discovery1.Location = new Point(245, 175);
            dockedConcertList.Controls.Add(moreInfo_discovery1);

            Label discoveryLabel2 = new Label();
            discoveryLabel2.Text = "Histoire du Tango - February 11, 2012";
            discoveryLabel2.Size = new Size(225, 15);
            discoveryLabel2.Location = new Point(20, 200);
            discoveryLabel2.Click += new EventHandler(this.discoveryLabel2_Click);
            dockedConcertList.Controls.Add(discoveryLabel2);
            Button moreInfo_discovery2 = new Button();
            moreInfo_discovery2.Text = "More Info";
            moreInfo_discovery2.Size = new Size(60, 20);
            moreInfo_discovery2.BackColor = Color.WhiteSmoke;
            moreInfo_discovery2.Location = new Point(245, 195);
            dockedConcertList.Controls.Add(moreInfo_discovery2);

            Label discoveryLabel3 = new Label();
            discoveryLabel3.Text = "Persian Zeal -  April 14, 2012";
            discoveryLabel3.Size = new Size(200, 15);
            discoveryLabel3.Location = new Point(20, 220);
            discoveryLabel3.Click += new EventHandler(this.discoveryLabel3_Click);
            dockedConcertList.Controls.Add(discoveryLabel3);
            Button moreInfo_discovery3 = new Button();
            moreInfo_discovery3.Text = "More Info";
            moreInfo_discovery3.Size = new Size(60, 20);
            moreInfo_discovery3.BackColor = Color.WhiteSmoke;
            moreInfo_discovery3.Location = new Point(245, 215);
            dockedConcertList.Controls.Add(moreInfo_discovery3);
            #endregion

            #region Monday Night Jazz Series
            //title
            Label jazzLabel = new Label();
            jazzLabel.Text = "Monday Night Jazz";
            jazzLabel.Size = new Size(125, 15);
            jazzLabel.Location = new Point(0, 240);
            dockedConcertList.Controls.Add(jazzLabel);
            //concerts
            Label jazzLabel1 = new Label();
            jazzLabel1.Text = "Tommy Banks Quartet - Monday, October 3, 2011";
            jazzLabel1.Size = new Size(250, 15);
            jazzLabel1.Location = new Point(20, 260);
            jazzLabel1.Click += new EventHandler(this.jazzLabel1_Click);
            dockedConcertList.Controls.Add(jazzLabel1);
            Button moreInfo_jazz1 = new Button();
            moreInfo_jazz1.Text = "More Info";
            moreInfo_jazz1.Size = new Size(60, 20);
            moreInfo_jazz1.BackColor = Color.WhiteSmoke;
            moreInfo_jazz1.Location = new Point(275, 255);
            dockedConcertList.Controls.Add(moreInfo_jazz1);
        
            Label jazzLabel2 = new Label();
            jazzLabel2.Text = "Bill Evans Tribute - Monday, November 7, 2011";
            jazzLabel2.Size = new Size(250, 15);
            jazzLabel2.Location = new Point(20, 280);
            jazzLabel2.Click += new EventHandler(this.jazzLabel2_Click);
            dockedConcertList.Controls.Add(jazzLabel2);
            Button moreInfo_jazz2 = new Button();
            moreInfo_jazz2.Text = "More Info";
            moreInfo_jazz2.Size = new Size(60, 20);
            moreInfo_jazz2.BackColor = Color.WhiteSmoke;
            moreInfo_jazz2.Location = new Point(275, 275);
            dockedConcertList.Controls.Add(moreInfo_jazz2);

            Label jazzLabel3 = new Label();
            jazzLabel3.Text = "Maria Schneider - Monday, January 23, 2012";
            jazzLabel3.Size = new Size(250, 15);
            jazzLabel3.Location = new Point(20, 300);
            jazzLabel3.Click += new EventHandler(this.jazzLabel3_Click);
            dockedConcertList.Controls.Add(jazzLabel3);
            Button moreInfo_jazz3 = new Button();
            moreInfo_jazz3.Text = "More Info";
            moreInfo_jazz3.Size = new Size(60, 20);
            moreInfo_jazz3.BackColor = Color.WhiteSmoke;
            moreInfo_jazz3.Location = new Point(275, 295);
            dockedConcertList.Controls.Add(moreInfo_jazz3);

            Label jazzLabel4 = new Label();
            jazzLabel4.Text = "Chris Andrew Quintet - Monday, February 27, 2012";
            jazzLabel4.Size = new Size(250, 15);
            jazzLabel4.Location = new Point(20, 320);
            jazzLabel4.Click += new EventHandler(this.jazzLabel4_Click);
            dockedConcertList.Controls.Add(jazzLabel4);
            Button moreInfo_jazz4 = new Button();
            moreInfo_jazz4.Text = "More Info";
            moreInfo_jazz4.Size = new Size(60, 20);
            moreInfo_jazz4.BackColor = Color.WhiteSmoke;
            moreInfo_jazz4.Location = new Point(275, 315);
            dockedConcertList.Controls.Add(moreInfo_jazz4);
            
            Label jazzLabel5 = new Label();
            jazzLabel5.Text = "Verismo with Chris Tarry - Monday, March 26, 2012";
            jazzLabel5.Size = new Size(250, 15);
            jazzLabel5.Location = new Point(20, 340);
            jazzLabel5.Click += new EventHandler(this.jazzLabel5_Click);
            dockedConcertList.Controls.Add(jazzLabel5);
            Button moreInfo_jazz5 = new Button();
            moreInfo_jazz5.Text = "More Info";
            moreInfo_jazz5.Size = new Size(60, 20);
            moreInfo_jazz5.BackColor = Color.WhiteSmoke;
            moreInfo_jazz5.Location = new Point(275, 335);
            dockedConcertList.Controls.Add(moreInfo_jazz5);

            Label jazzLabel6 = new Label();
            jazzLabel6.Text = "Alex Goodman/Brent Mah Quartet - Monday, April 23, 2012";
            jazzLabel6.Size = new Size(290, 15);
            jazzLabel6.Location = new Point(20, 360);
            jazzLabel6.Click += new EventHandler(this.jazzLabel6_Click);
            dockedConcertList.Controls.Add(jazzLabel6);
            Button moreInfo_jazz6 = new Button();
            moreInfo_jazz6.Text = "More Info";
            moreInfo_jazz6.Size = new Size(60, 20);
            moreInfo_jazz6.BackColor = Color.WhiteSmoke;
            moreInfo_jazz6.Location = new Point(325, 355);
            dockedConcertList.Controls.Add(moreInfo_jazz6);
            #endregion

            #region Organ Series
            //title
            Label organLabel = new Label();
            organLabel.Text = "Organ";
            organLabel.Size = new Size(70, 15);
            organLabel.Location = new Point(0, 380);
            dockedConcertList.Controls.Add(organLabel);
            //concerts
            Label organLabel1 = new Label();
            organLabel1.Text = "Romance: Germany Seduced by the South - October 18, 2011";
            organLabel1.Size = new Size(315, 15);
            organLabel1.Location = new Point(20, 400);
            organLabel1.Click += new EventHandler(this.organLabel1_Click);
            dockedConcertList.Controls.Add(organLabel1);
            Button moreInfo_organ1 = new Button();
            moreInfo_organ1.Text = "More Info";
            moreInfo_organ1.Size = new Size(60, 20);
            moreInfo_organ1.BackColor = Color.WhiteSmoke;
            moreInfo_organ1.Location = new Point(340, 395);
            dockedConcertList.Controls.Add(moreInfo_organ1);

            Label organLabel2 = new Label();
            organLabel2.Text = "French Symphonic Music of the 20th and 21st Centuries - November 29, 2011";
            organLabel2.Size = new Size(375, 15);
            organLabel2.Location = new Point(20, 420);
            organLabel2.Click += new EventHandler(this.organLabel2_Click);
            dockedConcertList.Controls.Add(organLabel2);
            Button moreInfo_organ2 = new Button();
            moreInfo_organ2.Text = "More Info";
            moreInfo_organ2.Size = new Size(60, 20);
            moreInfo_organ2.BackColor = Color.WhiteSmoke;
            moreInfo_organ2.Location = new Point(400, 415);
            dockedConcertList.Controls.Add(moreInfo_organ2);

            Label organLabel3 = new Label();
            organLabel3.Text = "Livre d'orgue de Montreal - February 7, 2012";
            organLabel3.Size = new Size(225, 15);
            organLabel3.Location = new Point(20, 440);
            organLabel3.Click += new EventHandler(this.organLabel3_Click);
            dockedConcertList.Controls.Add(organLabel3);
            Button moreInfo_organ3 = new Button();
            moreInfo_organ3.Text = "More Info";
            moreInfo_organ3.Size = new Size(60, 20);
            moreInfo_organ3.BackColor = Color.WhiteSmoke;
            moreInfo_organ3.Location = new Point(275, 435);
            dockedConcertList.Controls.Add(moreInfo_organ3);
            #endregion

            #region Special Series: UCalgary String Quartet
            //title
            Label quartetLabel = new Label();
            quartetLabel.Text = "Special Series: UCalgary String Quartet";
            quartetLabel.Size = new Size(300, 15);
            quartetLabel.Location = new Point(0, 460);
            dockedConcertList.Controls.Add(quartetLabel);
            //concerts
            Label quartetLabel1 = new Label();
            quartetLabel1.Text = "A Celebration of Brahms I - Friday, December 2, 2011";
            quartetLabel1.Size = new Size(260, 15);
            quartetLabel1.Location = new Point(20, 480);
            quartetLabel1.Click += new EventHandler(this.quartetLabel1_Click);
            dockedConcertList.Controls.Add(quartetLabel1);
            Button moreInfo_quartet1 = new Button();
            moreInfo_quartet1.Text = "More Info";
            moreInfo_quartet1.Size = new Size(60, 20);
            moreInfo_quartet1.BackColor = Color.WhiteSmoke;
            moreInfo_quartet1.Location = new Point(280, 475);
            dockedConcertList.Controls.Add(moreInfo_quartet1);

            Label quartetLabel2 = new Label();
            quartetLabel2.Text = "A Celebration of Brahms II - Friday, March 2, 2012";
            quartetLabel2.Size = new Size(250, 15);
            quartetLabel2.Location = new Point(20, 500);
            quartetLabel2.Click += new EventHandler(this.quartetLabel2_Click);
            dockedConcertList.Controls.Add(quartetLabel2);
            Button moreInfo_quartet2 = new Button();
            moreInfo_quartet2.Text = "More Info";
            moreInfo_quartet2.Size = new Size(60, 20);
            moreInfo_quartet2.BackColor = Color.WhiteSmoke;
            moreInfo_quartet2.Location = new Point(280, 495);
            dockedConcertList.Controls.Add(moreInfo_quartet2);

            Label quartetLabel3 = new Label();
            quartetLabel3.Text = "A Celebration of Brahms III - Friday, May 18, 2012";
            quartetLabel3.Size = new Size(250, 15);
            quartetLabel3.Location = new Point(20, 520);
            quartetLabel3.Click += new EventHandler(this.quartetLabel3_Click);
            dockedConcertList.Controls.Add(quartetLabel3);
            Button moreInfo_quartet3 = new Button();
            moreInfo_quartet3.Text = "More Info";
            moreInfo_quartet3.Size = new Size(60, 20);
            moreInfo_quartet3.BackColor = Color.WhiteSmoke;
            moreInfo_quartet3.Location = new Point(280, 515);
            dockedConcertList.Controls.Add(moreInfo_quartet3);
            #endregion

            //DockContent dockedPurchaseTickets = dockContentFactory.Create("Buy", DockState.DockRightAutoHide, Color.PaleGoldenrod);
            //dockedPurchaseTickets.Show(dockPanel1);
            //dockedPurchaseTickets.DockHandler.FloatPane.DockTo(dockPanel1.DockWindows[DockState.DockRight]);
            //dockedPurchaseTickets.AutoScroll = true;
        }
            
        #region click events for celebration labels
        private void celebrationLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void celebrationLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked2!");
        }

        private void celebrationLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked3!");
        }

        private void celebrationLabel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked4!");
        }

        private void celebrationLabel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked5!");
        }
        #endregion

        #region click events for discovery labels
        private void discoveryLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void discoveryLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked2!");
        }

        private void discoveryLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked3!");
        }
        #endregion

        #region click events for jazz labels
        private void jazzLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void jazzLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void jazzLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void jazzLabel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void jazzLabel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void jazzLabel6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }
        #endregion

        #region click events for organ labels
        private void organLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void organLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void organLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }
        #endregion

        #region click events for quartet
        private void quartetLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void quartetLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }

        private void quartetLabel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
        }
        #endregion
>>>>>>> .r4
    }
}
