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
        public MyTileBar03()
        {
            InitializeComponent();

            MyDevExpressFunctions.InitSearchLookUpEdit(this.slueSelect, "DEPT_NAME", "DEPT_CODE", true);
            MyDevExpressFunctions.SetVisibleColumnSearchLookUpEdit(this.slueSelect, new string[] { "DEPT_NAME", "DEPT_CODE" }, new string[] { "부서명", "부서코드" });
            this.slueSelect.Properties.DataSource = new MyDatabaseConnect01().connection2();
            //this.slueSelect.EditValueChanged += SlueSelect_EditValueChanged;
            MyDevExpressFunctions.MakeWindowsUIButtonPanel(this.windowsUIButtonPanel1, new string[] { "검색", "초기화", "저장", "프린트", "차트" });
            WindowsUIButton btnSearch = this.windowsUIButtonPanel1.Buttons["검색"] as WindowsUIButton;
            WindowsUIButton btnReset = this.windowsUIButtonPanel1.Buttons["초기화"] as WindowsUIButton;
            btnSearch.Click += BtnSearch_Click;
            btnReset.Click += BtnReset_Click;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            int col = layoutControlGroup2.OptionsTableLayoutGroup.ColumnCount;
            int row = layoutControlGroup2.OptionsTableLayoutGroup.RowCount;
            for (int x = 0; x < col; x++)
            {
                this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.RemoveAt(0);
            }
            for (int x = 0; x < row; x++)
            {
                this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.RemoveAt(0);
            }
            this.layoutControl2.Controls.Clear();
            this.layoutControl2.Clear();
            this.layoutControlGroup2.Clear();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BtnReset_Click(null,null);
            MyDevExpressFunctions.MakeLayoutContol(this.layoutControlGroup2, this.slueSelect.EditValue.ToString());
            this.groupControl2.Focus();
        }
    }
}
