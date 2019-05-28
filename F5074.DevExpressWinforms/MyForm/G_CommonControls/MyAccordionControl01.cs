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
    public partial class MyAccordionControl01 : UserControl
    {
        public MyAccordionControl01()
        {
            InitializeComponent();
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;

            for (int x = 0; x < 20; x++)
            {
                DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
                DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
                ////accordionControlElement3.ContentContainer = this.accordionContentContainer2;
                accordionContentContainer1.Controls.Add(new DevExpress.XtraGrid.GridControl() { Dock = System.Windows.Forms.DockStyle.Fill });
                //accordionControlElement1.Expanded = true;
                //accordionControlElement1.HeaderVisible = true;
                //accordionControlElement3.Name = "accordionControlElement3";
                accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                accordionControlElement1.Text = "설비" + (x + 1);
                //accordionControlElement1.Appearance.Normal.BackColor = System.Drawing.Color.Red;
                //accordionControlElement1.Appearance.Hovered.BackColor = System.Drawing.Color.Salmon;
                accordionControlElement1.ContentContainer = accordionContentContainer1;
                accordionControl1.Elements.Add(accordionControlElement1);
                this.accordionControl1.Controls.Add(accordionContentContainer1);
            }
        }
    }
}
