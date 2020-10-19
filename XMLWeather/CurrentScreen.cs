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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            todayLabel.Text = "Today in " + Form1.days[0].location; // Main Text Initialization
            tempLabel.Text = "It's " + Math.Round(Form1.days[0].currentTemp) + "°C";
            feelsOutput.Text = "But it feels like " + Math.Round(Form1.days[0].feelsLike) + "°C";
            minLabel.Text = "Today's minimum temperature is " + Math.Round(Form1.days[0].tempLow) + "°C";
            maxLabel.Text = "Today's maximum temperature is " + Math.Round(Form1.days[0].tempHigh) + "°C";
            dateLabel.Text = "(" + Form1.days[0].date + ")";

            flavorTextLoad(); // Loading the "flavorTextLabel" text by combining text about the temp with text about the condition

        }

        private void forecastLabel_Click(object sender, EventArgs e) // Switching screens
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void flavorTextLoad()
        {
            flavorTextLabel.Text = "";

            string tempLine, conditionLine;

            // Temperature text
            if (Form1.days[0].feelsLike > 50)
            {
                tempLine = "It's hellish";
                
            }
            else if (Form1.days[0].feelsLike > 35)
            {
                tempLine = "It's scorching";
            }
            else if (Form1.days[0].feelsLike > 23)
            {
                tempLine = "It's hot";
            }
            else if (Form1.days[0].feelsLike > 18)
            {
                tempLine = "It's warm";
            }
            else if (Form1.days[0].feelsLike > 13)
            {
                tempLine = "It's cool";
            }
            else if (Form1.days[0].feelsLike > 5)
            {
                tempLine = "It's chilly";
            }
            else if (Form1.days[0].feelsLike > -10)
            {
                tempLine = "It's cold";
            }
            else if (Form1.days[0].feelsLike > -30)
            {
                tempLine = "It's freezing";
            }
            else
            {
                tempLine = "It's hellish";
            }

            // Condition Text & screen colour
            if (Form1.days[0].condition == 800)
            {
                conditionLine = " and the sky is clear.";
                this.BackColor = Color.LightSkyBlue;
                forecastLabel.ForeColor = Color.LightSkyBlue;
                blackText();
            }
            else if (Form1.days[0].condition > 800)
            {
                conditionLine = " and cloudy.";
                this.BackColor = Color.LightSlateGray;
                forecastLabel.ForeColor = Color.LightSlateGray;
                whiteText();
            }
            else if (Form1.days[0].condition == 741)
            {
                conditionLine = " and it might be foggy.";
                this.BackColor = Color.MediumSeaGreen;
                forecastLabel.ForeColor = Color.MediumSeaGreen;
                whiteText();
            }
            else if (Form1.days[0].condition > 700)
            {
                conditionLine = " and the sky is funky,";
                this.BackColor = Color.Crimson;
                forecastLabel.ForeColor = Color.Crimson;
                whiteText();
            }
            else if (Form1.days[0].condition > 599)
            {
                conditionLine = " and it's snowing.";
                this.BackColor = Color.MediumPurple;
                forecastLabel.ForeColor = Color.MediumPurple;
                whiteText();

            }
            else if (Form1.days[0].condition > 499)
            {
                conditionLine = " and raining.";
                this.BackColor = Color.RoyalBlue;
                forecastLabel.ForeColor = Color.RoyalBlue;
                whiteText();
            }
            else if (Form1.days[0].condition > 299)
            {
                conditionLine = " and it's lightly raining.";
                this.BackColor = Color.DodgerBlue;
                forecastLabel.ForeColor = Color.DodgerBlue;
                whiteText();
            }
            else if (Form1.days[0].condition > 199)
            {
                conditionLine = " and stormy.";
                this.BackColor = Color.Navy;
                forecastLabel.ForeColor = Color.Navy;
                whiteText();
            }
            else
            {
                conditionLine = ".";
                this.BackColor = Color.SeaGreen;
                forecastLabel.ForeColor = Color.SeaGreen;
                whiteText();
            }

            // Combining the temperature and condition text into one line
            flavorTextLabel.Text = tempLine + conditionLine;
        }
        private void whiteText() // Setting text to white
        {
            forecastLabel.BackColor = Color.White;
            todayLabel.ForeColor = Color.White;
            dateLabel.ForeColor = Color.White;
            currentOutput.BackColor = Color.White;
            tempLabel.ForeColor = Color.White;
            feelsOutput.ForeColor = Color.White;
            flavorTextLabel.ForeColor = Color.White;
            maxLabel.ForeColor = Color.White;
            minLabel.ForeColor = Color.White;
        }
        private void blackText() // Setting text to black in case of light background colour
        {
            forecastLabel.BackColor = Color.Black;
            todayLabel.ForeColor = Color.Black;
            dateLabel.ForeColor = Color.Black;
            currentOutput.BackColor = Color.Black;
            tempLabel.ForeColor = Color.Black;
            feelsOutput.ForeColor = Color.Black;
            flavorTextLabel.ForeColor = Color.Black;
            maxLabel.ForeColor = Color.Black;
            minLabel.ForeColor = Color.Black;
        }

    }
}
