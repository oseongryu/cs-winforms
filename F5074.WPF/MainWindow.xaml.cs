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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F5074.WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        EventTrigger trigger1;
        EventTrigger trigger2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double from = double.Parse(FromVal.Text);
            double to = double.Parse(ToVal.Text);
            DoubleAnimation da = new DoubleAnimation(from, to, new Duration(new TimeSpan(0, 0, 1)));
            da.AutoReverse = true;

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(da);

            Storyboard.SetTargetName(da, Demo3Ellipse.Name);
            Storyboard.SetTargetProperty(da, new PropertyPath(Ellipse.WidthProperty));

            BeginStoryboard bs = new BeginStoryboard();
            bs.Storyboard = storyboard;

            if (Demo3Ellipse.Triggers.Contains(trigger1))
            {
                trigger1.Actions[0] = bs;
            }
            else
            {
                trigger1 = new EventTrigger(Ellipse.MouseLeftButtonDownEvent);
                trigger1.Actions.Add(bs);
                Demo3Ellipse.Triggers.Add(trigger1);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // https://www.youtube.com/watch?v=mSMfLTAYRho
            BeginStoryboard bs = new BeginStoryboard();
            bs.Storyboard = Resources["DemoStoryBoard"] as Storyboard;


            trigger2 = new EventTrigger(Ellipse.PreviewMouseLeftButtonDownEvent);
            trigger2.Actions.Add(bs);
            Demo3Ellipse.Triggers.Add(trigger2);
        }

    }
}
