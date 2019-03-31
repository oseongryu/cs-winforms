using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.TabFolder
{
    public partial class FormTab1 : Form
    {
        private enum DBIndex
        {
            ORDER_QTY
            , END_DATE_TIME
            , PRODUCT_NAME
            , END_QTY
            , PROCESS_NAME
            , EQP_NO
            , CREATE_DATE_TIME

        };
        public FormTab1()
        {
            InitializeComponent();
            string a = "this.txt";
            string b = ".EditValue = ";
            string d = ";";

            for (int x = 0; x < Enum.GetNames(typeof(DBIndex)).Length; x++)
            {
                string c = Enum.GetNames(typeof(DBIndex))[x].ToString();
                this.textBox1.AppendText( a + c + b + c + d + "\r\n");
                //this.textBox1.Text += a + c + b + c + d + "\r\n";
                //Console.WriteLine(a + c + b + c + d);
            }
        }

    }
}
