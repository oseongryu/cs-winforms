using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using System.Globalization;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class MyChartControl05 : UserControl
    {
        DateTimeFormatInfo m_dfiInfo = CultureInfo.CurrentCulture.DateTimeFormat;
        private BackgroundWorker worker = null;
        delegate void SetTimerDelegate(string text);
        Random r = new Random();
        Random r2 = new Random();
        Random r3 = new Random();
        int a = 25;
        Series series1 = new Series("Series 1", ViewType.Point);
        private int[] arrCount = { 23, 30, 25, 22, 1, 39, 23, 8 };

        public MyChartControl05()
        {
            InitializeComponent();
            MakeFullStackedBar();
            //MakePieChartLeft();
            //MakePieChartRight();
            MakeDoughnutChartLeft();
            MakeDoughnutChartRight();
            this.chartControl2.CustomDrawSeriesPoint += ChartControl2_CustomDrawSeriesPoint;
            MakeTimer();



            MakePointChart();
            this.simpleButton1.Click += SimpleButton1_Click;

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Random r3 = new Random();
            series1.Points.Add(new SeriesPoint(10, 10 + r3.Next(-1, 1)));
            chartControl4.Series.Add(series1);
        }

        private void MakePointChart()
        {
            // https://documentation.devexpress.com/WindowsForms/2975/Controls-and-Libraries/Chart-Control/Fundamentals/Series-Views/2D-Series-Views/Point-and-Line-Series-Views/Point-Chart
            // Create a point series. 

            // Set the numerical argument scale type for the series, 
            // as it is qualitative, by default. 
            series1.ArgumentScaleType = ScaleType.Numerical;

            // Add points to it. 

            for (int x = 1; x < 25; x++)
            {
                series1.Points.Add(new SeriesPoint(x, 10 +r2.Next(-1, 1)));

            }

            // Add the series to the chart. 
            chartControl4.Series.Add(series1);

            // Access the view-type-specific options of the series. 
            PointSeriesView myView1 = (PointSeriesView)series1.View;
            myView1.PointMarkerOptions.Kind = MarkerKind.Circle;
            myView1.PointMarkerOptions.StarPointCount = 20;
            myView1.PointMarkerOptions.Size = 3;

            // Access the type-specific options of the diagram. 
            ((XYDiagram)chartControl4.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary). 
            chartControl4.Legend.Visible = false;

            // Add a title to the chart (if necessary). 
            chartControl4.Titles.Add(new ChartTitle());
            chartControl4.Titles[0].Text = "";

        }
        private void MakeDoughnutChartLeft()
        {
            // https://documentation.devexpress.com/WindowsForms/3420/Controls-and-Libraries/Chart-Control/Fundamentals/Series-Views/2D-Series-Views/Pie-and-Donut-Series-Views/Doughnut-Chart
            // Create a doughnut series. 
            Series series1 = new Series("Series 1", ViewType.Doughnut);

            // Populate the series with points. 
            series1.Points.Add(new SeriesPoint("가동", 61));
            series1.Points.Add(new SeriesPoint("비가동", 39));
            // Add the series to the chart. 
            chartControl2.Series.Add(series1);

            // Specify the text pattern of series labels. 
            series1.Label.TextPattern = "{A}: {VP:P0}";

            // Specify how series points are sorted. 
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

            // Specify the behavior of series labels. 
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

            // Adjust the view-type-specific options of the series. 
            ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 1;

            // Access the diagram's options. 
            ((SimpleDiagram)chartControl2.Diagram).Dimension = 2;

            // Add a title to the chart and hide the legend. 
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "24시간";
            chartControl2.Titles.Add(chartTitle1);
            chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }
        private void MakeDoughnutChartRight()
        {
            // https://documentation.devexpress.com/WindowsForms/3420/Controls-and-Libraries/Chart-Control/Fundamentals/Series-Views/2D-Series-Views/Pie-and-Donut-Series-Views/Doughnut-Chart
            // Create a doughnut series. 
            Series series1 = new Series("Series 1", ViewType.Doughnut);

            // Populate the series with points. 
            series1.Points.Add(new SeriesPoint("가동", 65));
            series1.Points.Add(new SeriesPoint("비가동", 33));
            series1.Points.Add(new SeriesPoint("기타", 2));
            // Add the series to the chart. 
            chartControl3.Series.Add(series1);

            // Specify the text pattern of series labels. 
            series1.Label.TextPattern = "{A}: {VP:P0}";

            // Specify how series points are sorted. 
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

            // Specify the behavior of series labels. 
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

            // Adjust the view-type-specific options of the series. 
            ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 1;

            // Access the diagram's options. 
            ((SimpleDiagram)chartControl2.Diagram).Dimension = 2;

            // Add a title to the chart and hide the legend. 
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "7 일";
            chartControl3.Titles.Add(chartTitle1);
            chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }
        private void MakePieChartLeft()
        {
            Series series1 = new Series("24시간", ViewType.Pie);
            series1.Points.Add(new SeriesPoint("가동", 61));
            series1.Points.Add(new SeriesPoint("비가동", 39));
            chartControl2.Series.Add(series1);
            series1.Label.TextPattern = "{A}: {VP:p0}";
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            PieSeriesView myView = (PieSeriesView)series1.View;
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = series1.Name;
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"));
            chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }
        private void MakePieChartRight()
        {
            Series series1 = new Series("7일", ViewType.Pie);
            series1.Points.Add(new SeriesPoint("가동", 65));
            series1.Points.Add(new SeriesPoint("비가동", 33));
            series1.Points.Add(new SeriesPoint("기타", 2));
            chartControl3.Series.Add(series1);
            series1.Label.TextPattern = "{A}: {VP:p0}";
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            PieSeriesView myView = (PieSeriesView)series1.View;
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = series1.Name;
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument, DataFilterCondition.NotEqual, "Others"));
            chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
        }

        // MakeFullStackedBar
        private void MakeFullStackedBar()
        {
            var series = new Series();
            series.ArgumentScaleType = ScaleType.Auto;
            series.LabelsVisibility = DefaultBoolean.True;
            chartControl1.Series.Add(series);

            //Size = new Size(1006, 1005);
            //CreateSeries(15, 15, 15);
            //CreateSeries(7, 7, 7);
            //CreateSeries(5, 5, 5);

            CreateSeries2();
        }
        private void CreateSeries2()
        {
            var series = new Series("", ViewType.StackedBar);
            for (int x = 0; x < arrCount.Length; x++)
            {
                series.Points.Add(new SeriesPoint(DateTime.Now.AddDays(x).ToString("MM-dd"), arrCount[x]));
            }
            series.LabelsVisibility = DefaultBoolean.True;
            series.Label.TextPattern = "{V}";
            chartControl1.Series.Add(series);
        }

        private void MakeTimer()
        {
            //this.labelControl6.Text = DateTime.Now.ToString(m_dfiInfo);
            this.labelControl6.Text = DateTime.Now.ToString("02:mm:ss");
            this.labelControl8.Text = DateTime.Now.ToString("00:08:30");

            // https://documentation.devexpress.com/WindowsForms/18237/Controls-and-Libraries/Gauges/Concepts/Appearance-Customization/Color-Schemes
            this.labelComponent1.Text = "2000";
            this.labelControl11.Text = "20";
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void SetTimer(string text)
        {
            this.labelControl6.Text = text;
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            DateTime dateTimeStop = DateTime.Now;
            if (this.labelControl6.InvokeRequired)
            {
                SetTimerDelegate setTimer = new SetTimerDelegate(SetTimer);
                //this.Invoke(setTimer, DateTime.Now.ToString(m_dfiInfo));
                this.Invoke(setTimer, DateTime.Now.ToString("02:mm:ss"));

            }
            else
            {
                //this.labelControl6.Text = DateTime.Now.ToString(m_dfiInfo);
                this.labelControl6.Text = DateTime.Now.ToString("02:mm:ss");
            }
            TimeSpan timeDiff = DateTime.Now - dateTimeStop;
            int waiting = (int)(300 - (timeDiff.TotalMilliseconds % 1000));
            System.Threading.Thread.Sleep(waiting);
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            worker.RunWorkerAsync();
            a += 1;
            series1.Points.Add(new SeriesPoint(a, 10 + r3.Next(-5, 5)));
            chartControl4.Series.Add(series1);
            
            int b = Convert.ToInt32(this.labelComponent1.Text.ToString());
            this.labelComponent1.Text = Convert.ToString(b + r.Next(-50, 50));
            int c = Convert.ToInt32(this.labelControl11.Text.ToString());
            this.labelControl11.Text = Convert.ToString(c + r.Next(-1, 2));
        }

        private void ChartControl2_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            //e.LabelText = "Yes";
        }

        //private void worker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //}
        //private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //}
        //private void RunTimer(int milisec)
        //{
        //    try
        //    {
        //        if (worker.IsBusy)
        //        {
        //            return;
        //        }
        //        worker.RunWorkerAsync(milisec);
        //    }
        //    catch (Exception ex) { }
        //}

        //private void CreateSeries(int yes, int no, int never)
        //{
        //    var series = new Series("series1", ViewType.StackedBar);
        //    series.Points.Add(new SeriesPoint("Yes", yes));
        //    series.Points.Add(new SeriesPoint("No", no));
        //    series.Points.Add(new SeriesPoint("Never", never));
        //    series.LabelsVisibility = DefaultBoolean.True;
        //    series.Label.TextPattern = "{V}";
        //    chartControl1.Series.Add(series);
        //}
        //private void CreateData(int count)
        //{
        //    Series series = chartControl1.Series[0];
        //    series.Points.Clear();
        //    int multiplyValue = -1;
        //    var points = new List<SeriesPoint>();
        //    for (var i = 0; i < count; i++)
        //    {
        //        points.Add(CreatePoint(i + 1, new object[] { i * multiplyValue }));
        //        multiplyValue *= -1;
        //    }
        //    series.Points.AddRange(points.ToArray());
        //}
        //private SeriesPoint CreatePoint(object argument, object[] values)
        //{
        //    return new SeriesPoint(argument, values);
        //}
    }
}

