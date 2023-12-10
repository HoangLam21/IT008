using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;






namespace Mini_Project
{
    /// <summary>
    /// Interaction logic for Realities.xaml
    /// </summary>
    public partial class Realities : Window
    {
        public string fileName = "Account.txt";
        public static event Action OnRealitiesClosed;
        public Realities()
        {
            InitializeComponent();
            Timer.OnTimerClosed += ShowRealities;
            Timer.CountdownFinished += LoginReal;
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
        public void LoginReal()
        {
            this.DangNhap_Click(null, null);
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
            Timer timer = new Timer();
            Timer.OnCountdownButtonClick1 += () =>
            {
                timer.Show(); // Hiển thị cửa sổ Timer
                this.Hide();   // Ẩn cửa sổ hiện tại
            };
            timer.Show();
            this.Hide();
        }

        public class Account
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string SDT { get; set; }

            public Account(string username, string password, string email, string sdt)
            {
                Username = username;
                Password = password;
                Email = email;
                SDT = sdt;

            }
        }

        private void LoginAndDoSomething(Account account, string stk, string sthe, string thanghh, string namhh, string tenshow, int loaive, int soluong)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService("chromedriver.exe");
            service.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(service, options);
            try
            {
                Login(driver, account.Username, account.Password, account.Email, account.SDT, stk, sthe, thanghh, namhh, tenshow, loaive, soluong);
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
                    Account account = new Account(us, pa, Email.Text, SDT.Text);
                    accounts.Add(account);
                }
            }
            return accounts;
        }



        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                string stk = STK.Text;
                string sthe = SoThe.Text;
                string thanghh = Thang.Text;
                string namhh = Nam.Text;
                string tenshow = Show.Text;
                int loaive = int.Parse(Show1.Text);
                int soluong = int.Parse(SL.Text);

                List<Account> accounts = GetAccounts();

                List<Task> tasks = new List<Task>();

                foreach (var account in accounts)
                {
                    tasks.Add(Task.Run(() => LoginAndDoSomething(account, stk, sthe, thanghh, namhh, tenshow, loaive, soluong)));
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
                string stk = STK.Text;
                string sthe = SoThe.Text;
                string thanghh = Thang.Text;
                string namhh = Nam.Text;
                string tenshow = Show.Text;
                int loaive = int.Parse(Show1.Text);
                int soluong = int.Parse(SL.Text);
                driver.Navigate().GoToUrl("https://ticketbox.vn/");
                Login(driver, username, password, email, sdt, stk, sthe, thanghh, namhh, tenshow, loaive, soluong);



            }
        }
        private void Login(IWebDriver driver, string username, string password, string email, string sdt, string stk, string sthe, string thanghh, string namhh, string tenshow, int loaive, int soluong)
        {
            driver.Navigate().GoToUrl("https://ticketbox.vn/");

            driver.Manage().Window.Maximize();

            WebDriverWait doiWeb = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement clickLogin = doiWeb.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//a[@href='/sign-in']"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            clickLogin.Click();

            WebDriverWait doiUsername = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapUserName = doiUsername.Until<IWebElement>((d) =>
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
            nhapUserName.SendKeys(username);

            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div[2]/div/div[3]/button")).Click();

            WebDriverWait doiPass = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapPass = doiPass.Until<IWebElement>((d) =>
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
            nhapPass.SendKeys(password);
            driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div/div/div[4]/button")).Click();

            WebDriverWait doiTimKiem = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapTenShow = doiTimKiem.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/header[1]/div[1]/div/div/input"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            nhapTenShow.SendKeys(tenshow);
            nhapTenShow.SendKeys(OpenQA.Selenium.Keys.Enter);


            string originalWindow = driver.CurrentWindowHandle;

            // Nhấp vào eventlist element để mở sự kiện trong cửa sổ mới
            driver.FindElement(By.XPath("//*[@id=\"eventlist\"]/div[2]/div[2]/div[1]/div/div/div[1]/div/div[1]/a")).Click();

            // Chờ cho cửa sổ hoặc tab mới
            doiWeb.Until(wd => wd.WindowHandles.Count > 1);

            // Lặp qua các handle và chuyển đến cửa sổ hoặc tab mới
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (!windowHandle.Equals(originalWindow))
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }

            // Chờ cho nút button xuất hiện trong DOM
            IWebElement button = doiWeb.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"content\"]/div[3]/section/section[1]/div[1]")));

            // Sử dụng JavaScript để cuộn đến vị trí của nút button
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", button);

            // Chờ cho nút button nằm trong viewport
            doiWeb.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", button));

            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                string jsCode = " let a = document.getElementsByClassName(\"btn-booking\"); " +
                                 " for(let i=0;i<a.length;i++){a[i].click();}";
                js.ExecuteScript(jsCode);
            }
            catch (Exception)
            {
                MessageBox.Show("Het ve hoac khong the dat ve!");
            }

            Thread.Sleep(4000);

            for (int i = 0; i < soluong; i++)
            {
                driver.FindElement(By.XPath("//*[@id=\"ticket-type-list\"]/div/div[" + (loaive + 1) + "]/div/div/div[3]/div/div/div/span[2]/button/span")).Click();

            }

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[2]/div[3]/table/tbody/tr/td")).Click();


            WebDriverWait doiSDT = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapSDT = doiSDT.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[1]/div/accordion/div/div/div[2]/div/form/div/div[1]/div[2]/div/div[1]/div[2]/textarea"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            nhapSDT.SendKeys(sdt);

            WebDriverWait doiEmail = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapEmail = doiEmail.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[1]/div/accordion/div/div/div[2]/div/form/div/div[1]/div[2]/div/div[2]/div[2]/textarea"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            nhapEmail.SendKeys(email);

            IWebElement timTT = doiWeb.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[2]/tkb-booking-bill/div/div/div[1]/div/table[1]/thead/tr/th/span")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", timTT);
            doiWeb.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", timTT));

            driver.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[1]/div/accordion/div/div[1]/div[2]/div/form/div/div[2]/button")).Click();

            for (int i = 0; i < soluong - 1; i++)
            {
                if (i == (soluong - 2))
                {
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath("//div[@class='panel-collapse collapse in']//span[@class='ng-scope'][contains(text(),'Sao chép câu trả lời từ form đầu tiên')]")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[2]/div[3]/div[2]/table/tbody/tr/td")).Click();
                }
                else
                {
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[1]/div/accordion/div/div[2]/div[2]/div/form/div/div[1]/button/span")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath(" //*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[1]/div/accordion/div/div[2]/div[2]/div/form/div/div[2]/button[2]")).Click();
                }
            }

            IWebElement timNutTT = doiWeb.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[2]/tkb-booking-bill/div/div/div[1]/div/table[1]/thead/tr/th/span")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", timNutTT);
            doiWeb.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", timNutTT));

            driver.FindElement(By.XPath("//*[@id=\"content\"]/div/section/div[2]/div/div/div/div/div[2]/div[3]/div[2]/table/tbody/tr/td")).Click();

            Thread.Sleep(2000);

            WebDriverWait choEmail = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dienEmail = choEmail.Until<IWebElement>((d) =>
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
            dienEmail.Clear();
            dienEmail.SendKeys(email);

            WebDriverWait choNhapLaiE = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dienLaiEmail = choNhapLaiE.Until<IWebElement>((d) =>
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
            dienLaiEmail.Clear();
            dienLaiEmail.SendKeys(email);

            WebDriverWait choNhapLaiSDT  = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dienSDT = choNhapLaiSDT.Until<IWebElement>((d) =>
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
            dienSDT.SendKeys(sdt);

            driver.FindElement(By.XPath("//*[@id=\"payment-info\"]/div[2]/div/div/div/div[2]/div[3]/div/div[1]/div[1]/div[1]/div")).Click();

            IWebElement TimNut = doiWeb.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"informationForm\"]/div/div/div/div[2]/tkb-booking-bill/div/div/div[1]/div/table[1]/thead/tr/th/span")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", TimNut);
            doiWeb.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", TimNut));

            driver.FindElement(By.XPath("//*[@id=\"informationForm\"]/div/div/div/div[2]/div[2]/div[2]/table/tbody/tr/td/span[1]/span")).Click();

            IWebElement button3 = doiWeb.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"informationForm\"]/div/div/div/div[2]/tkb-booking-bill/div/div/div[1]/div/table[1]/thead/tr/th")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", button3);
            doiWeb.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", button3));

            driver.FindElement(By.XPath("//*[@id=\"informationForm\"]/div/div/div/div[2]/div[2]/div[2]/table/tbody/tr/td")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("  //*[@id=\"card_type_001\"]")).Click();

            WebDriverWait choSTK = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapSTK = choSTK.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath(" //*[@id=\"card_number\"]"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            nhapSTK.SendKeys(stk);


            IWebElement TNut = doiWeb.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"bill_to_address_city\"]")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", TNut);
            doiWeb.Until(wd => (bool)((IJavaScriptExecutor)wd).ExecuteScript("var rect = arguments[0].getBoundingClientRect(); return (rect.top >= 0 && rect.bottom <= window.innerHeight);", TNut));


            WebElement down = (WebElement)driver.FindElement(By.Name("card_expiry_month"));
            SelectElement select = new SelectElement(down);
            select.SelectByValue(thanghh.ToString());
            Thread.Sleep(2000);
            WebElement down1 = (WebElement)driver.FindElement(By.Name("card_expiry_year"));
            SelectElement select1 = new SelectElement(down1);
            select1.SelectByValue(namhh.ToString());

            WebDriverWait choThe = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement nhapThe = choThe.Until<IWebElement>((d) =>
            {
                try
                {
                    IWebElement element = d.FindElement(By.XPath(" //*[@id=\"card_cvn\"]"));
                    if (element.Displayed)
                    {
                        return element;
                    }
                }
                catch (NoSuchElementException) { }
                catch (StaleElementReferenceException) { }

                return null;
            });
            nhapThe.SendKeys(sthe);

        }
        private void checkBox1_Checked_1(object sender, RoutedEventArgs e)
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
