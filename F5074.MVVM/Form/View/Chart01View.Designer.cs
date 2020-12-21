
namespace F5074.MVVM.Form.View {
    partial class Chart01View {
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.calFromDate = new DevExpress.XtraEditors.DateEdit();
            this.calToDate = new DevExpress.XtraEditors.DateEdit();
            this.slueEquipment = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sluePartNumber = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.slueItemSpec = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.slueCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciItemSpec = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPartNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEquipment = new DevExpress.XtraLayout.LayoutControlItem();
            this.chartTab1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueEquipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueItemSpec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItemSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTab1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 70);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(633, 338);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.chartTab1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(627, 309);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(633, 70);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "조회조건";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.calFromDate);
            this.layoutControl2.Controls.Add(this.calToDate);
            this.layoutControl2.Controls.Add(this.slueEquipment);
            this.layoutControl2.Controls.Add(this.sluePartNumber);
            this.layoutControl2.Controls.Add(this.slueItemSpec);
            this.layoutControl2.Controls.Add(this.slueCategory);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 21);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(572, 342, 562, 500);
            this.layoutControl2.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(629, 47);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // calFromDate
            // 
            this.calFromDate.EditValue = null;
            this.calFromDate.Location = new System.Drawing.Point(47, 28);
            this.calFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calFromDate.Name = "calFromDate";
            this.calFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFromDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.calFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFromDate.Size = new System.Drawing.Size(104, 20);
            this.calFromDate.StyleController = this.layoutControl2;
            this.calFromDate.TabIndex = 14;
            // 
            // calToDate
            // 
            this.calToDate.EditValue = null;
            this.calToDate.Location = new System.Drawing.Point(198, 28);
            this.calToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calToDate.Name = "calToDate";
            this.calToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calToDate.Size = new System.Drawing.Size(106, 20);
            this.calToDate.StyleController = this.layoutControl2;
            this.calToDate.TabIndex = 14;
            // 
            // slueEquipment
            // 
            this.slueEquipment.EditValue = "";
            this.slueEquipment.Location = new System.Drawing.Point(45, 2);
            this.slueEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slueEquipment.Name = "slueEquipment";
            this.slueEquipment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueEquipment.Properties.NullText = "";
            this.slueEquipment.Properties.View = this.gridView1;
            this.slueEquipment.Size = new System.Drawing.Size(106, 20);
            this.slueEquipment.StyleController = this.layoutControl2;
            this.slueEquipment.TabIndex = 19;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // sluePartNumber
            // 
            this.sluePartNumber.EditValue = "";
            this.sluePartNumber.Location = new System.Drawing.Point(351, 2);
            this.sluePartNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sluePartNumber.Name = "sluePartNumber";
            this.sluePartNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sluePartNumber.Properties.NullText = "";
            this.sluePartNumber.Properties.View = this.gridView2;
            this.sluePartNumber.Size = new System.Drawing.Size(106, 20);
            this.sluePartNumber.StyleController = this.layoutControl2;
            this.sluePartNumber.TabIndex = 19;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // slueItemSpec
            // 
            this.slueItemSpec.EditValue = "";
            this.slueItemSpec.Location = new System.Drawing.Point(198, 2);
            this.slueItemSpec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slueItemSpec.Name = "slueItemSpec";
            this.slueItemSpec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueItemSpec.Properties.NullText = "";
            this.slueItemSpec.Properties.View = this.gridView3;
            this.slueItemSpec.Size = new System.Drawing.Size(106, 20);
            this.slueItemSpec.StyleController = this.layoutControl2;
            this.slueItemSpec.TabIndex = 19;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // slueCategory
            // 
            this.slueCategory.EditValue = "";
            this.slueCategory.Location = new System.Drawing.Point(504, 2);
            this.slueCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slueCategory.Name = "slueCategory";
            this.slueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueCategory.Properties.NullText = "";
            this.slueCategory.Properties.View = this.gridView4;
            this.slueCategory.Size = new System.Drawing.Size(106, 20);
            this.slueCategory.StyleController = this.layoutControl2;
            this.slueCategory.TabIndex = 19;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.lciItemSpec,
            this.lciPartNumber,
            this.lciCategory,
            this.lciEquipment});
            this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 25D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition6.Width = 25D;
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition7.Width = 25D;
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition8.Width = 25D;
            this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition5,
            columnDefinition6,
            columnDefinition7,
            columnDefinition8});
            rowDefinition3.Height = 26D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 28D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition3,
            rowDefinition4});
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(612, 54);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.calFromDate;
            this.layoutControlItem6.CustomizationFormText = "기간From";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(153, 28);
            this.layoutControlItem6.Text = "집계날짜";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(40, 14);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.calToDate;
            this.layoutControlItem7.CustomizationFormText = "기간From";
            this.layoutControlItem7.Location = new System.Drawing.Point(153, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem7.Size = new System.Drawing.Size(153, 28);
            this.layoutControlItem7.Text = " ~    ";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(40, 14);
            // 
            // lciItemSpec
            // 
            this.lciItemSpec.Control = this.slueItemSpec;
            this.lciItemSpec.CustomizationFormText = " ";
            this.lciItemSpec.Location = new System.Drawing.Point(153, 0);
            this.lciItemSpec.Name = "lciItemSpec";
            this.lciItemSpec.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciItemSpec.Size = new System.Drawing.Size(153, 26);
            this.lciItemSpec.Text = "재종";
            this.lciItemSpec.TextSize = new System.Drawing.Size(40, 14);
            // 
            // lciPartNumber
            // 
            this.lciPartNumber.Control = this.sluePartNumber;
            this.lciPartNumber.CustomizationFormText = " ";
            this.lciPartNumber.Location = new System.Drawing.Point(306, 0);
            this.lciPartNumber.Name = "lciPartNumber";
            this.lciPartNumber.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciPartNumber.Size = new System.Drawing.Size(153, 26);
            this.lciPartNumber.Text = "형번";
            this.lciPartNumber.TextSize = new System.Drawing.Size(40, 14);
            // 
            // lciCategory
            // 
            this.lciCategory.Control = this.slueCategory;
            this.lciCategory.CustomizationFormText = "구분";
            this.lciCategory.Location = new System.Drawing.Point(459, 0);
            this.lciCategory.Name = "lciCategory";
            this.lciCategory.OptionsTableLayoutItem.ColumnIndex = 3;
            this.lciCategory.Size = new System.Drawing.Size(153, 26);
            this.lciCategory.Text = "구분";
            this.lciCategory.TextSize = new System.Drawing.Size(40, 14);
            // 
            // lciEquipment
            // 
            this.lciEquipment.Control = this.slueEquipment;
            this.lciEquipment.CustomizationFormText = "설비번호";
            this.lciEquipment.Location = new System.Drawing.Point(0, 0);
            this.lciEquipment.Name = "lciEquipment";
            this.lciEquipment.Size = new System.Drawing.Size(153, 26);
            this.lciEquipment.Text = "설비번호";
            this.lciEquipment.TextSize = new System.Drawing.Size(40, 14);
            // 
            // chartTab1
            // 
            this.chartTab1.DataBindings = null;
            this.chartTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTab1.Legend.Name = "Default Legend";
            this.chartTab1.Location = new System.Drawing.Point(0, 0);
            this.chartTab1.Name = "chartTab1";
            this.chartTab1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartTab1.Size = new System.Drawing.Size(627, 309);
            this.chartTab1.TabIndex = 4;
            // 
            // Chart01View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Chart01View";
            this.Size = new System.Drawing.Size(633, 408);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueEquipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluePartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueItemSpec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciItemSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTab1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.DateEdit calFromDate;
        private DevExpress.XtraEditors.DateEdit calToDate;
        private DevExpress.XtraEditors.SearchLookUpEdit slueEquipment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit sluePartNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit slueItemSpec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit slueCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem lciItemSpec;
        private DevExpress.XtraLayout.LayoutControlItem lciPartNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciCategory;
        private DevExpress.XtraLayout.LayoutControlItem lciEquipment;
        private DevExpress.XtraCharts.ChartControl chartTab1;
    }
}
