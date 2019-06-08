using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper.SessionStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace F5074.MyBatisDataMapper.Common
{
    public class AutomationConnection
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
                    XmlDocument sqlMapConfig = Resources.GetEmbeddedResourceAsXmlDocument("Config.AutomationSqlMap.config, F5074.MyBatisDataMapper");
                    ISqlMapper mapper = dom.Configure(sqlMapConfig);


                    mapper.SessionStore = new HybridWebThreadSessionStore(mapper.Id);
                    mapper.DataSource.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Integrated Security=true ;AttachDbFileName=C:\Users\itcomm\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\AutomationDB.mdf;";

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
