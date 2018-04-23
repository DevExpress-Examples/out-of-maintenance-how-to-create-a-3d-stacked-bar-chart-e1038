using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace _DStackedBarChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl stackedBar3DChart = new ChartControl();

            // Create two series of the StackedBar3D view type.
            Series series1 = new Series("Series 1", ViewType.StackedBar3D);
            Series series2 = new Series("Series 2", ViewType.StackedBar3D);

            // Populate both series with points.
            series1.Points.Add(new SeriesPoint("A", 80));
            series1.Points.Add(new SeriesPoint("B", 20));
            series1.Points.Add(new SeriesPoint("C", 50));
            series1.Points.Add(new SeriesPoint("D", 30));
            series2.Points.Add(new SeriesPoint("A", 40));
            series2.Points.Add(new SeriesPoint("B", 60));
            series2.Points.Add(new SeriesPoint("C", 20));
            series2.Points.Add(new SeriesPoint("D", 80));

            // Add the series to the chart.
            stackedBar3DChart.Series.AddRange(new Series[] {
                series1,
                series2});

            // Adjust the view-type-specific options of the first series.
            StackedBar3DSeriesView myView = (StackedBar3DSeriesView)series1.View;
            myView.BarDepthAuto = false;
            myView.BarDepth = 1.5;
            myView.BarWidth = 1;
            myView.Transparency = 160;
            myView.Model = Bar3DModel.Cylinder;
            myView.ShowFacet = false;

            // Access the diagram's options.
            ((XYDiagram3D)stackedBar3DChart.Diagram).ZoomPercent = 110;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Stacked Bar Chart";
            stackedBar3DChart.Titles.Add(chartTitle1);
            stackedBar3DChart.Legend.Visible = false;

            // Add the chart to the form.
            stackedBar3DChart.Dock = DockStyle.Fill;
            this.Controls.Add(stackedBar3DChart);
        }

    }
}