using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Extension {
    public static class ChartControlExtension {



        public static void InitChartControl(this ChartControl chartControl,int minValue, int maxValue, int scrolValue )
        {
            XYDiagram diagram = (XYDiagram)chartControl.Diagram;

            //chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            //chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            //chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            // https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Legend.MarkerMode
            chartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker;


            diagram.AxisX.WholeRange.SetMinMaxValues(minValue, maxValue);
            diagram.AxisX.VisualRange.SetMinMaxValues(minValue, scrolValue);

            diagram.AxisX.WholeRange.SideMarginsValue = 20;
            diagram.AxisX.VisualRange.SideMarginsValue = 20;
        }


        public static void InitChartControl(this ChartControl chartControl, DateTime dtFromDt, DateTime dtToDt)
        {
            XYDiagram diagram = (XYDiagram)chartControl.Diagram;

            int yearVal = Convert.ToInt32(dtFromDt.ToString("yyyy"));
            int monthVal = Convert.ToInt32(dtFromDt.ToString("MM"));
            int dayVal = Convert.ToInt32(dtFromDt.ToString("dd"));

            int toYearVal = Convert.ToInt32(dtToDt.ToString("yyyy"));
            int toMonthVal = Convert.ToInt32(dtToDt.ToString("MM"));
            int toDayVal = Convert.ToInt32(dtToDt.ToString("dd"));

            diagram.AxisX.Label.TextPattern = "{A:MM-dd HH:mm}";
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute;
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour;

            diagram.AxisX.WholeRange.SetMinMaxValues(new DateTime(yearVal, monthVal, dayVal, 0, 0, 0), new DateTime(toYearVal, toMonthVal, toDayVal, 23, 59, 0));
            diagram.AxisX.VisualRange.SetMinMaxValues(new DateTime(yearVal, monthVal, dayVal, 0, 0, 0), new DateTime(yearVal, monthVal, dayVal, 23, 59, 0));

            diagram.AxisX.WholeRange.SideMarginsValue = 20;
            diagram.AxisX.VisualRange.SideMarginsValue = 20;


            //chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            //chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            //chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            // https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Legend.MarkerMode
            //chartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker;


        }

        /// <summary>
        /// InitScrolling
        /// </summary>
        /// <param name="chartControl"></param>
        public static void InitScrolling(this ChartControl chartControl)
        {

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;

            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisXZooming = true;
            diagram.EnableAxisYScrolling = true;
            diagram.EnableAxisYZooming = true;

            diagram.ZoomingOptions.UseKeyboard = false;
            diagram.ZoomingOptions.UseKeyboardWithMouse = false;
            diagram.ZoomingOptions.UseMouseWheel = false;
            diagram.ZoomingOptions.UseTouchDevice = false;

            diagram.AxisX.GridLines.Visible = true;
            diagram.AxisX.Interlaced = true;
            //diagram.AxisX.VisibleInPanesSerializable = "2";
            diagram.PaneDistance = 5;

        }
    }
}
