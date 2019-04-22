using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MyLayoutControl01 : UserControl
    {
        private DevExpress.XtraEditors.TextEdit textEdit1;

        public MyLayoutControl01()
        {
            InitializeComponent();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit() { Location = new System.Drawing.Point(20, 45), Name = "textEdit1", Size = new System.Drawing.Size(100, 20), TabIndex = 0 };
            this.groupControlRight.Controls.Add(this.textEdit1);
            WindowsUIButton btn1 = new WindowsUIButton("Btn1", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/refresh_16x16.png") });
            WindowsUIButton btn2 = new WindowsUIButton("Btn2", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/add_16x16.png") });
            WindowsUIButton btn3 = new WindowsUIButton("Btn3", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/apply_16x16.png") });
            WindowsUIButton btn4 = new WindowsUIButton("Btn4", true, new WindowsUIButtonImageOptions() { Image = DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_16x16.png") });
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { btn1, btn2, btn3, btn4 });
            windowsUIButtonPanel1.Buttons["Btn2"].Properties.Appearance.ForeColor = Color.Blue;
            windowsUIButtonPanel1.Buttons["Btn3"].Properties.Appearance.ForeColor = Color.Green;
            windowsUIButtonPanel1.Buttons["Btn4"].Properties.Appearance.ForeColor = Color.Red;
            this.windowsUIButtonPanel1.ButtonClick += windowsUIButtonPanel1_ButtonClick;
            this.splitContainerControlCR.SplitterPosition = 1200;
            this.splitContainerControlCB.SplitterPosition = 1500;
        }
        private void windowsUIButtonPanel1_ButtonClick(object sender, ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("Btn1"))
            {
                MessageBox.Show(btn.Caption);
            }
        }
    }
}
