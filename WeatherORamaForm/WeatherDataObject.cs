using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherORamaForm
{
    //public class WeatherDataObject
    //{
    //    private float _currentPressure;
    //    private float _lastPressure;
    //    private float _temp;
    //    private float _humidity;
    //    private float _pressure;
    //    private static int _readings = 0;
    //    private static float _avgTemp = 0;
    //    private static float _sumOfReadings = 0;

    //    public const float MiniTemp = -100;
    //    public const float MaxiTemp = 100;

    //    private float _minTemp = -10;
    //    private float _maxTemp = 20;

    //    public float CurrentPressure {
    //        get => _currentPressure;
    //        set => _currentPressure = value;
    //    }

    //    public float LastPressure
    //    {
    //        get => _lastPressure;
    //        set => _lastPressure = value;
    //    }

    //    public float Temp
    //    {
    //        get => _temp;
    //        set => _temp = value;
    //    }

    //    public float Humidity
    //    {
    //        get => _humidity;
    //        set => _humidity = value;
    //    }

    //    public float Pressure
    //    {
    //        get => _pressure;
    //        set => _pressure = value;
    //    }

    //    public int Readings
    //    {
    //        get => _readings;
    //        set => _readings = value;
    //    }

    //    public float AvgTemp
    //    {
    //        get => _avgTemp;
    //        set => _avgTemp = value;
    //    }

    //    public float SumOfReadings
    //    {
    //        get => _sumOfReadings;
    //        set => _sumOfReadings = value;
    //    }

    //    public float MinTemp
    //    {
    //        get => _minTemp;
    //        set => _minTemp = value;
    //    }

    //    public float MaxTemp
    //    {
    //        get => _maxTemp;
    //        set => _maxTemp = value;
    //    }


    //}
    public class WeatherDataObject
    {
        private static int _readings = 0;
        private static float _avgTemp = 0;
        private static float _sumOfReadings = 0;

        public float CurrentPressure { get; set; }

        public float LastPressure { get; set; }

        public float Temp { get; set; }

        public float Humidity { get; set; }

        public float Pressure { get; set; }

        public int Readings
        {
            get => _readings;
            set => _readings = value;
        }

        public float AvgTemp
        {
            get => _avgTemp;
            set => _avgTemp = value;
        }

        public float SumOfReadings
        {
            get => _sumOfReadings;
            set => _sumOfReadings = value;
        }

        public float MinTemp { get; set; } = -10;

        public float MaxTemp { get; set; } = 20;
    }
}