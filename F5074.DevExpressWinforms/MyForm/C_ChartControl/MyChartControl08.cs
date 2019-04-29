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
using static F5074.DevExpressWinforms.MyCommon.MyDatabaseConnect01;
using F5074.DevExpressWinforms.MyCommon;
using System.Globalization;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class MyChartControl08 : UserControl
    {
        public MyChartControl08()
        {
            InitializeComponent();


            List<DataFourVo> resultList = new MyDatabaseConnect01().connection4("");

            int maxVal = resultList.Count;
            for (int x = 0; x < maxVal; x++)
            {
                DateTime dt = DateTime.Now;
                Series period1 = new Series("", ViewType.RangeBar);
                //(DevExpress.XtraCharts.RangeBarSeriesView)period1
                period1.ValueScaleType = ScaleType.DateTime;

                if (resultList[x].STATUS.ToString() == "PRODUCT")
                {
                    period1.Points.Add(new SeriesPoint("A", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.FromArgb(0x3E, 0x70, 0x38) });

                }
                else if (resultList[x].STATUS.ToString() == "WARMUP")
                {
                    period1.Points.Add(new SeriesPoint("A", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.DarkGray });

                }
                else if (resultList[x].STATUS.ToString() == "ERROR")
                {
                    period1.Points.Add(new SeriesPoint("A", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.OrangeRed });

                }
                else if (resultList[x].STATUS.ToString() == "SETUP")
                {
                    period1.Points.Add(new SeriesPoint("A", new DateTime[] { DateTime.ParseExact(resultList[x].START_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), DateTime.ParseExact(resultList[x].END_TIME.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), }) { Color = Color.FromArgb(0x00, 0x73, 0xC4) });

                }
                this.chartControl1.Series.AddRange(new Series[] { period1 });
            }

            XYDiagram diagram = (XYDiagram)this.chartControl1.Diagram;
            diagram.AxisY.Label.TextPattern = "{A: yy/MM/dd hh:mm}";
            //diagram.AxisY.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            diagram.AxisY.DateTimeScaleOptions.GridSpacing = 1;
            diagram.AxisY.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            //diagram.AxisY.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour;
            //diagram.EnableAxisXScrolling = true;
            diagram.AxisY.WholeRange.SetMinMaxValues(DateTime.Now.AddHours(-48), DateTime.Now.AddHours(0));

        }

    }
}
