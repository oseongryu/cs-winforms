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
using DevExpress.XtraCharts.Designer;


namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class MyChartControl11 : UserControl
    {

        public MyChartControl11()
        {
            InitializeComponent();
            chartControl1.AnimationStartMode = ChartAnimationMode.OnDataChanged;
            Series pieSeries = new Series("Series1", ViewType.Pie);

            pieSeries.Points.Add(new SeriesPoint("Argument 1", 1));
            pieSeries.Points.Add(new SeriesPoint("Argument 2", 2));
            pieSeries.Points.Add(new SeriesPoint("Argument 3", 3));
            pieSeries.Points.Add(new SeriesPoint("Argument 4", 4));
            PieFanAnimation pieFanAnimation1 = new PieFanAnimation();
            chartControl1.Series.Add(pieSeries);
        }
    }
}
