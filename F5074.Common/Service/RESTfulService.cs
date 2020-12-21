using System;
using System.Collections.Generic;
using System.Data;

namespace F5074.Common.Service {
    public static class RESTfulService {

        /// <summary>
        /// SelectCommand
        /// </summary>
        /// <param name="EVENT_CD"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet SelectCommandRESTful(String EVENT_CD, Dictionary<string, string> parameters)
        {
            try
            {
                DataSet resultSet = new DataSet();
                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    var reqparam = new System.Collections.Specialized.NameValueCollection();
                    foreach (var kvp in parameters)
                    {
                        reqparam.Add(kvp.Key.ToString(), kvp.Value.ToString());
                    }

                    var json = System.Text.Encoding.UTF8.GetString(wc.UploadValues(String.Format("{0}{1}", "http://localhost/equipment/", EVENT_CD), reqparam));

                    string strJson = json.ToString();
                    Newtonsoft.Json.Linq.JObject arrJson = Newtonsoft.Json.Linq.JObject.Parse(strJson);
                    Newtonsoft.Json.Linq.JArray arrJsons = Newtonsoft.Json.Linq.JArray.Parse(arrJson["data"].ToString());
                    resultSet.Tables.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(arrJson["data"].ToString()));
                    return resultSet;
                }
                return resultSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
