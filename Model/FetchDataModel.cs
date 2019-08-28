using ListviewCheckboxEx.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ListviewCheckboxEx.Model
{
    public interface IFetchDataModel
    {
        Task<WeatherForecast[]> RetrieveForecastsAsync(DateTime startDate);
    }

    public class FetchDataModel : IFetchDataModel
    {
        public async Task<WeatherForecast[]> RetrieveForecastsAsync(DateTime startDate)
        {
            string[] Summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var rng = new Random();
            return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}