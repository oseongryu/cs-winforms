using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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

        /// <summary>
        /// SetBestFitPopupSearchLookUpEdit
        /// </summary>
        /// <param name="searchLookUpEdit"></param>
        /// <param name="CheckBoxWidth"></param>
        public static void SetBestFitPopupSearchLookUpEdit(this SearchLookUpEdit searchLookUpEdit, int CheckBoxWidth = 0)
        {
            searchLookUpEdit.Properties.Popup += (sender, e) =>
            {
                try
                {
                    DevExpress.XtraEditors.SearchLookUpEdit currentLook = (DevExpress.XtraEditors.SearchLookUpEdit)sender;

                    currentLook.Properties.View.OptionsView.ColumnAutoWidth = false;
                    currentLook.Properties.View.BestFitColumns();

                    currentLook.Properties.View.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;

                    DevExpress.XtraEditors.Popup.PopupSearchLookUpEditForm currentPopup = (currentLook as DevExpress.Utils.Win.IPopupControl).PopupWindow as DevExpress.XtraEditors.Popup.PopupSearchLookUpEditForm;
                    //currentPopup.Size = new System.Drawing.Size(currentPopup.Width + 20, currentPopup.Height);
                    //currentPopup.Size = new System.Drawing.Size(slEdit.Width, currentPopup.Height);

                    int iColumnWidth = 0;
                    int iColCount = currentLook.Properties.View.Columns.Count;
                    for (int i = 0; i < iColCount; i++)
                    {
                        if (currentLook.Properties.View.Columns[i].Visible == true)
                            iColumnWidth += currentLook.Properties.View.Columns[i].Width;
                    }

                    if (iColumnWidth > 0 && currentPopup.Size.Width < (iColumnWidth + 47 + CheckBoxWidth))
                    {
                        currentPopup.Size = new System.Drawing.Size(iColumnWidth + 47 + CheckBoxWidth, currentPopup.Height);
                    }
                }
                catch { }
            };
        }

        /// <summary>
        /// InitSearchLookUpEdit
        /// </summary>
        /// <param name="searchLookUpEdit"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        /// <param name="addClearButton"></param>
        public static void InitSearchLookUpEdit(this SearchLookUpEdit searchLookUpEdit, string displayMember, string valueMember, bool addClearButton = true)
        {
            searchLookUpEdit.EditValue = null;
            if (addClearButton)
            {
                bool isDelete = false;
                foreach (EditorButton btn in searchLookUpEdit.Properties.Buttons)
                {
                    if (btn.Kind.Equals(ButtonPredefines.Delete))
                    {
                        isDelete = true;
                    }
                }
                if (!isDelete)
                {
                    searchLookUpEdit.Properties.Buttons.Add(new EditorButton(ButtonPredefines.Delete));
                    searchLookUpEdit.Properties.ButtonClick += Properties_ButtonClick;
                }
            }
            searchLookUpEdit.Properties.ShowClearButton = false;
            searchLookUpEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            searchLookUpEdit.Properties.DisplayMember = displayMember;
            searchLookUpEdit.Properties.ValueMember = valueMember;
        }

        /// <summary>
        /// Properties_ButtonClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!((SearchLookUpEdit)sender).ReadOnly) ((SearchLookUpEdit)sender).EditValue = null;
        }

        /// <summary>
        /// SetVisibleColumnSearchLookUpEdit
        /// </summary>
        /// <param name="searchLookUpEdit"></param>
        /// <param name="oColumns"></param>
        /// <param name="oCaptions"></param>
        public static void SetVisibleColumnSearchLookUpEdit(this SearchLookUpEdit searchLookUpEdit, string[] oColumns, string[] oCaptions)
        {
            if (oColumns != null && oColumns.Length > 0)
            {
                if (oColumns.Length != oCaptions.Length)
                    return;

                string[] oCurrentColumns = new string[oColumns.Length];
                string[] oCurrentColumnCaptions = new string[oCaptions.Length];

                // 컬럼, 캡션 순서를 역순으로 변경
                // 먼저 visible 되는 컬럼이 뒤쪽으로 보여 지므로.
                int iCurIndex = 0;
                int iCurCapIndex = 0;
                for (int i = oColumns.Length - 1; i >= 0; i--)
                {
                    oCurrentColumns[iCurIndex++] = oColumns[i];
                    oCurrentColumnCaptions[iCurCapIndex++] = oCaptions[i];
                }

                searchLookUpEdit.QueryPopUp += (sender, e) =>
                {
                    SearchLookUpEdit edit = sender as SearchLookUpEdit;
                    edit.ForceInitialize();
                    edit.Properties.View.PopulateColumns();

                    int iRealColumnCount = edit.Properties.View.Columns.Count;

                    // 모든 컬럼 Hidden
                    for (int iColIndex = 0; iColIndex < iRealColumnCount; iColIndex++)
                    {
                        edit.Properties.View.Columns[iColIndex].Visible = false;
                    }

                    // 인수로 넘어온 컬럼만 Visible
                    for (int iSetColIndex = 0; iSetColIndex < oCurrentColumns.Length; iSetColIndex++)
                    {
                        for (int iColIndex = 0; iColIndex < iRealColumnCount; iColIndex++)
                        {
                            if (edit.Properties.View.Columns[iColIndex].FieldName == oCurrentColumns[iSetColIndex])
                            {
                                edit.Properties.View.Columns[iColIndex].Visible = true;
                                edit.Properties.View.Columns[iColIndex].Caption = oCurrentColumnCaptions[iSetColIndex];

                                break;
                            }
                        }
                    }
                };
            }

        }
    }
}
