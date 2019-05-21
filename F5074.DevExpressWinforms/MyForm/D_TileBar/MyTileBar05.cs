using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using F5074.DevExpressWinforms.MyCommon;
using F5074.DevExpressWinforms.MyUserControl;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using F5074.DevExpressWinforms.MyDialog;
using DevExpress.Utils;
using static F5074.DevExpressWinforms.MyCommon.MyDatabaseConnect01;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid.Columns;

namespace F5074.DevExpressWinforms.MyForm.D_TileBar
{
    public partial class MyTileBar05 : UserControl
    {
        int checkedRowIndex = -1;
        int checkedGridView1 = 0;
        enum DbColumnIndex
        {
            PROCESS_SEQ,
            PROCESS_DESC,
        }

        string[] oHeaderText = { "공정순서", "공정설명" };
        int[] HeaderWidth = { 40, 50, 40 };

        enum DbColumnIndex2
        {
            DUE_DATE,
            PROD_ORDER_NUMBER,
            PART_NUMBER,
            PROCESS_SEQ
        }

        string[] oHeaderText2 =
        {
             "완료예정일"
            ,"생산오더번호"
            ,"형번"
            , "생산순서"
        };

        int[] HeaderWidth2 = { 100, 100, 100, 50 };


        enum DbColumnIndex3
        {
            CHK,
            EQP_ID,
            CHK2,
            ORDER_COUNT,
            PROD_ORDER_NUMBER,
            PART_NUMBER,

        }

