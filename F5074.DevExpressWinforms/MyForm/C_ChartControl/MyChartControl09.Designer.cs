namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    partial class MyChartControl09
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Indiana", new object[] {
            ((object)(528.904D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("Illinois", new object[] {
            ((object)(227.271D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Michigan", new object[] {
            ((object)(372.576D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("Ohio", new object[] {
            ((object)(418.258D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("Wisconsin", new object[] {
            ((object)(211.727D))});
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.pnlChartControl = new DevExpress.XtraEditors.PanelControl();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.pnlBtnAnimate = new DevExpress.XtraEditors.PanelControl();
            this.btnAnimate = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnlChartControl)).BeginInit();
            this.pnlChartControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBtnAnimate)).BeginInit();
            this.pnlBtnAnimate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChartControl
            // 
            this.pnlChartControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlChartControl.Controls.Add(this.chartControl);
            this.pnlChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartControl.Location = new System.Drawing.Point(0, 0);
            this.pnlChartControl.Name = "pnlChartControl";
            this.pnlChartControl.Padding = new System.Windows.Forms.Padding(5, 4, 5, 2);
            this.pnlChartControl.Size = new System.Drawing.Size(150, 119);
            this.pnlChartControl.TabIndex = 3;
            // 
            // chartControl
            // 
            this.chartControl.DataBindings = null;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.Rotated = true;
            this.chartControl.Diagram = xyDiagram2;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(5, 4);
            this.chartControl.Name = "chartControl";
            series2.Name = "2004";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10});
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl.Size = new System.Drawing.Size(140, 113);
            this.chartControl.TabIndex = 0;
            this.chartControl.TabStop = false;
            chartTitle2.Text = "Great Lakes Gross State Product";
            this.chartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // pnlBtnAnimate
            // 
            this.pnlBtnAnimate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlBtnAnimate.Controls.Add(this.btnAnimate);
            this.pnlBtnAnimate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtnAnimate.Location = new System.Drawing.Point(0, 119);
            this.pnlBtnAnimate.Name = "pnlBtnAnimate";
            this.pnlBtnAnimate.Padding = new System.Windows.Forms.Padding(5, 2, 5, 4);
            this.pnlBtnAnimate.Size = new System.Drawing.Size(150, 31);
            this.pnlBtnAnimate.TabIndex = 4;
            // 
            // btnAnimate
            // 
            this.btnAnimate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnimate.Location = new System.Drawing.Point(28, 2);
            this.btnAnimate.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(117, 25);
            this.btnAnimate.TabIndex = 0;
            this.btnAnimate.Text = "Animate";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // MyChartControl09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChartControl);
            this.Controls.Add(this.pnlBtnAnimate);
            this.Name = "MyChartControl09";
            ((System.ComponentModel.ISupportInitialize)(this.pnlChartControl)).EndInit();
            this.pnlChartControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBtnAnimate)).EndInit();
            this.pnlBtnAnimate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlChartControl;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.PanelControl pnlBtnAnimate;
        private DevExpress.XtraEditors.SimpleButton btnAnimate;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}
