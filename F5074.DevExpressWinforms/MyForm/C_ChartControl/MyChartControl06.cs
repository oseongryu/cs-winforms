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

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class MyChartControl06 : UserControl
    {
        public MyChartControl06()
        {
            InitializeComponent();


            simpleButton1.Click += SimpleButton1_Click;


            for (int x = 0; x < 24; x++)
            {
                Series s = new Series("test", ViewType.Line);
                ((LineSeriesView)s.View).LineStyle.Thickness = 50;
                ((LineSeriesView)s.View).LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                ((LineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;
                s.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                s.Label.TextPattern = "{A:HH:mm}";

                s.Points.Add(new SeriesPoint(DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-24 + x), 1));
                s.Points.Add(new SeriesPoint(DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-23 + x), 1));
                //s.Points.Add(new SeriesPoint(DateTime.Now.Date.AddHours(-24 + x), 1));
                //s.Points.Add(new SeriesPoint(DateTime.Now.Date.AddHours(-23 + x), 1));
                this.chartControl1.Series.Add(s);
                // Access the view-type-specific options of the series. 
                //((LineSeriesView)s.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                //((LineSeriesView)s.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
                //((LineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;
                //((LineSeriesView)s.View).LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            }
            XYDiagram diag = (XYDiagram)chartControl1.Diagram;
            diag.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            diag.AxisX.DateTimeScaleOptions.GridSpacing = 1;
            diag.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour;
            diag.AxisX.Label.TextPattern = "{A:HH:mm}";
            // X축 스크롤 사용
            diag.EnableAxisXScrolling = true;
            diag.EnableAxisYScrolling = false;
            diag.AxisX.WholeRange.SetMinMaxValues(DateTime.Now.Date.AddHours(-48), DateTime.Now.Date.AddHours(0));
            diag.AxisX.VisualRange.SetMinMaxValues(DateTime.Now.Date.AddHours(-24), DateTime.Now.Date.AddHours(0));
            //diag.AxisY.WholeRange.SetMinMaxValues(1, 1);
            //diag.AxisY.VisualRange.SetMinMaxValues(1,1);
            diag.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chartControl1.Legend.TextVisible = false;
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int viewSize = int.Parse("24");
                XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
                diagram.AxisX.VisualRange.SetMinMaxValues(DateTime.Now.Date.AddHours(-24), DateTime.Now.Date.AddHours(0));
            }
            catch (Exception ex)
            {
            }
        }
    }
}
