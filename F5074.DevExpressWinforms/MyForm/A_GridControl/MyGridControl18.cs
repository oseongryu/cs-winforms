using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl18 : UserControl
    {
        public MyGridControl18()
        {
            InitializeComponent();
            this.gridView1.OptionsSelection.MultiSelect = true;
            gridControl1.DataSource = CreateTable( 50 );
            simpleButton1.Click += simpleButton1_Click;
            simpleButton2.Click += simpleButton2_Click;
            simpleButton3.Click += simpleButton3_Click;
            simpleButton4.Click += simpleButton4_Click;
            simpleButton5.Click += simpleButton5_Click;
            simpleButton6.Click += simpleButton6_Click;
            simpleButton7.Click += simpleButton7_Click;
        }
        private void simpleButton1_Click( object sender, EventArgs e )
        {
            gridView1.SelectAll();
        }

        private void simpleButton2_Click( object sender, EventArgs e )
        {
            gridView1.ClearSelection();
        }

        private void simpleButton3_Click( object sender, EventArgs e )
        {
            gridView1.SelectRow( 5 );
        }

        private void simpleButton4_Click( object sender, EventArgs e )
        {
            gridView1.UnselectRow( 5 );
        }

        private void simpleButton5_Click( object sender, EventArgs e )
        {
            gridView1.SelectRange( 0, 5 );
        }

        private void simpleButton6_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < 6; i++ )
            {
                gridView1.UnselectRow( i );
            }
        }

        private void simpleButton7_Click( object sender, EventArgs e )
        {
            gridView1.BeginSelection();
            int[] aList = gridView1.GetSelectedRows();
            gridView1.SelectAll();
            foreach ( int aRowHandle in aList )
                gridView1.UnselectRow( aRowHandle );
            gridView1.EndSelection();
        }

        private DataTable CreateTable( int RowCount )
        {
            Random rnd = new Random();
            DataTable tbl = new DataTable();

            tbl.Columns.Add( "Checked", typeof( string ) );
            tbl.Columns.Add( "Count", typeof( int ) );
            tbl.Columns.Add( "Name", typeof( string ) );
            tbl.Columns.Add( "Age", typeof( int ) );
            tbl.Columns.Add( "Height", typeof( int ) );
            tbl.Columns.Add( "Date", typeof( string ) );

            //tbl.Columns.Add("Checked", typeof(bool));
            for ( int i = 0; i < RowCount; i++ )
                tbl.Rows.Add( new object[] { "False", i, "kim", ( 1000000 + i ), ( 70000 + i ), "20181112 132406000" } );
            tbl.Rows.Add( new object[] { "False", 5, "kim", ( 1000000 ), ( 70000 ), null } );
            tbl.Rows.Add( new object[] { "False", 5, "kim", ( 1000000 ), ( 70000 ), "" } );
            tbl.Rows.Add( new object[] { "False", 5, "kim", ( 1000000 ), ( 70000 ), " " } );

            return tbl;
        }
    }
}
