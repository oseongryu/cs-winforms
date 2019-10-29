using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.G_CommonControls
{
    public partial class MySearchLookUpEdit02 : UserControl
    {
        public MySearchLookUpEdit02()
        {
            InitializeComponent();
            InitLookUpEdit();
            if ( datasource.Count == 1 ) lookUpEdit1.EditValue = datasource[ 0 ].ID;



            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "Text";
            lookUpEdit2.Properties.DataSource = DataStorage.GetData();
            lookUpEdit2.EditValue = 2;
            simpleButton1.Click += SimpleButton1_Click;
        }

        private void SimpleButton1_Click( object sender, EventArgs e )
        {
            lookUpEdit2.EditValue = (int) spinEdit1.Value;

        }

        static class DataStorage
        {
            public static IEnumerable<DataObject> GetData()
            {
                for ( int i = 0; i < 10; i++ )
                    yield return new DataObject() { ID = i, Text = ( (char) ( 'A' + i ) ).ToString() };
            }
            public class DataObject
            {
                public int ID { get; set; }
                public string Text { get; set; }
            }
        }

        private List<Account> datasource;
        private void InitLookUpEdit()
        {
            datasource = new List<Account>();
            Random random = new Random();
            datasource.Add( new Account( "P" ) { ID = random.Next( 100 ) } );
            datasource.Add( new Account( "S" ) { ID = random.Next( 100 ) } );
            lookUpEdit1.Properties.DataSource = datasource;
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "ID";
        }

        public class Account
        {
            public Account( string name )
            {
                Name = name;
            }
            private int _ID;
            private string _Name;
            public string Name
            {
                get { return _Name; }
                set
                {
                    _Name = value;
                }
            }
            public int ID
            {
                get { return _ID; }
                set
                {
                    _ID = value;
                }
            }
        }
    }
}
