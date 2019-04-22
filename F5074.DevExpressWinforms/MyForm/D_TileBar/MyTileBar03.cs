using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using F5074.DevExpressWinforms.MyUserControl;
using DevExpress.XtraBars.Docking2010;

namespace F5074.DevExpressWinforms.MyForm.D_TileBar
{
    public partial class MyTileBar03 : UserControl
    {
        public MyTileBar03()
        {
            InitializeComponent();
            //구분 (입력 데이터사용)
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn() { DataType = System.Type.GetType("System.String"), ColumnName = "VALUE", Caption = "구분" });
            myDataTable.Columns.Add(new DataColumn() { DataType = System.Type.GetType("System.String"), ColumnName = "DESC", Caption = "이름" });
            myDataTable.Rows.Add("All", "형압반");
            myDataTable.Rows.Add("defect", "불량");
            myDataTable.Rows.Add("specialTreat", "특채");
            InitSearchLookUpEdit(this.slueSelect, "VALUE", "VALUE", true);
            this.slueSelect.Properties.DataSource = myDataTable;
            this.slueSelect.EditValueChanged += SlueSelect_EditValueChanged;
            MakeButtonPanel();
        }
        private void SlueSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (this.slueSelect.EditorContainsFocus == true)
            {
                DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition() { Width = 100D, SizeType = SizeType.Percent };
                DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute };
                DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute };
                DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute };
                DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute };
                DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute };
                DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute };
                DevExpress.XtraLayout.LayoutControlItem layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
                DevExpress.XtraLayout.LayoutControlItem layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
                DevExpress.XtraLayout.LayoutControlItem layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
                DevExpress.XtraLayout.LayoutControlItem layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
                DevExpress.XtraLayout.LayoutControlItem layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
                layoutControlItem1.OptionsTableLayoutItem.RowIndex = 0;
                layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
                layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
                layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
                layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;

                this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
                this.layoutControlGroup2.GroupBordersVisible = false;
                this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
                this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
                this.layoutControlGroup2.Name = "layoutControlGroup1";
                this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] { columnDefinition1 });
                this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6 });
                this.layoutControlGroup2.Size = new System.Drawing.Size(796, 620);
                this.layoutControlGroup2.TextVisible = false;
                this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5 });

                MyUserControl01 myuser01 = new MyUserControl01("설비1", Color.FromArgb(0x00, 0x87, 0x9C), "53%", "00:23:20", "10%", 10);
                MyUserControl01 myuser02 = new MyUserControl01("설비2", Color.FromArgb(0xCC, 0x6D, 0x00), "84#", "00:07:20", "11%", 11);
                MyUserControl01 myuser03 = new MyUserControl01("설비3", Color.FromArgb(0x40, 0x40, 0x40), "76%", "01:25:20", "8%", 8);
                MyUserControl01 myuser04 = new MyUserControl01("설비4", Color.FromArgb(0x00, 0x73, 0xC4), "92%", "00:53:21", "6%", 6);
                MyUserControl01 myuser05 = new MyUserControl01("설비5", Color.FromArgb(0x40, 0x40, 0x40), "72%", "00:27:20", "10%", 10);
                this.layoutControl2.Controls.Add(myuser01);
                this.layoutControl2.Controls.Add(myuser02);
                this.layoutControl2.Controls.Add(myuser03);
                this.layoutControl2.Controls.Add(myuser04);
                this.layoutControl2.Controls.Add(myuser05);
                for (int x = 0; x < 5; x++)
                {

                }
                layoutControlItem1.Control = myuser01;
                layoutControlItem2.Control = myuser02;
                layoutControlItem3.Control = myuser03;
                layoutControlItem4.Control = myuser04;
                layoutControlItem5.Control = myuser05;


            }
        }

        public static void InitSearchLookUpEdit(SearchLookUpEdit slEdit, string displayMember, string valueMember, bool addClearButton = true)
        {
            slEdit.EditValue = null;
            if (addClearButton)
            {
                bool isDelete = false;
                foreach (EditorButton btn in slEdit.Properties.Buttons)
                {
                    if (btn.Kind.Equals(ButtonPredefines.Delete))
                    {
                        isDelete = true;
                    }
                }
                if (!isDelete)
                {
                    slEdit.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Delete));
                    slEdit.Properties.ButtonClick += Properties_ButtonClick;
                }
            }
            slEdit.Properties.ShowClearButton = false;
            slEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            slEdit.Properties.DisplayMember = displayMember;
            slEdit.Properties.ValueMember = valueMember;
        }

        private static void Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!((SearchLookUpEdit)sender).ReadOnly)
                ((SearchLookUpEdit)sender).EditValue = null;
        }
        private void MakeButtonPanel()
        {
            WindowsUIButton btn1 = new WindowsUIButton("검색", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/chart/bar_32x32.png") });
            //WindowsUIButton btn2 = new WindowsUIButton("Btn2", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_32x32.png") });
            //WindowsUIButton btn3 = new WindowsUIButton("Btn3", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_32x32.png") });
            //WindowsUIButton btn4 = new WindowsUIButton("Btn4", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_32x32.png") });
            WindowsUISeparator separator = new DevExpress.XtraBars.Docking2010.WindowsUISeparator();

            this.windowsUIButtonPanel1.AllowGlyphSkinning = true;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { btn1 });
            this.windowsUIButtonPanel1.ButtonClick += windowsUIButtonPanel1_ButtonClick;

            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1213, 73);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(159, 159, 159);
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(159, 159, 159);
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseForeColor = true;
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("Btn1"))
            {
                MessageBox.Show("Btn1");
            }
            else if (btn.Caption != null && btn.Caption.Equals("Btn2"))
            {
                MessageBox.Show("Btn2");
            }
        }
    }
}
