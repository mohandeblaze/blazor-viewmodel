using ListviewCheckboxEx.Data;
using ListviewCheckboxEx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListviewCheckboxEx.ViewModels
{
    public interface IFetchDataViewModel
    {
        WeatherForecast[] WeatherForecasts { get; set; }
        Task RetrieveForecastsAsync();

    }
    public class FetchDataViewModel : IFetchDataViewModel
    {
        private IFetchDataModel _fetchDataModel;
        public WeatherForecast[] WeatherForecasts { get; set; }
        public FetchDataViewModel(IFetchDataModel fetchDataModel)
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
            _fetchDataModel = fetchDataModel;
        }

        public async Task RetrieveForecastsAsync()
        {
            WeatherForecasts = await _fetchDataModel.RetrieveForecastsAsync(DateTime.Now);
            Console.WriteLine("FetchDataViewModel Forecasts Retrieved");
        }
    }
}
