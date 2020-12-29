using DevExpress.XtraCharts;
using DevExpress.XtraTab;
using F5074.Common.Extension;
using F5074.UI.Form.ViewModel;
using System;
using System.Data;
using System.Windows.Forms;

namespace F5074.UI.Form.View {
    public partial class Chart03View : UserControl {
        public Chart03View()
        {
            InitializeComponent();
            Init();
            btnFind.Click += btnFind_Click;
        }

        private void Init()
        {
            // ComboBox 장비
            slueEquipment.InitSearchLookUpEdit("EQP_DESC", "EQP_ID", true);
            slueEquipment.SetVisibleColumnSearchLookUpEdit(new string[] { "EQP_ID", "EQP_NO", "EQP_DESC" }, new string[] { "설비번호", "호기", "설비명" });
            slueEquipment.Properties.DataSource = Chart01ViewModel.SelectEqpMst();
            slueEquipment.EditValue = (slueEquipment.Properties.DataSource as DataTable).Rows[0]["EQP_ID"].ToString();
            slueEquipment.Text = "100218";

            // ComboBox 구분
            slueCategory.InitSearchLookUpEdit("GENE_CD_DESC", "GENE_CD", true);
            slueCategory.SetVisibleColumnSearchLookUpEdit(new string[] { "GENE_CD_DESC" }, new string[] { "값" });
            slueCategory.Properties.DataSource = Chart01ViewModel.SelectCommonMasCd("CB_EQP_CATEGORY").DefaultView.ToTable(false, new string[] { "GENE_CD", "GENE_CD_DESC" });
            slueCategory.EditValue = (slueCategory.Properties.DataSource as DataTable).Rows[0]["GENE_CD"].ToString();

            // ComboBox 집계일자
            DateTime dtNow = DateTime.Now;
            DateTime dtFromDate = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 0, 0, 0).AddDays(-5);
            DateTime dtToDate = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, 23, 59, 59).AddDays(-3);
            calFromDate.EditValue = dtFromDate;
            calToDate.EditValue = dtToDate;
        }

        /// <summary>
        /// BtnFind_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string eqpId = slueEquipment.EditValue.ToString();
            tcTab.TabPages.Clear();

            DateTime dtFromDt = Convert.ToDateTime(this.calFromDate.EditValue);
            DateTime dtToDt = Convert.ToDateTime(this.calToDate.EditValue);


            DataTable dt = Chart01ViewModel.SelectEqpMaxLoad(eqpId, dtFromDt.ToString("yyyyMMdd01"), dtToDt.ToString("yyyyMMdd23"), "ITEM_VALUE");
            DataTable dtCdSpec = Chart01ViewModel.SelectEqpCdSpec(eqpId);

            int tabCount = dtCdSpec.Rows.Count / 4 + (dtCdSpec.Rows.Count % 4 == 0 ? 0 : 1);
            int cdIdx = 0;
            for (int tabIndx = 0; tabIndx < tabCount; tabIndx++)
            {
                int startNum = (4 * tabIndx);
                int endNum = startNum + 4;
                int endCount = 4;
                if (endNum > dtCdSpec.Rows.Count)
                {
                    endCount = dtCdSpec.Rows.Count % 4;
                    endNum = dtCdSpec.Rows.Count;
                }

                XtraTabPage xtraTabPage = new XtraTabPage();
                ChartControl chartControl = new ChartControl();
                xtraTabPage.Text = "Chart";
                tcTab.TabPages.Add(xtraTabPage);
                xtraTabPage.Controls.Add(chartControl);
                chartControl.Series.Clear();
                chartControl.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.DeepPink;
                chartControl.CrosshairOptions.ShowOnlyInFocusedPane = false;
                for (int idx = 0; idx < endCount; idx++)
                {
                    string sItemCd = dtCdSpec.Rows[cdIdx]["ITEM_CD"].ToString();
                    string sItemDesc = dtCdSpec.Rows[cdIdx]["ITEM_DESC"].ToString();

                    Series series = new Series(sItemDesc, ViewType.Line);
                    Series series2 = new Series(sItemDesc, ViewType.Line);
                    for (int rowIdx = 0; rowIdx < dt.Rows.Count; rowIdx++)
                    {
                        DataRow dataRow = dt.Rows[rowIdx];
                        if (dataRow["ITEM_CD"].ToString() == sItemCd)
                        {
                            series.Points.Add(new SeriesPoint(rowIdx, 2 * Convert.ToDouble(dataRow["ITEM_VALUE"])));
                            series2.Points.Add(new SeriesPoint(rowIdx, dataRow["ITEM_VALUE"]));
                            if (rowIdx != 0) 
                            { 
                                series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
                                series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
                            }
                        }
                    }

                    chartControl.Series.Add(series);
                    chartControl.Series.Add(series2);
                    chartControl.InitScrolling();
                    chartControl.InitChartControl(0, 60 * 24 * 3, 60*24);
                    XYDiagram diagram = (XYDiagram)chartControl.Diagram;
                    if (idx == 0)
                    {
                        diagram.Panes.Clear();
                        diagram.SecondaryAxesX.Clear();
                        diagram.SecondaryAxesY.Clear();

                        diagram.DefaultPane.ScrollBarOptions.XAxisScrollBarVisible = false;
                        diagram.DefaultPane.Weight = 1D;
                    }

                    if (idx > 0)
                    {
                        int viewIdx = idx - 1;

                        LineSeriesView myView = (LineSeriesView)series.View;
                        diagram.Panes.Add(new XYDiagramPane("Pane"));

                        diagram.SecondaryAxesY.Add(new SecondaryAxisY("My Axis Y"));
                        diagram.SecondaryAxesY[viewIdx].Alignment = AxisAlignment.Near;
                        myView.AxisY = diagram.SecondaryAxesY[viewIdx];
                        myView.Pane = diagram.Panes[viewIdx];
                        myView.Pane.ScrollBarOptions.XAxisScrollBarVisible = false;
                        myView.Pane.Weight = 1D;

                        diagram.SecondaryAxesY[viewIdx].Title.Font = new System.Drawing.Font("Tahoma", 10F);
                        diagram.SecondaryAxesY[viewIdx].Title.Text = sItemDesc;
                        diagram.SecondaryAxesY[viewIdx].Title.Visibility = DevExpress.Utils.DefaultBoolean.True;


                        LineSeriesView myView2 = (LineSeriesView)series2.View;
                        myView2.AxisY = diagram.SecondaryAxesY[viewIdx];
                        myView2.Pane = diagram.Panes[viewIdx];
                        myView2.Pane.ScrollBarOptions.XAxisScrollBarVisible = false;
                        myView2.Pane.Weight = 1D;
                    }
                    if(dtCdSpec.Rows.Count -1 != cdIdx) cdIdx += 1;
                }
                if (((XYDiagram)chartControl.Diagram).Panes.Count == 0) {
                    ((XYDiagram)chartControl.Diagram).DefaultPane.ScrollBarOptions.XAxisScrollBarVisible = true;
                }
                else
                {
                    ((XYDiagram)chartControl.Diagram).Panes[((XYDiagram)chartControl.Diagram).Panes.Count - 1].ScrollBarOptions.XAxisScrollBarVisible = true;
                }
                //((XYDiagram)chartControl.Diagram).AxisX.Label.Visible = true;


                // Add the chart to the form.
                chartControl.Dock = DockStyle.Fill;
            }

        }
    }
}
