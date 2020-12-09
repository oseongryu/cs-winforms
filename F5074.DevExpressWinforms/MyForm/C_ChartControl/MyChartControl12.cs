using DevExpress.Utils;
using DevExpress.XtraCharts;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl {
    public partial class MyChartControl12 : UserControl {
        public MyChartControl12()
        {
            InitializeComponent();
            RestApi();

        }

        List<String> cdList = new List<String>(){
                    "10050648"
                    ,"10050649"
                    ,"10050650"
                    //,"10050651"
                    //,"10050652"
                    //,"10050654"
                    //,"10050655"
                    //,"10050656"
                    //,"10050657"
                    //,"10050658"
                    //,"10050659"
                };

        private void InitChartControl4()
        {
            chartControl4.Series.Clear();
            chartControl4.Controls.Clear();
            chartControl4.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.DeepSkyBlue;
            //chartControl4.CrosshairOptions.ArgumentLineStyle.Thickness = 2;
            ////chartControl4.CrosshairOptions.GroupHeaderPattern = "{A:d MMMM,  H:mm}";
            chartControl4.CrosshairOptions.ShowOnlyInFocusedPane = false;

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            var json = wc.DownloadString(@"http://localhost/eqpMaxLoad/100218/2020120308/2020120322");

            string strJson = json.ToString();
            JObject arrJson = JObject.Parse(strJson);
            JArray arrJsons = JArray.Parse(arrJson["data"].ToString());
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString());

            for (int cdIdx = 0; cdIdx < cdList.Count; cdIdx++)
            {
                Series series = new Series(cdList[cdIdx], ViewType.Line);
                for (int rowIdx = 0; rowIdx < dt.Rows.Count; rowIdx++)
                {
                    if (dt.Rows[rowIdx]["ITEM_CD"].ToString() == cdList[cdIdx])
                    {
                        series.Points.Add(new SeriesPoint(DateTime.ParseExact(dt.Rows[rowIdx]["PER_MIN"].ToString(), "yyyyMMdd HHmm", null), dt.Rows[rowIdx]["ITEM_VALUE"]));
                    }
                }
                chartControl4.Series.Add(series);
                XYDiagram diagram = (XYDiagram)chartControl4.Diagram;

                if (cdIdx == 0)
                {
                    diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.ShortTime;
                    diagram.AxisX.Label.TextPattern = "{A:HH:mm}";
                    diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
                    diagram.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
                    diagram.AxisX.WholeRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 17, 59, 0));
                    diagram.AxisX.WholeRange.SideMarginsValue = 20;
                    diagram.AxisX.VisualRange.SideMarginsValue = 20;
                    //diagram.AxisX.VisualRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 14, 59, 0));

                    diagram.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F);
                    diagram.AxisY.Title.Text = cdList[cdIdx];
                    diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                    diagram.PaneDistance = 10;
                    diagram.EnableAxisXScrolling = true;
                    diagram.EnableAxisXZooming = true;
                    diagram.EnableAxisYScrolling = true;
                    diagram.EnableAxisYZooming = true;
                    diagram.Panes.Clear();
                    diagram.SecondaryAxesX.Clear();
                    diagram.SecondaryAxesY.Clear();
                }


                if(cdIdx > 0)
                {
                    int viewIdx = cdIdx - 1;
                    LineSeriesView myView = (LineSeriesView)series.View;
                    diagram.Panes.Add(new XYDiagramPane("Pane"));
                    myView.Pane = diagram.Panes[viewIdx];

                    // Add secondary axes to the diagram, and adjust their options.
                    diagram.SecondaryAxesX.Add(new SecondaryAxisX("My Axis X"));
                    diagram.SecondaryAxesY.Add(new SecondaryAxisY("My Axis Y"));
                    diagram.SecondaryAxesX[viewIdx].Alignment = AxisAlignment.Near;
                    diagram.SecondaryAxesY[viewIdx].Alignment = AxisAlignment.Near;

                    myView.AxisX = diagram.SecondaryAxesX[viewIdx];
                    myView.AxisY = diagram.SecondaryAxesY[viewIdx];
                    myView.AxisX.DateTimeOptions.Format = DateTimeFormat.ShortTime;
                    myView.AxisX.Label.TextPattern = "{A:MM-dd HH:mm}";
                    myView.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
                    myView.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
                    myView.AxisX.WholeRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 17, 59, 0));
                    //myView.AxisX.VisualRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 14, 59, 0));
                    myView.AxisX.WholeRange.SideMarginsValue = 20;
                    myView.AxisX.VisualRange.SideMarginsValue = 20;

                    diagram.SecondaryAxesY[viewIdx].Title.Font = new System.Drawing.Font("Tahoma", 10F);
                    diagram.SecondaryAxesY[viewIdx].Title.Text = cdList[cdIdx];
                    diagram.SecondaryAxesY[viewIdx].Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                }
            }
            // Add the chart to the form.
            chartControl4.Dock = DockStyle.Fill;
        }


        private void InitChartControl3()
        {
            chartControl4.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.DeepSkyBlue;
            chartControl4.CrosshairOptions.ArgumentLineStyle.Thickness = 2;
            //chartControl4.CrosshairOptions.GroupHeaderPattern = "{A:d MMMM,  H:mm}";
            chartControl4.CrosshairOptions.ShowOnlyInFocusedPane = false;



            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            var json = wc.DownloadString("http://localhost/eqpMaxLoad/100218/2020120308/2020120322");

            string strJson = json.ToString();
            JObject arrJson = JObject.Parse(strJson);
            JArray arrJsons = JArray.Parse(arrJson["data"].ToString());
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString());

            Series series1 = new Series("1", ViewType.Bar);
            Series series2 = new Series("2", ViewType.Area);
            Series series3 = new Series("3", ViewType.Line);
            for (int cdIdx = 0; cdIdx < cdList.Count; cdIdx++)
            {
                Series series = new Series(cdList[cdIdx], ViewType.Line);
                for (int rowIdx = 0; rowIdx < dt.Rows.Count; rowIdx++)
                {
                    if (dt.Rows[rowIdx]["ITEM_CD"].ToString() == cdList[cdIdx])
                    {
                        if (cdIdx == 0)
                        {
                            
                            series1.Points.Add(new SeriesPoint(DateTime.ParseExact(dt.Rows[rowIdx]["PER_MIN"].ToString(), "yyyyMMdd HHmm", null), dt.Rows[rowIdx]["ITEM_VALUE"]));
                        }
                        if (cdIdx == 1)
                        {
                            series2.Points.Add(new SeriesPoint(DateTime.ParseExact(dt.Rows[rowIdx]["PER_MIN"].ToString(), "yyyyMMdd HHmm", null), dt.Rows[rowIdx]["ITEM_VALUE"]));
                        }
                        if (cdIdx == 2)
                        {
                            series3.Points.Add(new SeriesPoint(DateTime.ParseExact(dt.Rows[rowIdx]["PER_MIN"].ToString(), "yyyyMMdd HHmm", null), dt.Rows[rowIdx]["ITEM_VALUE"]));
                        }
                    }
                }
            }


            // Add both series to the chart.
            chartControl4.Series.AddRange(new Series[] { series1, series2, series3 });

            // Cast the second series's view to the LineSeriesView type.
            AreaSeriesView myView = (AreaSeriesView)series2.View;
            LineSeriesView myView2 = (LineSeriesView)series3.View;

            // Hide the legend (optional).
            //chartControl4.Legend.Visibility = DefaultBoolean.False;

            // Cast the chart's diagram to the XYDiagram type, 
            // to access its axes and panes.
            XYDiagram diagram = (XYDiagram)chartControl4.Diagram;

            // Add a new additional pane to the diagram.
            diagram.Panes.Add(new XYDiagramPane("My Pane1"));
            diagram.Panes.Add(new XYDiagramPane("My Pane2"));

            // Note that the created pane has the zero index in the collection,
            // because the existing Default pane is a separate entity.
            myView.Pane = diagram.Panes[0];
            myView2.Pane = diagram.Panes[1];
            // Add titles to panes.

            // Customize the pane layout.
            diagram.PaneDistance = 10;

            // Add secondary axes to the diagram, and adjust their options.
            diagram.SecondaryAxesX.Add(new SecondaryAxisX("My Axis X"));
            diagram.SecondaryAxesY.Add(new SecondaryAxisY("My Axis Y"));
            diagram.SecondaryAxesX[0].Alignment = AxisAlignment.Near;
            diagram.SecondaryAxesY[0].Alignment = AxisAlignment.Near;
            //diagram.SecondaryAxesY[0].GridLines.Visible = true;

            diagram.SecondaryAxesX.Add(new SecondaryAxisX("My Axis X"));
            diagram.SecondaryAxesY.Add(new SecondaryAxisY("My Axis Y"));
            diagram.SecondaryAxesX[1].Alignment = AxisAlignment.Near;
            diagram.SecondaryAxesY[1].Alignment = AxisAlignment.Near;



            //
            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisXZooming = true;
            diagram.EnableAxisYScrolling = true;
            diagram.EnableAxisYZooming = true;


            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.ShortTime;
            diagram.AxisX.Label.TextPattern = "{A:HH:mm}";
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
            diagram.AxisX.WholeRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 17, 59, 0));
            diagram.AxisX.WholeRange.SideMarginsValue = 20;
            diagram.AxisX.VisualRange.SideMarginsValue = 20;
            //diagram.AxisX.VisualRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 14, 59, 0));

            diagram.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            diagram.AxisY.Title.Text = "Temperature, F";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;



            myView.AxisX = diagram.SecondaryAxesX[0];
            myView.AxisY = diagram.SecondaryAxesY[0];
            myView.AxisX.DateTimeOptions.Format = DateTimeFormat.ShortTime;
            myView.AxisX.Label.TextPattern = "{A:HH:mm}";
            myView.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
            myView.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
            myView.AxisX.WholeRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 17, 59, 0));
            //myView.AxisX.VisualRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 14, 59, 0));
            myView.AxisX.WholeRange.SideMarginsValue = 20;
            myView.AxisX.VisualRange.SideMarginsValue = 20;

            diagram.SecondaryAxesY[0].Title.Font = new System.Drawing.Font("Tahoma", 10F);
            diagram.SecondaryAxesY[0].Title.Text = "Pressure, mbar";
            diagram.SecondaryAxesY[0].Title.Visibility = DevExpress.Utils.DefaultBoolean.True;


            myView2.AxisX = diagram.SecondaryAxesX[1];
            myView2.AxisY = diagram.SecondaryAxesY[1];
            myView2.AxisX.DateTimeOptions.Format = DateTimeFormat.ShortTime;
            myView2.AxisX.Label.TextPattern = "{A:HH:mm}";
            myView2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
            myView2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
            myView2.AxisX.WholeRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 17, 59, 0));
            //myView2.AxisX.VisualRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 14, 59, 0));
            myView2.AxisX.WholeRange.SideMarginsValue = 20;
            myView2.AxisX.VisualRange.SideMarginsValue = 20;


            diagram.SecondaryAxesY[1].Title.Font = new System.Drawing.Font("Tahoma", 10F);
            diagram.SecondaryAxesY[1].Title.Text = "Pressure, mbar";
            diagram.SecondaryAxesY[1].Title.Visibility = DevExpress.Utils.DefaultBoolean.True;


            // Add the chart to the form.
            chartControl4.Dock = DockStyle.Fill;
        }


        private void InitChartControl()
        {
            //Series series1 = new Series("1", ViewType.Line);
            //for (int rowIdx = 0; rowIdx < 10; rowIdx++)
            //{
            //    series1.Points.Add(new SeriesPoint(rowIdx, rowIdx));
            //}

            //Series series2 = new Series("1", ViewType.Line);
            //for (int rowIdx = 0; rowIdx < 10; rowIdx++)
            //{
            //    series2.Points.Add(new SeriesPoint(rowIdx, rowIdx + 10));
            //}

            //Series series3 = new Series("1", ViewType.Line);
            //for (int rowIdx = 0; rowIdx < 10; rowIdx++)
            //{
            //    series3.Points.Add(new SeriesPoint(rowIdx, rowIdx + 20));
            //}

            XYDiagram xyDiagram1 = new XYDiagram();
            var xyDiagramPane1 = new XYDiagramPane();
            SecondaryAxisY secondaryAxisY1 = new SecondaryAxisY();
            Series series1 = new Series();
            PointSeriesLabel pointSeriesLabel1 = new PointSeriesLabel();
            SeriesPoint seriesPoint1 = new SeriesPoint(new DateTime(2008, 6, 11, 6, 0, 0, 0), new object[] {
            ((object)(56.48D))});
            SeriesPoint seriesPoint2 = new SeriesPoint(new DateTime(2008, 6, 11, 3, 0, 0, 0), new object[] {
            ((object)(53.78D))});
            LineSeriesView lineSeriesView1 = new LineSeriesView();
            Series series2 = new Series();
            PointSeriesLabel pointSeriesLabel2 = new PointSeriesLabel();
            SeriesPoint seriesPoint3 = new SeriesPoint(new DateTime(2008, 6, 11, 6, 0, 0, 0), new object[] {
            ((object)(1023D))});
            SeriesPoint seriesPoint4 = new SeriesPoint(new System.DateTime(2008, 6, 11, 3, 0, 0, 0), new object[] {
            ((object)(1021D))});
            AreaSeriesView areaSeriesView1 = new AreaSeriesView();
            ChartTitle chartTitle1 = new ChartTitle();

            ((ISupportInitialize)(chartControl4)).BeginInit();
            ((ISupportInitialize)(xyDiagram1)).BeginInit();
            ((ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((ISupportInitialize)(series1)).BeginInit();
            ((ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((ISupportInitialize)(series2)).BeginInit();
            ((ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((ISupportInitialize)(areaSeriesView1)).BeginInit();
            this.SuspendLayout();
           

            chartControl4.AutoLayout = false;
            chartControl4.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.DeepSkyBlue;
            chartControl4.CrosshairOptions.ArgumentLineStyle.Thickness = 2;
            chartControl4.CrosshairOptions.GroupHeaderPattern = "{A:d MMMM,  H:mm}";
            chartControl4.CrosshairOptions.ShowOnlyInFocusedPane = false;
            chartControl4.DataBindings = null;
            
            
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 6D;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Label.TextPattern = "{A:dd/MM HH:mm}";
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "06/11/2008 06:00:00.000";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "06/11/2008 03:00:00.000";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisY.Title.Text = "Temperature, F";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.DefaultPane.ScrollBarOptions.XAxisScrollBarVisible = false;
            xyDiagram1.DefaultPane.ScrollBarOptions.YAxisScrollBarVisible = false;
            xyDiagram1.DefaultPane.Weight = 2D;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.PaneDistance = 4;
            xyDiagramPane1.Name = "Pane 1";
            xyDiagramPane1.PaneID = 0;
            xyDiagramPane1.ScrollBarOptions.XAxisScrollBarVisible = false;
            xyDiagramPane1.ScrollBarOptions.YAxisScrollBarVisible = false;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1});
           
            
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.GridLines.MinorVisible = true;
            secondaryAxisY1.GridLines.Visible = true;
            secondaryAxisY1.Name = "secondaryAxisY1";
            secondaryAxisY1.NumericScaleOptions.AutoGrid = false;
            secondaryAxisY1.NumericScaleOptions.GridSpacing = 4D;
            secondaryAxisY1.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            secondaryAxisY1.Title.Text = "Pressure, mbar";
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisY1.VisibleInPanesSerializable = "0";
            secondaryAxisY1.VisualRange.Auto = false;
            secondaryAxisY1.VisualRange.AutoSideMargins = false;
            secondaryAxisY1.VisualRange.MaxValueSerializable = "1025";
            secondaryAxisY1.VisualRange.MinValueSerializable = "1014";
            secondaryAxisY1.VisualRange.SideMarginsValue = 0D;
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = false;
            secondaryAxisY1.WholeRange.Auto = false;
            secondaryAxisY1.WholeRange.AutoSideMargins = false;
            secondaryAxisY1.WholeRange.MaxValueSerializable = "1025";
            secondaryAxisY1.WholeRange.MinValueSerializable = "1014";
            secondaryAxisY1.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
           
            
            
            chartControl4.Diagram = xyDiagram1;
            chartControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            chartControl4.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            chartControl4.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            chartControl4.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            chartControl4.Legend.Name = "Default Legend";
            chartControl4.Location = new System.Drawing.Point(0, 0);
            chartControl4.Name = "chart04";
            
            
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel1.Angle = 90;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Temperature (F)";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2});
            series1.View = lineSeriesView1;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            pointSeriesLabel2.Angle = 90;
            pointSeriesLabel2.LineLength = 5;
            series2.Label = pointSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Pressure (mbar)";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint3,
            seriesPoint4});
            areaSeriesView1.AxisYName = "secondaryAxisY1";
            areaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
            areaSeriesView1.PaneName = "Pane 1";
            areaSeriesView1.Transparency = ((byte)(0));
            series2.View = areaSeriesView1;

            this.chartControl4.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            chartControl4.Size = new System.Drawing.Size(1333, 548);
            chartControl4.TabIndex = 3;
            chartTitle1.Text = "Weather in London";
            chartControl4.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            chartControl4.ToolTipOptions.ShowForPoints = false;


            ((ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((ISupportInitialize)(xyDiagram1)).EndInit();
            ((ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((ISupportInitialize)(lineSeriesView1)).EndInit();
            ((ISupportInitialize)(series1)).EndInit();
            ((ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((ISupportInitialize)(areaSeriesView1)).EndInit();
            ((ISupportInitialize)(series2)).EndInit();
            ((ISupportInitialize)(this.chartControl4)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitChartControl2()
        {
            chartControl4.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.DeepSkyBlue;
            //chartControl4.CrosshairOptions.ArgumentLineStyle.Thickness = 2;
            //chartControl4.CrosshairOptions.GroupHeaderPattern = "{A:d MMMM,  H:mm}";
            chartControl4.CrosshairOptions.ShowOnlyInFocusedPane = false;


            Series series1 = new Series("1", ViewType.Line);
            for (int rowIdx = 0; rowIdx < 10; rowIdx++)
            {
                series1.Points.Add(new SeriesPoint(rowIdx, rowIdx));
            }

            Series series2 = new Series("2", ViewType.Line);
            for (int rowIdx = 0; rowIdx < 10; rowIdx++)
            {
                series2.Points.Add(new SeriesPoint(rowIdx, rowIdx + 10));
            }

            Series series3 = new Series("3", ViewType.Line);
            for (int rowIdx = 0; rowIdx < 10; rowIdx++)
            {
                series3.Points.Add(new SeriesPoint(rowIdx, rowIdx + 20));
            }


            // Add both series to the chart.
            chartControl4.Series.AddRange(new Series[] { series1, series2 });

            // Cast the second series's view to the LineSeriesView type.
            LineSeriesView myView = (LineSeriesView)series2.View;

            // Hide the legend (optional).
            chartControl4.Legend.Visibility = DefaultBoolean.False;

            // Cast the chart's diagram to the XYDiagram type, 
            // to access its axes and panes.
            XYDiagram diagram = (XYDiagram)chartControl4.Diagram;

            // Add a new additional pane to the diagram.
            diagram.Panes.Add(new XYDiagramPane("My Pane"));

            // Note that the created pane has the zero index in the collection,
            // because the existing Default pane is a separate entity.
            myView.Pane = diagram.Panes[0];

            // Add titles to panes.

            // Customize the pane layout.
            diagram.PaneDistance = 10;

            // Add secondary axes to the diagram, and adjust their options.
            diagram.SecondaryAxesX.Add(new SecondaryAxisX("My Axis X"));
            diagram.SecondaryAxesY.Add(new SecondaryAxisY("My Axis Y"));
            diagram.SecondaryAxesX[0].Alignment = AxisAlignment.Near;
            diagram.SecondaryAxesY[0].Alignment = AxisAlignment.Near;
            diagram.SecondaryAxesY[0].GridLines.Visible = true;

            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisXZooming = true;
            diagram.EnableAxisYScrolling = true;
            diagram.EnableAxisYZooming = true;

            // Assign both the additional pane and, if required,
            // the secondary axes to the second series.             
            myView.AxisX = diagram.SecondaryAxesX[0];
            myView.AxisY = diagram.SecondaryAxesY[0];



            // Add the chart to the form.
            chartControl4.Dock = DockStyle.Fill;
        }

        private void RestApi()
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            var json = wc.DownloadString("http://localhost/eqpMaxLoad/100218/20201203/20201203");

            string strJson = json.ToString();
            JObject arrJson = JObject.Parse(strJson);
            JArray arrJsons = JArray.Parse(arrJson["data"].ToString());
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString());


            for (int cdIdx = 0; cdIdx < cdList.Count; cdIdx++)
            {
                Series series = new Series(cdList[cdIdx], ViewType.Line);
                for (int rowIdx = 0; rowIdx < dt.Rows.Count; rowIdx++)
                {
                    if (dt.Rows[rowIdx]["ITEM_CD"].ToString() == cdList[cdIdx])
                    {
                        series.Points.Add(new SeriesPoint(dt.Rows[rowIdx]["PER_MIN"], dt.Rows[rowIdx]["ITEM_VALUE"]));

                    }
                }
            }

                //for (int cdIdx = 0; cdIdx < cdList.Count; cdIdx++)
                //{
                //    Series series = new Series(cdList[cdIdx], ViewType.Line);
                //    for (int rowIdx = 0; rowIdx < dt.Rows.Count; rowIdx++)
                //    {
                //        if (dt.Rows[rowIdx]["ITEM_CD"].ToString() == cdList[cdIdx])
                //        {
                //            series.Points.Add(new SeriesPoint(dt.Rows[rowIdx]["PER_MIN"], dt.Rows[rowIdx]["ITEM_VALUE"]));

                //        }
                //    }
                //    // Set the numerical argument scale types for the series,
                //    // as it is qualitative, by default.
                //    series.ArgumentScaleType = ScaleType.Qualitative;

                //    // Access the view-type-specific options of the series.
                //    ((LineSeriesView)series.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
                //    //((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                //    //((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;
                //    //((XYDiagram)chartControl1.Diagram).EnableAxisXZooming = true;
                //    if (cdIdx == 0)
                //    {
                //        chartControl1.Titles.Clear();
                //        chartControl1.Series.Clear();

                //        chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                //        series.View.Color = Color.Red;
                //        chartControl1.Series.Add(series);

                //        chartControl1.Titles.Add(new ChartTitle());
                //        chartControl1.Titles[0].Text = "이송속도";

                //    }
                //    else if (cdIdx == 1)
                //    {
                //        chartControl2.Titles.Clear();
                //        chartControl2.Series.Clear();
                //        chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                //        series.View.Color = Color.Green;
                //        chartControl2.Series.Add(series);
                //        chartControl2.Titles.Add(new ChartTitle());
                //        chartControl2.Titles[0].Text = "주축회전속도";
                //    }
                //    else if (cdIdx == 2)
                //    {
                //        chartControl3.Titles.Clear();
                //        chartControl3.Series.Clear();
                //        chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                //        series.View.Color = Color.Yellow;
                //        chartControl3.Series.Add(series);
                //        chartControl3.Titles.Add(new ChartTitle());
                //        chartControl3.Titles[0].Text = "실가공시간";
                //    }
                //    else if (cdIdx == 3)
                //    {
                //        chartControl4.Titles.Clear();
                //        chartControl4.Series.Clear();
                //        chartControl4.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                //        series.View.Color = Color.Orange;
                //        chartControl4.Series.Add(series);
                //        chartControl4.Titles.Add(new ChartTitle());
                //        chartControl4.Titles[0].Text = "스핀들온도";
                //    }

                //}

            }

        private void button1_Click(object sender, EventArgs e)
        {
            InitChartControl4();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartControl4.Series.Clear();
        }
    }
}
