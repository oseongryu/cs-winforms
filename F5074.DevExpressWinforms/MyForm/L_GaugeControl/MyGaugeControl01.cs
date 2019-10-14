using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraGauges.Base;

namespace F5074.DevExpressWinforms.MyForm.L_GaugeControl
{
    public partial class MyGaugeControl01 : UserControl
    {
        public MyGaugeControl01()
        {
            InitializeComponent();
            timer1.Start();
            SetUpAnimation();
            timer1.Tick += OnTimerTick;
        }


        private void SetUpAnimation()
        {
            arcScaleComponent1.EnableAnimation = true;
            arcScaleComponent1.EasingFunction = new BackEase();
            arcScaleComponent1.EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;

            arcScaleComponent2.EnableAnimation = true;
            arcScaleComponent2.EasingFunction = new CircleEase();
            arcScaleComponent2.EasingMode = EasingMode.EaseIn;

            linearScaleComponent1.EnableAnimation = true;
            linearScaleComponent1.EasingFunction = new QuadraticEase();
            linearScaleComponent1.EasingMode = EasingMode.EaseOut;
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            DoAnimation(gaugeControl1);
        }

        void DoAnimation(GaugeControl gauge)
        {
            foreach (IGauge gb in gauge.Gauges)
            {
                ICircularGauge cGauge = gb as ICircularGauge;
                if (cGauge != null)
                {
                    foreach (IScale scale in cGauge.Scales) scale.Value = AnimateScaleValue(scale);
                }
                ILinearGauge lGauge = gb as ILinearGauge;
                if (lGauge != null)
                {
                    foreach (IScale scale in lGauge.Scales) scale.Value = AnimateScaleValue(scale);
                }
            }
        }

        float AnimateScaleValue(IScale scale)
        {
            Random r = new Random();
            return 100;
        }
    }
}