        string[] oHeaderText3 =
        {
             "선택"
            , "장비ID"
            , "선택2"
            , "오더수"
            , "생산오더번호"
            , "형번"


        };
        int[] HeaderWidth3 = { 40, 100, 40, 50, 100, 100 };
        private string ColumnCheckState = "";
        public MyTileBar05()
        {

            InitializeComponent();

            try
            {
                MyDevExpressFunctions.InitSearchLookUpEdit(this.slueSelect, "DEPT_NAME", "DEPT_CODE", true);
                MyDevExpressFunctions.SetVisibleColumnSearchLookUpEdit(this.slueSelect, new string[] { "DEPT_NAME", "DEPT_CODE" }, new string[] { "부서명", "부서코드" });
                this.slueSelect.Properties.DataSource = new MyDatabaseConnect01().connection2();
                //this.slueSelect.EditValueChanged += SlueSelect_EditValueChanged;
                MyDevExpressFunctions.MakeWindowsUIButtonPanel(this.windowsUIButtonPanel1, new string[] { "검색", "초기화", "구분자", "미리보기", "차트", "작업이동", "구분자", "저장", "프린트" });
                WindowsUIButton btnSearch = this.windowsUIButtonPanel1.Buttons["검색"] as WindowsUIButton;
                WindowsUIButton btnReset = this.windowsUIButtonPanel1.Buttons["초기화"] as WindowsUIButton;
                WindowsUIButton btnChart = this.windowsUIButtonPanel1.Buttons["차트"] as WindowsUIButton;
                WindowsUIButton btnPreview = this.windowsUIButtonPanel1.Buttons["미리보기"] as WindowsUIButton;
                WindowsUIButton btnMoveWork = this.windowsUIButtonPanel1.Buttons["작업이동"] as WindowsUIButton;

                //PeekFormButton btnPanelMoveWork = this.flyoutPanel1.OptionsButtonPanel.Buttons["작업이동"] as PeekFormButton;
                //PeekFormButton btnPanelAccept = this.flyoutPanel1.OptionsButtonPanel.Buttons["적용"] as PeekFormButton;
                //PeekFormButton btnPanelDecline = this.flyoutPanel1.OptionsButtonPanel.Buttons["취소"] as PeekFormButton;
                this.flyoutPanel1.ButtonClick += FlyoutPanel1_ButtonClick;
                //btn.clik


                btnSearch.Click += BtnSearch_Click;
                btnReset.Click += BtnReset_Click;
                btnChart.Click += BtnChart_Click;
                btnPreview.Click += BtnPreview_Click;
                //btnMoveWork.Click += BtnMoveWork_Click;
                //btnPanelMoveWork.Click += BtnMoveWork_Click;
                this.gridControl1.Click += GridControl1_Click;

                // https://enginhak.tistory.com/entry/XtraGridView-Column-Header-Checkbox-Add
                this.gridView2.CellValueChanging += GridView2_CellValueChanging;
                this.gridView2.MouseUp += GridView2_MouseUp;
                this.panelComparence.Visible = false;
                //flowLayoutPanel1.MouseDown += FlowLayoutPanel1_MouseDown;
                //MyDevExpressFunctions.InitGridControl(this.gridView1, 0);
                //int iColumnCount = oHeaderText.Length;
                //DevExpress.XtraGrid.Columns.GridColumn[] cCols = new DevExpress.XtraGrid.Columns.GridColumn[iColumnCount];
                //for (int i = 0; i < iColumnCount; i++)
                //{
                //    cCols[i] = new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = Enum.GetNames(typeof(DbColumnIndex))[i].ToString(), Name = Enum.GetNames(typeof(DbColumnIndex))[i], Caption = oHeaderText[i], Visible = true, Width = HeaderWidth[i] };
                //    this.gridView1.Columns.Add(cCols[i]);
                //    MyDevExpressFunctions.SetHeaderAlignmentGridView(this.gridView1, gridView1.Columns.Count - 1);
                //    MyDevExpressFunctions.SetCellAlignmentGridView(this.gridView1, gridView1.Columns.Count - 1);
                //}
                MyDevExpressFunctions.InitGridControl(this.gridView1, 0);

                int iColumnCount = oHeaderText2.Length;



                DevExpress.XtraGrid.Columns.GridColumn[] cCols = new DevExpress.XtraGrid.Columns.GridColumn[iColumnCount];
                for (int i = 0; i < iColumnCount; i++)
                {


                    cCols[i] = new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = Enum.GetNames(typeof(DbColumnIndex2))[i].ToString(), Name = Enum.GetNames(typeof(DbColumnIndex2))[i], Caption = oHeaderText2[i], Visible = true, Width = HeaderWidth2[i] };
                    if (oHeaderText2[i] == "생산순서") cCols[i].Visible = false;
                    this.gridView1.Columns.Add(cCols[i]);
                    MyDevExpressFunctions.SetHeaderAlignmentGridView(this.gridView1, gridView1.Columns.Count - 1);
                    MyDevExpressFunctions.SetCellAlignmentGridView(this.gridView1, gridView1.Columns.Count - 1);
                }


                MyDevExpressFunctions.InitGridControl(this.gridView2, 0);
                this.gridView2.OptionsBehavior.Editable = true;
                iColumnCount = oHeaderText3.Length;

                cCols = new DevExpress.XtraGrid.Columns.GridColumn[iColumnCount];
                for (int i = 0; i < iColumnCount; i++)
                {
                    RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
                    repositoryItemCheckEdit.ValueChecked = "True";
                    repositoryItemCheckEdit.ValueUnchecked = "False";
                    repositoryItemCheckEdit.CheckedChanged += RepositoryItemCheckEdit_CheckedChanged;
                    cCols[i] = new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = Enum.GetNames(typeof(DbColumnIndex3))[i].ToString(), Name = Enum.GetNames(typeof(DbColumnIndex3))[i], Caption = oHeaderText3[i], Visible = true, Width = HeaderWidth3[i] };
                    if (oHeaderText3[i] == "선택") cCols[i].ColumnEdit = repositoryItemCheckEdit;
                    if (oHeaderText3[i] == "선택2") cCols[i].ColumnEdit = repositoryItemCheckEdit;

                    this.gridView2.Columns.Add(cCols[i]);

                    MyDevExpressFunctions.SetHeaderAlignmentGridView(this.gridView2, gridView2.Columns.Count - 1);
                    MyDevExpressFunctions.SetCellAlignmentGridView(this.gridView2, gridView2.Columns.Count - 1);
                }
                this.gridView2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True; // 체크박스 전체 선택가능 헤더만들지 여부
                this.gridView2.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;  // 셀밖에 값을 눌러도 체크박스 온오프만 적용됨
                //gridView2.OptionsSelection.MultiSelect = true;
                //gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridView2.VisibleColumns[2].OptionsColumn.ShowCaption = false;
                this.gridView2.CustomDrawColumnHeader += GridView2_CustomDrawColumnHeader;




