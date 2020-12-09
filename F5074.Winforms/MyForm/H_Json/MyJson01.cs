using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace F5074.Winforms.MyForm.H_Json {
    public partial class MyJson01 : UserControl {
        public MyJson01()
        {
            InitializeComponent();
            RestApi();
            //Refresh();
        }

        NameValueCollection parameters = new NameValueCollection
        {
            { "USER_ID", "admin"},
        };

        private void Refresh()
        {
            using (WebClient wc = new WebClient())
            {
                var response = wc.UploadValues("http://localhost/users", parameters);
                string strJson = Encoding.UTF8.GetString(response);
                JObject arrJson = JObject.Parse(strJson);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString());


                ////var json = new WebClient().DownloadString("http://localhost/users");
                //string strJson = json.ToString();
                //JObject arrJson = JObject.Parse(strJson);
                //DataTable dt = JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString());
            }
        }

        private void RestApi()
        {
            var json = new WebClient().DownloadString("http://localhost/users2");

            string strJson = json.ToString();
            JObject arrJson = JObject.Parse(strJson);
            JArray arrJsons = JArray.Parse(arrJson["data"].ToString());
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString());
        }

    }
}

