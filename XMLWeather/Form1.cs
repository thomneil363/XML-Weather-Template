﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                // create a day object
                Day day = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                day.condition = Convert.ToDouble(reader.GetAttribute("number"));

                reader.ReadToFollowing("windSpeed");
                day.windSpeed = Convert.ToString(reader.GetAttribute("mps"));

                reader.ReadToFollowing("temperature");
                day.tempLow = Convert.ToDouble(reader.GetAttribute("min"));
                day.tempHigh = Convert.ToDouble(reader.GetAttribute("max"));

                days.Add(day);

                //TODO: if day object not null add to the days list
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Convert.ToDouble(value: reader.GetAttribute("value"));
            reader.ReadToFollowing("feels_like");
            days[0].feelsLike = Convert.ToDouble(reader.GetAttribute("value"));

        }


    }
}
