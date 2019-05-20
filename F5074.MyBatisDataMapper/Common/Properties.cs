using IBatisNet.DataMapper;
using IBatisNet.DataMapper.SessionStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.MyBatisDataMapper.Common
{
    public class Properties
    {
        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    ISqlMapper mapper = Mapper.Instance();
                    mapper.SessionStore = new HybridWebThreadSessionStore(mapper.Id);
                    mapper.DataSource.ConnectionString = "User Id=hr;Password=hr;Data Source=(DESCRIPTION=(ADDRESS_LIST= (ADDRESS=(PROTOCOL=TCP) (HOST=127.0.0.1) (PORT=1521))) (CONNECT_DATA = (SERVICE_NAME = XE)))";
                    return mapper;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
