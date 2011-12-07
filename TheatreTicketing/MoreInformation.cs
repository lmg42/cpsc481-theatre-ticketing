using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheatreTicketing
{
    public partial class MoreInformation : Form
    {
        public MoreInformation()
        {
            InitializeComponent();
        }

        public void updateMoreInfo(string serie, Concert concert)
        {
            labelSeries.Text = serie;
            labelConcert.Text = concert.name;
            labelDate.Text = concert.date;
            labelTime.Text = concert.time;
            textBox1.Text = concert.otherInfos;
            pictureBoxConcert.Image = concert.image;
        }
    }


}
