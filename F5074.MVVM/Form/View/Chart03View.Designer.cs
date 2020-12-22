
namespace F5074.UI.Form.View {
    partial class Chart03View {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart03View));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.tcTab = new DevExpress.XtraTab.XtraTabControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.calFromDate = new DevExpress.XtraEditors.DateEdit();
            this.calToDate = new DevExpress.XtraEditors.DateEdit();
            this.slueEquipment = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.slueCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEquipment = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCategory = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcTab)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.slueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFind);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 70);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1143, 38);
            this.panelControl1.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(5, 4);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 28);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Search";
            // 
            // tcTab
            // 
            this.tcTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTab.Location = new System.Drawing.Point(0, 108);
            this.tcTab.Name = "tcTab";
            this.tcTab.Size = new System.Drawing.Size(1143, 466);
            this.tcTab.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 70);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "조회조건";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.calFromDate);
            this.layoutControl2.Controls.Add(this.calToDate);
            this.layoutControl2.Controls.Add(this.slueEquipment);
            this.layoutControl2.Controls.Add(this.slueCategory);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 21);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(572, 342, 562, 500);
            this.layoutControl2.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1139, 47);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // calFromDate
            // 
            this.calFromDate.EditValue = null;
            this.calFromDate.Location = new System.Drawing.Point(593, 2);
            this.calFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calFromDate.Name = "calFromDate";
            this.calFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFromDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.calFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calFromDate.Size = new System.Drawing.Size(245, 20);
            this.calFromDate.StyleController = this.layoutControl2;
            this.calFromDate.TabIndex = 14;
            // 
            // calToDate
            // 
            this.calToDate.EditValue = null;
            this.calToDate.Location = new System.Drawing.Point(875, 2);
            this.calToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calToDate.Name = "calToDate";
            this.calToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calToDate.Size = new System.Drawing.Size(245, 20);
            this.calToDate.StyleController = this.layoutControl2;
            this.calToDate.TabIndex = 14;
            // 
            // slueEquipment
            // 
            this.slueEquipment.EditValue = "";
            this.slueEquipment.Location = new System.Drawing.Point(35, 2);
            this.slueEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slueEquipment.Name = "slueEquipment";
            this.slueEquipment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueEquipment.Properties.NullText = "";
            this.slueEquipment.Properties.View = this.gridView1;
            this.slueEquipment.Size = new System.Drawing.Size(243, 20);
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
            // slueCategory
            // 
            this.slueCategory.EditValue = "";
            this.slueCategory.Location = new System.Drawing.Point(315, 2);
            this.slueCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slueCategory.Name = "slueCategory";
            this.slueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueCategory.Properties.NullText = "";
            this.slueCategory.Properties.View = this.gridView4;
            this.slueCategory.Size = new System.Drawing.Size(243, 20);
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
            this.lciEquipment,
            this.lciCategory,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 25D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 25D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 25D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 25D;
            this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 26D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 28D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(1122, 54);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // lciEquipment
            // 
            this.lciEquipment.Control = this.slueEquipment;
            this.lciEquipment.CustomizationFormText = "설비번호";
            this.lciEquipment.Location = new System.Drawing.Point(0, 0);
            this.lciEquipment.Name = "lciEquipment";
            this.lciEquipment.Size = new System.Drawing.Size(280, 26);
            this.lciEquipment.Text = "Equip";
            this.lciEquipment.TextSize = new System.Drawing.Size(30, 14);
            // 
            // lciCategory
            // 
            this.lciCategory.Control = this.slueCategory;
            this.lciCategory.CustomizationFormText = "구분";
            this.lciCategory.Location = new System.Drawing.Point(280, 0);
            this.lciCategory.Name = "lciCategory";
            this.lciCategory.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciCategory.Size = new System.Drawing.Size(280, 26);
            this.lciCategory.Text = "Cate";
            this.lciCategory.TextSize = new System.Drawing.Size(30, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.calFromDate;
            this.layoutControlItem6.CustomizationFormText = "기간From";
            this.layoutControlItem6.Location = new System.Drawing.Point(560, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem6.Size = new System.Drawing.Size(280, 26);
            this.layoutControlItem6.Text = "Date";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(26, 14);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.calToDate;
            this.layoutControlItem7.CustomizationFormText = "기간From";
            this.layoutControlItem7.Location = new System.Drawing.Point(840, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem7.Size = new System.Drawing.Size(282, 26);
            this.layoutControlItem7.Text = " ~    ";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(30, 14);
            // 
            // Chart03View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcTab);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Chart03View";
            this.Size = new System.Drawing.Size(1143, 574);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcTab)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.slueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraTab.XtraTabControl tcTab;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.DateEdit calFromDate;
        private DevExpress.XtraEditors.DateEdit calToDate;
        private DevExpress.XtraEditors.SearchLookUpEdit slueEquipment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit slueCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciEquipment;
        private DevExpress.XtraLayout.LayoutControlItem lciCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}
