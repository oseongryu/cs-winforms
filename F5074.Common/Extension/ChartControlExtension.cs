using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Extension {
    public static class ChartControlExtension {

        /// <summary>
        /// InitScrolling
        /// </summary>
        /// <param name="chartControl"></param>
        public static void InitScrolling(this ChartControl chartControl)
        {
            chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;

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
