using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using F5074.DevExpressWinforms.MyUserControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyCommon
{
    public class MyDevExpressFunctions
    {
        public static FlyoutAction CreateCloseAction()
        {
            // https://www.devexpress.com/Support/Center/Question/Details/T140795/how-to-show-modal-flyout-with-usercontrol-via-showflyoutdialog-method
            FlyoutAction closeAction = new FlyoutAction();
            closeAction.Caption = "[작업이동]";
            closeAction.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_32x32.png");
            closeAction.Description = "정말로 작업이동을 하시겠습니까?";
            closeAction.Commands.Add(FlyoutCommand.Yes);
            closeAction.Commands.Add(FlyoutCommand.No);
            return closeAction;
        }
        public static void MakeLayoutContol3(FlowLayoutPanel flowLayoutPanel, string _valString)
        {
            List<MyDatabaseConnect01.DataThreeVo> resultList = new MyDatabaseConnect01().connection3(_valString);
            //flowLayoutPanel.Size = new Size(3000, 2000);
            //flowLayoutPanel.WrapContents = false;
            // https://www.dotnetperls.com/flowlayoutpanel
            // https://www.c-sharpcorner.com/forums/getting-control-from-flowlayoutpanel
            // https://stackoverflow.com/questions/40279918/flowlayoutpanel-scrollbar-doesnt-disapear-properly-sometimes
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.VerticalScroll.Visible = false;
            flowLayoutPanel.AutoScroll = true;

            MyUserControl02 userControl;
            int _rowIndex = 0;
            for (int x = 0; x < resultList.Count; x++)
            {
                userControl = new MyUserControl02(resultList[x].EQP_DESC.ToString(), resultList[x].EQP_ID.ToString(), resultList[x].WORK_CENTER.ToString(), resultList[x].STATE.ToString());
                flowLayoutPanel.Controls.Add(userControl);
            }
        }
        //public static void MakeLayoutContol2(LayoutControlGroup layoutControlGroup, string _valString)
        //{
        //    List<DataThreeVo> resultList = new MyDatabaseConnect01().connection3(_valString);
        //    layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        //    layoutControlGroup.GroupBordersVisible = false;
        //    layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
        //    layoutControlGroup.Location = new Point(0, 0);
        //    layoutControlGroup.Name = "layoutControlGroup";

        //    for (int x = 0; x < 11; x++)
        //    {
        //        layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition() { Width = 120D, SizeType = SizeType.Absolute });

        //    }
        //    layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition() { Width = 2D, SizeType = SizeType.Absolute });

        //    for (int x = 0; x < (resultList.Count + 1) / 6; x++)
        //    {
        //        layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition() { Height = 200D, SizeType = SizeType.Absolute });
        //    }

        //    layoutControlGroup.Size = new Size(3000, 2000);
        //    layoutControlGroup.TextVisible = false;


        //    LayoutControlItem controlItem;
        //    MyUserControl02 userControl;
        //    int _rowIndex = 0;
        //    for (int x = 0; x < resultList.Count; x++)
        //    {
        //        controlItem = new LayoutControlItem() { TextVisible = false };
        //        if ((x + 1) % 6 == 0)
        //        {
        //            _rowIndex += 1;
        //        }
        //        controlItem.OptionsTableLayoutItem.RowIndex = _rowIndex;

        //        if ((x + 1) % 6 == 1)
        //        {
        //            controlItem.OptionsTableLayoutItem.ColumnIndex = 0;
        //        }
        //        else if ((x + 1) % 6 == 2)
        //        {
        //            controlItem.OptionsTableLayoutItem.ColumnIndex = 1;
        //        }
        //        else if ((x + 1) % 6 == 3)
        //        {
        //            controlItem.OptionsTableLayoutItem.ColumnIndex = 2;
        //        }
        //        else if ((x + 1) % 6 == 4)
        //        {
        //            controlItem.OptionsTableLayoutItem.ColumnIndex = 3;

        //        }
        //        else if ((x + 1) % 6 == 5)
        //        {
        //            controlItem.OptionsTableLayoutItem.ColumnIndex = 4;

        //        }
        //        else if ((x + 1) % 6 == 0)
        //        {
        //            controlItem.OptionsTableLayoutItem.ColumnIndex = 5;
        //            controlItem.OptionsTableLayoutItem.RowIndex = _rowIndex - 1;

        //        }
        //        userControl = new MyUserControl02(resultList[x].EQP_DESC.ToString(), resultList[x].EQP_ID.ToString(), "", "");
        //        controlItem.Control = userControl;
        //        layoutControlGroup.Items.AddRange(new BaseLayoutItem[] { controlItem });
        //    }
        //}
        public static void MakeLayoutContol(LayoutControlGroup layoutControlGroup, string _valString)
        {
            List<MyDatabaseConnect01.DataFourVo> resultList = new MyDatabaseConnect01().connection6(_valString);
            layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup.GroupBordersVisible = false;
            layoutControlGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            layoutControlGroup.Location = new Point(0, 0);
            layoutControlGroup.Name = "layoutControlGroup";

            layoutControlGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100D, SizeType = SizeType.Percent });

            for (int x = 0; x < resultList.Count + 1; x++)
            {
                layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition() { Height = 100D, SizeType = SizeType.Absolute });
            }

            layoutControlGroup.Size = new Size(796, 620);
            layoutControlGroup.TextVisible = false;


            LayoutControlItem controlItem;
            MyUserControl01 userControl;
            for (int x = 0; x < resultList.Count; x++)
            {
                controlItem = new LayoutControlItem() { TextVisible = false };
                controlItem.OptionsTableLayoutItem.RowIndex = x;
                //// Run 초록
                //if (resultList[x].STATE.ToString() == "Run")
                //{
                //    userControl = new MyUserControl01(resultList[x].EQP_DESC.ToString() + (x + 1), Color.FromArgb(0x3E, 0x70, 0x38), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));
                //    controlItem.Control = userControl;
                //}
                //else if (resultList[x].STATE.ToString() == "Idle" || resultList[x].STATE.ToString() == "Ready")
                //{
                //    userControl = new MyUserControl01(resultList[x].EQP_DESC.ToString() + (x + 1), Color.DarkGray, 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));

                //    controlItem.Control = userControl;
                //}
                //else if (resultList[x].STATE.ToString() == "Down")
                //{
                //    userControl = new MyUserControl01(resultList[x].EQP_DESC.ToString() + (x + 1), Color.OrangeRed, 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));

                //    controlItem.Control = userControl;
                //}
                //else if (resultList[x].STATE.ToString() == "SetUp")
                //{
                //    userControl = new MyUserControl01(resultList[x].EQP_DESC.ToString() + (x + 1), Color.FromArgb(0x00, 0x73, 0xC4), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 10 + new Random().Next(-5, 5));
                //    controlItem.Control = userControl;
                //}
                userControl = new MyUserControl01(resultList[x].EQP_ID.ToString(), Color.FromArgb(0x00, 0x73, 0xC4), 40 + new Random().Next(-20, 40) + " %", "00:23:20", 5 + new Random().Next(-3, 3) + " %", 100 + new Random().Next(-5, 5));
                controlItem.Control = userControl;
                layoutControlGroup.Items.AddRange(new BaseLayoutItem[] { controlItem });

            }

        }

        public static void MakeWindowsUIButtonPanel(WindowsUIButtonPanel currentPanel, string[] arrString)
        {
            //for (int x = 0; x < arrString.Length; x++)
            //{
            //    string _imageName = "";
            //    switch (arrString[x])
            //    {
            //       case "검색" : _imageName = "office2013/zoom/zoom_32x32.png"; break;
            //       case "프린트" : _imageName = "office2013/print/print_32x32.png"; break;
            //       case "적용" : _imageName = "office2013/actions/apply_32x32.png"; break;
            //       case "초기화" : _imageName = "office2013/actions/reset_32x32.png"; break;
            //       case "저장" : _imageName = "office2013/save/save_32x32.png"; break;
            //       case "차트": _imageName = "office2013/chart/bar_32x32.png"; break;

            //    }
            //    //new WindowsUIButton(arrString[x], true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage(_imageName) });
            //    currentPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new WindowsUIButton(arrString[x], true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage(_imageName) }) });
            //}

            // https://documentation.devexpress.com/WindowsForms/16864/What-s-Installed/Image-Gallery-and-Context-Dependent-Images
            for (int x = 0; x < arrString.Length; x++)
            {
                string _imageUri = "";
                switch (arrString[x])
                {
                    case "검색": _imageUri = "Zoom;Size32x32;GrayScaled"; break;
                    case "프린트": _imageUri = "Print;Size32x32;GrayScaled"; break;
                    case "적용": _imageUri = "Apply;Size32x32;GrayScaled"; break;
                    case "초기화": _imageUri = "Reset;Size32x32;GrayScaled"; break;
                    case "저장": _imageUri = "Save;Size32x32;GrayScaled"; break;
                    case "차트": _imageUri = "Chart;Size32x32;GrayScaled"; break;
                    case "미리보기": _imageUri = "Show;Size32x32;GrayScaled"; break;
                    case "작업이동": _imageUri = "Replace;Size32x32;GrayScaled"; break;
                    case "구분자": currentPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new WindowsUISeparator() }); break;

                }
                if (arrString[x] != "구분자") currentPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new WindowsUIButton(arrString[x], true, new WindowsUIButtonImageOptions() { ImageUri = _imageUri }) });

            }


            WindowsUIButton btn1 = new WindowsUIButton("검색", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/chart/bar_32x32.png") });
            WindowsUIButton btn2 = new WindowsUIButton("초기화", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_32x32.png") });
            WindowsUIButton btn3 = new WindowsUIButton("Btn3", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_32x32.png") });
            WindowsUIButton btn4 = new WindowsUIButton("Btn4", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_32x32.png") });
            WindowsUISeparator separator = new WindowsUISeparator();

            currentPanel.AllowGlyphSkinning = true;
            currentPanel.ForeColor = System.Drawing.Color.White;
            //currentPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { btn1, separator, btn2 });
            //currentPanel.ButtonClick += windowsUIButtonPanel1_ButtonClick;
            currentPanel.Size = new System.Drawing.Size(1213, 73);
            currentPanel.TabIndex = 0;
            currentPanel.UseButtonBackgroundImages = false;
            currentPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(130, 130, 130);
            currentPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            currentPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            currentPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            currentPanel.AppearanceButton.Hovered.Options.UseFont = true;
            currentPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            currentPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            currentPanel.AppearanceButton.Normal.Options.UseFont = true;
            currentPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(159, 159, 159);
            currentPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            currentPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(159, 159, 159);
            currentPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            currentPanel.AppearanceButton.Pressed.Options.UseFont = true;
            currentPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
        }

        public static void MakeSearchLookUPEdit(SearchLookUpEdit slEdit, string displayMember, string valueMember, bool addClearButton = true)
        {

        }

        public static void SetBestFitPopupSearchLookUpEdit(SearchLookUpEdit slEdit, int CheckBoxWidth = 0)
        {
            slEdit.Properties.Popup += (sender, e) =>
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
        public static void SetVisibleColumnSearchLookUpEdit(SearchLookUpEdit slEdit, string[] oColumns, string[] oCaptions)
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

                slEdit.QueryPopUp += (sender, e) =>
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
        /// <param name="gvCurrentView"></param>
        /// <param name="iColumnIndex"></param>
        /// <param name="HAlignment"></param>
        /// <param name="VAlignment"></param>
        public static void SetHeaderAlignmentGridView(GridView gvCurrentView, int iColumnIndex
            , DevExpress.Utils.HorzAlignment HAlignment = HorzAlignment.Center, DevExpress.Utils.VertAlignment VAlignment = VertAlignment.Center)
        {
            gvCurrentView.Columns[iColumnIndex].AppearanceHeader.TextOptions.HAlignment = HAlignment;
            gvCurrentView.Columns[iColumnIndex].AppearanceHeader.TextOptions.VAlignment = VAlignment;
        }

        /// <summary>
        /// 컬럼(Cell) 텍스트 정렬. Default 는 가로, 세로 정렬 Center
        /// </summary>
        /// <param name="gvCurrentView"></param>
        /// <param name="iColumnIndex"></param>
        /// <param name="HAlignment"></param>
        /// <param name="VAlignment"></param>
        public static void SetCellAlignmentGridView(GridView gvCurrentView, int iColumnIndex
            , DevExpress.Utils.HorzAlignment HAlignment = HorzAlignment.Center, DevExpress.Utils.VertAlignment VAlignment = VertAlignment.Center)
        {
            gvCurrentView.Columns[iColumnIndex].AppearanceCell.TextOptions.HAlignment = HAlignment;
            gvCurrentView.Columns[iColumnIndex].AppearanceCell.TextOptions.VAlignment = VAlignment;
        }

        private static void Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!((SearchLookUpEdit)sender).ReadOnly) ((SearchLookUpEdit)sender).EditValue = null;
        }
    }
}
