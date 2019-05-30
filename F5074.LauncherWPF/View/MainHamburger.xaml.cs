using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Layout.Core;
using F5074.LauncherWPF.View.A_FlowLayout;
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
using System.Windows.Shapes;

namespace F5074.LauncherWPF.View
{
    /// <summary>
    /// MainHamburger.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainHamburger : Window
    {
        public MainHamburger()
        {
            InitializeComponent();

            //btnDashboard.MouseDoubleClick += BtnDashboard_MouseDoubleClick;
            //btnDashboard2.MouseDoubleClick += BtnDashboard2_MouseDoubleClick;
            //LayoutPanel layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.None);
            //System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            //host.Child = new F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar06();
            //layoutPanel1.Content = host;
            //dockLayoutManager1.DockController.Dock(layoutPanel1, layoutGroup1, DockType.Fill);
            LayoutPanel layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.None);
            layoutPanel1.Content = new FlowLayout01();
            layoutPanel1.Caption = "대시보드1";
            dockLayoutManager1.DockController.Insert(documentGroup1, layoutPanel1, 0);

            layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.Fill);
            layoutPanel1.Content = new FlowLayout01();
            layoutPanel1.Caption = "대시보드2";
            dockLayoutManager1.DockController.Insert(documentGroup1, layoutPanel1, 1);

            layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.Fill);
            layoutPanel1.Content = new FlowLayout01();
            layoutPanel1.Caption = "대시보드3";
            dockLayoutManager1.DockController.Insert(documentGroup1, layoutPanel1,2);


        }

        private void BtnDashboard2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            LayoutPanel layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.None);
            //host.Child = new F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar05();
            layoutPanel1.Content = host;
            dockLayoutManager1.DockController.Insert(documentGroup1, layoutPanel1, 0);
        }

        private void BtnDashboard_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
            LayoutPanel layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.None);
            //host.Child = Button();
            layoutPanel1.Content = host;
            dockLayoutManager1.DockController.Insert(documentGroup1, layoutPanel1, 0);

            //dockLayoutManager1.DockController.Restore(layoutPanel1);
            //dockLayoutManager1.DockController.Insert(layoutGroup1, layoutPanel1, 0);
        }

        //private void BtnDashboard2_Click(object sender, RoutedEventArgs e)
        //{
        //    System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
        //    LayoutPanel layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.None);
        //    host.Child = new F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar07();
        //    layoutPanel1.Content = host;
        //    dockLayoutManager1.DockController.Insert(layoutGroup1, layoutPanel1, 0);
        //}

        //private void HamburgerMenuNavigationButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        //{
        //    System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
        //    LayoutPanel layoutPanel1 = dockLayoutManager1.DockController.AddPanel(DockType.None);
        //    host.Child = new F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar06();
        //    layoutPanel1.Content = host;
        //    dockLayoutManager1.DockController.Insert(layoutGroup1, layoutPanel1, 0);

        //    //dockLayoutManager1.DockController.Restore(layoutPanel1);
        //    //dockLayoutManager1.DockController.Insert(layoutGroup1, layoutPanel1, 0);
        //}
    }
}
