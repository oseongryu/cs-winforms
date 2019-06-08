using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Service.Common
{
    public class CommonDTO
    {
        public bool isCheckd { get; set; }
        public bool isSuccess { get; set; }
        public string Message { get; set; }
        public string CRE_USR_ID { get; set; }
        public string UPD_USR_ID { get; set; }
        public object CRE_DT { get; set; }
        public object UPD_DT { get; set; }
    }
}
