namespace F5074.DevExpressWinforms.MyForm.E_WindowsUIView
{
    partial class MyWindowsUIView01
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.labelComponent1 = new DevExpress.XtraGauges.Win.Base.LabelComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.ColorScheme.TargetElements = ((DevExpress.XtraGauges.Core.Base.TargetElement)((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar | DevExpress.XtraGauges.Core.Base.TargetElement.Label)));
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(368, 158);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(260, 260);
            this.gaugeControl1.TabIndex = 0;
            // 
            // circularGauge1
            // 
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 248, 248);
            this.circularGauge1.Labels.AddRange(new DevExpress.XtraGauges.Win.Base.LabelComponent[] {
            this.labelComponent1});
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.RangeBars.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent[] {
            this.arcScaleRangeBarComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            // 
            // labelComponent1
            // 
            this.labelComponent1.AppearanceText.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.labelComponent1.Name = "circularGauge1_Label1";
            this.labelComponent1.Size = new System.Drawing.SizeF(140F, 60F);
            this.labelComponent1.Text = "910";
            this.labelComponent1.ZOrder = -1001;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 90F;
            this.arcScaleComponent1.MajorTickCount = 0;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 0;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent1.Name = "scale1";
            this.arcScaleComponent1.StartAngle = -270F;
            this.arcScaleComponent1.Value = 20F;
            // 
            // arcScaleRangeBarComponent1
            // 
            this.arcScaleRangeBarComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2";
            this.arcScaleRangeBarComponent1.RoundedCaps = true;
            this.arcScaleRangeBarComponent1.ShowBackground = true;
            this.arcScaleRangeBarComponent1.StartOffset = 80F;
            this.arcScaleRangeBarComponent1.ZOrder = -10;
            // 
            // MyWindowsUIView01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gaugeControl1);
            this.Name = "MyWindowsUIView01";
            this.Size = new System.Drawing.Size(1151, 539);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleRangeBarComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Base.LabelComponent labelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent arcScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
    }
}
