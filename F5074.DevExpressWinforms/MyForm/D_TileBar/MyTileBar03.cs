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
using DevExpress.XtraLayout;

namespace F5074.DevExpressWinforms.MyForm.D_TileBar
{
    public partial class MyTileBar03 : UserControl
    {
        public MyTileBar03()
        {
            InitializeComponent();

            MakeSlue();
            MakeButtonPanel();
        }

        private void SlueSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (this.slueSelect.EditorContainsFocus == true)
            {


                this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
                this.layoutControlGroup2.GroupBordersVisible = false;
                this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
                this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
                this.layoutControlGroup2.Name = "layoutControlGroup2";

                this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.Add(new DevExpress.XtraLayout.ColumnDefinition() { Width = 100D, SizeType = SizeType.Percent });

                for (int x = 0; x < 6; x++)
                {
                    this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition() { Height = 100D, SizeType = SizeType.Absolute });

                }

                this.layoutControlGroup2.Size = new System.Drawing.Size(796, 620);
                this.layoutControlGroup2.TextVisible = false;

                LayoutControlItem controlItem;
                MyUserControl01 userControl;
                for (int x = 0; x < 5; x++)
                {
                    controlItem = new LayoutControlItem() { TextVisible = false };
                    controlItem.OptionsTableLayoutItem.RowIndex = x;
                    if (x%4 == 0)
                    {
                        // SetUp 하늘색 Color.FromArgb(0x00, 0x87, 0x9C), 주황색 Color.FromArgb(0xCC, 0x6D, 0x00), 파란색 Color.FromArgb(0x00, 0x73, 0xC4), 초록색 Color.FromArgb(0x3E, 0x70, 0x38)
                        userControl = new MyUserControl01("설비 " + (x + 1), Color.FromArgb(0x00, 0x87, 0x9C), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));
                        this.layoutControl2.Controls.Add(userControl);
                        controlItem.Control = userControl;
                    }
                    else if (x % 4 == 1)
                    {
                        // WarmUp
                        userControl = new MyUserControl01("설비 " + (x + 1), Color.FromArgb(0xCC, 0x6D, 0x00), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));
                        this.layoutControl2.Controls.Add(userControl);
                        controlItem.Control = userControl;
                    }
                    else if(x % 4 == 2)
                    {
                        // Run
                        userControl = new MyUserControl01("설비 " + (x + 1), Color.FromArgb(0x00, 0x73, 0xC4), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));
                        this.layoutControl2.Controls.Add(userControl);
                        controlItem.Control = userControl;
                    }
                    else if (x % 4 == 3)
                    {
                        // Stop
                        userControl = new MyUserControl01("설비 " + (x + 1), Color.FromArgb(0x3E, 0x70, 0x38), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));
                        this.layoutControl2.Controls.Add(userControl);
                        controlItem.Control = userControl;
                    }

                    this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { controlItem });

                }
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
        private void MakeSlue()
        {
            DataTable myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn() { DataType = System.Type.GetType("System.String"), ColumnName = "VALUE", Caption = "구분" });
            myDataTable.Columns.Add(new DataColumn() { DataType = System.Type.GetType("System.String"), ColumnName = "DESC", Caption = "이름" });
            myDataTable.Rows.Add("All", "형압반");
            myDataTable.Rows.Add("defect", "불량");
            myDataTable.Rows.Add("specialTreat", "특채");
            InitSearchLookUpEdit(this.slueSelect, "VALUE", "VALUE", true);
            this.slueSelect.Properties.DataSource = myDataTable;
            this.slueSelect.EditValueChanged += SlueSelect_EditValueChanged;
            this.slueSelect.Properties.ShowClearButton = true;
            this.slueSelect.Properties.ShowAddNewButton = true;          
        }

        private void MakeButtonPanel()
        {
            WindowsUIButton btn1 = new WindowsUIButton("검색", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/chart/bar_32x32.png") });
            WindowsUIButton btn2 = new WindowsUIButton("초기화", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_32x32.png") });
            //WindowsUIButton btn3 = new WindowsUIButton("Btn3", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_32x32.png") });
            //WindowsUIButton btn4 = new WindowsUIButton("Btn4", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_32x32.png") });
            WindowsUISeparator separator = new DevExpress.XtraBars.Docking2010.WindowsUISeparator();

            //this.windowsUIButtonPanel1.AllowGlyphSkinning = true;
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { btn1,separator, btn2 });
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
            if (btn.Caption != null && btn.Caption.Equals("검색"))
            {
                MessageBox.Show("Btn1");
            }
            else if (btn.Caption != null && btn.Caption.Equals("초기화"))
            {
                this.layoutControl2.Controls.Clear();
                this.layoutControl2.Clear();
                this.layoutControlGroup2.Clear();
            }
        }
    }
}
