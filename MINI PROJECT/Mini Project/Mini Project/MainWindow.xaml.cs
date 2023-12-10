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

namespace Mini_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DemoEvent.OnDemoClosed += ShowMainWindow;
            Mini_Project.Realities.OnRealitiesClosed += ShowMainWindow;
        }
        public void ShowMainWindow()
        {
            this.Show();
        }
        private void Realities_Click(object sender, RoutedEventArgs e)
        {
            Realities realities = new Realities();
            realities.Show(); 
            this.Hide();
        }
        private void DemoButton_Click(object sender, RoutedEventArgs e)
        {
            DemoEvent demoEvent = new DemoEvent();
            demoEvent.Show(); this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
