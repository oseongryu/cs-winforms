namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    partial class MyGridControl16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyGridControl16));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(150, 150);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "add_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "addfile_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "additem_32x32.png");
            this.imageCollection1.Images.SetKeyName(3, "apply_32x32.png");
            this.imageCollection1.Images.SetKeyName(4, "cancel_32x32.png");
            this.imageCollection1.Images.SetKeyName(5, "clear_32x32.png");
            this.imageCollection1.Images.SetKeyName(6, "clearformatting_32x32.png");
            this.imageCollection1.Images.SetKeyName(7, "cleartablestyle_32x32.png");
            this.imageCollection1.Images.SetKeyName(8, "clip_32x32.png");
            this.imageCollection1.Images.SetKeyName(9, "close_32x32.png");
            this.imageCollection1.Images.SetKeyName(10, "convert_32x32.png");
            this.imageCollection1.Images.SetKeyName(11, "converttorange_32x32.png");
            this.imageCollection1.Images.SetKeyName(12, "deletelist_32x32.png");
            this.imageCollection1.Images.SetKeyName(13, "deletelist2_32x32.png");
            this.imageCollection1.Images.SetKeyName(14, "down_32x32.png");
            this.imageCollection1.Images.SetKeyName(15, "download_32x32.png");
            this.imageCollection1.Images.SetKeyName(16, "editname_32x32.png");
            this.imageCollection1.Images.SetKeyName(17, "fill_32x32.png");
            this.imageCollection1.Images.SetKeyName(18, "formatastable_32x32.png");
            this.imageCollection1.Images.SetKeyName(19, "group_32x32.png");
            this.imageCollection1.Images.SetKeyName(20, "group2_32x32.png");
            this.imageCollection1.Images.SetKeyName(21, "hide_32x32.png");
            this.imageCollection1.Images.SetKeyName(22, "importimage_32x32.png");
            this.imageCollection1.Images.SetKeyName(23, "insert_32x32.png");
            this.imageCollection1.Images.SetKeyName(24, "left_32x32.png");
            this.imageCollection1.Images.SetKeyName(25, "loadfrom_32x32.png");
            this.imageCollection1.Images.SetKeyName(26, "merge_32x32.png");
            this.imageCollection1.Images.SetKeyName(27, "new_32x32.png");
            this.imageCollection1.Images.SetKeyName(28, "newtablestyle_32x32.png");
            this.imageCollection1.Images.SetKeyName(29, "open_32x32.png");
            this.imageCollection1.Images.SetKeyName(30, "open2_32x32.png");
            this.imageCollection1.Images.SetKeyName(31, "openhyperlink_32x32.png");
            this.imageCollection1.Images.SetKeyName(32, "reading_32x32.png");
            this.imageCollection1.Images.SetKeyName(33, "refresh_32x32.png");
            this.imageCollection1.Images.SetKeyName(34, "refresh2_32x32.png");
            this.imageCollection1.Images.SetKeyName(35, "remove_32x32.png");
            this.imageCollection1.Images.SetKeyName(36, "removeitem_32x32.png");
            this.imageCollection1.Images.SetKeyName(37, "reset_32x32.png");
            this.imageCollection1.Images.SetKeyName(38, "reset2_32x32.png");
            this.imageCollection1.Images.SetKeyName(39, "right_32x32.png");
            this.imageCollection1.Images.SetKeyName(40, "selectall_32x32.png");
            this.imageCollection1.Images.SetKeyName(41, "selectall2_32x32.png");
            this.imageCollection1.Images.SetKeyName(42, "show_32x32.png");
            this.imageCollection1.Images.SetKeyName(43, "squeeze_32x32.png");
            this.imageCollection1.Images.SetKeyName(44, "stretch_32x32.png");
            this.imageCollection1.Images.SetKeyName(45, "switchrowcolumn_32x32.png");
            this.imageCollection1.Images.SetKeyName(46, "trash_32x32.png");
            this.imageCollection1.Images.SetKeyName(47, "up2_32x32.png");
            // 
            // MyGridControl16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "MyGridControl16";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
