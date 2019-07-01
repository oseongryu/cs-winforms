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

                    // https://stackoverflow.com/questions/18641883/a-database-with-the-same-name-exists-or-specified-file-cannot-be-opened-or-it
                    // C# mssql attached db https://stackoverflow.com/questions/39264707/attach-sql-server-database-in-c-sharp
                    // https://andwiz.tistory.com/entry/MyBatisnet%EC%97%90%EC%84%9C-%EC%BF%BC%EB%A6%AC-%EB%A7%B5%ED%95%91-%ED%8C%8C%EC%9D%BC%EB%93%A4%EC%9D%98-%EB%B6%84%EB%A6%AC
                    // http://www.sqler.com/401700
                    mapper.SessionStore = new HybridWebThreadSessionStore(mapper.Id);
                    //mapper.DataSource.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Integrated Security=true ;AttachDbFileName=C:\Users\f5074\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\mssqllocaldb\AutomationDB.mdf;";
                    //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                    //mapper.DataSource.ConnectionString = string.Format(@"Server=(localdb)\MSSQLLocalDB; Integrated Security=true ;AttachDbFileName={0};", Path.GetFullPath(Path.Combine(projectDirectory, @"..\\Lib\\AutomationDB.mdf")));
                    mapper.DataSource.ConnectionString = string.Format(@"Server=(localdb)\MSSQLLocalDB; Integrated Security=true ;AttachDbFileName={0};", AppDomain.CurrentDomain.BaseDirectory + "Lib\\AutomationDB.mdf");




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
