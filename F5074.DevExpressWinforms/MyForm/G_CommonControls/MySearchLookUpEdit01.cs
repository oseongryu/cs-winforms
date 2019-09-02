using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.DevExpressWinforms.MyCommon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.Utils.Win;
using DevExpress.XtraLayout;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MySearchLookUpEdit01 : UserControl
    {
        public MySearchLookUpEdit01()
        {
            InitializeComponent();


            MyDevExpressFunctions.SetVisibleColumnSearchLookUpEdit(this.slueTest, new string[] { "BIG_CLASS", "BIG_CLASS_DESC" }, new string[] { "대분류", "대분류명" });
            MyDevExpressFunctions.InitSearchLookUpEdit(this.slueTest, "BIG_CLASS_DESC", "ROWINDEX", true);

            slueTest.Properties.View.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            slueTest.Properties.View.OptionsSelection.MultiSelect = true;
            slueTest.Properties.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            slueTest.Properties.ShowAddNewButton = true;
            slueTest.Enter += slueTest_Enter;
            slueTest.EditValueChanged += slueTest_EditValueChanged;
            slueTest.CustomDisplayText += slueTest_CustomDisplayText;
            slueTest.Closed += searchLookUpEdit_Closed;
            slueTest.Popup += AddNewButtonChangeCaption_Popup; // AddNewButton Caption
            MyDevExpressFunctions.SetBestFitPopupSearchLookUpEdit(this.slueTest, 25);
        }
        private void slueTest_Enter(object sender, EventArgs e)
        {

        }

        private void slueTest_EditValueChanged(object sender, EventArgs e)
        {
            //slueMidClass.Properties.DataSource = null;
            //slueSubClass.Properties.DataSource = null;
            //slueMidClass.EditValue = null;
            //slueSubClass.EditValue = null;
        }
        private void slueTest_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            SearchLookUpEdit searchLookUpEdit = sender as SearchLookUpEdit;
            var view = searchLookUpEdit.Properties.View;
            int[] selectedRows = view.GetSelectedRows();
            if (selectedRows.Length > 0)
            {
                string sValues = "";
                for (int iRow = 0; iRow < selectedRows.Length; iRow++)
                {
                    if (iRow == 0)
                    {
                        sValues = view.GetRowCellValue(selectedRows[iRow], "BIG_CLASS_DESC").ToString();
                    }
                    else
                    {
                        sValues += "," + view.GetRowCellValue(selectedRows[iRow], "BIG_CLASS_DESC").ToString();
                    }
                }
                e.DisplayText = sValues;
            }
        }


        private void searchLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            SearchLookUpEdit searchLookUpEdit = sender as SearchLookUpEdit;
            var view = searchLookUpEdit.Properties.View;
            int[] selectedRows = view.GetSelectedRows();
            if (selectedRows.Length > 0)
            {
                string sValues = "";
                for (int iRow = 0; iRow < selectedRows.Length; iRow++)
                {
                    if (iRow == 0)
                    {
                        sValues = view.GetRowCellValue(selectedRows[iRow], "ROWINDEX").ToString();
                    }
                    else
                    {
                        sValues += "," + view.GetRowCellValue(selectedRows[iRow], "ROWINDEX").ToString();
                    }
                }

                searchLookUpEdit.EditValue = sValues;
            }
            else
                searchLookUpEdit.EditValue = null;
        }



        private void AddNewButtonChangeCaption_Popup(object sender, EventArgs e)
        {
            IPopupControl popupControl = sender as IPopupControl;
            LayoutControl layoutControl = popupControl.PopupWindow.Controls[2].Controls[0] as LayoutControl;
            SimpleButton AddNewButton = ((LayoutControlItem)layoutControl.Items.FindByName("lciAddNew")).Control as SimpleButton;

            AddNewButton.Text = "OK";
        }
    }
}
