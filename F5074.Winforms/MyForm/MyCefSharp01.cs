using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace F5074.Winforms.MyForm
{
    public partial class MyCefSharp01 : UserControl
    {
        public ChromiumWebBrowser browser;
        public MyCefSharp01()
        {
            // https://www.codeproject.com/Tips/1058700/Embedding-Chrome-in-your-Csharp-App-using-CefSharp
            // 실행 전 관련 파일들을 Debug에 저장해야 함
            InitializeComponent();
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("http://kostat.go.kr/file_total/kor3/korIp1_14.pdf");
            this.panel1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
