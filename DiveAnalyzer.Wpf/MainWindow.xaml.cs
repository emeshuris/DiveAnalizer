using DiveAnalizer.Loader;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace DiveAnalyzer.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            List<dives> Dives = Loader.ReadFiles();
            dives dive = Dives.FirstOrDefault();
            if (dive == null)
            {
                return;
            }

            var sampleTimes = (from s in dive.dive.samples select s.time).ToList();
            var samplePressure = (from s in dive.dive.samples select Convert.ToInt32(s.pressure)).ToList();
            var sampleDepth = (from s in dive.dive.samples select Convert.ToInt32(s.depth)).ToList();
            var sampleTemperature = (from s in dive.dive.samples select Convert.ToInt32(s.temperature)).ToList();

            List<Point> pressurePoints = new List<Point>();
            List<Point> depthPoints = new List<Point>();
            List<Point> temperaturePoints = new List<Point>();

            for (int i = 0; i < samplePressure.Count - 1; i++)
            {
                pressurePoints.Add(new Point(sampleTimes[i], samplePressure[i]));
            }

            for (int i = 0; i < samplePressure.Count - 1; i++)
            {
                depthPoints.Add(new Point(sampleTimes[i], sampleDepth[i] * -1));
            }

            for(int i = 0; i < samplePressure.Count -1; i++)
            {
                temperaturePoints.Add(new Point(sampleTimes[i], sampleTemperature[i]));
            }

            EnumerableDataSource<Point> pressurePointDataSource = new EnumerableDataSource<Point>(pressurePoints);
            pressurePointDataSource.SetXYMapping(p => p);
            CompositeDataSource pressureDataSource = new CompositeDataSource(pressurePointDataSource);

            EnumerableDataSource<Point> depthPointDataSource = new EnumerableDataSource<Point>(depthPoints);
            depthPointDataSource.SetXYMapping(p => p);
            CompositeDataSource depthDataSource = new CompositeDataSource(depthPointDataSource);

            EnumerableDataSource<Point> temperaturePointDataSource = new EnumerableDataSource<Point>(temperaturePoints);
            temperaturePointDataSource.SetXYMapping(p => p);
            CompositeDataSource temperatureDataSource = new CompositeDataSource(temperaturePointDataSource);

            pressurePlotter.AddLineGraph(pressureDataSource,
                new Pen(Brushes.Blue, 2),
                new CirclePointMarker { Size = 2, Fill = Brushes.Red },
                new PenDescription("Pressure"));
            pressurePlotter.Viewport.FitToView();

            depthPlotter.AddLineGraph(depthDataSource,
                new Pen(Brushes.Green, 2),
                new CirclePointMarker { Size = 2, Fill = Brushes.Yellow },
                new PenDescription("Depth"));
            depthPlotter.Viewport.FitToView();

            temperaturePlotter.AddLineGraph(temperatureDataSource,
                new Pen(Brushes.Fuchsia, 2),
                new CirclePointMarker { Size = 2, Fill = Brushes.Yellow },
                new PenDescription("Temperature"));
            temperaturePlotter.Viewport.FitToView();
        }
    }
}
