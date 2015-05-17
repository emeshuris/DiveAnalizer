using System;
using UIKit;
using Alliance.Charts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Windows;

namespace DiveAnalyzer.iOS
{
    public partial class RootViewController : UIViewController
    {
        public AllianceChart AllianceChart { get; set; }

        public RootViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            AllianceChart = new AllianceChart(Chart.Line, View);
            createLineChart();

            View.SetNeedsDisplay();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        public void createLineChart()
        {
            //List<Entities.Dive> Dives = new List<Entities.Dive>();
            List<Entities.Dive> Dives = DAL.DAL.GetDives();

            Entities.Dive _dive = Dives.FirstOrDefault();

            if (_dive == null)
            {
                return;
            }

            ChartComponent ChartComponent = new ChartComponent();
            ChartComponent.valueList = new List<float?>();
            foreach (Entities.DivePoint divePoint in _dive.DivePoints)
            {
                AllianceChart.LineChartView.XLabels.Add(divePoint.Time.ToString());
                ChartComponent.valueList.Add((float?)divePoint.Pressure);
            }

            AllianceChart.LineChartView.PopOverTextColor = UIColor.White;
            List<ChartComponent> components = new List<ChartComponent>();

            ChartComponent.Name = "Smith";
            ChartComponent.valueList = new List<float?> { 20f, 10f, 35f, 45f, 69f, 70f };
            ChartComponent.color = UIColor.FromRGB(23f / 255f, 169f / 255f, 227f / 255f);
            ChartComponent.lableColor = UIColor.Black;
            components.Add(ChartComponent);

            AllianceChart.LoadChart(components, Chart.Line, View);

        }
        #endregion
    }
}