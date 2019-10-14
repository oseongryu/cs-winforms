namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    partial class MyGridControl17
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyGridControl17));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attachRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.ZoomAccelerationFactor = 1D;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // GridControl1
            // 
            this.GridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl1.Location = new System.Drawing.Point(53, 114);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.attachRepositoryItemButtonEdit,
            this.RepositoryItemPictureEdit1});
            this.GridControl1.Size = new System.Drawing.Size(621, 242);
            this.GridControl1.TabIndex = 1;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(218)))), ((int)(((byte)(228)))));
            this.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.Empty.Options.UseBackColor = true;
            this.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.GridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.GridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.GridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.GridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.GridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.GridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.GridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.GridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            this.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            this.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.GridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.GridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.GridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.GridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.GridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.GridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.GridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.GridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.GridView1.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.GridView1.Appearance.Preview.Options.UseBackColor = true;
            this.GridView1.Appearance.Preview.Options.UseForeColor = true;
            this.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.GridView1.Appearance.Row.Options.UseBackColor = true;
            this.GridView1.Appearance.Row.Options.UseForeColor = true;
            this.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.GridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(161)))));
            this.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.GridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(185)))), ((int)(((byte)(200)))));
            this.GridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridColumn1,
            this.GridColumn2,
            this.GridColumn3,
            this.GridColumn4,
            this.GridColumn5});
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.GridView1.OptionsView.EnableAppearanceOddRow = true;
            this.GridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.GridView1.PaintStyleName = "Style3D";
            // 
            // GridColumn1
            // 
            this.GridColumn1.Caption = "ID";
            this.GridColumn1.FieldName = "Id";
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            this.GridColumn1.Width = 30;
            // 
            // GridColumn2
            // 
            this.GridColumn2.Caption = "Parent";
            this.GridColumn2.FieldName = "ParentItem";
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 1;
            this.GridColumn2.Width = 95;
            // 
            // GridColumn3
            // 
            this.GridColumn3.Caption = "Another";
            this.GridColumn3.FieldName = "AnotherColumn";
            this.GridColumn3.Name = "GridColumn3";
            this.GridColumn3.Visible = true;
            this.GridColumn3.VisibleIndex = 2;
            this.GridColumn3.Width = 95;
            // 
            // GridColumn4
            // 
            this.GridColumn4.ColumnEdit = this.attachRepositoryItemButtonEdit;
            this.GridColumn4.MaxWidth = 26;
            this.GridColumn4.MinWidth = 26;
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.OptionsColumn.ShowCaption = false;
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 3;
            this.GridColumn4.Width = 26;
            // 
            // attachRepositoryItemButtonEdit
            // 
            this.attachRepositoryItemButtonEdit.AutoHeight = false;
            this.attachRepositoryItemButtonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.attachRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.attachRepositoryItemButtonEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.attachRepositoryItemButtonEdit.Name = "attachRepositoryItemButtonEdit";
            this.attachRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // GridColumn5
            // 
            this.GridColumn5.Caption = "Image";
            this.GridColumn5.ColumnEdit = this.RepositoryItemPictureEdit1;
            this.GridColumn5.FieldName = "Image";
            this.GridColumn5.Name = "GridColumn5";
            this.GridColumn5.Visible = true;
            this.GridColumn5.VisibleIndex = 4;
            this.GridColumn5.Width = 243;
            // 
            // RepositoryItemPictureEdit1
            // 
            this.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1";
            this.RepositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // MyGridControl17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridControl1);
            this.Name = "MyGridControl17";
            this.Size = new System.Drawing.Size(726, 470);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        internal DevExpress.XtraGrid.GridControl GridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit attachRepositoryItemButtonEdit;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        internal DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit RepositoryItemPictureEdit1;
    }
}
