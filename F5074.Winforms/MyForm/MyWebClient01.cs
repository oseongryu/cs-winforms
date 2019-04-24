using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using F5074.Winforms.MyResources;

namespace F5074.Winforms.MyForm
{
    public partial class MyWebClient01 : UserControl
    {
        string url = @"http://kostat.go.kr/file_total/kor3/korIp1_14.pdf";
        private BackgroundWorker worker = null;
        WebClient myWebClient = new WebClient();
        public MyWebClient01()
        {
            InitializeComponent();
            this.webBrowser1.Navigate(new Uri(url));
            this.webBrowser1.Navigating += WebBrowser1_Navigating;
            this.webBrowser1.FileDownload += WebBrowser1_FileDownload;

            //worker = new BackgroundWorker();
            //worker.WorkerReportsProgress = true;
            //worker.WorkerSupportsCancellation = true;
            //worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            //worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            //worker.RunWorkerAsync();


            //Thread th = new Thread(() =>
            //{
            //    System.Threading.Thread.Sleep(3000);
            //    this.webBrowser1.Navigate(new Uri(url));
            //});
            //th.SetApartmentState(ApartmentState.MTA);
            //th.Start();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DateTime dateTimeStop = DateTime.Now;

                //foreach (HtmlElement row in webBrowser1.Document.Window.Frames["View_Frame"].Document.GetElementsByTagName("TR"))

                //{
                //    foreach (HtmlElement link in row.GetElementsByTagName("A"))
                //    {
                //        link.InvokeMember("Click");
                //    }

                //}

                foreach (HtmlElement row in webBrowser1.Document.Window.Frames["View_Frame"].Document.GetElementsByTagName("input"))
                {
                    if (row.Name == "DOWNLOADALL")
                    {
                        row.InvokeMember("click");
                        //tbState.Text = "4";
                        myWebClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)");
                        myWebClient.DownloadFile(url, "test.pdf");//I don't know where is your URL and path!
                        break;
                    }

                }

                TimeSpan timeDiff = DateTime.Now - dateTimeStop;
                int waiting = (int)(1000 - (timeDiff.TotalMilliseconds % 1000));
                System.Threading.Thread.Sleep(waiting);
            }
            catch { }

        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void WebBrowser1_FileDownload(object sender, EventArgs e)
        {
            //byte[] myDataBuffer = myWebClient.DownloadData(url);
            //foreach (HtmlElement row in webBrowser1.Document.Window.Frames["View_Frame"].Document.GetElementsByTagName("TR"))

            //{
            //    foreach (HtmlElement link in row.GetElementsByTagName("A"))
            //    {
            //        link.InvokeMember("Click");
            //    }

            //}
        }

        private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Console.WriteLine("yes");
            //myWebClient.DownloadFileAsync(e.Url, "tes.pdf");
        }

        //private void WebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        //{
        //    if (e.Url.Segments[e.Url.Segments.Length - 1].EndsWith(".exe"))//".exe" is the extension of the download file
        //    {
        //        e.Cancel = true;
        //        string filepath = @"C:\";//the path for file to save                
        //        WebClient client = new WebClient();
        //        client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
        //        client.DownloadFileAsync(e.Url, filepath);
        //    }
        //}
        //void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        //{
        //    MessageBox.Show("File downloaded");
        //}

        private void webFileDown()
        {
            // https://link2me.tistory.com/1115
            // 파일 다운로드
            string webfilePath = url;
            if (WebFile.WebExists(webfilePath))
            {
                int write = WebFile.DownloadFile(webfilePath, "abc.pdf");  // 파일 사이즈를 반환
            }
            else
            {
                MessageBox.Show("다운받을 파일이 존재하지 않습니다");
                return;
            }
        }

        public void ByteDownload()
        {
            //string url = "http://httpbin.org/image/png";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            // Response 바이너리 데이타 처리. 이미지 파일로 저장.                        
            using (WebResponse resp = request.GetResponse())
            {
                var buff = new byte[1024];
                int pos = 0;
                int count;
                using (Stream stream = resp.GetResponseStream())
                {
                    using (var fs = new FileStream("document.pdf", FileMode.Create))
                    {
                        do
                        {
                            count = stream.Read(buff, pos, buff.Length);
                            fs.Write(buff, 0, count);
                        } while (count > 0);
                    }
                }
            }
        }

        public void FileDownload(String url, String path)
        {
            try
            {
                WebClient webClient = new WebClient();
                //webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                //webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                webClient.UseDefaultCredentials = true;
                webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                webClient.DownloadFileAsync(new Uri(url), "test1.pdf");
                //webClient.DownloadFileAsync(new Uri(url), "dev.pdf");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void DownloadFile(string filenameXML)
        {
            HttpWebRequest request;
            HttpWebResponse response = null;
            FileStream fs = null;
            long startpoint = 0;

            fs = File.Create(filenameXML);
            request = (HttpWebRequest)WebRequest.Create("http://kostat.go.kr/file_total/kor3/korIp1_14.pdf");
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version11;
            request.Method = "GET";
            request.ContentType = "pdf";
            request.Timeout = 500000;
            request.Headers.Add("xRange", "bytes " + startpoint + "-");
            response = (HttpWebResponse)request.GetResponse();
            Stream streamResponse = response.GetResponseStream();
            byte[] buffer = new byte[1024];
            int read;
            while ((read = streamResponse.Read(buffer, 0, buffer.Length)) > 0)
            {
                fs.Write(buffer, 0, read);
            }
            fs.Flush(); fs.Close();
        }
    }
}
