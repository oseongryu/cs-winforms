using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F5074.LauncherWPF.View.A_FlowLayout
{
    /// <summary>
    /// FlowLayout01.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FlowLayout01 : UserControl
    {
        private DevExpress.Xpf.LayoutControl.GroupBox gb1 = new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch, Name = "groupBox1" };
        public FlowLayout01()
        {
            InitializeComponent();
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch });
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch });
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch });
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch });
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch });
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch });
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch, MaximizeElementVisibility = Visibility.Visible });
        }

        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            //string a = groupBox1.Content.ToString();
            //this.groupBox1.MaximizeElementVisibility = Visibility.Visible;


            // Create the interop host control.
            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            // Create the MaskedTextBox control.
            System.Windows.Forms.MaskedTextBox mtbDate = new System.Windows.Forms.MaskedTextBox("00/00/0000");

            // Assign the MaskedTextBox control as the host control's child.
            host.Child = mtbDate;

            //// Add the interop host control to the Grid
            //// control's collection of child controls.
            //this.flowLayout.Children.Add(host);
            this.flowLayout.Children.Add(new DevExpress.Xpf.LayoutControl.GroupBox() { Content = host, Header = "yyyy", HorizontalAlignment = HorizontalAlignment.Stretch, VerticalAlignment = VerticalAlignment.Stretch, MaximizeElementVisibility = Visibility.Visible });

        }
    }
}
