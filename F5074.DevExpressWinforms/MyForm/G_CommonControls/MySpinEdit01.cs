using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MySpinEdit01 : UserControl
    {
        public MySpinEdit01()
        {
            InitializeComponent();
            //this.spinEdit1.EditValueChanged += SpinEdit1_EditValueChanged;
            this.spinEdit1.ValueChanged += SpinEdit1_ValueChanged;
            this.spinEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.spinEdit1.Properties.EditValueChangedDelay = 0;
            this.spinEdit1.Properties.MaxValue = 9999999;
            this.spinEdit1.Properties.MaxLength = 8;
            this.spinEdit1.Properties.Increment = 1;
            this.spinEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinEdit1.Properties.EditMask = @"#,###,##0";
            this.spinEdit1.Properties.DisplayFormat.FormatString = @"#,###,##0";
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;


            textEdit1.Properties.Mask.EditMask = @"#,###,##0";
            textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            textEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            textEdit1.Properties.DisplayFormat.FormatString = @"#,###,##0";
            textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;

            //textEdit1.Properties.EditValueChangedFiringMode = EditValueChangedFiringMode.Default;
            //textEdit1.Properties.EditValueChangedDelay = 0;   
        }

        private void SpinEdit1_ValueChanged(object sender, EventArgs e)
        {
            this.textEdit1.EditValue = this.spinEdit1.EditValue;

        }

        //private void SpinEdit1_EditValueChanged(object sender, EventArgs e)
        //{
        //    this.textEdit1.EditValue = this.spinEdit1.EditValue;
        //}
    }
}
