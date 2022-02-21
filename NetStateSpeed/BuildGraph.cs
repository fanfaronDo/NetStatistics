using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;


namespace NetStateSpeed
{
    class BuildGraph
    {
        
        public void BuildGraphSpeed(List<double> msrSpeedDown, List<double> msrSpeedUp, LiveCharts.WinForms.CartesianChart cartesianChart1)
        {
            cartesianChart1.Series.Clear();

            SeriesCollection series = new SeriesCollection();

          

            var xvals = new List<DateTime>();

            series.Add(new LineSeries
            {
                Title = " download ",
                Values = new ChartValues<double>(msrSpeedDown)
            });

            series.Add(new LineSeries
            { 
                Title = " upload ",
                Values = new ChartValues<double>(msrSpeedUp)
            });
            cartesianChart1.Series = series;
        }

    }
}
