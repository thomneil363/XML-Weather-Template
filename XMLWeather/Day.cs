using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public double currentTemp, currentTempF, tempHigh, tempHighF, tempLow, tempLowF, feelsLike, condition;
        public string date, currentTime, location, windSpeed, windDirection, precipitation, visibility;

        public Day()
        {
            date = currentTime = location = windSpeed = windDirection = precipitation = visibility = "";
            currentTemp = currentTempF = tempHigh = tempHighF = tempLow = tempLowF = feelsLike = condition = 0;
        }
    }
}
