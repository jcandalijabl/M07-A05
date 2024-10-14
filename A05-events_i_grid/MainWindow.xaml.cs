using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace A05_events_i_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void boto1_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("socBOTO 1");
        }

        private void boto2_MouseDown(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("soc BOTO 2");
        }

        private void boto3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("soc BOTO 3");
        }

        private void panel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("soc PANEL");
        }
    }
}
