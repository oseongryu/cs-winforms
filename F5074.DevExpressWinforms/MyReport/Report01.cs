using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Drawing.Text;

namespace F5074.DevExpressWinforms.MyReport
{
    public partial class Report01 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report01()
        {
            InitializeComponent();
            customFontStyle.Font = new Font(FontCollection.Families[0], 20F, FontStyle.Regular, GraphicsUnit.Point);
            xrLabel1.Font = new Font(FontCollection.Families[0], 20F, FontStyle.Regular, GraphicsUnit.Point);
        }

        static PrivateFontCollection fontCollection;
        public static FontCollection FontCollection
        {
            get
            {
                if (fontCollection == null)
                {
                    fontCollection = new PrivateFontCollection();
                    fontCollection.AddFontFile("free3of9.ttf");
                }
                return fontCollection;
            }
        }

    }
}
