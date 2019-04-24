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

    }
}
