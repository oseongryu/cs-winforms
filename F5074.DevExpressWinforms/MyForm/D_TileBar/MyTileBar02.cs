using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using F5074.DevExpressWinforms.MyUserControl;

namespace F5074.DevExpressWinforms.MyForm.D_TileBar
{
    public partial class MyTileBar02 : UserControl
    {
        public MyTileBar02()
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

        }

        private void SlueSelect_EditValueChanged(object sender, EventArgs e)
        {
            if (this.slueSelect.EditorContainsFocus == true)
            {


                string a = this.slueSelect.EditValue == null ? "" : this.slueSelect.EditValue.ToString();
                //MessageBox.Show(a);
                this.tableLayoutPanel1.ColumnCount = 1;
                this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel1.Location = new Point(0, 0);
                this.tableLayoutPanel1.Name = "tableLayoutPanel1";
                this.tableLayoutPanel1.RowCount = 4;
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
                this.tableLayoutPanel1.Size = new Size(1183, 526);
                this.tableLayoutPanel1.TabIndex = 0;

                this.tableLayoutPanel1.Controls.Add(new MyUserControl01("설비1",Color.DodgerBlue, "53%", "00:23:20", "10%", 10), 0, 0);
                this.tableLayoutPanel1.Controls.Add(new MyUserControl01("설비2", Color.DodgerBlue, "84%", "00:07:20", "11%", 11), 1, 0);
                this.tableLayoutPanel1.Controls.Add(new MyUserControl01("설비3", Color.DodgerBlue, "76%", "01:25:20", "8%", 8), 2, 0);
                this.tableLayoutPanel1.Controls.Add(new MyUserControl01("설비4", Color.DodgerBlue, "92%", "00:53:21", "6%", 6), 3, 0);
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
    }
}
