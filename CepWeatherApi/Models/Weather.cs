﻿using System.Text.Json.Serialization;

namespace CepWeatherApi.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Weather()
        {

        }
        public Weather(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}
