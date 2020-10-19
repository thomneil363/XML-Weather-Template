using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public int condition = Convert.ToInt32(Form1.days[0].condition); // int representing daily condition for expanded view
        public ForecastScreen()
        {
            InitializeComponent(); // Main Initialization
            displayForecast(); // Displaying the main daily forecast view
            screenColour(); // Changing the colour of the screen and text by today's weather
            loadIcon(condition); // Loading an icon to match the condition of the day being tested
        }

        public void displayForecast()
        {
            forecastLabel.Text = "This week in " + Form1.days[0].location; // Main forecast text
            date1.Text = Form1.days[0].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[0].tempHigh + Form1.days[0].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[0].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[0].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[0].windSpeed + " m/s"; 

            // Initializing the average temperature for the next 6 days of the week
            date2.Text = Form1.days[1].date + " = " + Convert.ToString(Math.Round((Form1.days[1].tempHigh + Form1.days[1].tempLow) / 2)) + "°C";
            date3.Text = Form1.days[2].date + " = " + Convert.ToString(Math.Round((Form1.days[2].tempHigh + Form1.days[2].tempLow) / 2)) + "°C";
            date4.Text = Form1.days[3].date + " = " + Convert.ToString(Math.Round((Form1.days[3].tempHigh + Form1.days[3].tempLow) / 2)) + "°C";
            date5.Text = Form1.days[4].date + " = " + Convert.ToString(Math.Round((Form1.days[4].tempHigh + Form1.days[4].tempLow) / 2)) + "°C";
            date6.Text = Form1.days[5].date + " = " + Convert.ToString(Math.Round((Form1.days[5].tempHigh + Form1.days[5].tempLow) / 2)) + "°C";
            date7.Text = Form1.days[6].date + " = " + Convert.ToString(Math.Round((Form1.days[6].tempHigh + Form1.days[6].tempLow) / 2)) + "°C";
        }

        private void forecastLabel2_Click(object sender, EventArgs e) // Switching screens when the forecast label is clicked
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void Date2_Click(object sender, EventArgs e) // Day #2 Text loading
        {
            date1.Text = Form1.days[1].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[1].tempHigh + Form1.days[1].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[1].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[1].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[1].windSpeed + " m/s";
            condition = Convert.ToInt32(Form1.days[1].condition);
            loadIcon(condition);
        }

        private void Date3_Click(object sender, EventArgs e) // Day #3 Text loading
        {
            date1.Text = Form1.days[2].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[2].tempHigh + Form1.days[2].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[2].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[2].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[2].windSpeed + " m/s";
            condition = Convert.ToInt32(Form1.days[2].condition);
            loadIcon(condition);
        }

        private void Date4_Click(object sender, EventArgs e) // Day #4 Text loading
        {
            date1.Text = Form1.days[3].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[3].tempHigh + Form1.days[3].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[3].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[3].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[3].windSpeed + " m/s";
            condition = Convert.ToInt32(Form1.days[3].condition);
            loadIcon(condition);
        }

        private void Date5_Click(object sender, EventArgs e) // Day #5 Text loading
        {
            date1.Text = Form1.days[4].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[4].tempHigh + Form1.days[4].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[4].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[4].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[4].windSpeed + " m/s";
            condition = Convert.ToInt32(Form1.days[4].condition);
            loadIcon(condition);
        }

        private void Date6_Click(object sender, EventArgs e) // Day #6 Text loading
        {
            date1.Text = Form1.days[5].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[5].tempHigh + Form1.days[5].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[5].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[5].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[5].windSpeed + " m/s";
            condition = Convert.ToInt32(Form1.days[5].condition);
            loadIcon(condition);
        }

        private void Date7_Click(object sender, EventArgs e) // Day #7 Text loading
        {
            date1.Text = Form1.days[6].date;
            avgLabel.Text = " Average Temperature = " + Convert.ToString(Math.Round((Form1.days[6].tempHigh + Form1.days[6].tempLow) / 2)) + "°C";
            minLabel.Text = "Min Temperature = " + Convert.ToString(Math.Round(Form1.days[6].tempLow)) + "°C";
            maxLabel.Text = "Max Temperature = " + Convert.ToString(Math.Round(Form1.days[6].tempHigh)) + "°C";
            windLabel.Text = "Wind Speed = " + Form1.days[6].windSpeed + " m/s";
            condition = Convert.ToInt32(Form1.days[6].condition);
            loadIcon(condition);
        }

        private void loadIcon(int condition) // Check conditions per weekday for icon
        {
            if (condition == 800) // Clear Sky
            {
                pictureBox1.BackgroundImage = Properties.Resources.day1;
            }
            else if (condition == 801) // Cloudy
            {
                pictureBox1.BackgroundImage = Properties.Resources.day2;
            }
            else if (condition == 802) // Cloudy
            {
                pictureBox1.BackgroundImage = Properties.Resources.day3;
            }
            else if (condition > 802) // Cloudy
            {
                pictureBox1.BackgroundImage = Properties.Resources.day4;
            }
            else if (condition > 699) // Fog
            {
                pictureBox1.BackgroundImage = Properties.Resources.day50;
            }
            else if (condition > 599) // Snow
            {
                pictureBox1.BackgroundImage = Properties.Resources.day13;
            }
            else if (condition > 510) // Heavy Rain
            {
                pictureBox1.BackgroundImage = Properties.Resources.day9;
            }
            else if (condition > 499) // Rain
            {
                pictureBox1.BackgroundImage = Properties.Resources.day10;
            }
            else if (condition > 299) // Drizzle
            {
                pictureBox1.BackgroundImage = Properties.Resources.day9;
            }
            else if (condition > 199) // Thunderstorm
            {
                pictureBox1.BackgroundImage = Properties.Resources.day11;
            }
            else // Default
            {
                pictureBox1.BackgroundImage = Properties.Resources.day2;
            }

            pictureBox1.Refresh();
            pictureBox1.Visible = true;
        }

        private void screenColour() // Check conditions for today and set screen colour
        {
            // Condition Text & screen colour
            if (Form1.days[0].condition == 800)
            {
                LightSkyBlue();
            }
            else if (Form1.days[0].condition > 800)
            {
                LightSlateGray();
            }
            else if (Form1.days[0].condition == 741)
            {
                MediumSeaGreen();
            }
            else if (Form1.days[0].condition > 700)
            {
                Crimson();
            }
            else if (Form1.days[0].condition > 599)
            {
               /*What if it was*/ MediumPurple();
            }
            else if (Form1.days[0].condition > 499)
            {
                RoyalBlue();
            }
            else if (Form1.days[0].condition > 299)
            {
                DodgerBlue();
            }
            else if (Form1.days[0].condition > 199)
            {
                Navy();
            }
            else
            {
                SeaGreen();
            }
        }

        private void LightSkyBlue() // Changing screen colours to light sky blue
        {
            this.BackColor = Color.LightSkyBlue;
            forecastLabel2.ForeColor = Color.LightSkyBlue;
            date1.ForeColor = Color.LightSkyBlue;
            windLabel.ForeColor = Color.LightSkyBlue;
            maxLabel.ForeColor = Color.LightSkyBlue;
            minLabel.ForeColor = Color.LightSkyBlue;
            avgLabel.ForeColor = Color.LightSkyBlue;
            pictureBox1.BackColor = Color.LightSkyBlue;
            date2.ForeColor = Color.LightSkyBlue;
            date3.ForeColor = Color.LightSkyBlue;
            date4.ForeColor = Color.LightSkyBlue;
            date5.ForeColor = Color.LightSkyBlue;
            date6.ForeColor = Color.LightSkyBlue;
            date7.ForeColor = Color.LightSkyBlue;
        }
        private void LightSlateGray() // Changing screen colours to light gray
        {
            this.BackColor = Color.LightSlateGray;
            forecastLabel2.ForeColor = Color.LightSlateGray;
            date1.ForeColor = Color.LightSlateGray;
            windLabel.ForeColor = Color.LightSlateGray;
            maxLabel.ForeColor = Color.LightSlateGray;
            minLabel.ForeColor = Color.LightSlateGray;
            avgLabel.ForeColor = Color.LightSlateGray;
            pictureBox1.BackColor = Color.LightSlateGray;
            date2.ForeColor = Color.LightSlateGray;
            date3.ForeColor = Color.LightSlateGray;
            date4.ForeColor = Color.LightSlateGray;
            date5.ForeColor = Color.LightSlateGray;
            date6.ForeColor = Color.LightSlateGray;
            date7.ForeColor = Color.LightSlateGray;
        }
        private void MediumSeaGreen()  // Changing screen colours to light green
        {
            this.BackColor = Color.MediumSeaGreen;
            forecastLabel2.ForeColor = Color.MediumSeaGreen;
            date1.ForeColor = Color.MediumSeaGreen;
            windLabel.ForeColor = Color.MediumSeaGreen;
            maxLabel.ForeColor = Color.MediumSeaGreen;
            minLabel.ForeColor = Color.MediumSeaGreen;
            avgLabel.ForeColor = Color.MediumSeaGreen;
            pictureBox1.BackColor = Color.MediumSeaGreen;
            date2.ForeColor = Color.MediumSeaGreen;
            date3.ForeColor = Color.MediumSeaGreen;
            date4.ForeColor = Color.MediumSeaGreen;
            date5.ForeColor = Color.MediumSeaGreen;
            date6.ForeColor = Color.MediumSeaGreen;
            date7.ForeColor = Color.MediumSeaGreen;
        }
        private void Crimson()  // Changing screen colours to red
        {
            this.BackColor = Color.Crimson;
            forecastLabel2.ForeColor = Color.Crimson;
            date1.ForeColor = Color.Crimson;
            windLabel.ForeColor = Color.Crimson;
            maxLabel.ForeColor = Color.Crimson;
            minLabel.ForeColor = Color.Crimson;
            avgLabel.ForeColor = Color.Crimson;
            pictureBox1.BackColor = Color.Crimson;
            date2.ForeColor = Color.Crimson;
            date3.ForeColor = Color.Crimson;
            date4.ForeColor = Color.Crimson;
            date5.ForeColor = Color.Crimson;
            date6.ForeColor = Color.Crimson;
            date7.ForeColor = Color.Crimson;
        }
        private void MediumPurple() // Changing screen colours to purple
        {
            this.BackColor = Color.MediumPurple;
            forecastLabel2.ForeColor = Color.MediumPurple;
            date1.ForeColor = Color.MediumPurple;
            windLabel.ForeColor = Color.MediumPurple;
            maxLabel.ForeColor = Color.MediumPurple;
            minLabel.ForeColor = Color.MediumPurple;
            avgLabel.ForeColor = Color.MediumPurple;
            pictureBox1.BackColor = Color.MediumPurple;
            date2.ForeColor = Color.MediumPurple;
            date3.ForeColor = Color.MediumPurple;
            date4.ForeColor = Color.MediumPurple;
            date5.ForeColor = Color.MediumPurple;
            date6.ForeColor = Color.MediumPurple;
            date7.ForeColor = Color.MediumPurple;
        }
        private void RoyalBlue()  // Changing screen colours to blue
        {
            this.BackColor = Color.RoyalBlue;
            forecastLabel2.ForeColor = Color.RoyalBlue;
            date1.ForeColor = Color.RoyalBlue;
            windLabel.ForeColor = Color.RoyalBlue;
            maxLabel.ForeColor = Color.RoyalBlue;
            minLabel.ForeColor = Color.RoyalBlue;
            avgLabel.ForeColor = Color.RoyalBlue;
            pictureBox1.BackColor = Color.RoyalBlue;
            date2.ForeColor = Color.RoyalBlue;
            date3.ForeColor = Color.RoyalBlue;
            date4.ForeColor = Color.RoyalBlue;
            date5.ForeColor = Color.RoyalBlue;
            date6.ForeColor = Color.RoyalBlue;
            date7.ForeColor = Color.RoyalBlue;
        }
        private void DodgerBlue()  // Changing screen colours to a different blue
        {
            this.BackColor = Color.DodgerBlue;
            forecastLabel2.ForeColor = Color.DodgerBlue;
            date1.ForeColor = Color.DodgerBlue;
            windLabel.ForeColor = Color.DodgerBlue;
            maxLabel.ForeColor = Color.DodgerBlue;
            minLabel.ForeColor = Color.DodgerBlue;
            avgLabel.ForeColor = Color.DodgerBlue;
            pictureBox1.BackColor = Color.DodgerBlue;
            date2.ForeColor = Color.DodgerBlue;
            date3.ForeColor = Color.DodgerBlue;
            date4.ForeColor = Color.DodgerBlue;
            date5.ForeColor = Color.DodgerBlue;
            date6.ForeColor = Color.DodgerBlue;
            date7.ForeColor = Color.DodgerBlue;
        }
        private void Navy() // Changing screen colours to navy
        {
            this.BackColor = Color.Navy;
            forecastLabel2.ForeColor = Color.Navy;
            date1.ForeColor = Color.Navy;
            windLabel.ForeColor = Color.Navy;
            maxLabel.ForeColor = Color.Navy;
            minLabel.ForeColor = Color.Navy;
            avgLabel.ForeColor = Color.Navy;
            pictureBox1.BackColor = Color.Navy;
            date2.ForeColor = Color.Navy;
            date3.ForeColor = Color.Navy;
            date4.ForeColor = Color.Navy;
            date5.ForeColor = Color.Navy;
            date6.ForeColor = Color.Navy;
            date7.ForeColor = Color.Navy;
        }
        private void SeaGreen()  // Changing screen colours to green
        {
            this.BackColor = Color.SeaGreen;
            forecastLabel2.ForeColor = Color.SeaGreen;
            date1.ForeColor = Color.SeaGreen;
            windLabel.ForeColor = Color.SeaGreen;
            maxLabel.ForeColor = Color.SeaGreen;
            minLabel.ForeColor = Color.SeaGreen;
            avgLabel.ForeColor = Color.SeaGreen;
            pictureBox1.BackColor = Color.SeaGreen;
            date2.ForeColor = Color.SeaGreen;
            date3.ForeColor = Color.SeaGreen;
            date4.ForeColor = Color.SeaGreen;
            date5.ForeColor = Color.SeaGreen;
            date6.ForeColor = Color.SeaGreen;
            date7.ForeColor = Color.SeaGreen;
        }
    }
}
