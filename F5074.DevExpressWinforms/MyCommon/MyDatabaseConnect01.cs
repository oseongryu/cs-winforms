using DevExpress.DataAccess.ConnectionParameters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyCommon
{
    public class MyDatabaseConnect01
    {
        // https://www.devexpress.com/Support/Center/Question/Details/T418610/documentation-for-connection-to-oracle-database
        private string oraCon = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))(CONNECT_DATA =(SERVER = XE)(SERVICE_NAME = XE)));User Id=abc;Password=1234;";
        //public void connection()
        //{
        //    try
        //    {
        //        //https://and0329.tistory.com/entry/C-%EA%B3%BC-%EC%98%A4%EB%9D%BC%ED%81%B4-%EB%8D%B0%EC%9D%B4%ED%84%B0%EB%B2%A0%EC%9D%B4%EC%8A%A4-%EC%97%B0%EB%8F%99-%EB%B0%A9%EB%B2%95
        //        foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
        //        {
        //            oraCon = line;
        //        }

        //        // 1
        //        //OracleConnection OraConn = new OracleConnection(oraCon);
        //        //OraConn.Open();//디비 오픈
        //        //OracleDataAdapter oda = new OracleDataAdapter();//어댑터 생성자
        //        //oda.SelectCommand = new OracleCommand("SELECT USER_ID FROM DESIGN_PROGRAM", OraConn);
        //        //DataTable d1 = new DataTable(); //데이터 저장공간 만들기
        //        //oda.Fill(d1);//데이터 저장공간에 데이터 집어넣음

        //        // 2
        //        //using (var conn = new OracleConnection(oraCon))
        //        //{
        //        //    conn.Open();

        //        //    conn.Close();
        //        //}

        //        using (OracleConnection conn = new OracleConnection(oraCon))
        //        {
        //            conn.Open();
        //            string sql = "SELECT * FROM PRODUCT_COMPONENT_VERSION";
        //            using (OracleCommand comm = new OracleCommand(sql, conn))
        //            {
        //                using (OracleDataReader rdr = comm.ExecuteReader())
        //                {
        //                    while (rdr.Read())
        //                    {
        //                        Console.WriteLine(rdr.GetString(0));
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}
        public List<DataVo> connection(string _val)
        {
            List<DataVo> resultList = new List<DataVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }

                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sql");
                    OracleCommand comm = new OracleCommand();
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.Parameters.Add("val", _val);
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            // http://www.csharpstudy.com/Mistake/Article/20
                            DataVo vo = new DataVo()
                            {
                                EQP_ID = rdr.IsDBNull(0) == true ? " " : rdr.GetValue(0),
                                EQP_NO = rdr.IsDBNull(1) == true ? " " : rdr.GetValue(1),
                                STATE = rdr.IsDBNull(2) == true ? " " : rdr.GetValue(2),
                                PLC_FLAG = rdr.IsDBNull(3) == true ? " " : rdr.GetValue(3),
                                LOT_ID = rdr.IsDBNull(4) == true ? " " : rdr.GetValue(4),
                                PROD_ORDER_NUMBER = rdr.IsDBNull(5) == true ? " " : rdr.GetValue(5),
                                EQP_LOTSN = rdr.IsDBNull(6) == true ? " " : rdr.GetValue(6),
                                EQP_LOTSN_SEQ = rdr.IsDBNull(7) == true ? " " : rdr.GetValue(7),
                                EQP_BATCH_TYPE = rdr.IsDBNull(8) == true ? " " : rdr.GetValue(8),
                                EQP_BATCH_ID = rdr.IsDBNull(9) == true ? " " : rdr.GetValue(9),
                                START_QTY = rdr.IsDBNull(10) == true ? " " : rdr.GetValue(10),
                                TRACKIN_DATE_TIME = rdr.IsDBNull(11) == true ? " " : rdr.GetValue(11),
                                STD_QTY = rdr.IsDBNull(12) == true ? " " : rdr.GetValue(12),
                                STD_VAL = rdr.IsDBNull(13) == true ? " " : rdr.GetValue(13),
                                BATCH_TM = rdr.IsDBNull(14) == true ? " " : rdr.GetValue(14),
                                SAMPLE_COUNT = rdr.IsDBNull(15) == true ? " " : rdr.GetValue(15),
                                PART_NUMBER = rdr.IsDBNull(16) == true ? " " : rdr.GetValue(16)
                            };
                            resultList.Add(vo);
                        }
                    }
                    conn.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataTwoVo> connection2()
        {
            List<DataTwoVo> resultList = new List<DataTwoVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }

                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqltwo");
                    using (OracleCommand comm = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader rdr = comm.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                DataTwoVo vo = new DataTwoVo()
                                {
                                    DEPT_CODE = rdr.GetValue(rdr.GetOrdinal("DEPT_CODE")),
                                    DEPT_NAME = rdr.GetValue(rdr.GetOrdinal("DEPT_NAME"))
                                };
                                resultList.Add(vo);
                            }
                        }
                    }
                    conn.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataThreeVo> connection3(string _val)
        {
            List<DataThreeVo> resultList = new List<DataThreeVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }
                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlthree");
                    OracleCommand comm = new OracleCommand();
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.Parameters.Add("val", _val);
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                            DataThreeVo vo = new DataThreeVo()
                            {
                                EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                EQP_NO = rdr.GetValue(rdr.GetOrdinal("EQP_NO")),
                                ASSET_FLAG = rdr.GetValue(rdr.GetOrdinal("ASSET_FLAG")),
                                EQP_DESC = rdr.GetValue(rdr.GetOrdinal("EQP_DESC")),
                                ASSET_NUMBER = rdr.GetValue(rdr.GetOrdinal("ASSET_NUMBER")),
                                WORK_CENTER = rdr.GetValue(rdr.GetOrdinal("WORK_CENTER")),
                                WORK_CENTER_NAME = rdr.GetValue(rdr.GetOrdinal("WORK_CENTER_NAME")),
                                RUN_TYPE = rdr.GetValue(rdr.GetOrdinal("RUN_TYPE")),
                                DEPT_CODE = rdr.GetValue(rdr.GetOrdinal("DEPT_CODE")),
                                PLC_FLAG = rdr.GetValue(rdr.GetOrdinal("PLC_FLAG")),
                                PLC_COUNT_FLAG = rdr.GetValue(rdr.GetOrdinal("PLC_COUNT_FLAG")),
                                STATE = rdr.GetValue(rdr.GetOrdinal("STATE")),
                                PROCESS_NAME = rdr.GetValue(rdr.GetOrdinal("PROCESS_NAME")),
                                LOT_ID = rdr.GetValue(rdr.GetOrdinal("LOT_ID")),
                                WC_NAME = rdr.GetValue(rdr.GetOrdinal("WC_NAME"))
                            };
                            resultList.Add(vo);


                        }
                    }
                    conn.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataFourVo> connection4(string _val)
        {
            List<DataFourVo> resultList = new List<DataFourVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }

                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlfour");
                    using (OracleCommand comm = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader rdr = comm.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                DataFourVo vo = new DataFourVo()
                                {
                                    SITE = rdr.GetValue(rdr.GetOrdinal("SITE")),
                                    EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                    EQP_NO = rdr.GetValue(rdr.GetOrdinal("EQP_NO")),
                                    STATUS = rdr.GetValue(rdr.GetOrdinal("STATUS")),
                                    START_TIME = rdr.GetValue(rdr.GetOrdinal("START_TIME")),
                                    END_TIME = rdr.GetValue(rdr.GetOrdinal("END_TIME")),
                                    DIFF_TIME = rdr.GetValue(rdr.GetOrdinal("DIFF_TIME"))
                                };
                                resultList.Add(vo);
                            }
                        }
                    }
                    conn.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataFourVo> connection6(string _val)
        {
            List<DataFourVo> resultList = new List<DataFourVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }

                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlsix");
                    using (OracleCommand comm = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader rdr = comm.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                DataFourVo vo = new DataFourVo()
                                {
                                    SITE = rdr.GetValue(rdr.GetOrdinal("SITE")),
                                    EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                    EQP_NO = rdr.GetValue(rdr.GetOrdinal("EQP_NO")),
                                };
                                resultList.Add(vo);
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataSevenVo> connection7(string _val, string _workCenter)
        {
            List<DataSevenVo> resultList = new List<DataSevenVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }
                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlseven");
                    OracleCommand comm = new OracleCommand();
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.Parameters.Add("eqp_id", _val);
                    comm.Parameters.Add("work_center", _workCenter);
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                            DataSevenVo vo = new DataSevenVo()
                            {

                                CHK = rdr.GetValue(rdr.GetOrdinal("CHK")),
                                NP_FLAG = rdr.GetValue(rdr.GetOrdinal("NP_FLAG")),
                                STAY_DURATION = rdr.GetValue(rdr.GetOrdinal("STAY_DURATION")),
                                DURATI = rdr.GetValue(rdr.GetOrdinal("DURATI")),
                                CAPACITY = rdr.GetValue(rdr.GetOrdinal("CAPACITY")),
                                SCRAP_QTY = rdr.GetValue(rdr.GetOrdinal("SCRAP_QTY")),
                                LOT_ID = rdr.GetValue(rdr.GetOrdinal("LOT_ID")),
                                PLAN_NAME = rdr.GetValue(rdr.GetOrdinal("PLAN_NAME")),
                                PLAN_VERSION = rdr.GetValue(rdr.GetOrdinal("PLAN_VERSION")),
                                PRODUCT_NAME = rdr.GetValue(rdr.GetOrdinal("PRODUCT_NAME")),
                                PRODUCT_REVISION = rdr.GetValue(rdr.GetOrdinal("PRODUCT_REVISION")),
                                PRODUCT_DESC = rdr.GetValue(rdr.GetOrdinal("PRODUCT_DESC")),
                                SALES_ORDER_NUMBER = rdr.GetValue(rdr.GetOrdinal("SALES_ORDER_NUMBER")),
                                PROD_ORDER_NUMBER = rdr.GetValue(rdr.GetOrdinal("PROD_ORDER_NUMBER")),
                                ORDER_QTY = rdr.GetValue(rdr.GetOrdinal("ORDER_QTY")),
                                PARENT_PROD_ORDER_NUMBER = rdr.GetValue(rdr.GetOrdinal("PARENT_PROD_ORDER_NUMBER")),
                                START_QTY = rdr.GetValue(rdr.GetOrdinal("START_QTY")),
                                CURRENT_QTY = rdr.GetValue(rdr.GetOrdinal("CURRENT_QTY")),
                                END_QTY = rdr.GetValue(rdr.GetOrdinal("END_QTY")),
                                STATUS = rdr.GetValue(rdr.GetOrdinal("STATUS")),
                                PARENT_LOT_ID = rdr.GetValue(rdr.GetOrdinal("PARENT_LOT_ID")),
                                REPRC_FLAG = rdr.GetValue(rdr.GetOrdinal("REPRC_FLAG")),
                                START_DATE_TIME = rdr.GetValue(rdr.GetOrdinal("START_DATE_TIME")),
                                END_DATE_TIME = rdr.GetValue(rdr.GetOrdinal("END_DATE_TIME")),
                                PRIORITY = rdr.GetValue(rdr.GetOrdinal("PRIORITY")),
                                PROCESS_NAME = rdr.GetValue(rdr.GetOrdinal("PROCESS_NAME")),
                                PROCESS_SEQ = rdr.GetValue(rdr.GetOrdinal("PROCESS_SEQ")),
                                PROCESS_DESC = rdr.GetValue(rdr.GetOrdinal("PROCESS_DESC")),
                                LOT_TYPE = rdr.GetValue(rdr.GetOrdinal("LOT_TYPE")),
                                SITE = rdr.GetValue(rdr.GetOrdinal("SITE")),
                                WIP_DUE_DATE = rdr.GetValue(rdr.GetOrdinal("WIP_DUE_DATE")),
                                ERP_IF_FLAG = rdr.GetValue(rdr.GetOrdinal("ERP_IF_FLAG")),
                                EQP_LOTSN = rdr.GetValue(rdr.GetOrdinal("EQP_LOTSN")),
                                EQP_LOTSN_SEQ = rdr.GetValue(rdr.GetOrdinal("EQP_LOTSN_SEQ")),
                                EQP_BATCH_TYPE = rdr.GetValue(rdr.GetOrdinal("EQP_BATCH_TYPE")),
                                ORG_LOT_ID = rdr.GetValue(rdr.GetOrdinal("ORG_LOT_ID")),
                                WORK_CENTER = rdr.GetValue(rdr.GetOrdinal("WORK_CENTER")),
                                EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                EQP_NO = rdr.GetValue(rdr.GetOrdinal("EQP_NO")),
                                EQP_BATCH_ID = rdr.GetValue(rdr.GetOrdinal("EQP_BATCH_ID")),
                                PREV_UNIT_WEIGHT = rdr.GetValue(rdr.GetOrdinal("PREV_UNIT_WEIGHT")),
                                SPLIT_SEQ = rdr.GetValue(rdr.GetOrdinal("SPLIT_SEQ")),
                                CREATE_DATE_TIME = rdr.GetValue(rdr.GetOrdinal("CREATE_DATE_TIME")),
                                INCOMING_QTY = rdr.GetValue(rdr.GetOrdinal("INCOMING_QTY")),
                                STAY_REASON = rdr.GetValue(rdr.GetOrdinal("STAY_REASON")),
                                MAT_DOC_NUMBER = rdr.GetValue(rdr.GetOrdinal("MAT_DOC_NUMBER")),
                                MAT_YEAR = rdr.GetValue(rdr.GetOrdinal("MAT_YEAR")),
                                MAT_DOC_ITEM = rdr.GetValue(rdr.GetOrdinal("MAT_DOC_ITEM")),
                                SPECIAL_TREAT = rdr.GetValue(rdr.GetOrdinal("SPECIAL_TREAT")),
                                PROD_ORDER_SPEC = rdr.GetValue(rdr.GetOrdinal("PROD_ORDER_SPEC")),
                                PREV_PROCESS_SEQ = rdr.GetValue(rdr.GetOrdinal("PREV_PROCESS_SEQ")),
                                NEXT_PROCESS_SEQ = rdr.GetValue(rdr.GetOrdinal("NEXT_PROCESS_SEQ")),
                                PURCHASE_ORDER_NO = rdr.GetValue(rdr.GetOrdinal("PURCHASE_ORDER_NO")),
                                ORDER_DATE = rdr.GetValue(rdr.GetOrdinal("ORDER_DATE")),
                                EST_END_DATE = rdr.GetValue(rdr.GetOrdinal("EST_END_DATE")),
                                DUE_DATE = rdr.GetValue(rdr.GetOrdinal("DUE_DATE")),
                                ITEM_SPEC = rdr.GetValue(rdr.GetOrdinal("ITEM_SPEC")),
                                PART_NUMBER = rdr.GetValue(rdr.GetOrdinal("PART_NUMBER")),
                                UNIT_WEIGHT = rdr.GetValue(rdr.GetOrdinal("UNIT_WEIGHT")),
                                MOLD_NUMBER = rdr.GetValue(rdr.GetOrdinal("MOLD_NUMBER")),
                                ORDER_IDX = rdr.GetValue(rdr.GetOrdinal("ORDER_IDX")),
                            };
                            resultList.Add(vo);


                        }
                    }
                    conn.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }


        public List<DataSevenVo> connection8(string _val, string _workCenter)
        {
            List<DataSevenVo> resultList = new List<DataSevenVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }
                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlProcessList");
                    OracleCommand comm = new OracleCommand();
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.Parameters.Add("eqp_id", _val);
                    //comm.Parameters.Add("work_center", _workCenter);
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                            DataSevenVo vo = new DataSevenVo()
                            {
                                SITE = rdr.GetValue(rdr.GetOrdinal("SITE")),
                                EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                EQP_NO = rdr.GetValue(rdr.GetOrdinal("EQP_NO")),
                                PROCESS_DESC = rdr.GetValue(rdr.GetOrdinal("PROCESS_DESC")),
                                PROCESS_SEQ = rdr.GetValue(rdr.GetOrdinal("PROCESS_SEQ")),
                                PROCESS_NAME = rdr.GetValue(rdr.GetOrdinal("PROCESS_NAME")),
                                LEB = rdr.GetValue(rdr.GetOrdinal("LEB")),
                                CURRENTPROC = rdr.GetValue(rdr.GetOrdinal("CURRENTPROC"))
                            };
                            resultList.Add(vo);


                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataSevenVo> connection9(string _val, string _workCenter)
        {
            List<DataSevenVo> resultList = new List<DataSevenVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }
                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlProcessList2");
                    OracleCommand comm = new OracleCommand();
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.Parameters.Add("PROD_ORDER_NUMBER", _val);
                    //comm.Parameters.Add("work_center", _workCenter);
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                            DataSevenVo vo = new DataSevenVo()
                            {
                                SITE = rdr.GetValue(rdr.GetOrdinal("SITE")),
                                EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                PROCESS_DESC = rdr.GetValue(rdr.GetOrdinal("PROCESS_DESC")),
                                PROCESS_SEQ = rdr.GetValue(rdr.GetOrdinal("PROCESS_SEQ")),
                                PROCESS_NAME = rdr.GetValue(rdr.GetOrdinal("PROCESS_NAME")),
                            };
                            resultList.Add(vo);


                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public List<DataSevenVo> connectionProcessComaparence(string _partNumber)
        {
            List<DataSevenVo> resultList = new List<DataSevenVo>();
            try
            {
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }
                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = new MyXMLReader().Read("sqlProcessComparence2");
                    OracleCommand comm = new OracleCommand();
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.Parameters.Add("PART_NUMBER", _partNumber);
                    //comm.Parameters.Add("work_center", _workCenter);
                    using (OracleDataReader rdr = comm.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                            DataSevenVo vo = new DataSevenVo()
                            {
                                SITE = rdr.GetValue(rdr.GetOrdinal("SITE")),
                                EQP_ID = rdr.GetValue(rdr.GetOrdinal("EQP_ID")),
                                WORK_CENTER = rdr.GetValue(rdr.GetOrdinal("WORK_CENTER")),
                                PART_NUMBER = rdr.GetValue(rdr.GetOrdinal("PART_NUMBER")),
                                PROD_ORDER_NUMBER = rdr.GetValue(rdr.GetOrdinal("PROD_ORDER_NUMBER")),
                                ORDER_COUNT = rdr.GetValue(rdr.GetOrdinal("ORDER_COUNT")),
                                CHK = "False",
                                CHK2 = "False"
                            };
                            resultList.Add(vo);


                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return resultList;
        }

        public class DataVo
        {
            public object EQP_ID { get; set; }
            public object EQP_NO { get; set; }
            public object STATE { get; set; }
            public object PLC_FLAG { get; set; }
            public object LOT_ID { get; set; }
            public object PROD_ORDER_NUMBER { get; set; }
            public object EQP_LOTSN { get; set; }
            public object EQP_LOTSN_SEQ { get; set; }
            public object EQP_BATCH_TYPE { get; set; }
            public object EQP_BATCH_ID { get; set; }
            public object START_QTY { get; set; }
            public object TRACKIN_DATE_TIME { get; set; }
            public object STD_QTY { get; set; }
            public object STD_VAL { get; set; }
            public object BATCH_TM { get; set; }
            public object SAMPLE_COUNT { get; set; }
            public object PART_NUMBER { get; set; }
        }

        public class DataTwoVo
        {
            public object DEPT_CODE { get; set; }
            public object DEPT_NAME { get; set; }
        }

        public class DataThreeVo
        {
            public object EQP_ID { get; set; }
            public object EQP_NO { get; set; }
            public object ASSET_FLAG { get; set; }
            public object EQP_DESC { get; set; }
            public object ASSET_NUMBER { get; set; }
            public object WORK_CENTER { get; set; }
            public object WORK_CENTER_NAME { get; set; }
            public object RUN_TYPE { get; set; }
            public object DEPT_CODE { get; set; }
            public object PLC_FLAG { get; set; }
            public object PLC_COUNT_FLAG { get; set; }
            public object STATE { get; set; }
            public object PROCESS_NAME { get; set; }
            public object LOT_ID { get; set; }
            public object WC_NAME { get; set; }
        }

        public class DataFourVo
        {
            public object SITE { get; set; }
            public object EQP_ID { get; set; }
            public object EQP_NO { get; set; }
            public object STATUS { get; set; }
            public object START_TIME { get; set; }
            public object END_TIME { get; set; }
            public object DIFF_TIME { get; set; }
        }

        public class DataSevenVo
        {
            public object CHK { get; set; }
            public object NP_FLAG { get; set; }
            public object STAY_DURATION { get; set; }
            public object DURATI { get; set; }
            public object CAPACITY { get; set; }
            public object SCRAP_QTY { get; set; }
            public object LOT_ID { get; set; }
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
            public object PROCESS_NAME { get; set; }
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
            public object WORK_CENTER { get; set; }
            public object EQP_ID { get; set; }
            public object EQP_NO { get; set; }
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
}
