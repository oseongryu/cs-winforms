namespace F5074.DevExpressWinforms.MyForm.K_XtraDiagram
{
    partial class MyXtraDiagram01
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
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.diagramToolboxDockPanel1 = new DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel();
            this.diagramPropertyGridDockPanel1 = new DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel();
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.diagramControlDockPanel1 = new DevExpress.XtraDiagram.Docking.DiagramControlDockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.hideContainerRight = new DevExpress.XtraBars.Docking.AutoHideContainer();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramPropertyGridDockPanel1.PropertyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            this.diagramControlDockPanel1.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            this.hideContainerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramControl1
            // 
            this.diagramControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramControl1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape3});
            this.diagramControl1.Location = new System.Drawing.Point(0, 0);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.PropertyGrid = this.diagramPropertyGridDockPanel1;
            this.diagramControl1.Size = new System.Drawing.Size(993, 562);
            this.diagramControl1.TabIndex = 0;
            this.diagramControl1.Text = "diagramControl1";
            this.diagramControl1.Toolbox = this.diagramToolboxDockPanel1;
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerRight});
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.diagramToolboxDockPanel1,
            this.diagramControlDockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroupProperties.ShowTabHeader = false;
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1});
            this.tabbedView1.RootContainer.Element = null;
            dockingContainer2.Element = this.documentGroup1;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer2});
            // 
            // diagramToolboxDockPanel1
            // 
            this.diagramToolboxDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.diagramToolboxDockPanel1.FloatSize = new System.Drawing.Size(200, 500);
            this.diagramToolboxDockPanel1.ID = new System.Guid("0616dd1c-b1cb-4d71-8062-6a45adde778d");
            this.diagramToolboxDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.diagramToolboxDockPanel1.Name = "diagramToolboxDockPanel1";
            this.diagramToolboxDockPanel1.Options.AllowFloating = false;
            this.diagramToolboxDockPanel1.OriginalSize = new System.Drawing.Size(267, 200);
            this.diagramToolboxDockPanel1.Size = new System.Drawing.Size(267, 568);
            // 
            // 
            // 
            this.diagramToolboxDockPanel1.Toolbox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramToolboxDockPanel1.Toolbox.Caption = "Shapes";
            this.diagramToolboxDockPanel1.Toolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramToolboxDockPanel1.Toolbox.Location = new System.Drawing.Point(0, 0);
            this.diagramToolboxDockPanel1.Toolbox.Name = "";
            this.diagramToolboxDockPanel1.Toolbox.OptionsBehavior.ItemSelectMode = DevExpress.XtraToolbox.ToolboxItemSelectMode.Single;
            this.diagramToolboxDockPanel1.Toolbox.OptionsView.ItemImageSize = new System.Drawing.Size(32, 32);
            this.diagramToolboxDockPanel1.Toolbox.OptionsView.MenuButtonCaption = "More Shapes";
            this.diagramToolboxDockPanel1.Toolbox.OptionsView.ShowToolboxCaption = true;
            this.diagramToolboxDockPanel1.Toolbox.SelectedGroupIndex = 1;
            this.diagramToolboxDockPanel1.Toolbox.Size = new System.Drawing.Size(291, 541);
            this.diagramToolboxDockPanel1.Toolbox.TabIndex = 0;
            this.diagramToolboxDockPanel1.Toolbox.Text = "Shapes";
            // 
            // diagramPropertyGridDockPanel1
            // 
            this.diagramPropertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.diagramPropertyGridDockPanel1.ID = new System.Guid("d4cedabe-404c-4b5c-aa6c-2eb8356b1a9f");
            this.diagramPropertyGridDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.diagramPropertyGridDockPanel1.Name = "diagramPropertyGridDockPanel1";
            this.diagramPropertyGridDockPanel1.Options.AllowFloating = false;
            this.diagramPropertyGridDockPanel1.OriginalSize = new System.Drawing.Size(300, 200);
            // 
            // 
            // 
            this.diagramPropertyGridDockPanel1.PropertyGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.diagramPropertyGridDockPanel1.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramPropertyGridDockPanel1.PropertyGrid.Location = new System.Drawing.Point(0, 31);
            this.diagramPropertyGridDockPanel1.PropertyGrid.Name = "propertyGrid";
            this.diagramPropertyGridDockPanel1.PropertyGrid.OptionsMenu.EnableContextMenu = true;
            this.diagramPropertyGridDockPanel1.PropertyGrid.Size = new System.Drawing.Size(291, 510);
            this.diagramPropertyGridDockPanel1.PropertyGrid.TabIndex = 6;
            this.diagramPropertyGridDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.diagramPropertyGridDockPanel1.SavedIndex = 1;
            this.diagramPropertyGridDockPanel1.Size = new System.Drawing.Size(300, 568);
            this.diagramPropertyGridDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // document1
            // 
            this.document1.Caption = "";
            this.document1.ControlName = "diagramControlDockPanel1";
            this.document1.FloatLocation = new System.Drawing.Point(0, 0);
            this.document1.FloatSize = new System.Drawing.Size(300, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.False;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1});
            // 
            // diagramControlDockPanel1
            // 
            this.diagramControlDockPanel1.Controls.Add(this.controlContainer1);
            this.diagramControlDockPanel1.DockedAsTabbedDocument = true;
            this.diagramControlDockPanel1.FloatSize = new System.Drawing.Size(300, 200);
            this.diagramControlDockPanel1.ID = new System.Guid("f678d782-b235-47de-a213-332cb4816f28");
            this.diagramControlDockPanel1.Name = "diagramControlDockPanel1";
            this.diagramControlDockPanel1.Options.AllowFloating = false;
            this.diagramControlDockPanel1.Options.ShowCloseButton = false;
            this.diagramControlDockPanel1.OriginalSize = new System.Drawing.Size(300, 200);
            this.diagramControlDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.diagramControlDockPanel1.SavedIndex = 1;
            // 
            // controlContainer1
            // 
            this.controlContainer1.Controls.Add(this.diagramControl1);
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(993, 562);
            this.controlContainer1.TabIndex = 0;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(100F, 100F);
            this.diagramShape1.Size = new System.Drawing.SizeF(100F, 75F);
            // 
            // diagramShape2
            // 
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(100F, 200F);
            this.diagramShape2.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse;
            this.diagramShape2.Size = new System.Drawing.SizeF(100F, 75F);
            // 
            // diagramShape3
            // 
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(100F, 300F);
            this.diagramShape3.Size = new System.Drawing.SizeF(100F, 75F);
            // 
            // hideContainerRight
            // 
            this.hideContainerRight.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerRight.Controls.Add(this.diagramPropertyGridDockPanel1);
            this.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideContainerRight.Location = new System.Drawing.Point(1266, 0);
            this.hideContainerRight.Name = "hideContainerRight";
            this.hideContainerRight.Size = new System.Drawing.Size(20, 568);
            // 
            // MyXtraDiagram01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.diagramToolboxDockPanel1);
            this.Controls.Add(this.hideContainerRight);
            this.Name = "MyXtraDiagram01";
            this.Size = new System.Drawing.Size(1286, 568);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramPropertyGridDockPanel1.PropertyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            this.diagramControlDockPanel1.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            this.hideContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraDiagram.Docking.DiagramPropertyGridDockPanel diagramPropertyGridDockPanel1;
        private DevExpress.XtraDiagram.Docking.DiagramToolboxDockPanel diagramToolboxDockPanel1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraDiagram.Docking.DiagramControlDockPanel diagramControlDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerRight;
    }
}
