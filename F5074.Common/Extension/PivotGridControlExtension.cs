using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Common.Extension {
    public static class PivotGridControlExtension {

        /// <summary>
        /// InitPivotGridControl
        /// </summary>
        /// <param name="pivotGrid"></param>
        public static void InitPivotGridControl(this PivotGridControl pivotGrid)
        {
            pivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            pivotGrid.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.LegacyOptimized;
            pivotGrid.OptionsView.ShowColumnGrandTotalHeader = false;
            pivotGrid.OptionsView.ShowColumnGrandTotals = false;
            pivotGrid.OptionsView.ShowColumnTotals = false;
            pivotGrid.OptionsView.ShowRowGrandTotalHeader = false;
            pivotGrid.OptionsView.ShowRowGrandTotals = false;
            pivotGrid.OptionsView.ShowRowTotals = false;
        }

        /// <summary>
        /// ExportToExcel
        /// </summary>
        /// <param name="pivotGridControl"></param>
        public static void ExportToExcel(this PivotGridControl pivotGridControl)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.InitialDirectory = "c:\\";
            saveDlg.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDlg.RestoreDirectory = true;

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                var pivotExportOptions = new DevExpress.XtraPivotGrid.PivotXlsxExportOptions();
                pivotExportOptions.ExportType = DevExpress.Export.ExportType.DataAware;
                pivotGridControl.ExportToXlsx(saveDlg.FileName, pivotExportOptions);
            }

        }
    }
}
