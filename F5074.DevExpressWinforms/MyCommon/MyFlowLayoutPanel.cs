using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyCommon
{
    public partial class MyFlowLayoutPanel : FlowLayoutPanel
    {
        public MyFlowLayoutPanel() : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        //protected override void OnScroll(ScrollEventArgs se)
        //{
        //    this.Invalidate();

        //    base.OnScroll(se);
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
        //        return cp;
        //    }
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.SuspendLayout();
                base.OnPaint(e);
                this.ResumeLayout();
            });
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;
                return parms;
            }
        }
    }
}
