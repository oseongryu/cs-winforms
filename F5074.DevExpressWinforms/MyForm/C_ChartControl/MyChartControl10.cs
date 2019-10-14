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
    public partial class MyChartControl10 : UserControl
    {
        public MyChartControl10()
        {
            InitializeComponent();

            chartControl1.DoubleClick += OnDoubleClick;

            Series series = chartControl1.Series["Europe"];
            if (series == null) return;
            LineSeriesView view = series.View as LineSeriesView;
            if (view == null) return;
            view.SeriesAnimation = new XYSeriesRotateAndZoomAnimation { RotationCount = 1 };
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            chartControl1.Animate();
        }
    }
    class XYSeriesRotateAndZoomAnimation : XYSeriesAnimationBase
    {
        const int defaultRotationCount = 1;

        int rotationCount = defaultRotationCount;
        public int RotationCount
        {
            get { return rotationCount; }
            set { rotationCount = value; }
        }

        public override void ApplyState(SceneModifier modifier, Rectangle diagramBounds, float progress)
        {
            float currentWidth = diagramBounds.Width * progress;
            float currentHeight = diagramBounds.Height * progress;

            float diagramCenterX = diagramBounds.X + diagramBounds.Width / 2.0f;
            float diagramCenterY = diagramBounds.Y + diagramBounds.Height / 2.0f;

            float dx = (currentWidth - diagramBounds.Width) / 2;
            float dy = (currentHeight - diagramBounds.Height) / 2;

            modifier.Translate(-dx, -dy);
            modifier.Scale(progress, progress);

            modifier.Translate(diagramCenterX, diagramCenterY);
            modifier.Rotate(progress * 360 * RotationCount);
            modifier.Translate(-diagramCenterX, -diagramCenterY);
        }

        protected override ChartElement CreateObjectForClone()
        {
            return new XYSeriesRotateAndZoomAnimation();
        }
    }
}
