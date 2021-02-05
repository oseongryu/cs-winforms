using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static void InitGridControl(GridView _gridView, int _count)
        {
            _gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.False;
            _gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            _gridView.OptionsSelection.MultiSelect = false;
            _gridView.OptionsView.ColumnAutoWidth = false;
            _gridView.OptionsView.ShowGroupPanel = false;
            _gridView.OptionsBehavior.Editable = false;
            if (_count == 1)
            {
                _gridView.Appearance.Row.Font = new Font("Tahoma", 5f);
                //_gridView.Appearance.HeaderPanel.Font = new Font(_gridView.Appearance.HeaderPanel.Font, FontStyle.Bold);
                _gridView.Appearance.HeaderPanel.Font = new Font(new Font("Tahoma", 5f), FontStyle.Regular);
            }


            //_gridView.OptionsView.EnableAppearanceEvenRow = true;
            //_gridView.Appearance.EvenRow.BackColor = Color.AliceBlue;
        }

        /// <summary>
        /// 헤더 컬럼 텍스트 정렬. Default 는 가로, 세로 정렬 Center
        /// </summary>
        /// <param name="_gridView"></param>
        /// <param name="iColumnIndex"></param>
        /// <param name="HAlignment"></param>
        /// <param name="VAlignment"></param>
        public static void SetHeaderAlignmentGridView(this GridView _gridView, int iColumnIndex, DevExpress.Utils.HorzAlignment HAlignment = HorzAlignment.Center, DevExpress.Utils.VertAlignment VAlignment = VertAlignment.Center)
        {
            _gridView.Columns[iColumnIndex].AppearanceHeader.TextOptions.HAlignment = HAlignment;
            _gridView.Columns[iColumnIndex].AppearanceHeader.TextOptions.VAlignment = VAlignment;
        }

        /// <summary>
        /// 컬럼(Cell) 텍스트 정렬. Default 는 가로, 세로 정렬 Center
        /// </summary>
        /// <param name="_gridView"></param>
        /// <param name="iColumnIndex"></param>
        /// <param name="HAlignment"></param>
        /// <param name="VAlignment"></param>
        public static void SetCellAlignmentGridView(this GridView _gridView, int iColumnIndex, DevExpress.Utils.HorzAlignment HAlignment = HorzAlignment.Center, DevExpress.Utils.VertAlignment VAlignment = VertAlignment.Center)
        {
            _gridView.Columns[iColumnIndex].AppearanceCell.TextOptions.HAlignment = HAlignment;
            _gridView.Columns[iColumnIndex].AppearanceCell.TextOptions.VAlignment = VAlignment;
        }

        // 공통되는 인수는 계속 추가
        /// <summary>
        /// GridView 초기화
        /// </summary>
        /// <param name="_gridView"></param> GridControl 의 GridView
        /// <param name="bShowCheckBoxSelectorInColumnHeader"></param> 컬럼 헤더에 체크박스 컬럼 표시 여부
        /// <param name="bGridMultiSelectMode"></param> 다중선택의 기준. 선택행기준, 선택열기준, 체크박스선택행기준 인지를 결정
        /// <param name="bMultiSelect"></param> 다중선택을 할것인지 결정
        /// <param name="bColumnAutoWidth"></param> 컬럼의 넓이를 배분할 것인지를 결정
        /// <param name="bEnableAppearanceEvenRow"></param> 짝수행의 모습을 사용할지를 결정 (짝수행만 배경색 표시등......)
        /// <param name="bShowFooter"></param> SummaryItem 표시용 Footer 표시 여부 결정
        public static void InitGridView(this GridView _gridView, DefaultBoolean bShowCheckBoxSelectorInColumnHeader = DefaultBoolean.False
                                        , GridMultiSelectMode bGridMultiSelectMode = GridMultiSelectMode.RowSelect
                                        , bool bMultiSelect = false
                                        , bool bColumnAutoWidth = false
                                        , bool bEnableAppearanceEvenRow = true
                                        , bool bShowFooter = true)
        {
            _gridView.OptionsClipboard.CopyColumnHeaders = DefaultBoolean.False; // Cell 복사시에 컬럼 헤더 포함 시키지 않는다.

            _gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = bShowCheckBoxSelectorInColumnHeader;
            _gridView.OptionsSelection.MultiSelectMode = bGridMultiSelectMode;
            _gridView.OptionsSelection.MultiSelect = bMultiSelect;
            _gridView.OptionsView.ColumnAutoWidth = bColumnAutoWidth;
            if (bEnableAppearanceEvenRow == true)
            {
                _gridView.OptionsView.EnableAppearanceEvenRow = bEnableAppearanceEvenRow;
                _gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            }
            _gridView.OptionsView.ShowFooter = bShowFooter;

            if (bGridMultiSelectMode == GridMultiSelectMode.CheckBoxRowSelect)
            {
                _gridView.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = false;

            }
        }

    }
}
