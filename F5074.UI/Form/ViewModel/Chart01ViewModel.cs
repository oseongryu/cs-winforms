using F5074.Common.Service.RESTful;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.UI.Form.ViewModel {
    public static class Chart01ViewModel {
        private static string SITE = "1000";

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
                dicParam.Add("SITE", SITE);
                dicParam.Add("USE_YN", useYn);
                dicParam.Add("GENE_DV", geneDv);
                DataTable dt = RESTfulService.SelectCommandRESTful("MAS_CD_GENEDATA_SELECT_BY_CONDITION", dicParam).Tables[0].Copy();
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
        /// <param name="deptCd"></param>
        /// <returns></returns>
        public static DataTable SelectEqpMst(string deptCd)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("DEPT_CODE", deptCd);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_MST", dicParam).Tables[0].Copy();
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
                dicParam.Add("SITE", SITE);
                dicParam.Add("EQP_ID", eqpId);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("ITEM_CD", itemCd);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_SRC_DATA", dicParam).Tables[0].Copy();
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
                dicParam.Add("SITE", SITE);
                dicParam.Add("EQP_ID", eqpId);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_CD_SPEC", dicParam).Tables[0].Copy();
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
                dicParam.Add("SITE", SITE);
                dicParam.Add("EQP_ID", eqpId);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("CATEGORY", category);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_MAX_LOAD", dicParam).Tables[0].Copy();
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
        /// <param name="partNumber"></param>
        /// <returns></returns>
        public static DataTable SelectEqpMaxLoad(string eqpId, string startDt, string endDt, string category, string partNumber)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("EQP_ID", eqpId);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("CATEGORY", category);
                dicParam.Add("PART_NUMBER", partNumber);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_MAX_LOAD", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SelectEqpDeptMst
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectEqpDeptMst()
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("GENE_DV", "CB_EQP_DEPT_CD");
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_DEPT_CD", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SelectEqpPartNumber
        /// </summary>
        /// <param name="eqpId"></param>
        /// <param name="startDt"></param>
        /// <param name="endDt"></param>
        /// <returns></returns>
        public static DataTable SelectEqpPartNumber(String eqpId, string startDt, string endDt)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("EQP_ID", eqpId);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_PART_NUMBER", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
