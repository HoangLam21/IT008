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
using System.Windows.Threading;

namespace Mini_Project
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        public DispatcherTimer uiTimer;
        public static event Action CountdownFinished;
        public static event Action OnCountdownButtonClick1;
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
            try
            {
                int hour = int.Parse(Hour.Text);
                int minute = int.Parse(Minute.Text);
                int second = int.Parse(Second.Text);

                StartCountdown(hour, minute, second);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giờ và phút đúng định dạng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        public void StartCountdown(int h, int m, int s)
        {
            DateTime endTime = DateTime.Now.AddHours(h - DateTime.Now.Hour)
                                    .AddMinutes(m - DateTime.Now.Minute)
                                    .AddSeconds(s - DateTime.Now.Second);

            uiTimer = new DispatcherTimer();
            uiTimer.Interval = TimeSpan.FromSeconds(1); // Cập nhật giao diện mỗi 1 giây
            uiTimer.Tick += (sender, e) =>
            {
                TimeSpan remainingTime = endTime - DateTime.Now;

                CountDownTextBlock.Text = $"{remainingTime.Hours:D2}:{remainingTime.Minutes:D2}:{remainingTime.Seconds:D2}";
                if (remainingTime.TotalSeconds <= 0)
                {
                    uiTimer.Stop();
                    CountdownFinished?.Invoke();
                }
            };

            uiTimer.Start();
        }
    }
}
