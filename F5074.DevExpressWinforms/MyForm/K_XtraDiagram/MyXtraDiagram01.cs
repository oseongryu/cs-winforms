using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraDiagram;

namespace F5074.DevExpressWinforms.MyForm.K_XtraDiagram
{
    public partial class MyXtraDiagram01 : UserControl
    {
        public MyXtraDiagram01()
        {
            InitializeComponent();
            diagramControl1.SelectionChanged += DiagramControl1_SelectionChanged;
            diagramControl1.FitToPage();

            // https://www.devexpress.com/Support/Center/Question/Details/T572792/how-to-add-pre-excisting-shapes-in-stencil
            // custom

        }

        private void DiagramControl1_SelectionChanged(object sender, DevExpress.XtraDiagram.DiagramSelectionChangedEventArgs e)
        {
            // https://www.devexpress.com/Support/Center/Question/Details/T323487/does-diagramshape-support-click-event
            DiagramControl control = sender as DiagramControl;
            if(control.SelectedItems.Count > 0)
            {
                DiagramShape diagramShape = control.SelectedItems[0] as DiagramShape;
                MessageBox.Show(diagramShape.Content);
            }

        }
    }
}