                MyDevExpressFunctions.InitGridControl(this.gridView3, 0);
                this.gridView3.OptionsBehavior.Editable = true;
                iColumnCount = oHeaderText3.Length;

                cCols = new DevExpress.XtraGrid.Columns.GridColumn[iColumnCount];
                for (int i = 0; i < iColumnCount; i++)
                {
                    cCols[i] = new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = Enum.GetNames(typeof(DbColumnIndex3))[i].ToString(), Name = Enum.GetNames(typeof(DbColumnIndex3))[i], Caption = oHeaderText3[i], Visible = true, Width = HeaderWidth3[i] };
                    if (oHeaderText3[i] == "선택") cCols[i].Visible = false;
                    if (oHeaderText3[i] == "선택2") cCols[i].Visible = false;
                    this.gridView3.Columns.Add(cCols[i]);

                    MyDevExpressFunctions.SetHeaderAlignmentGridView(this.gridView3, gridView3.Columns.Count - 1);
                    MyDevExpressFunctions.SetCellAlignmentGridView(this.gridView3, gridView3.Columns.Count - 1);
                }
                this.slueSelect.Text = "50000198";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && e.Clicks == 1)
            {
                GridView gridview = sender as GridView;
                if (gridview != null)
                {
                    GridHitInfo hitinfo = gridview.CalcHitInfo(e.Location);

                    if (hitinfo.InRow == false && hitinfo.InColumn == true)
                    {
                        //SetAllCheckBox(!true);
                        //if (AffectCheckBoxChange != null)
                        //    AffectCheckBoxChange(this, null);
                        UnChekAll(gridview);
                    }

                }
                this.gridView2.RefreshData();
                DXMouseEventArgs args = DXMouseEventArgs.GetMouseArgs(e);
                args.Handled = true;
            }
        }



        void DrawCheckBox(Graphics g, Rectangle r, RepositoryItemCheckEdit checkEdit, string isCheck)
        {
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info = default(DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo);
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter = default(DevExpress.XtraEditors.Drawing.CheckEditPainter);
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args = default(DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs);
            info = (CheckEditViewInfo)checkEdit.CreateViewInfo();
            painter = (CheckEditPainter)checkEdit.CreatePainter();

            info.EditValue = isCheck;
            info.Bounds = r;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }

        private void GridView2_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null)
                return;
            if (e.Column.AbsoluteIndex != 2)
                return;
            Rectangle rect = e.Bounds;
            rect.Inflate(-1, -1);

            e.Info.InnerElements.Clear();
            e.Painter.DrawObject(e.Info);
            string sCheckedState = "";
            if (GetCheckCount() == this.gridView2.DataRowCount) sCheckedState = "True";
            else sCheckedState = "False";
            DrawCheckBox(e.Graphics, rect, e.Column.ColumnEdit as RepositoryItemCheckEdit, sCheckedState);
            e.Handled = true;

        }

        //// 모두 체크
        //void CheckAll(GridView gv)
        //{
        //    for (int i = 0; i < gv.DataRowCount; i++)
        //    {
        //        gv.SetRowCellValue(i, gv.Columns["선택2"], "True");
        //    }
        //}

        // 모두 체크 해제
        void UnChekAll(GridView gv)
        {
            if(GetCheckCount() == gv.DataRowCount)
            {
                for (int i = 0; i < gv.DataRowCount; i++)
                {
                    gv.SetRowCellValue(i, "CHK2", (object)"False");

                }
            }
            else
            {
                for (int i = 0; i < gv.DataRowCount; i++)
                {
                    gv.SetRowCellValue(i, "CHK2", (object)"True");

                }
            }



            //gv.RefreshData();
        }

        private int GetCheckCount()
        {
            int count = 0;


            List<DataSevenVo> gridList = this.gridControl2.DataSource as List<DataSevenVo>;


            for (int x = 0; x < gridList.Count; x++)
            {
                if (gridList[x].CHK2.ToString() == "True") count += 1;

            }

            return count;
        }

        private void FlyoutPanel1_ButtonClick(object sender, FlyoutPanelButtonClickEventArgs e)
        {
            try
            {


                string caption = e.Button.Caption.ToString();
                switch (caption)
                {
                    case "작업이동":
                        if (FlyoutDialog.Show(this.FindForm(), MyDevExpressFunctions.CreateCloseAction()) == System.Windows.Forms.DialogResult.Yes)
                        {
                            List<DataSevenVo> gridList = this.gridControl2.DataSource as List<DataSevenVo>;
                            IList<DataSevenVo> resultList = new List<DataSevenVo>();
                            for (int x = 0; x < gridList.Count; x++)
                            {
                                // https://stackoverflow.com/questions/12762617/how-to-get-the-selected-row-values-of-devexpress-xtragrid
                                if (gridList[x].CHK2.ToString() == "True")
                                {
                                    DataSevenVo vo = gridList[x];
                                    vo.EQP_ID = gridList[checkedGridView1].EQP_ID;
                                    vo.ORDER_COUNT = gridList[checkedGridView1].ORDER_COUNT;
                                    resultList.Add(vo);
                                }

                            }
                            this.gridControl3.DataSource = resultList;
                        };

                        break;
                    case "적용":
                        //(sender as FlyoutPanel).HidePopup();
                        //this.panelComparence.Visible = false; this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = false;
                        (sender as FlyoutPanel).HidePopup();
                        this.panelComparence.Visible = false; this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = false; this.gridControl3.Visible = false; this.gridControl3.DataSource = null;
                        break;
                    case "취소":
                        // . . . 
                        (sender as FlyoutPanel).HidePopup();
                        this.panelComparence.Visible = false; this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = false; this.gridControl3.Visible = false; this.gridControl3.DataSource = null;
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RepositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

            //CheckEdit edit = sender as CheckEdit;
            //List<DataSevenVo> gridList = this.gridControl2.DataSource as List<DataSevenVo>;


            //int _count = 0;
            //for (int x = 0; x < gridList.Count; x++)
            //{
            //    if (gridList[x].CHK2.ToString() == "True") _count += 1;

            //}
            //if (edit.Checked == true) 
            //{
            //    _count += 1;
            //}
            //else if(edit.Checked == false)
            //{
            //    _count -= 1;
            //}

            //if (_count >= 1) this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = true;
            //else this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = false;

        }



        private void GridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.Column.FieldName == "CHK" && (string)e.Value == "True")
                {
                    // https://www.devexpress.com/Support/Center/Question/Details/Q411750/single-selection-checkbox-in-a-grid
                    int rowHandle = view.GetRowHandle(checkedRowIndex);
                    view.SetRowCellValue(rowHandle, "CHK", "False");
                    checkedRowIndex = view.GetDataSourceRowIndex(e.RowHandle);
                    checkedGridView1 = e.RowHandle;
                }
                int _count = 0;
                if (e.Column.FieldName == "CHK2")
                {
                    view.SetRowCellValue(view.GetRowHandle(e.RowHandle), "CHK2", e.Value.ToString());
                    List<DataSevenVo> gridList = this.gridControl2.DataSource as List<DataSevenVo>;


                    for (int x = 0; x < gridList.Count; x++)
                    {
                        if (gridList[x].CHK2.ToString() == "True") _count += 1;

                    }

                    if (_count >= 1) this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = true;
                    else this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = false;
                }
                //this.gridControl2.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                this.panelComparence.Visible = true;
                this.gridControl3.Visible = true;

                GridView testView = gridView1 as GridView;
                this.gridControl2.DataSource = new MyDatabaseConnect01().connectionProcessComaparence(testView.GetRowCellValue(testView.FocusedRowHandle, "PART_NUMBER").ToString());

                //flyoutPanel1.Size = new Size(1200, 350);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void BtnMoveWork_Click(object sender, EventArgs e)
        //{
        //    //MyUserControl02 test = this.ActiveControl as MyUserControl02;
        //    //GridControl testControl = test.ActiveControl as GridControl;
        //    //GridView testView = testControl.MainView as GridView;

        //    //ProcessComparenceDialog dialog = new ProcessComparenceDialog(testView.GetRowCellValue(testView.FocusedRowHandle, "PART_NUMBER").ToString());
        //    //dialog.Width = 1300;
        //    //dialog.Height = 350;
        //    //dialog.ShowDialog();
        //}

        //private void FlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    flyoutPanel1.OwnerControl = this.flowLayoutPanel1;
        //    flyoutPanel1.Size = new Size(200, 400);
        //    //flyoutPanel.ShowBeakForm();
        //    if (flyoutPanel1.FlyoutPanelState.IsActive) flyoutPanel1.HidePopup();
        //    else flyoutPanel1.ShowPopup();
        //}

        private void UserControl_Click(object sender, EventArgs e)
        {
            try
            {
                MyUserControl02 selectedUserControl = sender as MyUserControl02;
                this.gridControl1.DataSource = new MyDatabaseConnect01().connection7(selectedUserControl.eqpId, selectedUserControl.workCenter);
                this.labelControl2.Text = selectedUserControl.eqpDesc;
                flyoutPanel1.OwnerControl = this;
                flyoutPanel1.Size = new Size(600, 350);
                //flyoutPanel.ShowBeakForm();

                if (flyoutPanel1.FlyoutPanelState.IsActive) { flyoutPanel1.HidePopup(); this.panelComparence.Visible = false; this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = false; this.gridControl3.Visible = false; this.gridControl3.DataSource = null; }
                else flyoutPanel1.ShowPopup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                flyoutPanel1.OwnerControl = this.flowLayoutPanel1;
                flyoutPanel1.Size = new Size(200, 400);
                //flyoutPanel.ShowBeakForm();
                if (flyoutPanel1.FlyoutPanelState.IsActive) flyoutPanel1.HidePopup();
                else flyoutPanel1.ShowPopup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            try
            {
                MyUserControl02 test = this.ActiveControl as MyUserControl02;
                GridControl testControl = test.ActiveControl as GridControl;
                GridView testView = testControl.MainView as GridView;
                //MessageBox.Show(testView.FocusedRowHandle.ToString());
                //this.gridControl1.DataSource = new MyDatabaseConnect01().connection8(test.eqpNumber, "");
                //DataRow drFocusedRow = testView.GetDataRow(testView.FocusedRowHandle);

                if (testView.SelectedRowsCount <= 0) return;

                FlyoutProperties properties = new FlyoutProperties();
                properties.ButtonSize = new Size(100, 10);
                properties.Style = FlyoutStyle.Popup;
                FlyoutDialog.Show(this.FindForm(), "", new MyDialog01(test.eqpId, testView.GetRowCellValue(testView.FocusedRowHandle, "PROCESS_SEQ").ToString(), testView.GetRowCellValue(testView.FocusedRowHandle, "PROD_ORDER_NUMBER").ToString()), properties, 0, 0);

                //dialog.Width = 1300;
                //dialog.Height = 350;


                //if (groupControl1.Visible == true) this.groupControl1.Visible = false;
                //else if(groupControl1.Visible == false) this.groupControl1.Visible = true;
                //MyUserControl02 test = this.ActiveControl as MyUserControl02;
                ////GridControl testControl = test.ActiveControl as GridControl;
                ////GridView testView = testControl.MainView as GridView;
                ////MessageBox.Show(testView.FocusedRowHandle.ToString());
                //this.gridControl1.DataSource = new MyDatabaseConnect01().connection8(test.eqpNumber,"");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {


                this.flowLayoutPanel1.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                BtnReset_Click(null, null);

                List<DataThreeVo> resultList = new MyDatabaseConnect01().connection3(this.slueSelect.EditValue.ToString());
                //flowLayoutPanel.Size = new Size(3000, 2000);
                //flowLayoutPanel.WrapContents = false;
                // https://www.dotnetperls.com/flowlayoutpanel
                // https://www.c-sharpcorner.com/forums/getting-control-from-flowlayoutpanel
                // https://stackoverflow.com/questions/40279918/flowlayoutpanel-scrollbar-doesnt-disapear-properly-sometimes
                flowLayoutPanel1.HorizontalScroll.Maximum = 0;
                flowLayoutPanel1.AutoScroll = false;
                flowLayoutPanel1.VerticalScroll.Visible = false;
                flowLayoutPanel1.AutoScroll = true;

                MyUserControl02 userControl;
                int _rowIndex = 0;
                for (int x = 0; x < resultList.Count; x++)
                {
                    userControl = new MyUserControl02(resultList[x].EQP_DESC.ToString(), resultList[x].EQP_ID.ToString(), resultList[x].WORK_CENTER.ToString(), resultList[x].STATE.ToString());
                    userControl.Click += UserControl_Click;
                    flowLayoutPanel1.Controls.Add(userControl);
                }


                //this.groupControl2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
