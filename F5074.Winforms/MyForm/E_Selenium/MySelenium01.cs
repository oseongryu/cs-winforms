using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace F5074.Winforms.MyForm.E_Selenium
{
    public partial class MySelenium01 : UserControl
    {
        public MySelenium01()
        {
            // 1.Selenium 예제 http://www.csharpstudy.com/web/article/17-Web-Automation
            // 2_1.Selenium 다운로드 https://www.seleniumhq.org/download/
            // 2_2. Selenium ChromeDriver 다운로드
            // 3. Invisible Console, Chrome https://stackoverflow.com/questions/11501623/chromedriver-console-application-hide

            InitializeComponent();


            // Invisible Chrome
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            //ChromeDriver chromeDriver = new ChromeDriver(options);
            //IWebDriver driver = chromeDriver;


            // Invisible Console
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chromeDriverService, new ChromeOptions());


            //IWebDriver driver = new ChromeDriver();

            driver.Url = "http://www.naver.com";
            driver.Manage().Window.Maximize();

            IWebElement q = driver.FindElement(By.Id("query"));
            q.SendKeys("최신영화순위");
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
}
