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
                dicParam.Add("SITE", SITE);
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
        /// SelectEqpWorkCenter
        /// </summary>
        /// <param name="deptCd"></param>
        /// <returns></returns>
        public static DataTable SelectEqpWorkCenter(string deptCd)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("DEPT_CODE", deptCd);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_WORK_CENTER", dicParam).Tables[0].Copy();
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
        /// <param name="workCenter"></param>
        /// <param name="eqpId"></param>
        /// <returns></returns>
        public static DataTable SelectEqpMstCIM(string deptCd, string workCenter = "", string eqpId = "")
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("DEPT_CODE", deptCd);
                dicParam.Add("WORK_CENTER", workCenter);
                dicParam.Add("EQP_ID", eqpId);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_MST", dicParam).Tables[0].Copy();
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

        /// <summary>
        /// SelectEqpSetupPerf
        /// </summary>
        /// <param name="startDt"></param>
        /// <param name="endDt"></param>
        /// /// <param name="statusDetail"></param>
        /// <param name="deptCd"></param>
        /// <param name="workCenter"></param>
        /// <param name="eqpId"></param>
        /// <returns></returns>
        public static DataTable SelectEqpSetupPerf(String startDt, String endDt, String statusDetail, String deptCd, String workCenter = "", String eqpId = "")
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("STATUS_D", statusDetail);
                dicParam.Add("DEPT_CODE", deptCd);
                dicParam.Add("WORK_CENTER", workCenter);
                dicParam.Add("EQP_ID", eqpId);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_SETUP_PERF", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SelectEqpSetupPerfSum
        /// </summary>
        /// <param name="startDt"></param>
        /// <param name="endDt"></param>
        /// /// <param name="statusDetail"></param>
        /// <param name="deptCd"></param>
        /// <param name="workCenter"></param>
        /// <param name="eqpId"></param>
        /// <returns></returns>
        public static DataTable SelectEqpSetupPerfSum(String startDt, String endDt, String statusDetail, String deptCd, String workCenter = "", String eqpId = "")
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("START_DT", startDt);
                dicParam.Add("END_DT", endDt);
                dicParam.Add("STATUS_D", statusDetail);
                dicParam.Add("DEPT_CODE", deptCd);
                dicParam.Add("WORK_CENTER", workCenter);
                dicParam.Add("EQP_ID", eqpId);
                DataTable dt = RESTfulService.SelectCommandRESTful("EQP_SETUP_PERF_SUM", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectItemSpec(String itemNumber)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("ITEM_NUMBER", itemNumber);
                DataTable dt = RESTfulService.SelectCommandRESTful("SPC_CODE_SPEC_ITEMSPEC_SELECT", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectPartNumber(String itemNumber)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("ITEM_NUMBER", itemNumber);
                DataTable dt = RESTfulService.SelectCommandRESTful("SPC_CODE_SPEC_PARTNO_SELECT", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectProductName(String itemNumber)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("ITEM_NUMBER", itemNumber);
                DataTable dt = RESTfulService.SelectCommandRESTful("SPC_CODE_SPEC_PROD_SELECT", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectProcessName(String productName)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("PRODUCT_NAME", productName);
                DataTable dt = RESTfulService.SelectCommandRESTful("SPC_CHART_PROCESS_SELECT", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelectItemCode(String productName, String processName)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("PRODUCT_NAME", productName);
                dicParam.Add("PROCESS_NAME", processName);
                DataTable dt = RESTfulService.SelectCommandRESTful("SPC_CHART_ITEM_SELECT", dicParam).Tables[0].Copy();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet SelectByCondition(String itemSpec, String partNumber, String productName, String processName, String itemCd, String fromDate, String toDate)
        {
            try
            {
                Dictionary<string, string> dicParam = new Dictionary<string, string>();
                dicParam.Add("SITE", SITE);
                dicParam.Add("ITEM_SPEC", itemSpec);
                dicParam.Add("PART_NUMBER", partNumber);
                dicParam.Add("PRODUCT_NAME", productName);
                dicParam.Add("PROCESS_NAME", processName);
                dicParam.Add("ITEM_CD", itemCd);
                dicParam.Add("UPDATE_TIME_FROM", fromDate);
                dicParam.Add("UPDATE_TIME_TO", toDate);

                DataSet ds = RESTfulService.SelectCommandRESTful("SPC_CHART_HISTOGRAM_SELECT", dicParam).Copy();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
