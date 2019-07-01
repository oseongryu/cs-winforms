using F5074.MyBatisDataMapper.Common;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Service.Automation
{
    public class AutomationDAO
    {
        private static ISqlMapper mapper = AutomationConnection.EntityMapper;
        private static AutomationDTO resultDTO = new AutomationDTO();
        public static IList<AutomationDTO> SelectSiteList(AutomationDTO _dto)
        {
            return mapper.QueryForList<AutomationDTO>("Automation.SelectSiteList", _dto);
        }

        public static AutomationDTO CreateTable1(AutomationDTO _dto)
        {
            try
            {
                int str = mapper.Update("Automation.CreateTable1", (object)"Testss");
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }


        public static AutomationDTO InsertSite(AutomationDTO _dto)
        {
            try
            {
                mapper.Insert("InsertSite", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }
        public static AutomationDTO InsertSite(List<AutomationDTO> _dtoList)
        {
            try
            {
                mapper.BeginTransaction();

                for (int x = 0; x < _dtoList.Count; x++)
                {
                    mapper.Insert("InsertSite", _dtoList[x]);

                }
                mapper.CommitTransaction();
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
                mapper.RollBackTransaction();
            }
            return resultDTO;
        }

        public static AutomationDTO UpdateSite(AutomationDTO _dto)
        {
            try
            {
                mapper.Update("UpdateSite", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }

        public static AutomationDTO DeleteSite(AutomationDTO _dto)
        {
            try
            {
                mapper.Delete("DeleteSite", _dto);
                resultDTO.isSuccess = true;
            }
            catch (Exception exception)
            {
                resultDTO.Message = exception.Message;
                resultDTO.isSuccess = false;
            }
            return resultDTO;
        }
    }
}
