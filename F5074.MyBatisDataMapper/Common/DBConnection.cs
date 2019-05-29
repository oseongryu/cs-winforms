using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper.SessionStore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace F5074.MyBatisDataMapper.Common
{
    public class DBConnection
    {
        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    // 1. root에 SqlMap.config일 경우
                    //ISqlMapper mapper = Mapper.Instance();

                    // 2. Config의 위치 변경일 경우
                    // https://guyaga.tistory.com/415
                    // https://guyaga.tistory.com/423
                    DomSqlMapBuilder dom = new DomSqlMapBuilder();
                    XmlDocument sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("Config.SqlMap.config, F5074.MyBatisDataMapper");
                    ISqlMapper mapper = dom.Configure(sqlMapConfig);


                    mapper.SessionStore = new HybridWebThreadSessionStore(mapper.Id);
                    mapper.DataSource.ConnectionString = "User Id=hr;Password=hr;Data Source=(DESCRIPTION=(ADDRESS_LIST= (ADDRESS=(PROTOCOL=TCP) (HOST=127.0.0.1) (PORT=1521))) (CONNECT_DATA = (SERVICE_NAME = XE)))";

                    foreach (string line in File.ReadLines("C:\\DEV\\server.txt", Encoding.UTF8))
                    {
                        mapper.DataSource.ConnectionString = line;
                    }


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
