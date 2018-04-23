Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace _DStackedBarChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create a new chart.
            Dim stackedBar3DChart As New ChartControl()

            ' Create two series of the StackedBar3D view type.
            Dim series1 As New Series("Series 1", ViewType.StackedBar3D)
            Dim series2 As New Series("Series 2", ViewType.StackedBar3D)

            ' Populate both series with points.
            series1.Points.Add(New SeriesPoint("A", 80))
            series1.Points.Add(New SeriesPoint("B", 20))
            series1.Points.Add(New SeriesPoint("C", 50))
            series1.Points.Add(New SeriesPoint("D", 30))
            series2.Points.Add(New SeriesPoint("A", 40))
            series2.Points.Add(New SeriesPoint("B", 60))
            series2.Points.Add(New SeriesPoint("C", 20))
            series2.Points.Add(New SeriesPoint("D", 80))

            ' Add the series to the chart.
            stackedBar3DChart.Series.AddRange(New Series() {series1, series2})

            ' Adjust the view-type-specific options of the first series.
            Dim myView As StackedBar3DSeriesView = CType(series1.View, StackedBar3DSeriesView)
            myView.BarDepthAuto = False
            myView.BarDepth = 1.5
            myView.BarWidth = 1
            myView.Transparency = 160
            myView.Model = Bar3DModel.Cylinder
            myView.ShowFacet = False

            ' Access the diagram's options.
            CType(stackedBar3DChart.Diagram, XYDiagram3D).ZoomPercent = 110

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Stacked Bar Chart"
            stackedBar3DChart.Titles.Add(chartTitle1)
            stackedBar3DChart.Legend.Visible = False

            ' Add the chart to the form.
            stackedBar3DChart.Dock = DockStyle.Fill
            Me.Controls.Add(stackedBar3DChart)
        End Sub

	End Class
End Namespace