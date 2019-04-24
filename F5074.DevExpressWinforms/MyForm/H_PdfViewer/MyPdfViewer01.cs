using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace F5074.DevExpressWinforms.MyForm.H_PdfViewer
{
    public partial class MyPdfViewer01 : UserControl
    {
        public MyPdfViewer01()
        {
            InitializeComponent();
        }

        public void SetPDF()
        {
            try
            {
                MemoryStream ms;
                using (WebClient client = new WebClient())
                {
                    Uri _pdfUri = new Uri(@"http://kostat.go.kr/file_total/kor3/korIp1_14.pdf");
                    byte[] fileBytes = client.DownloadData(_pdfUri);
                    ms = new MemoryStream(fileBytes);
                    pdfViewer1.LoadDocument(ms);
                }

                //string url = @"http://kostat.go.kr/file_total/kor3/korIp1_14.pdf";
                //MemoryStream stream;
                //WebClient wc = new WebClient();
                //byte[] data = wc.DownloadData(url);
                //stream = new MemoryStream(data);
                //pdfViewer1.LoadDocument(stream);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
