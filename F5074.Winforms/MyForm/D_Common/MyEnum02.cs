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
        private enum DbColumnIndex
        {
            LOT_ID, PROCESS_NAME, ITEM_CD, ITEM_NM, ITEM_SEQ, VALUE_SEQ, T_VALUE
        };

        string[] oHeaderText =
        {
              "LOT ID"
            , "공정명"
            , "검사 항목 코드"
            , "검사 항목명"
            , "검사 횟수"
            , "값 순서"
            , "값"
        };

        private void MakeSentences()
        {
            StringBuilder text = new StringBuilder(this.richTextBox1.Text);
            for (int x = 0; x < Enum.GetNames(typeof(DbColumnIndex)).Length; x++)
            {
                Console.WriteLine(Enum.GetNames(typeof(DbColumnIndex))[x].ToString());

                //text.AppendFormat("{0}public string {1} {2}", Environment.NewLine, Enum.GetNames(typeof(ma3))[x].ToString(), "{ get; set; }");
                //text.AppendFormat("{0}{1} = rdr.GetValue(rdr.GetOrdinal(\"{1}\")),", Environment.NewLine, Enum.GetNames(typeof(ma3))[x].ToString());
                text.AppendFormat("{0}{5} AllowEdit = false, Visble= {4}, HAlignment= {3}, Caption= \"{2}\", FieldName=\"{1}\" {6} ", Environment.NewLine, Enum.GetNames(typeof(DbColumnIndex))[x].ToString(), oHeaderText[x], "HorzAlignment.Center", "true", "columnList.Add(new GridControlColumn() {", "});", "false");

                richTextBox1.Text = text.ToString();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }
    }
}
