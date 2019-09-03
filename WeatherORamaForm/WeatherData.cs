using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeatherORamaForm
{
    public sealed partial class WeatherData : Form, ISubject
    {
        private readonly List<IObserver> _observers;
        private WeatherDataObject _wdo;

        public WeatherData() //Displays the forms on initialization
        {
            InitializeComponent();
            _observers = new List<IObserver>();
            _wdo = new WeatherDataObject();

            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(this);
            ccd.Show();

            ForecastDisplay fcd = new ForecastDisplay(this);
            fcd.Show();

            WeatherStatistics wsf = new WeatherStatistics(this);
            wsf.Show();
        }

        private void TextBoxTempEnter_TextChanged(object sender, EventArgs e) 
        {
            MeasurementsChanged();
        }
        #region moreTextChanged Functions

        private void TextBoxHumidityEnter_TextChanged(object sender, EventArgs e)
        {
            MeasurementsChanged();
        }

        private void TextBoxPressureEnter_TextChanged(object sender, EventArgs e)
        {
            MeasurementsChanged();
        }

        #endregion //Humdity and pressue as well


        public void MeasurementsChanged() //Updates the wdo
        {
            float temp;

            float.TryParse(TextBoxTempEnter.Text, out temp);
            _wdo.Temp = temp;

            float.TryParse(TextBoxHumidityEnter.Text, out temp);
            _wdo.Humidity = temp;

            float.TryParse(TextBoxPressureEnter.Text, out temp);
            _wdo.Pressure = temp;

            NotifyObserver();
        }
        
        public void RegisterObserver(IObserver o) //Adds the observer to the list
        {
            if(! _observers.Contains(o))  _observers.Add(o);
        }

        public void RemoveObserver(IObserver o) //Removes the observer from the list
        {
            if (_observers.Contains(o)) _observers.Remove(o);
        }

        public void NotifyObserver() //Passes the _wdo to all the observers
        {
            foreach (IObserver observer in _observers)    observer.Update(_wdo);
        }
    }
}
