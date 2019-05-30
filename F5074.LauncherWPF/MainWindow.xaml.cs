using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using F5074.MyBatisDataMapper.Service.Dashboard;

namespace F5074.LauncherWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int x = 0; x < 5; x++)
            {
                DevExpress.Xpf.LayoutControl.GroupBox groupBox = new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "xx" + x, HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch, MaximizeElementVisibility = Visibility.Visible };
                System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
                //host.Child = new F5074.DevExpressWinforms.Dashboard.FlowPanelControl();
                groupBox.Content = host;
                this.flowLayout.Children.Add(groupBox);

            }
        }

    }
}
