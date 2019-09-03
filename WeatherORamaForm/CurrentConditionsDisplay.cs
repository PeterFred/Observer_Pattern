using System;
using System.Windows.Forms;

namespace WeatherORamaForm
{
    public partial class CurrentConditionsDisplay : Form, IObserver
    {
        private readonly ISubject _subject;
        private WeatherDataObject _wdo;

        public CurrentConditionsDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;
            _wdo = new WeatherDataObject();
        }

        public void Display()
        {
            LabelTempDisplay.Text = _wdo.Temp.ToString();
            LabelHumidityDisplay.Text = _wdo.Humidity.ToString();
            LabelPressureDisplay.Text = _wdo.Pressure.ToString();
        }

        void IObserver.Update(WeatherDataObject wdo)
        {
            _wdo = wdo;
            _wdo.Temp = wdo.Temp;
            wdo.Humidity = wdo.Humidity;
            wdo.Pressure = wdo.Pressure;
            Display();
        }

        void IObserver.UpdatePull() { }

        private void CurrentConditionsDisplay_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void ButtonDeRegister_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
