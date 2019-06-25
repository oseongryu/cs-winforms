using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using DevExpress.XtraBars.Docking2010;
using F5074.MyBatisDataMapper.Service.Automation;

namespace F5074.Selenium.Views
{
    public partial class SeleniumUserControl : UserControl
    {
        // 1.Selenium 예제 http://www.csharpstudy.com/web/article/17-Web-Automation
        // 2_1.Selenium 다운로드 https://www.seleniumhq.org/download/
        // 2_2. Selenium ChromeDriver 다운로드
        // 3. Invisible Console, Chrome https://stackoverflow.com/questions/11501623/chromedriver-console-application-hide
        public SeleniumUserControl()
        {
            InitializeComponent();

            MyDevExpressFunctions.MakeWindowsUIButtonPanel(this.windowsUIButtonPanel1, new string[] { "검색" });
            WindowsUIButton btnSearch = this.windowsUIButtonPanel1.Buttons["검색"] as WindowsUIButton;
            WindowsUIButton btnChart = this.windowsUIButtonPanel1.Buttons["차트"] as WindowsUIButton;

            btnSearch.Click += BtnSearch_Click;

            IList<AutomationDTO> tempList = AutomationDAO.SelectSiteList(new AutomationDTO());

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Invisible Chrome
                //ChromeOptions options = new ChromeOptions();
                //options.AddArgument("headless");
                //ChromeDriver chromeDriver = new ChromeDriver(options);
                //IWebDriver driver = chromeDriver;


                //// Invisible Console
                //var chromeDriverService = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory + @"\Lib");
                //chromeDriverService.HideCommandPromptWindow = true;
                //ChromeOptions chromeOptions = new ChromeOptions();
                //IWebDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);


                //IWebDriver driver = new ChromeDriver();



                using (IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory + @"\Lib"))
                {
                    driver.Url = "https://google.co.kr";
                    //driver.Manage().Window.Maximize();

                    IWebElement q = driver.FindElement(By.Id("query"));
                    q.SendKeys("abc");
                    driver.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(5000);

                    // 1위 제목 출력
                    var rank = driver.FindElement(By.ClassName("list_rank"));
                    var rankOne = rank.FindElement(By.XPath(".//li[0]/h4/a"));
                    string title = rankOne.Text;
                    Console.WriteLine(title);
                    driver.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
