﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class MyChartControl01 : UserControl
    {
        ChartControl pieChart = new ChartControl();

        public MyChartControl01()
        {
            InitializeComponent();
        }

        private void MyCharts01_Load(object sender, EventArgs e)
        {
            // https://documentation.devexpress.com/WindowsForms/2978/Controls-and-Libraries/Chart-Control/Fundamentals/Series-Views/2D-Series-Views/Pie-and-Donut-Series-Views/Pie-Chart
            // Create an empty chart. 

            pieChart.CustomDrawSeriesPoint += PieChart_CustomDrawSeriesPoint;
            // Create a pie series. 
            Series series1 = new Series("24 시간", ViewType.Pie);

            // Populate the series with points. 
            series1.Points.Add(new SeriesPoint("Russia", 17.0752));
            series1.Points.Add(new SeriesPoint("Canada", 9.98467));
            series1.Points.Add(new SeriesPoint("USA", 9.63142));
            series1.Points.Add(new SeriesPoint("China", 9.59696));
            series1.Points.Add(new SeriesPoint("Brazil", 8.511965));
            series1.Points.Add(new SeriesPoint("Australia", 7.68685));
            series1.Points.Add(new SeriesPoint("India", 3.28759));
            series1.Points.Add(new SeriesPoint("Others", 81.2));
            // Add the series to the chart. 
            pieChart.Series.Add(series1);

            // Format the the series labels. 
            series1.Label.TextPattern = "{A}: {VP:p0}";

            // Adjust the position of series labels.  
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels. 
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series. 
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Show a title for the series. 
            myView.Titles.Add(new SeriesTitle());
            myView.Titles[0].Text = series1.Name;

            // Specify a data filter to explode points. 
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1, DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,  DataFilterCondition.NotEqual, "Others"));
            //myView.ExplodeMode = PieExplodeMode.UseFilters;
            //myView.ExplodedDistancePercentage = 30;
            //myView.RuntimeExploding = true;
            //myView.HeightToWidthRatio = 0.75;

            // Hide the legend (if necessary). 
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            pieChart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
            //pieChart.Legend.VerticalIndent = 100;
            //pieChart.Legend.HorizontalIndent = 100;
            // Add the chart to the form. 
            pieChart.Dock = DockStyle.Fill;
            this.Controls.Add(pieChart);
        }

        private void PieChart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            if (e.SeriesPoint == pieChart.Series[0].Points[0])
            {
                e.LegendText = e.Series.ToString();
            }
            else
                e.LegendText = "";
        }
    }
}
