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

    public partial class MyChartControl09 : UserControl
    {
        Series series { get { return chartControl.Series[0]; } }
        SideBySideBarSeriesView view { get { return series.View as SideBySideBarSeriesView; } }
        public MyChartControl09()
        {
            InitializeComponent();
            this.btnAnimate.Click += OnAnimateClick;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad;
            view.Animation = new ZoomInFromCenterBarAnimation
            {
                BeginTime = new TimeSpan( 0, 0, 0 ),
                Duration = new TimeSpan( 0, 0, 2 ),
                PointDelay = new TimeSpan( 0, 0, 0, 0, 250 ),
                PointOrder = PointAnimationOrder.Random,
                EasingFunction = new SineEasingFunction
                {
                    EasingMode = EasingMode.Out
                }
            };
        }

        private void OnAnimateClick(object sender, EventArgs e)
        {
            chartControl.Animate();
        }
    }
    class ZoomInFromCenterBarAnimation : BarAnimationBase
    {
        public override void ApplyState(
                SceneModifier modifier,
                RectangleF diagramBounds,
                BarSeriesPointLayoutParameters barParameters,
                float progress )
        {
            float startPositionX = diagramBounds.Left + diagramBounds.Width / 2;
            float startPositionY = diagramBounds.Top + diagramBounds.Height / 2;

            RectangleF barBounds = barParameters.Bounds;
            float endPositionX = barBounds.Left + barBounds.Width / 2;
            float endPositionY = barBounds.Top + barBounds.Height / 2;

            // Moves bar from the diagram center to its position on the diagram.
            modifier.Translate(
                    ( startPositionX - endPositionX ) * ( 1 - progress ),
                    ( startPositionY - endPositionY ) * ( 1 - progress )
            );

            // Scales bar.
            // Note that methods requiered for correct transform are called in inverse order.
            // This is a feature of affine transformations.
            modifier.Translate( endPositionX, endPositionY );
            modifier.Scale( progress, progress );
            modifier.Translate( -endPositionX, -endPositionY );
        }

        protected override ChartElement CreateObjectForClone()
        {
            return new ZoomInFromCenterBarAnimation();
        }
    }
}
