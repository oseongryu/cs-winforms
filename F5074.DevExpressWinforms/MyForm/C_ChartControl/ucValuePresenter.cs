using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public partial class ucValuePresenter : UserControl
    {
        double doubleValue;
        string valueFormat;

        public Color ValueTextColor
        {
            get { return labelValue.ForeColor; }
            set { labelValue.ForeColor = value; }
        }
        public string TitleText
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        public string ValueFormat
        {
            get { return valueFormat; }
            set
            {
                valueFormat = value;
                UpdateValueText();
            }
        }
        public double Value
        {
            get { return doubleValue; }
            set
            {
                doubleValue = value;
                UpdateValueText();
            }
        }

        public ucValuePresenter()
        {
            InitializeComponent();
        }

        void UpdateValueText()
        {
            if (valueFormat != null)
                labelValue.Text = string.Format(valueFormat, doubleValue);
            else
                labelValue.Text = doubleValue.ToString();
        }
    }
}
