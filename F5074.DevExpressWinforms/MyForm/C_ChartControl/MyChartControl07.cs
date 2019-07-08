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
using F5074.DevExpressWinforms.MyCommon;
using System.Globalization;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class MyChartControl07 : UserControl
    {
        public MyChartControl07()
        {
            InitializeComponent();


            List<MyDatabaseConnect01.DataFourVo> resultList =  new MyDatabaseConnect01().connection4("");
            this.chartControl1.AxisScaleChanged += ChartControl1_AxisScaleChanged;
            this.chartControl1.CustomDrawAxisLabel += ChartControl1_CustomDrawAxisLabel;


            int maxVal = resultList.Count;
            for (int x = 0; x < maxVal; x++)
            {
                DateTime dt = DateTime.Now;
                Series period1 = new Series("", ViewType.RangeBar);
                //(DevExpress.XtraCharts.RangeBarSeriesView)period1
                period1.ValueScaleType = ScaleType.DateTime;

                if(resultList[x].STATUS.ToString() == "PRODUCT")
                {
                    period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.FromArgb(0x3E, 0x70, 0x38) });

                }
                else if (resultList[x].STATUS.ToString() == "WARMUP")
                {
                    period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.DarkGray });

                }
                else if (resultList[x].STATUS.ToString() == "ERROR")
                {
                    period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.OrangeRed });

                }
                else if (resultList[x].STATUS.ToString() == "SETUP")
                {
                    period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.FromArgb(0x00, 0x73, 0xC4) });

                }
                chartControl1.Series.AddRange(new Series[] { period1 });
            }



            //Series period11 = new Series("P11", ViewType.RangeBar);
            //period11.ValueScaleType = ScaleType.DateTime;
            //period11.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt, dt.AddHours(3) }));
            //Series period12 = new Series("P12", ViewType.RangeBar);
            //period12.ValueScaleType = ScaleType.DateTime;
            //period12.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(3), dt.AddHours(9) }));
            //Series period13 = new Series("P13", ViewType.RangeBar);
            //period13.ValueScaleType = ScaleType.DateTime;
            //period13.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(9), dt.AddHours(15) }));
            //Series period14 = new Series("P14", ViewType.RangeBar);
            //period14.ValueScaleType = ScaleType.DateTime;
            //period14.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(15), dt.AddHours(21) }));

            //Series period15 = new Series("P15", ViewType.RangeBar);
            //period15.ValueScaleType = ScaleType.DateTime;
            //period15.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(21), dt.AddHours(24) }));


            //chartControl1.Series.AddRange(new Series[] { period1, period2, period3, period4});

            foreach (Series s in chartControl1.Series)
            {
                s.CrosshairLabelPattern = "{A:HH:mm} - {A:HH:mm}";
                s.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.False;
            }


            chartControl1.Legend.TextVisible = false;
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            ((XYDiagram)chartControl1.Diagram).Rotated = true;
            ((XYDiagram)chartControl1.Diagram).EnableAxisXScrolling = false;
            ((XYDiagram)chartControl1.Diagram).EnableAxisYScrolling = true;
            //((XYDiagram)chartControl1.Diagram).AxisY.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            ((XYDiagram)chartControl1.Diagram).AxisY.DateTimeScaleOptions.GridSpacing = 1;
            ((XYDiagram)chartControl1.Diagram).AxisY.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour;
            ((XYDiagram)chartControl1.Diagram).AxisY.WholeRange.SetMinMaxValues(DateTime.Now.AddHours(-48), DateTime.Now.AddHours(0));
            ((XYDiagram)chartControl1.Diagram).AxisY.VisualRange.SetMinMaxValues(DateTime.Now.AddHours(-24), DateTime.Now.AddHours(0));
            //((XYDiagram)chartControl1.Diagram).AxisY.Label.TextPattern = "{A:HH:mm}";

            //maxVal = 48;
            //for (int x = 0; x < maxVal; x++)
            //{
            //    DateTime dt = DateTime.Now.Date;
            //    Series period1 = new Series("", ViewType.RangeBar);
            //    //(DevExpress.XtraCharts.RangeBarSeriesView)period1
            //    period1.ValueScaleType = ScaleType.DateTime;
            //    if (x % 4 == 1)
            //    {
            //        period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + x), DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + 1 + x), }) { Color = Color.FromArgb(0x3E, 0x70, 0x38) });

            //    }
            //    else if (x % 4 == 2)
            //    {
            //        period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + x), DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + 1 + x), }) { Color = Color.DarkGray });

            //    }
            //    else if (x % 4 == 3)
            //    {
            //        period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + x), DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + 1 + x), }) { Color = Color.OrangeRed });

            //    }
            //    else if (x % 4 == 0)
            //    {
            //        period1.Points.Add(new SeriesPoint(" ", new DateTime[] { DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + x), DateTime.ParseExact("2019-04-26 02:14:42", "yyyy-MM-dd HH:mm:ss", null).AddHours(-maxVal + 1 + x), }) { Color = Color.FromArgb(0x00, 0x73, 0xC4) });

            //    }
            //    chartControl2.Series.AddRange(new Series[] { period1 });
            //}



            ////Series period11 = new Series("P11", ViewType.RangeBar);
            ////period11.ValueScaleType = ScaleType.DateTime;
            ////period11.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt, dt.AddHours(3) }));
            ////Series period12 = new Series("P12", ViewType.RangeBar);
            ////period12.ValueScaleType = ScaleType.DateTime;
            ////period12.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(3), dt.AddHours(9) }));
            ////Series period13 = new Series("P13", ViewType.RangeBar);
            ////period13.ValueScaleType = ScaleType.DateTime;
            ////period13.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(9), dt.AddHours(15) }));
            ////Series period14 = new Series("P14", ViewType.RangeBar);
            ////period14.ValueScaleType = ScaleType.DateTime;
            ////period14.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(15), dt.AddHours(21) }));

            ////Series period15 = new Series("P15", ViewType.RangeBar);
            ////period15.ValueScaleType = ScaleType.DateTime;
            ////period15.Points.Add(new SeriesPoint("Machine B", new DateTime[] { dt.AddHours(21), dt.AddHours(24) }));


            ////chartControl1.Series.AddRange(new Series[] { period1, period2, period3, period4});

            //foreach (Series s in chartControl2.Series)
            //    s.CrosshairLabelPattern = "{A:HH:mm} - {A:HH:mm}";

            //chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            //((XYDiagram)chartControl2.Diagram).Rotated = true;
            //((XYDiagram)chartControl2.Diagram).EnableAxisXScrolling = false;
            //((XYDiagram)chartControl2.Diagram).EnableAxisYScrolling = true;
            //((XYDiagram)chartControl2.Diagram).AxisY.WholeRange.SetMinMaxValues(DateTime.Now.Date.AddHours(-48), DateTime.Now.Date.AddHours(0));
            //((XYDiagram)chartControl2.Diagram).AxisY.VisualRange.SetMinMaxValues(DateTime.Now.Date.AddHours(-24), DateTime.Now.Date.AddHours(0));
        }

        private void ChartControl1_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e)
        {

            ((XYDiagram)chartControl1.Diagram).AxisY.Label.TextPattern = "{A:HH:mm}";
        }

        private void ChartControl1_AxisScaleChanged(object sender, AxisScaleChangedEventArgs e)
        {
            // https://documentation.devexpress.com/WindowsForms/5877/Controls-and-Libraries/Chart-Control/Examples/Creating-Charts/Data-Representation/How-to-Change-the-Display-Format-for-Axis-Labels
            // https://www.devexpress.com/Support/Center/Question/Details/T692000/how-to-customize-the-axis-label-text-pattern
            if (e.Axis is AxisY)
            {
                double gridSpacing = Convert.ToDouble(e.GridSpacingChange.NewValue);
                string grdStr = gridSpacing.ToString();
                int len = grdStr.Substring(grdStr.IndexOf(".") + 1).Length;
                ((XYDiagram)chartControl1.Diagram).AxisY.Label.TextPattern = "{V:n" + len.ToString() + "}";
            }
            //((XYDiagram)chartControl1.Diagram).AxisY.Label.TextPattern = "{S:yy-M-d H:mm:ss}";
        }
    }
}
