using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Service.Dashboard
{
    public class DashboardDTO
    {
        //
        public object A1 { get; set; }
        public object A2 { get; set; }
        public object A3 { get; set; }
        public object A4 { get; set; }

        // 부서
        public object DEPT_CODE { get; set; }
        public object DEPT_NAME { get; set; }

        // 장비
        public object EQP_ID { get; set; }
        public object EQP_NO { get; set; }
        public object ASSET_FLAG { get; set; }
        public object EQP_DESC { get; set; }
        public object ASSET_NUMBER { get; set; }
        public object WORK_CENTER { get; set; }
        public object WORK_CENTER_NAME { get; set; }
        public object RUN_TYPE { get; set; }
        public object PLC_FLAG { get; set; }
        public object PLC_COUNT_FLAG { get; set; }
        public object STATE { get; set; }
        public object PROCESS_NAME { get; set; }
        public object LOT_ID { get; set; }
        public object WC_NAME { get; set; }


        public object CHK { get; set; }
        public object NP_FLAG { get; set; }
        public object STAY_DURATION { get; set; }
        public object DURATI { get; set; }
        public object CAPACITY { get; set; }
        public object SCRAP_QTY { get; set; }
        public object PLAN_NAME { get; set; }
        public object PLAN_VERSION { get; set; }
        public object PRODUCT_NAME { get; set; }
        public object PRODUCT_REVISION { get; set; }
        public object PRODUCT_DESC { get; set; }
        public object SALES_ORDER_NUMBER { get; set; }
        public object PROD_ORDER_NUMBER { get; set; }
        public object ORDER_QTY { get; set; }
        public object PARENT_PROD_ORDER_NUMBER { get; set; }
        public object START_QTY { get; set; }
        public object CURRENT_QTY { get; set; }
        public object END_QTY { get; set; }
        public object STATUS { get; set; }
        public object PARENT_LOT_ID { get; set; }
        public object REPRC_FLAG { get; set; }
        public object START_DATE_TIME { get; set; }
        public object END_DATE_TIME { get; set; }
        public object PRIORITY { get; set; }
        public object PROCESS_SEQ { get; set; }
        public object PROCESS_DESC { get; set; }
        public object LOT_TYPE { get; set; }
        public object SITE { get; set; }
        public object WIP_DUE_DATE { get; set; }
        public object ERP_IF_FLAG { get; set; }
        public object EQP_LOTSN { get; set; }
        public object EQP_LOTSN_SEQ { get; set; }
        public object EQP_BATCH_TYPE { get; set; }
        public object ORG_LOT_ID { get; set; }
        public object EQP_BATCH_ID { get; set; }
        public object PREV_UNIT_WEIGHT { get; set; }
        public object SPLIT_SEQ { get; set; }
        public object CREATE_DATE_TIME { get; set; }
        public object INCOMING_QTY { get; set; }
        public object STAY_REASON { get; set; }
        public object MAT_DOC_NUMBER { get; set; }
        public object MAT_YEAR { get; set; }
        public object MAT_DOC_ITEM { get; set; }
        public object SPECIAL_TREAT { get; set; }
        public object PROD_ORDER_SPEC { get; set; }
        public object PREV_PROCESS_SEQ { get; set; }
        public object NEXT_PROCESS_SEQ { get; set; }
        public object PURCHASE_ORDER_NO { get; set; }
        public object ORDER_DATE { get; set; }
        public object EST_END_DATE { get; set; }
        public object DUE_DATE { get; set; }
        public object ITEM_SPEC { get; set; }
        public object PART_NUMBER { get; set; }
        public object UNIT_WEIGHT { get; set; }
        public object MOLD_NUMBER { get; set; }
        public object ORDER_IDX { get; set; }
        public object LEB { get; set; }
        public object CURRENTPROC { get; set; }
        public object ORDER_COUNT { get; set; }
        public object CHK2 { get; set; }
    }
}
