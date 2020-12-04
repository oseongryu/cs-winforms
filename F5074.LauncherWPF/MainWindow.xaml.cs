using DevExpress.Xpf.Core;
using System.Windows;

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
