using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
