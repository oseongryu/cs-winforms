using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.UI.Form.ViewModel {
    public static class Chart01ViewModel {


        /// <summary>
        /// SelectCommonMasCd
        /// </summary>
        /// <param name="geneDv"></param>
        /// <param name="useYn"></param>
        /// <returns></returns>
        public static DataTable SelectCommonMasCd(string geneDv, string useYn = "Y")
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", "1000");
                dicParam.Add("USE_YN", useYn);
                dicParam.Add("GENE_DV", geneDv);
                DataTable dt = SelectCommandRESTful("MAS_CD_GENEDATA_SELECT_BY_CONDITION", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// SelectEqpMst
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectEqpMst()
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", "1000");
                DataTable dt = SelectCommandRESTful("EQP_MST", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SelectEqpSrcData
        /// </summary>
        /// <param name="eqpId"></param>
        /// <param name="startDt"></param>
        /// <param name="endDt"></param>
        /// <param name="itemCd"></param>
        /// <returns></returns>
        public static DataTable SelectEqpSrcData(String eqpId, string startDt, string endDt, string itemCd)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", "1000");
                dicParam.Add("EQP_ID", eqpId);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("ITEM_CD", itemCd);
                DataTable dt = SelectCommandRESTful("EQP_SRC_DATA", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SelectEqpCdSpec
        /// </summary>
        /// <param name="eqpId"></param>
        /// <returns></returns>
        public static DataTable SelectEqpCdSpec(string eqpId)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", "1000");
                dicParam.Add("EQP_ID", eqpId);
                DataTable dt = SelectCommandRESTful("EQP_CD_SPEC", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SelectEqpMaxLoad
        /// </summary>
        /// <param name="eqpId"></param>
        /// <param name="startDt"></param>
        /// <param name="endDt"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public static DataTable SelectEqpMaxLoad(string eqpId, string startDt, string endDt, string category)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", "1000");
                dicParam.Add("EQP_ID", eqpId);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("CATEGORY", category);
                DataTable dt = SelectCommandRESTful("EQP_MAX_LOAD", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
