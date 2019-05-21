using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyForm.D_Common
{
    public partial class MyEnum02 : UserControl
    {
        public MyEnum02()
        {
            InitializeComponent();
            MakeSentences();
        }

        enum ma3
        {
            AUFNR
,VORNR
,KTEXT
,WTEXT
,WDATE
,LIFNR
,NAME1
,CKEY



        }

        private void MakeSentences()
        {
            StringBuilder text = new StringBuilder(this.richTextBox1.Text);
            for (int x = 0; x < Enum.GetNames(typeof(ma3)).Length; x++)
            {
                Console.WriteLine(Enum.GetNames(typeof(ma3))[x].ToString());

                //text.AppendFormat("{0}public string {1} {2}", Environment.NewLine, Enum.GetNames(typeof(ma3))[x].ToString(), "{ get; set; }");
                //text.AppendFormat("{0}{1} = rdr.GetValue(rdr.GetOrdinal(\"{1}\")),", Environment.NewLine, Enum.GetNames(typeof(ma3))[x].ToString());
                text.AppendFormat("{0}tempVo.{1} = dtTable3.Rows[0][\"{1}\"].ToString();", Environment.NewLine, Enum.GetNames(typeof(ma3))[x].ToString());

                richTextBox1.Text = text.ToString();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }
    }
}
