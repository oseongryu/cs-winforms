using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Extension {
    public static class EnumExtension {

        /// <summary>
        /// ToCaption
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static string ToCaption(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            CaptionAttribute[] attr = fi.GetCustomAttributes(typeof(CaptionAttribute), false) as CaptionAttribute[];
            return attr.Length > 0 ? attr[0].CaptionValue : null;
        }

        /// <summary>
        /// ToWidth
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static int ToWidth(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            WidthAttribute[] attr = fi.GetCustomAttributes(typeof(WidthAttribute), false) as WidthAttribute[];
            return attr.Length > 0 ? attr[0].WidthValue : 0;
        }

        /// <summary>
        /// ToArea
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static DevExpress.XtraPivotGrid.PivotArea ToArea(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            AreaAttribute[] attr = fi.GetCustomAttributes(typeof(AreaAttribute), false) as AreaAttribute[];
            return attr.Length > 0 ? attr[0].AreaValue : DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
        }

        /// <summary>
        /// ToSummary
        /// </summary>
        /// <param name="_enum"></param>
        /// <returns></returns>
        public static DevExpress.Data.PivotGrid.PivotSummaryType ToSummary(this Enum _enum)
        {
            Type t = _enum.GetType();
            FieldInfo fi = t.GetField(_enum.ToString());
            SummaryAttribute[] attr = fi.GetCustomAttributes(typeof(SummaryAttribute), false) as SummaryAttribute[];
            return attr.Length > 0 ? attr[0].SummaryValue : DevExpress.Data.PivotGrid.PivotSummaryType.Sum;
        }
    }

    /// <summary>
    /// CaptionAttribute
    /// </summary>
    public class CaptionAttribute : Attribute {
        public string CaptionValue { get; protected set; }

        public CaptionAttribute(string value)
        {
            this.CaptionValue = value;
        }
    }

    /// <summary>
    /// WidthAttribute
    /// </summary>
    public class WidthAttribute : Attribute {
        public int WidthValue { get; protected set; }

        public WidthAttribute(int value)
        {
            this.WidthValue = value;
        }
    }

    /// <summary>
    /// AreaAttribute
    /// </summary>
    public class AreaAttribute : Attribute {
        public DevExpress.XtraPivotGrid.PivotArea AreaValue { get; protected set; }

        public AreaAttribute(DevExpress.XtraPivotGrid.PivotArea value)
        {
            this.AreaValue = value;
        }
    }

    /// <summary>
    /// SummaryAttribute
    /// </summary>
    public class SummaryAttribute : Attribute {
        public DevExpress.Data.PivotGrid.PivotSummaryType SummaryValue { get; protected set; }

        public SummaryAttribute(DevExpress.Data.PivotGrid.PivotSummaryType value)
        {
            this.SummaryValue = value;
        }
    }
}
