using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Extension
{
    public static class GridControlExtension
    {
        /// <summary>
        /// 그리드 Row Indicator에 row 숫자 생성 및 MenuItem설정.
        /// </summary>
        /// <param name="grid">데브 그리드</param>

        public static GridControl gcCurrent;
        public static void InitGridIndicator(this GridControl grid)
        {
            gcCurrent = grid;
            grid.MouseDown += grid_MouseDown;


            ((GridView)grid.MainView).OptionsView.ShowGroupedColumns = true;
            ((GridView)grid.MainView).CustomDrawRowIndicator += ControlFunction_CustomDrawRowIndicator;
            ((GridView)grid.MainView).RowCountChanged += ControlFunction_RowCountChanged;
        }

        public static void grid_MouseDown(object sender, MouseEventArgs e)
        {

            //if (e.Button.IsRight())
            //{
            //    GridControl grid = sender as GridControl;
            //    if (grid != null)
            //    {
            //        GridView view = grid.MainView as GridView;
            //        if (view != null)
            //        {
            //            DoShowMenu(view.CalcHitInfo(new Point(e.X, e.Y)));

            //            if (!string.IsNullOrWhiteSpace(view.GetFocusedDisplayText()))
            //                Clipboard.SetText(view.GetFocusedDisplayText());
            //        }
            //    }
            //}
        }


        public static void ControlFunction_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();

                    SkinElement element = SkinManager.GetSkinElement(SkinProductId.Grid, DevExpress.LookAndFeel.UserLookAndFeel.Default, GridSkins.SkinHeader);
                    Color captionColor = element.Color.ForeColor;

                    Skin currentSkin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                    Color cChangeColor = currentSkin.TranslateColor(captionColor);

                    e.Info.Appearance.ForeColor = cChangeColor;
                    e.Info.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                    //e.Handled = true;
                }
            }
            catch
            {
            }
        }

        public static void ControlFunction_RowCountChanged(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                int rowCount = view.RowCount;
                if (rowCount > 0)
                {
                    view.IndicatorWidth = ((rowCount.ToString().Length * 7) + 23);
                }
                else
                {
                    view.IndicatorWidth = 30;
                }
            }
        }
    }
}
