using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.MVVM.Form.View {
    public partial class Chart01View : UserControl {
        public Chart01View()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            //    DateTime dtFromDt = Convert.ToDateTime(this.calFromDate.EditValue);
            //    DateTime dtToDt = Convert.ToDateTime(this.calToDate.EditValue);
            //    int yearVal = Convert.ToInt32(dtFromDt.ToString("yyyy"));
            //    int monthVal = Convert.ToInt32(dtFromDt.ToString("MM"));
            //    int dayVal = Convert.ToInt32(dtFromDt.ToString("dd"));

            //    int toYearVal = Convert.ToInt32(dtToDt.ToString("yyyy"));
            //    int toMonthVal = Convert.ToInt32(dtToDt.ToString("MM"));
            //    int toDayVal = Convert.ToInt32(dtToDt.ToString("dd"));

            //    DataTable dt = Biz.Handler.Equipment.EquipmentManagementHandler.SelectEqpMaxLoad(slueEquipment.EditValue.ToString(), dtFromDt.ToString("yyyyMMdd01"), dtToDt.ToString("yyyyMMdd23"), slueCategory.EditValue.ToString());
            //    chartTab1.Series.Clear();
            //    chartTab1.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.DeepPink;
            //    chartTab1.CrosshairOptions.ShowOnlyInFocusedPane = false;

            //    DataTable dtCdSpec = Biz.Handler.Equipment.EquipmentManagementHandler.SelectEqpCdSpec(slueEquipment.EditValue.ToString());

            //    for (int cdIdx = 0; cdIdx < dtCdSpec.Rows.Count; cdIdx++)
            //    {
            //        string sItemCd = dtCdSpec.Rows[cdIdx]["ITEM_CD"].ToString();
            //        string sItemDesc = dtCdSpec.Rows[cdIdx]["ITEM_DESC"].ToString();

            //        Series series = new Series(sItemDesc, ViewType.Line);

            //        foreach (DataRow row in dt.Rows)
            //        {
            //            if (row["ITEM_CD"].ToString() == sItemCd)
            //            {
            //                series.Points.Add(new SeriesPoint(DateTime.ParseExact(row["PER_MIN"].ToString(), "yyyyMMdd HHmm", null), row["ITEM_VALUE"]));
            //            }
            //        }

            //        chartTab1.Series.Add(series);
            //        XYDiagram diagram = (XYDiagram)chartTab1.Diagram;

            //        if (cdIdx == 0)
            //        {
            //            diagram.Panes.Clear();
            //            diagram.SecondaryAxesX.Clear();
            //            diagram.SecondaryAxesY.Clear();

            //            diagram.AxisX.Label.TextPattern = "{A:MM-dd HH:mm}";
            //            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
            //            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;

            //            diagram.AxisX.WholeRange.SetMinMaxValues(new DateTime(yearVal, monthVal, dayVal, 9, 0, 0), new DateTime(toYearVal, toMonthVal, toDayVal, 17, 59, 0));
            //            diagram.AxisX.VisualRange.SetMinMaxValues(new DateTime(yearVal, monthVal, dayVal, 9, 0, 0), new DateTime(yearVal, monthVal, dayVal, 17, 59, 0));

            //            diagram.AxisX.WholeRange.SideMarginsValue = 20;
            //            diagram.AxisX.VisualRange.SideMarginsValue = 20;

            //            diagram.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            //            diagram.AxisY.Title.Text = sItemDesc;
            //            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //            diagram.PaneDistance = 10;
            //            diagram.EnableAxisXScrolling = true;
            //            diagram.EnableAxisXZooming = true;
            //            diagram.EnableAxisYScrolling = true;
            //            diagram.EnableAxisYZooming = true;

            //        }

            //        if (cdIdx > 0)
            //        {
            //            int viewIdx = cdIdx - 1;

            //            LineSeriesView myView = (LineSeriesView)series.View;
            //            diagram.Panes.Add(new XYDiagramPane("Pane"));
            //            myView.Pane = diagram.Panes[viewIdx];

            //            // Add secondary axes to the diagram, and adjust their options.
            //            diagram.SecondaryAxesX.Add(new SecondaryAxisX("My Axis X"));
            //            diagram.SecondaryAxesY.Add(new SecondaryAxisY("My Axis Y"));
            //            diagram.SecondaryAxesX[viewIdx].Alignment = AxisAlignment.Near;
            //            diagram.SecondaryAxesY[viewIdx].Alignment = AxisAlignment.Near;

            //            myView.AxisX = diagram.SecondaryAxesX[viewIdx];
            //            myView.AxisY = diagram.SecondaryAxesY[viewIdx];
            //            myView.AxisX.Label.TextPattern = "{A:MM-dd HH:mm}";
            //            myView.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
            //            myView.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;
            //            myView.AxisX.WholeRange.SetMinMaxValues(new DateTime(yearVal, monthVal, dayVal, 9, 0, 0), new DateTime(toYearVal, toMonthVal, toDayVal, 17, 59, 0));
            //            myView.AxisX.VisualRange.SetMinMaxValues(new DateTime(yearVal, monthVal, dayVal, 9, 0, 0), new DateTime(yearVal, monthVal, dayVal, 17, 59, 0));
            //            //myView.AxisX.WholeRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 17, 59, 0));
            //            //myView.AxisX.VisualRange.SetMinMaxValues(new DateTime(2020, 12, 03, 9, 0, 0), new DateTime(2020, 12, 03, 14, 59, 0));
            //            myView.AxisX.WholeRange.SideMarginsValue = 20;
            //            myView.AxisX.VisualRange.SideMarginsValue = 20;

            //            diagram.SecondaryAxesY[viewIdx].Title.Font = new System.Drawing.Font("Tahoma", 10F);
            //            diagram.SecondaryAxesY[viewIdx].Title.Text = sItemDesc;
            //            diagram.SecondaryAxesY[viewIdx].Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //        }
            //    }
            //    // Add the chart to the form.
            //    chartTab1.Dock = DockStyle.Fill;
        }
    }
}
