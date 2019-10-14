namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    partial class MyChartControl11
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
            DevExpress.XtraCharts.CrosshairFreePosition crosshairFreePosition1 = new DevExpress.XtraCharts.CrosshairFreePosition();
            this.myDevExpressImages011 = new F5074.DevExpressWinforms.MyForm.F_DevExpressImages.MyDevExpressImages01();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // myDevExpressImages011
            // 
            this.myDevExpressImages011.Location = new System.Drawing.Point(785, 294);
            this.myDevExpressImages011.Name = "myDevExpressImages011";
            this.myDevExpressImages011.Size = new System.Drawing.Size(938, 464);
            this.myDevExpressImages011.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1;
            this.chartControl1.DataBindings = null;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(843, 515);
            this.chartControl1.TabIndex = 1;
            // 
            // MyChartControl11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.myDevExpressImages011);
            this.Name = "MyChartControl11";
            this.Size = new System.Drawing.Size(843, 515);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private F_DevExpressImages.MyDevExpressImages01 myDevExpressImages011;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
