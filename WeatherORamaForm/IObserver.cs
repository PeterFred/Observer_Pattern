namespace WeatherORamaForm
{
    public interface IObserver
    {
        void Update(WeatherDataObject weatherDataObject);
        void UpdatePull();
    }
}