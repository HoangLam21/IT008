using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
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
using System.IO;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using Microsoft.Win32;

namespace Mini_Project
{
    /// <summary>
    /// Interaction logic for DemoEvent.xaml
    /// </summary>
    public partial class DemoEvent : Window
    {
        public string fileName = "Account.txt";
        public static event Action OnDemoClosed; public DemoEvent()
        {
            InitializeComponent();
            TimerEvent.OnTimerEventClosed += ShowDemoEvent;
            TimerEvent.CountdownFinished += LoginDemoEvent;
            CenterWindowOnScreen();
        }
        private void CenterWindowOnScreen()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public void LoginDemoEvent()
        {
            this.DangNhap_Click(null, null);
        }
        public void ShowDemoEvent()
        {
            if (this.Visibility != Visibility.Visible)
            {
                this.Show();
            }
        }
        public class Account
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string AccID { get; set; }

            public Account(string username, string password)
            {

                Username = username;
                Password = password;
            }
        }
        private void LoginAndDoSomething(Account account, string email, string sdt, int sl)
        {

            ChromeDriverService service = ChromeDriverService.CreateDefaultService("chromedriver.exe");
            service.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(service, options);


            try
            {
                Login(driver, account.Username, account.Password, email, sdt, sl);
            }
            catch
            {
                //driver.Quit();
            }
        }
        private List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account> { };
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string us, pa;
                    us = line.Split(' ')[0];
                    pa = line.Split(' ')[1];
                    Account account = new Account(us, pa);
                    accounts.Add(account);
                }
            }
            return accounts;
        }
        private void HenGioButton_Click(object sender, RoutedEventArgs e)
        {
            TimerEvent timer = new TimerEvent();
            TimerEvent.OnCountdownButtonClick += () =>
            {
                timer.Show(); 
                this.Hide();   

            };
            timer.Show();
            this.Hide();
        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox2.IsChecked == true)
            {
                string email = Email.Text;
                string sdt = SDT.Text;
                int sl = int.Parse(SL.Text);

                List<Account> accounts = GetAccounts();

                List<Task> tasks = new List<Task>();

                foreach (var account in accounts)
                {
                    tasks.Add(Task.Run(() => LoginAndDoSomething(account, email, sdt, sl)));
                }

                Task.WaitAll(tasks.ToArray());
            }
            else
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService("chromedriver.exe");
                service.HideCommandPromptWindow = true;
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                IWebDriver driver = new ChromeDriver(service, options);
                string username = User.Text;
                string password = mk.Text;
                string email = Email.Text;
                string sdt = SDT.Text;
                int sl = int.Parse(SL.Text);
                driver.Navigate().GoToUrl("https://ticketbox.vn/event/thuyet-trinh-lap-trinh-truc-quan-89015");
                Login(driver, username, password, email, sdt, sl);
            }
        }
        private void Login(IWebDriver driver, string username, string password, string email, string sdt, int sl)
        {
            driver.Navigate().GoToUrl("https://ticketbox.vn/event/thuyet-trinh-lap-trinh-truc-quan-89015");
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement dangNhap = wait.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/section/section[1]/div[2]/div[1]/div/div/div[2]/a"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            dangNhap.Click();

            WebDriverWait choTaiKhoan = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement taiKhoan = wait.Until<IWebElement>((d) =>
            {
                try

                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div[2]/div/div[1]/input"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            taiKhoan.SendKeys(username);

            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div[2]/div/div[3]/button")).Click();

            WebDriverWait choMatKhau = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement matKhau = wait.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div/div[3]/div[2]/input"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            matKhau.SendKeys(password);
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div/div[4]/button")).Click();

            Thread.Sleep(2000);

            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                string jsCode = " let a = document.getElementsByClassName(\"register-btn\"); " +
                                 " for(let i=0;i<a.length;i++){a[i].click();}";
                js.ExecuteScript(jsCode);
            }
            catch (Exception)
            {
                MessageBox.Show("Het ve hoac khong the dat ve!");
            }

            Thread.Sleep(1000);

            for (int i = 0; i < sl; i++)
            {
                driver.FindElement(By.XPath("//*[@id=\"ticket-type-list\"]/div/div[2]/div/div[1]/div[3]/div/div/div/span[2]/button/span")).Click();
            }

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[2]/div[3]/table/tbody/tr/td")).Click();

            Thread.Sleep(2000);

            WebDriverWait choGuiE = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement guiEmail = wait.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"buyer-info\"]/div[2]/div/div[2]/div[1]/input"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            guiEmail.Clear();
            guiEmail.SendKeys(email);

            WebDriverWait choCfR = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement confirmEmail = wait.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"confirmEmail\"]"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            confirmEmail.Clear();
            confirmEmail.SendKeys(email);

            WebDriverWait choGuiSdt = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement guiSDT = wait.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.Name("phoneNumber"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            guiSDT.SendKeys(sdt);

            IWebElement thongTinDatVe = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"informationForm\"]/div/div/div/div[2]/tkb-booking-bill/div/div/div[1]/div/table[1]/thead/tr/th/span")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", thongTinDatVe);
            wait.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", thongTinDatVe));
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"informationForm\"]/div/div/div/div[2]/div[2]/div[2]/table/tbody/tr/td")).Click();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OnDemoClosed?.Invoke();
        }
        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Nội dung file [Username] [Password]", "THÔNG BÁO", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    fileName = selectedFilePath;
                }
            }
        }
    }
}
