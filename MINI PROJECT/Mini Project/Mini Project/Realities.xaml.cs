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
    /// Interaction logic for Realities.xaml
    /// </summary>
    public partial class Realities : Window
    {
        public static event Action OnRealitiesClosed;
        public Realities()
        {
            InitializeComponent();
            Timer.OnTimerClosed += ShowRealities;
            CenterWindowOnScreen();
        }
        private void CenterWindowOnScreen()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public void ShowRealities()
        {
            if (this.Visibility != Visibility.Visible)
            {
                this.Show();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            OnRealitiesClosed?.Invoke();
        }

        private void HenGio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
