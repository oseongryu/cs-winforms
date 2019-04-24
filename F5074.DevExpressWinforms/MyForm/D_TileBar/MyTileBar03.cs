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
using F5074.DevExpressWinforms.MyCommon;

namespace F5074.DevExpressWinforms.MyForm.D_TileBar
{
    public partial class MyTileBar03 : UserControl
    {
        SearchControl searchControl = new SearchControl();

        public MyTileBar03()
        {
            InitializeComponent();

            MyDevExpressFunctions.InitSearchLookUpEdit(this.slueSelect, "DEPT_NAME", "DEPT_CODE", true);
            MyDevExpressFunctions.SetVisibleColumnSearchLookUpEdit(this.slueSelect, new string[] { "DEPT_NAME", "DEPT_CODE" }, new string[] { "부서명", "부서코드" });
            this.slueSelect.Properties.DataSource = new MyDatabaseConnect01().connection2();
            this.slueSelect.EditValueChanged += SlueSelect_EditValueChanged;
            MyDevExpressFunctions.MakeWindowsUIButtonPanel(this.windowsUIButtonPanel1,new string[] {"검색", "초기화", "저장", "프린트","차트" });
            this.windowsUIButtonPanel1.ButtonClick += WindowsUIButtonPanel1_ButtonClick;
        }



        private void WindowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("검색"))
            {

            }
            else if (btn.Caption != null && btn.Caption.Equals("초기화"))
            {
                this.layoutControl2.Controls.Clear();
                this.layoutControl2.Clear();
                this.layoutControlGroup2.Clear();
            }
        }
        
        private void SlueSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (this.slueSelect.EditorContainsFocus == true)
            {


                this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
                this.layoutControlGroup2.GroupBordersVisible = false;
                this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
                this.layoutControlGroup2.Location = new Point(0, 0);
                this.layoutControlGroup2.Name = "layoutControlGroup2";

                this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100D, SizeType = SizeType.Percent });

                for (int x = 0; x < 6; x++)
                {
                    this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition() { Height = 100D, SizeType = SizeType.Absolute });

                }

                this.layoutControlGroup2.Size = new Size(796, 620);
                this.layoutControlGroup2.TextVisible = false;

                LayoutControlItem controlItem;
                MyUserControl01 userControl;
                for (int x = 0; x < 5; x++)
                {
                    controlItem = new LayoutControlItem() { TextVisible = false };
                    controlItem.OptionsTableLayoutItem.RowIndex = x;
                    if (x % 4 == 0)
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
                    else if (x % 4 == 2)
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

                    this.layoutControlGroup2.Items.AddRange(new BaseLayoutItem[] { controlItem });

                }
            }
        }
    }
}
