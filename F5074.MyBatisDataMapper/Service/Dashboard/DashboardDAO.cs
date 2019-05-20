using F5074.MyBatisDataMapper.Common;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Service.Dashboard
{
    public class DashboardDAO
    {
        private static ISqlMapper mapper = Properties.EntityMapper;
        public static IList<DashboardVo> SelectList(DashboardVo vo)
        {
            return mapper.QueryForList<DashboardVo>("SelectList", vo);
        }
    }
}
