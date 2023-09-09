namespace WatherSys.Models.Bots;

using System;
using System.Collections.Generic;
using WatherSys.Models.Interfaces;

public class SnowBot : IWeatherObserver
{
    public bool? Enabled { get; set; }
    public int? TemperatureThreshold { get; set; }
    public string? Message { get; set; }
    public void Update(WeatherData weatherData)
    {
        if (weatherData.Temperature < TemperatureThreshold)
        {
            Console.WriteLine("SnowBot activated!");
            Console.WriteLine($"SnowBot: \"{Message}\" ");
        }
    }
}

