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

namespace Mini_Project
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        public static event Action OnTimerClosed;
        public Timer()
        {
            InitializeComponent();
            CenterWindowOnScreen();
        }
        private void CenterWindowOnScreen()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OnTimerClosed?.Invoke();
            this.Close();
        }

        private void CountDowm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
