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
        public Serie[] series;
        public Label ticketsToPurchase;
        public Button cancelPurchase;
        public Button confirmPurchase;

        public int numberSeatSelected = 0;
        public List<System.Windows.Forms.CheckBox> seatSelected = new List<System.Windows.Forms.CheckBox>();

        public string currentSerie;
        public Concert currentConcert;

        public decimal totalTicketValue;
        public decimal currentPageTotal;
    

        public MainScreen()
            : this(new DockContentFormFactory())
        {
            currentPageTotal = 0;

            series = new Serie[6];
            for(int i = 0; i < 6; i++)
            {
                series[i] = new Serie();
                series[i].Populate(i);
            }

            //Add a pre purchased seat to the next concert
            Concert nextConcert = findAConcert("The Blackbird Sings ");
            nextConcert.addAPurchasedSeat(SeatType.StudentSenior, checkBox100);
            nextConcert.addAPurchasedSeat(SeatType.Adult, checkBox111);
            nextConcert.addAPurchasedSeat(SeatType.UofCStudent, checkBox122);
            currentConcert = nextConcert;
            currentSerie = SeriesName.Celebration.ToString();

            labelSeries.Text = currentSerie;
            labelConcert.Text = currentConcert.name;
            labelDate.Text = currentConcert.date;
            labelTime.Text = currentConcert.time;
            pictureBoxConcert.Image = currentConcert.image;
            

            //We construct the screen of next concert
            clearConcertScreen();
            constructConcertScreen();

            //add a pre purchased seat to the second concert
            Concert secondConcert = findAConcert("The Hyphenated Liszt ");
            secondConcert.addAPurchasedSeat(SeatType.StudentSenior, checkBox193);
        }

        public MainScreen(IDockContentFormFactory dockContentFactory)
        {
            InitializeComponent();

            DockContent dockedConcertList = dockContentFactory.Create("Concerts", DockState.Float, Color.PaleGoldenrod);
            dockedConcertList.Show(dockPanel1);
            dockedConcertList.DockHandler.FloatPane.DockTo(dockPanel1.DockWindows[DockState.DockRight]);
            dockedConcertList.AutoScroll = true;

            TreeView treeView = new TreeView();
            treeView.Scale(new System.Drawing.SizeF((float)4.5, (float)4.6));
            treeView.BorderStyle = BorderStyle.None;
            treeView.BackColor = Color.PaleGoldenrod;
            #region now showing
            TreeNode nowShowingConcert = new TreeNode("The Blackbird Sings - September 17, 2011");
            TreeNode[] nowShowingConcertList = new TreeNode[] { nowShowingConcert };
            TreeNode nowShowingMasterNode = new TreeNode("Now Showing", nowShowingConcertList);
            treeView.Nodes.Add(nowShowingMasterNode);
            #endregion
            #region Celebration Series
            TreeNode celebrationConcert1 = new TreeNode("The Blackbird Sings - September 17, 2011");
            TreeNode celebrationConcert2 = new TreeNode("The Hyphenated Liszt - October 28, 2011");
            TreeNode celebrationConcert3 = new TreeNode("Schubert's Winterreise - November 19, 2011");
            TreeNode celebrationConcert4 = new TreeNode("The Literary Liszt - January 14, 2012");
            TreeNode celebrationConcert5 = new TreeNode("Old vs New - March 24, 2012");
            TreeNode[] celebrationConcertList = new TreeNode[] { celebrationConcert1, celebrationConcert2, celebrationConcert3, celebrationConcert4, celebrationConcert5 };
            TreeNode celebrationMasterNode = new TreeNode("Celebration", celebrationConcertList);
            treeView.Nodes.Add(celebrationMasterNode);
            #endregion
            #region Discovery Series
            TreeNode discoveryConcert1 = new TreeNode("Contemporary Canada - November 5, 2011");
            TreeNode discoveryConcert2 = new TreeNode("Histoire du Tango - February 11, 2012");
            TreeNode discoveryConcert3 = new TreeNode("Persian Zeal -  April 14, 2012");
            TreeNode[] discoveryConcertList = new TreeNode[] { discoveryConcert1, discoveryConcert2, discoveryConcert3 };
            TreeNode discoveryMasterNode = new TreeNode("Discovery", discoveryConcertList);
            treeView.Nodes.Add(discoveryMasterNode);
            #endregion
            #region Monday Night Jazz Series
            TreeNode jazzConcert1 = new TreeNode("Tommy Banks Quartet - Monday, October 30, 2011");
            TreeNode jazzConcert2 = new TreeNode("Bill Evans Tribute - Monday, November 7, 2011");
            TreeNode jazzConcert3 = new TreeNode("Maria Schneider - Monday, January 23, 2012");
            TreeNode jazzConcert4 = new TreeNode("Chris Andrew Quintet - Monday, February 27, 2012");
            TreeNode jazzConcert5 = new TreeNode("Verismo with Chris Tarry - Monday, March 26, 2012");
            TreeNode jazzConcert6 = new TreeNode("Alex Goodman/Brent Mah Quartet - Monday, April 23, 2012");
            TreeNode[] jazzConcertList = new TreeNode[] { jazzConcert1, jazzConcert2, jazzConcert3, jazzConcert4, jazzConcert5, jazzConcert6 };
            TreeNode jazzMasterNode = new TreeNode("Celebration", jazzConcertList);
            treeView.Nodes.Add(jazzMasterNode);
            #endregion
            #region Organ Series
            TreeNode organConcert1 = new TreeNode("Romance: Germany Seduced by the South - October 31, 2011");
            TreeNode organConcert2 = new TreeNode("French Symphonic Music of the 20th and 21st Centuries - November 29, 2011");
            TreeNode organConcert3 = new TreeNode("Livre d'orgue de Montreal - February 7, 2012");
            TreeNode[] organConcertList = new TreeNode[] { organConcert1, organConcert2, organConcert3 };
            TreeNode organMasterNode = new TreeNode("Organ", organConcertList);
            treeView.Nodes.Add(organMasterNode);
            #endregion
            #region Special Series: UCalgary String Quartet
            TreeNode specialConcert1 = new TreeNode("A Celebration of Brahms I - Friday, December 2, 2011");
            TreeNode specialConcert2 = new TreeNode("A Celebration of Brahms II - Friday, March 2, 2012");
            TreeNode specialConcert3 = new TreeNode("A Celebration of Brahms III - Friday, May 18, 2012");
            TreeNode[] specialConcertList = new TreeNode[] { specialConcert1, specialConcert2, specialConcert3 };
            TreeNode specialMasterNode = new TreeNode("Special Series: UCalgary String Quartet", specialConcertList);
            treeView.Nodes.Add(specialMasterNode);
            #endregion
            treeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView_NodeMouseClick);
            dockedConcertList.Controls.Add(treeView);

            DockContent dockedPurchaseTickets = dockContentFactory.Create("Buy", DockState.Float, Color.PaleGoldenrod);
            dockedPurchaseTickets.Show(dockPanel1);
            dockedPurchaseTickets.DockHandler.FloatPane.DockTo(dockPanel1.DockWindows[DockState.DockRight]);
            dockedPurchaseTickets.AutoScroll = true;

            ticketsToPurchase = new Label();
            ticketsToPurchase.BackColor = Color.PaleGoldenrod;
            ticketsToPurchase.Size = new System.Drawing.Size(300, 120);
            dockedPurchaseTickets.Controls.Add(ticketsToPurchase);
            cancelPurchase = new Button();
            cancelPurchase.Text = "Cancel";
            cancelPurchase.Location = new Point(75, 120);
            cancelPurchase.Click += new EventHandler(cancelPurchase_Click);
            cancelPurchase.Hide();
            dockedPurchaseTickets.Controls.Add(cancelPurchase);
            confirmPurchase = new Button();
            confirmPurchase.Text = "Buy";
            confirmPurchase.Location = new Point(0, 120);
            confirmPurchase.Click += new EventHandler(confirmPurchase_Click);
            confirmPurchase.Hide();
            dockedPurchaseTickets.Controls.Add(confirmPurchase);
        }

        void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //find the \ (nothing should be changed if a base node is clicked)
            int slashCount = 0;
            foreach (char c in e.Node.FullPath.ToString())
            {
                if (c == '\\')
                {
                    slashCount++;
                }
            }
            if (slashCount > 0)
            {
                //find the \
                int backslashLocation = e.Node.FullPath.ToString().IndexOf('\\');
                //change the series
                if (!e.Node.FullPath.Substring(0, backslashLocation).ToString().Equals("Now Showing"))
                {
                    currentSerie = e.Node.FullPath.Substring(0, backslashLocation).ToString();
                }
                else
                {
                    currentSerie = "Celebration";
                }

                addReservedSeatToTheConcert();

                labelSeries.Text = currentSerie;
                //find index of the '-' character
                int dashLocation = e.Node.Text.ToString().IndexOf('-');

                //remove characters after the '-' character and change the concert
                string newConcertName = e.Node.Text.ToString().Remove(dashLocation);

                //We construct the sreen of the new selected concert
                labelConcert.Text = newConcertName;
                Concert newConcert = findAConcert(newConcertName);

                clearConcertScreen();
                currentConcert = newConcert;
                seatSelected = new List<CheckBox>();
                constructConcertScreen();

                //change the date label to the other concert
                labelDate.Text = newConcert.date;
                labelTime.Text = newConcert.time;
                pictureBoxConcert.Image = newConcert.image;

            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is under construction.", "Help");
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Test test = new Test();
            //test.ShowDialog();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            MoreInformation moreInfo = new MoreInformation();
            moreInfo.updateMoreInfo(currentSerie, currentConcert);
            moreInfo.ShowDialog();
        }

        //Function to update the number of seats slected
        private void updateNumberSelected_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.FlatStyle != FlatStyle.Flat)
            {
                if (checkbox.Checked)
                {
                    this.numberSeatSelected = this.numberSeatSelected + 1;
                    seatSelected.Add(checkbox);
                }
                else
                {
                    this.numberSeatSelected = this.numberSeatSelected - 1;
                }
                labelNumberSeat.Text = numberSeatSelected.ToString();
                updateMaxNumericUpDown_ValueChanged(null, null);
            }
        }

        //Function to update the number of maximum seat we can take per type
        private void updateMaxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownTypeAdult.Maximum = Math.Max(0, this.numberSeatSelected - numericUpDownTypeStudent.Value - numericUpDownTypeUofC.Value);
            numericUpDownTypeStudent.Maximum =  Math.Max(0, this.numberSeatSelected - numericUpDownTypeAdult.Value - numericUpDownTypeUofC.Value);
            numericUpDownTypeUofC.Maximum =  Math.Max(0, this.numberSeatSelected - numericUpDownTypeAdult.Value - numericUpDownTypeStudent.Value);
            if (sender != null && e != null)
            {
                updateBuyTicketsPanel();
            }
        }

        private void updateBuyTicketsPanel()
        {
            ticketsToPurchase.Text = "";
            decimal adultValue = 0;
            decimal studentValue = 0;

            for (int i = 1; i < series.Length; i++)
            {
                foreach (Concert c in series[i].concerts)
                {
                    if (c.reservedSeatsExist())
                    {
                        //output data
                        ticketsToPurchase.Text += series[i].seriesName;
                        ticketsToPurchase.Text += Environment.NewLine;
                        ticketsToPurchase.Text += c.name;
                        ticketsToPurchase.Text += Environment.NewLine;
                        ticketsToPurchase.Text += c.date;
                        ticketsToPurchase.Text += Environment.NewLine;
                        ticketsToPurchase.Text += c.time;
                        ticketsToPurchase.Text += Environment.NewLine;
                        ticketsToPurchase.Text += Environment.NewLine;

                        if (numericUpDownTypeAdult.Value > 0)
                        {
                            adultValue += 35 * numericUpDownTypeAdult.Value;
                            ticketsToPurchase.Text += numericUpDownTypeAdult.Value.ToString() + " Adult               = $" + adultValue.ToString() + ".00";
                            ticketsToPurchase.Text += Environment.NewLine;
                        }
                        if (numericUpDownTypeStudent.Value > 0)
                        {
                            studentValue += 25 * numericUpDownTypeStudent.Value;
                            ticketsToPurchase.Text += numericUpDownTypeStudent.Value.ToString() + " Student/Senior = $" + studentValue.ToString() + ".00";
                            ticketsToPurchase.Text += Environment.NewLine;
                        }
                        if (numericUpDownTypeUofC.Value > 0)
                        {
                            ticketsToPurchase.Text += numericUpDownTypeUofC.Value.ToString() + " UofC Student    = $0.00";
                            ticketsToPurchase.Text += Environment.NewLine;
                        }
                    }
                }
            }

            currentPageTotal = adultValue + studentValue;
            ticketsToPurchase.Text += "TOTAL               = $" + currentPageTotal + ".00";
            ticketsToPurchase.Text += Environment.NewLine;

            cancelPurchase.Show();
            confirmPurchase.Show();

            if ((numericUpDownTypeAdult.Value + numericUpDownTypeStudent.Value + numericUpDownTypeUofC.Value) == 0)
            {
                ticketsToPurchase.Text = "";
                cancelPurchase.Hide();
                confirmPurchase.Hide();
            }
        }

        void cancelPurchase_Click(object sender, EventArgs e)
        {
            totalTicketValue += currentPageTotal;
            DialogResult result = MessageBox.Show("Are you sure you would like to cancel your purchase of $" + totalTicketValue + ".00", "Cancel Purchase", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //clear all currently selected tickets
                clearAllSelectedTickets();

                //reset all counters
                totalTicketValue = 0;
                currentPageTotal = 0;
            }
            else
            {
                totalTicketValue = totalTicketValue - currentPageTotal;
            }
        }

        void confirmPurchase_Click(object sender, EventArgs e)
        {
            if (numberSeatSelected != (numericUpDownTypeAdult.Value + numericUpDownTypeStudent.Value + numericUpDownTypeUofC.Value))
            {
                MessageBox.Show("Please, before buying, select a seat type for each seats selected");
                return;
            }
            totalTicketValue += currentPageTotal;
            DialogResult result = MessageBox.Show("Are you sure you would like to purchase your tickets at a total of $" + totalTicketValue + ".00", "Buy Tickets", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                addPurchasedSeatToTheConcert();
                totalTicketValue = 0;
                currentPageTotal = 0;
                constructConcertScreen();
            }
            else
            {
                totalTicketValue = totalTicketValue - currentPageTotal;
            }
        }

        void constructConcertScreen()
        {
            Concert concert = currentConcert;

            foreach(Seat seat in concert.seatPurchased)
            {
                seat.checkBox.Checked = true;
                seat.checkBox.AutoCheck = false;
                seat.checkBox.CheckState = CheckState.Checked;
                seat.checkBox.FlatStyle = FlatStyle.Flat;
                if (seat.seatType == SeatType.Adult)
                {
                    seat.checkBox.BackColor = Color.LightCoral;
                    seat.checkBox.ForeColor = Color.Red;
                }
                else if (seat.seatType == SeatType.StudentSenior)
                {
                    seat.checkBox.BackColor = Color.LightGreen;
                    seat.checkBox.ForeColor = Color.Green;
                }
                else
                {
                    seat.checkBox.BackColor = Color.LightSkyBlue;
                    seat.checkBox.ForeColor = Color.Blue;
                }
            }

            foreach (Seat seat in concert.seatReserved)
            {
                seat.checkBox.Checked = true;
                seatSelected.Add(seat.checkBox);
            }

            //Number of seat purchased
            labelTicketSold.Text = "Tickets Sold : " + (concert.numberAdultSeat + concert.numberStudentSeat + concert.numberUofCSeat);
            labelAdultSeat.Text = "     Adult ( " + concert.numberAdultSeat + " )";
            labelStudentSeat.Text = "     Student/Senior ( " + concert.numberStudentSeat + " )";
            labelUofCSeat.Text = "     UofC Student ( " + concert.numberUofCSeat + " )";

            //Number of seat selected
            numberSeatSelected = currentConcert.numberSeatReserved;

            updateMaxNumericUpDown_ValueChanged(null, null);

            numericUpDownTypeAdult.Value = currentConcert.numberAdultSeatReserved;
            numericUpDownTypeStudent.Value = currentConcert.numberStudentSeatReserved;
            numericUpDownTypeUofC.Value = currentConcert.numberUofCSeatReserved;
            updateMaxNumericUpDown_ValueChanged(null, null);

            labelNumberSeat.Text = numberSeatSelected.ToString();

            updateBuyTicketsPanel();
        }

        public void clearConcertScreen()
        {
            foreach (Seat seat in currentConcert.seatPurchased)
            {
                seat.checkBox.Checked = false;
                seat.checkBox.AutoCheck = true;
                seat.checkBox.CheckState = CheckState.Unchecked;
                seat.checkBox.FlatStyle = FlatStyle.Standard;
                seat.checkBox.BackColor = Color.White;
                seat.checkBox.ForeColor = Color.White;
            }

            foreach (Seat seat in currentConcert.seatReserved)
            {
                seat.checkBox.Checked = false;
            }
            
            //Number of seat selected
            numberSeatSelected = 0;
            seatSelected = new List<System.Windows.Forms.CheckBox>();

            labelNumberSeat.Text = numberSeatSelected.ToString();
            updateMaxNumericUpDown_ValueChanged(null, null);
            updateBuyTicketsPanel();
        }

        public Concert findAConcert(string name)
        {
            Concert temp = null;
            for (int i=0; i < series.Length; i++ ) 
            {
                temp = series[i].findAConcert(name);
                if ( temp != null ) 
                {
                    return temp;
                }
            }
            return temp;

        }

        public void addPurchasedSeatToTheConcert()
        {
            int numberAdultSeats = (int)numericUpDownTypeAdult.Value;
            int numberStudentSeats = (int)numericUpDownTypeStudent.Value;
            int numberUofCSeats = (int)numericUpDownTypeUofC.Value;
            Seat temp;

            foreach (System.Windows.Forms.CheckBox checkbox in seatSelected)
            {
                if (numberAdultSeats > 0)
                {
                    temp = new Seat(SeatType.Adult,checkbox);
                    numberAdultSeats -= 1;
                    currentConcert.seatPurchased.Add(temp);
                    currentConcert.numberAdultSeat += 1;
                }
                else if (numberStudentSeats > 0)
                {
                    temp = new Seat(SeatType.StudentSenior, checkbox);
                    numberStudentSeats -= 1;
                    currentConcert.seatPurchased.Add(temp);
                    currentConcert.numberStudentSeat += 1;
                }
                else if (numberUofCSeats > 0)
                {
                    temp = new Seat(SeatType.UofCStudent, checkbox);
                    numberUofCSeats -= 1;
                    currentConcert.seatPurchased.Add(temp);
                    currentConcert.numberUofCSeat += 1;
                }
            }

            currentConcert.seatReserved = new List<Seat>();
            currentConcert.numberAdultSeatReserved = 0;
            currentConcert.numberStudentSeatReserved = 0;
            currentConcert.numberUofCSeatReserved = 0;
            currentConcert.numberSeatReserved = 0;

            numberSeatSelected = 0;
            seatSelected = new List<System.Windows.Forms.CheckBox>();
        }

        public void addReservedSeatToTheConcert()
        {
            int numberAdultSeats = (int)numericUpDownTypeAdult.Value;
            int numberStudentSeats = (int)numericUpDownTypeStudent.Value;
            int numberUofCSeats = (int)numericUpDownTypeUofC.Value;
            Seat temp;

            currentConcert.numberSeatReserved = numberSeatSelected;
            currentConcert.numberAdultSeatReserved = numberAdultSeats;
            currentConcert.numberStudentSeatReserved = numberStudentSeats;
            currentConcert.numberUofCSeatReserved = numberUofCSeats;

            foreach (System.Windows.Forms.CheckBox checkbox in seatSelected)
            {
                    temp = new Seat(SeatType.Adult, checkbox);
                    currentConcert.seatReserved.Add(temp);
            }
        }

        public void clearAllSelectedTickets()
        {
            numericUpDownTypeAdult.Value = 0;
            numericUpDownTypeStudent.Value = 0;
            numericUpDownTypeUofC.Value = 0;

            foreach (System.Windows.Forms.CheckBox checkbox in seatSelected)
            {
                checkbox.Checked = false;
            }

            currentConcert.seatReserved = new List<Seat>();
            currentConcert.numberAdultSeatReserved = 0;
            currentConcert.numberStudentSeatReserved = 0;
            currentConcert.numberUofCSeatReserved = 0;
            currentConcert.numberSeatReserved = 0;

            numberSeatSelected = 0;
            seatSelected = new List<System.Windows.Forms.CheckBox>();
            constructConcertScreen();
        }

    }
}
