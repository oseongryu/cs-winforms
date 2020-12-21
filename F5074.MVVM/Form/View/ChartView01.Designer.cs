
namespace F5074.MVVM.Form.View {
    partial class ChartView01 {
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
            this.chartControl4 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl4
            // 
            this.chartControl4.AutoLayout = false;
            this.chartControl4.DataBindings = null;
            this.chartControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl4.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chartControl4.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl4.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl4.Legend.Name = "Default Legend";
            this.chartControl4.Location = new System.Drawing.Point(0, 0);
            this.chartControl4.Name = "chartControl4";
            this.chartControl4.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl4.Size = new System.Drawing.Size(633, 408);
            this.chartControl4.TabIndex = 4;
            this.chartControl4.ToolTipOptions.ShowForPoints = false;
            // 
            // ChartView01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl4);
            this.Name = "ChartView01";
            this.Size = new System.Drawing.Size(633, 408);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl4;
    }
}
