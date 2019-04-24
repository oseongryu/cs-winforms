using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyResources
{
    class WebFile
    {
        /// <summary>
        /// 웹파일 다운로드
        /// </summary>
        /// <param name="remoteFilename">웹 서버 파일</param>
        /// <param name="localFilename">PC 저장 파일</param>
        /// <returns>파일 크기를 반환</returns>
        public static int DownloadFile(String remoteFilename, String localFilename)
        {
            // Function will return the number of bytes processed to the caller. Initialize to 0 here.
            int bytesProcessed = 0;

            // Assign values to these objects here so that they can be referenced in the finally block
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            // Use a try/catch/finally block as both the WebRequest and Stream classes throw exceptions upon error
            try
            {
                WebRequest request = WebRequest.Create(remoteFilename); // 원격 파일 다운을 위한 객체 생성
                if (request != null)
                {
                    response = request.GetResponse(); // 서버로부터 WebResponse 오브젝트 받아옴
                    if (response != null)
                    {
                        // Once the WebResponse object has been retrieved, get the stream object associated with the response's data
                        remoteStream = response.GetResponseStream();
                        //localStream = File.Create(localFilename);  // local File 생성
                        localStream = new FileStream(localFilename, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                        byte[] buffer = new byte[1024];  // 1k 버퍼 할당
                        int bytesRead;

                        // Simple do/while loop to read from stream until no bytes are returned
                        do
                        {
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length); // 1K 바이트씩 데이터 읽기
                            localStream.Write(buffer, 0, bytesRead); // PC에 데이터 저장
                            bytesProcessed += bytesRead;  // 전체 바이트 수 체크를 위해 누적
                        } while (bytesRead > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (response != null) response.Close(); //WebResponse객체 Close
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();
            }

            return bytesProcessed;  // 수신한 전체 바이트수를 리턴(파일의 크기)
        }

        /// <summary>
        /// 웹에 파일이 존재하는지 검사하여 있으면 true 반환
        /// </summary>
        /// <param name="url">Web 파일 경로</param>
        /// <returns></returns>
        public static bool WebExists(string url)
        {
            bool ret = true;
            if (url == null)
                return false;
            HttpWebResponse response = null;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException)
            {
                ret = false;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            return ret;
        }
    }
}
