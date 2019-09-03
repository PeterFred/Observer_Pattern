using System;
using System.Windows.Forms;

namespace WeatherORamaForm
{
    public partial class WeatherStatistics : Form, IObserver
    {
        private readonly ISubject _subject;
        WeatherDataObject _wdo;
        

        public WeatherStatistics(ISubject s)
        {
            InitializeComponent();
            _subject = s;
            _wdo = new WeatherDataObject();
        }

        public void Display()
        {
            LabelAverageDisplay.Text = _wdo.AvgTemp.ToString();
            LabelMinDisplay.Text = _wdo.AvgTemp.ToString();
            LabelMaxDisplay.Text = _wdo.MaxTemp.ToString();
        }

        void IObserver.Update(WeatherDataObject wdo)
        {
            _wdo = wdo;
            _wdo.Readings++;
            _wdo.SumOfReadings += wdo.Temp;
            _wdo.AvgTemp = wdo.SumOfReadings / wdo.Readings;
            if (_wdo.Temp < wdo.MinTemp) _wdo.MinTemp = _wdo.Temp;
            if (_wdo.Temp > wdo.MaxTemp) _wdo.MaxTemp = _wdo.Temp;
            Display();
            
        }

        void IObserver.UpdatePull(){ }

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
