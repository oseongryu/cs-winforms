using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Extension {
    public static class DateEditExtension {

        /// <summary>
        /// DateEdit의 포맷 yyyy-MM-dd
        /// </summary>
        /// <param name="dateEdit"></param>
        public static void InitDisplayFormatDate(this DateEdit dateEdit, DateTime dateTime)
        {
            dateEdit.EditValue = dateTime;
            dateEdit.Properties.Mask.EditMask = "yyyy-MM-dd";
            dateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
        }

        /// <summary>
        /// DateEdit의 포맷 HH:mm:ss 
        /// </summary>
        /// <param name="dateEdit"></param>
        public static void InitDisplayFormatTime(this DateEdit dateEdit, DateTime dateTime)
        {
            dateEdit.EditValue = dateTime;
            dateEdit.Properties.Mask.EditMask = "HH:mm:ss";
            dateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            dateEdit.Properties.CalendarView = CalendarView.TouchUI;
        }

        /// <summary>
        /// DateEdit의 포맷 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="dateEdit"></param>
        public static void InitDisplayFormatDateTime(this DateEdit dateEdit, DateTime dateTime)
        {
            dateEdit.EditValue = dateTime;
            dateEdit.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            dateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
