using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6_Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fourDayImage_CheckedChanged(object sender, EventArgs e)
        {
            if(fourDayImage.Checked == true)
            {
                 
            }
        }

        private void forecastArea_TextChanged(object sender, EventArgs e)
        {
            String location = forecastArea.Text;

            forecastLocationText.Text = location;

            
        }

        private void createForecastImageButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            forecastLocationText.Parent = workInProgressDisplayImage;
            forecastLocationText.BackColor = Color.Transparent; 

            dayOne.Parent = workInProgressDisplayImage;
            dayOne.BackColor = Color.Transparent;

            dayTwo.Parent = workInProgressDisplayImage;
            dayTwo.BackColor = Color.Transparent;

            dayThree.Parent = workInProgressDisplayImage;
            dayThree.BackColor = Color.Transparent;

            dayFour.Parent = workInProgressDisplayImage;
            dayFive.BackColor = Color.Transparent;

            dayFive.Parent = workInProgressDisplayImage;
            dayFive.BackColor= Color.Transparent;

            dayOneHighTemp.Parent = workInProgressDisplayImage;
            dayOneHighTemp.BackColor = Color.Transparent;

            dayTwoHighTemp.Parent= workInProgressDisplayImage;
            dayTwoHighTemp.BackColor= Color.Transparent;

            dayOnePictureBox.Parent = workInProgressDisplayImage;
            dayOnePictureBox.BackColor = Color.Transparent;

        }

        private void forecastStartMon_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Monday";
            dayTwo.Text = "Tuesday";
            dayThree.Text = "Wednesday";
            dayFour.Text = "Thursday";
            dayFive.Text = "Friday";
        }

        private void forecastStartTues_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Tuesday";
            dayTwo.Text = "Wednesday";
            dayThree.Text = "Thursday";
            dayFour.Text = "Friday";
            dayFive.Text = "Saturday";
        }

        private void forecastStartWed_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Wednesday";
            dayTwo.Text = "Thursday";
            dayThree.Text = "Friday";
            dayFour.Text = "Saturday";
            dayFive.Text = "Sunday";
        }

        private void forecastStartThur_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Thursday";
            dayTwo.Text = "Friday";
            dayThree.Text = "Saturday";
            dayFour.Text = "Sunday";
            dayFive.Text = "Monday";
        }

        private void forecastStartFriday_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Friday";
            dayTwo.Text = "Saturday";
            dayThree.Text = "Sunday";
            dayFour.Text = "Monday";
            dayFive.Text = "Tuesday";
        }

        private void forecastStartSat_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Saturday";
            dayTwo.Text = "Sunday";
            dayThree.Text = "Monday";
            dayFour.Text = "Tuesday";
            dayFive.Text = "Wednesday";
        }

        private void forecastStartSun_CheckedChanged(object sender, EventArgs e)
        {
            dayOne.Text = "Sunday";
            dayTwo.Text = "Monday";
            dayThree.Text = "Tuesday";
            dayFour.Text = "Wednesday";
            dayFive.Text = "Thursday";
        }

        private void highTempsMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayOneHighTemp.Text = highTempsMonday.SelectedItem.ToString();
        }

        private void highTempsTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayTwoHighTemp.Text = highTempsTuesday.SelectedItem.ToString();
        }

        private void weatherConditionsSelectionMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayOnePictureBox.Image = weatherConditionsList.Images[0];
        }
    }
}
