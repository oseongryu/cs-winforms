using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyCommon
{
    public class CheckBoxInColumnHeaderGridView
    {
        string strColumnName = string.Empty;
        string strChackValue = string.Empty;
        string strUnChackValue = string.Empty;

        public CheckBoxInColumnHeaderGridView(GridView gv, string strColumnName = "CHECKBOX", string strChackValue = "1", string strUnChackValue = "0")
        {
            if (gv.GroupPanelText != "COLUMN EVENT")
            {
                gv.CustomDrawColumnHeader += gv_CustomDrawColumnHeader;
                gv.MouseDown += gv_MouseDown;
                gv.GroupPanelText = "COLUMN EVENT";
            }

            this.strColumnName = strColumnName;
            this.strChackValue = strChackValue;
            this.strUnChackValue = strUnChackValue;
        }





        public static RepositoryItem RepCheckEdit(string strCheckedValue = "1", string strUncheckedValue = "0", bool isUnique = false)
        {
            RepositoryItemCheckEdit repCheck = new RepositoryItemCheckEdit();
            repCheck.CheckedChanged += repCheck_CheckedChanged;
            repCheck.ValueChecked = strCheckedValue;
            repCheck.ValueUnchecked = strUncheckedValue;
            repCheck.Tag = isUnique;
            return repCheck;
        }




        static void repCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit repCheck = sender as CheckEdit;
            PropertyInfo info = typeof(BaseEdit).GetProperty("EditorContainer", BindingFlags.NonPublic | BindingFlags.Instance);
            GridControl gc = info.GetValue(repCheck, null) as GridControl;
            if (gc == null) return;
            GridView gv = gc.MainView as GridView;
            bool? isUnique = repCheck.Properties.Tag as bool?;
            if (isUnique != null && isUnique == true)
            {
                DataView dv = gc.DataSource as DataView;
                DataTable dt = dv == null ? gc.DataSource as DataTable : dv.Table;
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[gv.FocusedColumn.FieldName].ToString() == "1") dr[gv.FocusedColumn.FieldName] = repCheck.Properties.ValueUnchecked;
                    }
                }
            }
            gv.CloseEditor(); gv.UpdateCurrentRow();
            gc.Refresh();
        }





        //컬럼의 헤더를 CheckEdit으로 그려줌.

        void gv_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.Column == null) return;
            if (e.Column.FieldName == strColumnName)
            {
                e.Info.InnerElements.Clear();
                e.Info.Appearance.ForeColor = Color.Blue;
                e.Painter.DrawObject(e.Info);
                int intCheckCnt = getCheckedCount(gv);
                switch (intCheckCnt)
                {
                    case 0:
                        DrawCheckBox(e.Graphics, e.Bounds, false);
                        break;
                    default:
                        if (intCheckCnt == gv.RowCount) DrawCheckBox(e.Graphics, e.Bounds, true);
                        else DrawCheckBox(e.Graphics, e.Bounds);
                        break;
                }
                e.Handled = true;
            }
        }





        void gv_MouseDown(object sender, MouseEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.Clicks == 1 && e.Button == MouseButtons.Left)
            {
                GridHitInfo info;
                Point pt = gv.GridControl.PointToClient(Control.MousePosition);
                info = gv.CalcHitInfo(pt);

                if (info.InColumn && info.Column.FieldName == strColumnName)
                {
                    //Console.WriteLine(string.Format("{0} :: {1}", getCheckedCount(gv), gv.DataRowCount));
                    if (getCheckedCount(gv) == gv.DataRowCount)
                        UnChekAll(gv);
                    else
                        CheckAll(gv);
                } // 모두 체크 되어있을때만 체크를 해제하고 다른 경우에는 모두 체크 한다.
            }
        }





        protected void DrawCheckBox(Graphics g, Rectangle r, bool? Checked = null)
        {
            RepositoryItemCheckEdit chkedit = new RepositoryItemCheckEdit();
            DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo info;
            DevExpress.XtraEditors.Drawing.CheckEditPainter painter;
            DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs args;
            info = chkedit.CreateViewInfo() as DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo;
            painter = chkedit.CreatePainter() as DevExpress.XtraEditors.Drawing.CheckEditPainter;
            info.EditValue = Checked;

            info.Bounds = r;
            info.PaintAppearance.ForeColor = Color.Black;
            info.CalcViewInfo(g);
            args = new DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, new DevExpress.Utils.Drawing.GraphicsCache(g), r);
            painter.Draw(args);
            args.Cache.Dispose();
        }



        // 현재 체크된 곳의 갯수를 가져옴.

        int getCheckedCount(GridView gv)
        {
            int count = 0;
            for (int i = 0; i < gv.DataRowCount; i++)
            {
                if (gv.GetRowCellValue(i, gv.Columns[strColumnName]).ToString() == strChackValue)
                    count++;
            }
            return count;
        }



        // 모두 체크
        void CheckAll(GridView gv)
        {
            for (int i = 0; i < gv.DataRowCount; i++)
            {
                gv.SetRowCellValue(i, gv.Columns[strColumnName], strChackValue);
            }
        }



        // 모두 체크 해제
        void UnChekAll(GridView gv)
        {
            for (int i = 0; i < gv.DataRowCount; i++)
            {
                gv.SetRowCellValue(i, gv.Columns[strColumnName], strUnChackValue);
            }
        }
    }

}
