namespace F5074.DevExpressWinforms.MyForm.C_Charts
{
    partial class MyCharts03
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
            DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint1 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition1 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView2 = new DevExpress.XtraCharts.AreaSeriesView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreviousDate = new DevExpress.XtraEditors.CheckButton();
            this.btnCurrentDate = new DevExpress.XtraEditors.CheckButton();
            this.valuePresenter1 = new F5074.DevExpressWinforms.MyForm.C_Charts.ucValuePresenter();
            this.valuePresenter0 = new F5074.DevExpressWinforms.MyForm.C_Charts.ucValuePresenter();
            this.valuePresenter2 = new F5074.DevExpressWinforms.MyForm.C_Charts.ucValuePresenter();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.chart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1280, 633);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            chartAnchorPoint1.X = 50;
            chartAnchorPoint1.Y = 30;
            textAnnotation1.AnchorPoint = chartAnchorPoint1;
            textAnnotation1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            textAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            textAnnotation1.Name = "Text Annotation 1";
            textAnnotation1.Padding.Bottom = 7;
            textAnnotation1.Padding.Left = 7;
            textAnnotation1.Padding.Right = 10;
            textAnnotation1.Padding.Top = 7;
            textAnnotation1.Shadow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            textAnnotation1.Shadow.Size = 1;
            textAnnotation1.ShapeKind = DevExpress.XtraCharts.ShapeKind.Rectangle;
            freePosition1.DockTargetName = "Default Pane";
            textAnnotation1.ShapePosition = freePosition1;
            this.chart.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1});
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "9";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0D;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Margins.Left = 35;
            xyDiagram1.Margins.Right = 21;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None;
            this.chart.Legend.MarkerSize = new System.Drawing.Size(1, 16);
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 42);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            this.chart.Padding.Left = 0;
            this.chart.Padding.Right = 0;
            pointSeriesLabel1.TextPattern = "{V:N0}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            areaSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            areaSeriesView1.Transparency = ((byte)(64));
            series1.View = areaSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            areaSeriesView2.Transparency = ((byte)(0));
            this.chart.SeriesTemplate.View = areaSeriesView2;
            this.chart.Size = new System.Drawing.Size(1280, 549);
            this.chart.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.valuePresenter1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.valuePresenter0, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.valuePresenter2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 37);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnForward, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPreviousDate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCurrentDate, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 591);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1280, 37);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBack.Location = new System.Drawing.Point(40, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 31);
            this.btnBack.TabIndex = 0;
            // 
            // btnForward
            // 
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForward.Location = new System.Drawing.Point(1202, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 31);
            this.btnForward.TabIndex = 1;
            // 
            // btnPreviousDate
            // 
            this.btnPreviousDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreviousDate.Location = new System.Drawing.Point(98, 3);
            this.btnPreviousDate.Name = "btnPreviousDate";
            this.btnPreviousDate.Size = new System.Drawing.Size(546, 31);
            this.btnPreviousDate.TabIndex = 2;
            this.btnPreviousDate.Text = "prev";
            // 
            // btnCurrentDate
            // 
            this.btnCurrentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCurrentDate.Location = new System.Drawing.Point(650, 3);
            this.btnCurrentDate.Name = "btnCurrentDate";
            this.btnCurrentDate.Size = new System.Drawing.Size(546, 31);
            this.btnCurrentDate.TabIndex = 3;
            this.btnCurrentDate.Text = "current";
            // 
            // valuePresenter1
            // 
            this.valuePresenter1.Location = new System.Drawing.Point(44, 3);
            this.valuePresenter1.Name = "valuePresenter1";
            this.valuePresenter1.Size = new System.Drawing.Size(407, 31);
            this.valuePresenter1.TabIndex = 0;
            this.valuePresenter1.TitleText = "title";
            this.valuePresenter1.Value = 0D;
            this.valuePresenter1.ValueFormat = null;
            this.valuePresenter1.ValueTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // valuePresenter0
            // 
            this.valuePresenter0.Location = new System.Drawing.Point(457, 3);
            this.valuePresenter0.Name = "valuePresenter0";
            this.valuePresenter0.Size = new System.Drawing.Size(406, 31);
            this.valuePresenter0.TabIndex = 1;
            this.valuePresenter0.TitleText = "title";
            this.valuePresenter0.Value = 0D;
            this.valuePresenter0.ValueFormat = null;
            this.valuePresenter0.ValueTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // valuePresenter2
            // 
            this.valuePresenter2.Location = new System.Drawing.Point(869, 3);
            this.valuePresenter2.Name = "valuePresenter2";
            this.valuePresenter2.Size = new System.Drawing.Size(408, 31);
            this.valuePresenter2.TabIndex = 2;
            this.valuePresenter2.TitleText = "title";
            this.valuePresenter2.Value = 0D;
            this.valuePresenter2.ValueFormat = null;
            this.valuePresenter2.ValueTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // MyCharts03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "MyCharts03";
            this.Size = new System.Drawing.Size(1280, 633);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraCharts.ChartControl chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.CheckButton btnPreviousDate;
        private DevExpress.XtraEditors.CheckButton btnCurrentDate;
        private ucValuePresenter valuePresenter1;
        private ucValuePresenter valuePresenter0;
        private ucValuePresenter valuePresenter2;
    }
}
