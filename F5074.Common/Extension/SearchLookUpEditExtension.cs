using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Extension {
    public static class SearchLookUpEditExtension {

        /// <summary>
        /// SearchLookUpEdit 멀티 체크박스 가능
        /// </summary>
        /// <param name="searchLookUpEdit"></param>
        public static void InitMultiSelect(this SearchLookUpEdit searchLookUpEdit)
        {
            searchLookUpEdit.Properties.View.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            searchLookUpEdit.Properties.View.OptionsSelection.MultiSelect = true;
            searchLookUpEdit.Properties.View.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            searchLookUpEdit.Properties.ShowAddNewButton = true;
        }
    }
}
