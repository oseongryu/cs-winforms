using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace F5074.DevExpressWinforms.MyForm.A_GridControl
{
    public partial class MyGridControl19 : UserControl
    {
        public event EventHandler Shown;
        private bool wasShown = false;
        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );
            if ( !wasShown )
            {
                wasShown = true;
                if ( Shown != null )
                {
                    Shown( this, EventArgs.Empty );
                }
            }
        }
        private void MyGridControl19_Shown( object sender, EventArgs e )
        {
            gridView1.RowCountChanged += new EventHandler( OnGridViewRowCountChanged );
            gridView1.ColumnWidthChanged += new ColumnEventHandler( OnGridViewColumnWidthChanged );
            gridView1.DragObjectDrop += new DragObjectDropEventHandler( OnGridViewDragObjectDrop );
            //UpdateGridSize();
        }


        private const int GridMinWidth = 400;
        private const int GridMinHeight = 200;

        public MyGridControl19()
        {
            this.Shown += MyGridControl19_Shown;
            InitializeComponent();

            gridControl1.DataSource = GetData( 15 );
            gridView1.ActiveFilterString = "ID > 15";
        }

        DataTable GetData( int rows )
        {
            DataTable dt = new DataTable();
            dt.Columns.Add( "ID", typeof( int ) );
            dt.Columns.Add( "Info", typeof( string ) );
            for ( int i = 0; i < rows; i++ )
            {
                dt.Rows.Add( i, "Info" + i.ToString() );
            }
            return dt;
        }

        private void UpdateGridSize()
        {
            GridViewInfo viewInfo = (GridViewInfo) gridView1.GetViewInfo();
            FieldInfo fi = typeof( GridView ).GetField( "scrollInfo", BindingFlags.Instance | BindingFlags.NonPublic );
            ScrollInfo scrollInfo = (ScrollInfo) fi.GetValue( gridView1 );
            int width = viewInfo.ViewRects.IndicatorWidth;
            foreach ( GridColumn column in gridView1.VisibleColumns )
            {
                if ( viewInfo.GetColumnLeftCoord( column ) < viewInfo.ViewRects.ColumnPanelWidth )
                    gridView1.LeftCoord = width;
                width += viewInfo.ColumnsInfo[ column ].Bounds.Width;
            }
            if ( scrollInfo.VScrollVisible ) width += scrollInfo.VScrollSize;
            int height = viewInfo.CalcRealViewHeight( new Rectangle( 0, 0, ClientSize.Width, ClientSize.Height ) );
            if ( scrollInfo.HScrollVisible ) height += scrollInfo.HScrollSize;
            width = Math.Max( GridMinWidth, width );
            width = Math.Min( ClientSize.Width - gridControl1.Location.X, width );
            height = Math.Max( GridMinHeight, height );
            height = Math.Min( ClientSize.Height - gridControl1.Location.Y, height );
            gridControl1.Size = new Size( width, height );
            gridView1.LayoutChanged();
        }

        private void OnGridViewRowCountChanged( object sender, EventArgs e )
        {
            UpdateGridSize();
        }

        private void OnGridViewColumnWidthChanged( object sender, ColumnEventArgs e )
        {
            UpdateGridSize();
        }

        private void OnGridViewDragObjectDrop( object sender, DragObjectDropEventArgs e )
        {
            UpdateGridSize();
        }
    }
}
