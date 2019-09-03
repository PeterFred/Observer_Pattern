using System;
using System.Windows.Forms;

namespace WeatherORamaForm
{
    public partial class ForecastDisplay : Form, IObserver
    {
        private ISubject _subject;
        private WeatherDataObject _wdo;

        public ForecastDisplay(ISubject s)
        {
            InitializeComponent();
            this._subject = s;
            _wdo = new WeatherDataObject();
        }

        public void Display()
        {
            if (_wdo.CurrentPressure > _wdo.LastPressure)
                LabelExpectedDisplay.Text = "Improving weather on the way!";
            
            else if (_wdo.CurrentPressure == _wdo.LastPressure)
                LabelExpectedDisplay.Text = "More of the same";
            
            else if (_wdo.CurrentPressure < _wdo.LastPressure)
                LabelExpectedDisplay.Text = "Watch out for cooler, rainy weather";          
        }

        void IObserver.Update(WeatherDataObject wdo)
        {
            _wdo = wdo;
            _wdo.LastPressure = wdo.CurrentPressure;
            _wdo.CurrentPressure = wdo.Pressure;
            Display();
        }

        void IObserver.UpdatePull() { }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
