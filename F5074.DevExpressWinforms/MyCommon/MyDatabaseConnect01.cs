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
        public void connection()
        {
            try
            {
                //https://and0329.tistory.com/entry/C-%EA%B3%BC-%EC%98%A4%EB%9D%BC%ED%81%B4-%EB%8D%B0%EC%9D%B4%ED%84%B0%EB%B2%A0%EC%9D%B4%EC%8A%A4-%EC%97%B0%EB%8F%99-%EB%B0%A9%EB%B2%95
                foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                {
                    oraCon = line;
                }

                // 1
                //OracleConnection OraConn = new OracleConnection(oraCon);
                //OraConn.Open();//디비 오픈
                //OracleDataAdapter oda = new OracleDataAdapter();//어댑터 생성자
                //oda.SelectCommand = new OracleCommand("SELECT USER_ID FROM DESIGN_PROGRAM", OraConn);
                //DataTable d1 = new DataTable(); //데이터 저장공간 만들기
                //oda.Fill(d1);//데이터 저장공간에 데이터 집어넣음

                // 2
                //using (var conn = new OracleConnection(oraCon))
                //{
                //    conn.Open();

                //    conn.Close();
                //}

                using (OracleConnection conn = new OracleConnection(oraCon))
                {
                    conn.Open();
                    string sql = "SELECT * FROM PRODUCT_COMPONENT_VERSION";
                    using (OracleCommand comm = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader rdr = comm.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                Console.WriteLine(rdr.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            


        }




    }
}
