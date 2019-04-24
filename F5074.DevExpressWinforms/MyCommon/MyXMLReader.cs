using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace F5074.DevExpressWinforms.MyCommon
{
    public class MyXMLReader
    {
        public void Read()
        {
            // https://yi-chi.tistory.com/91
            string temp = "";
            XmlDocument xml = new XmlDocument();
            xml.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/MyResources/Sql.xml");
            XmlNodeList xmlList = xml.SelectNodes("/config");
            foreach (XmlNode xnl in xmlList)
            {
                temp = temp = xnl["sql"].InnerText;

                //temp += xnl["Age"].InnerText;
                //temp += xnl["ID"].InnerText;
                //temp += xnl["Pw"].InnerText;
                //temp += xnl["Name"]["성"].InnerText;
                //temp += xnl["Name"]["이름"].InnerText;
            }
            Console.WriteLine(temp);
        }
        public string Read(string sqlName)
        {
            string result = "";
            XmlDocument xml = new XmlDocument();
            //xml.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/MyResources/Sql.xml");
            xml.Load("C:\\DEV\\Sql.xml");
            XmlNodeList xmlList = xml.SelectNodes("/config");
            foreach (XmlNode xnl in xmlList)
            {
                result = xnl[sqlName].InnerText;
            }

            return result;
        }
    }
}
