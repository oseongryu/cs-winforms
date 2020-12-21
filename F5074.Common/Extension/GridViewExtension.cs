using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Extension {
    public static class GridViewExtension {

        /// <summary>
        /// GridView 일괄설정
        /// </summary>
        /// <param name="gridView"></param>
        public static void DefaultSetting(this GridView gridView)
        {
            CopyCell(gridView);
            gridView.BestFitColumns();
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsBehavior.Editable = true;
        }

        /// <summary>
        /// // GridView Copy시 Cell 선택가능
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="check"></param>
        public static void CopyCell(this GridView gridView)
        {
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsClipboard.CopyColumnHeaders = DefaultBoolean.False;
            gridView.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDown;
        }
    }
}
