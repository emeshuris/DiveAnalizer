using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Threading.Tasks;

namespace DiveAnalyzer.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Entities.Dive _dive;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        private async void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            List<Entities.Dive> Dives = (Task<List<Entities.Dive>>.Factory.StartNew(() => DAL.DAL.GetDives())).Result;
            _dive = Dives.FirstOrDefault();

            if (_dive == null)
            {
                return;
            }

            List<Point> pressurePoints = new List<Point>();
            List<Point> depthPoints = new List<Point>();
            List<Point> temperaturePoints = new List<Point>();

            foreach (Entities.DivePoint divePoint in _dive.DivePoints)
            {
                pressurePoints.Add(new Point(divePoint.Time, Convert.ToDouble(divePoint.Pressure)));
                depthPoints.Add(new Point(divePoint.Time, Convert.ToDouble(divePoint.Depth)));
                temperaturePoints.Add(new Point(divePoint.Time, Convert.ToDouble(divePoint.Temperature)));
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
                new CirclePointMarker { Size = 2, Fill = Brushes.Green },
                new PenDescription("Temperature"));
            temperaturePlotter.Viewport.FitToView();
        }
    }
}
