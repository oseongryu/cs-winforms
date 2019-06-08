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
        private static ISqlMapper mapper = DBConnection.EntityMapper;
        public static IList<DashboardDTO> SelectList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("Dashboard.SelectList", vo);
        }

        // 부서 
        public static IList<DashboardDTO> SelectDepartmentList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("Dashboard.SelectDepartmentList", vo);
        }

        // 부서의 장비리스트
        public static IList<DashboardDTO> SelectEquipmentList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("Dashboard.SelectEquipmentList", vo);
        }
        // 장비의 프로세스
        public static IList<DashboardDTO> SelectProcessOfEquipmentList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("Dashboard.SelectProcessOfEquipmentList", vo);
        }
        // 장비의 오더리스트
        public static IList<DashboardDTO> SelectOrderOfEquipmentList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("Dashboard.SelectOrderOfEquipmentList", vo);
        }
        
        // 다른 장비에 있는 동일 아이템 찾기
        public static IList<DashboardDTO> SelectEquipmentComparenceList(DashboardDTO vo)
        {
            return mapper.QueryForList<DashboardDTO>("Dashboard.SelectEquipmentComparenceList", vo);
        }


    }
}
