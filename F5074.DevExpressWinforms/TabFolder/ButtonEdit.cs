using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F5074.DevExpressWinforms.DialogFolder;

namespace F5074.DevExpressWinforms.TabFolder
{
    public partial class ButtonEdit : UserControl
    {
        public ButtonEdit()
        {
            InitializeComponent();
            this.buttonEdit1.Click += buttonEdit1_Click;
        }

        void buttonEdit1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
            //ButtonEditDialog buttonEditDialog = new ButtonEditDialog();
            //buttonEditDialog.ShowDialog();


            // http://www.csharpstudy.com/DevNote/Article/21
            // https://stackoverflow.com/questions/12491392/returning-a-dialogresult-from-child-form-referenced-in-parent-form-project

            // modaldialog
            ButtonEditForm buttonEditForm = new ButtonEditForm();
            DialogResult result = buttonEditForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK" + buttonEditForm.textEditModal.Text);

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }

            // modeless diaolg 

            //ButtonEditForm buttonEditForm = new ButtonEditForm();
            //buttonEditForm.Show();

        }
    }
}
