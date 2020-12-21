using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace F5074.DevExpressWinforms.MyCommon
{
    public class MyDirectory01
    {
        public void FileCheck()
        {

            if (System.IO.Directory.Exists(@"C:\\DEV\\Repos\\cs_winforms\\F5074.DevExpressWinforms\\MyForm\\A_GridControl"))
            {
                string a = "";
                foreach (string s in System.IO.Directory.GetFiles(@"C:\\DEV\Repos\\cs_winforms\F5074.DevExpressWinforms\\MyForm\\A_GridControl"))
                {
                    a += s + "\r\n";
                }
            }
        }
        public List<MenuVo> SearchAssembly()
        {
            // https://dotnetcademy.net/Learn/4/Pages/3
            // http://www.hoons.net/Board/qacshap/Content/59151
            List<MenuVo> result = new List<MenuVo>();


            Assembly assembly = Assembly.LoadFrom(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\F5074.WInforms.dll");
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                if (typeInfo.BaseType != null)
                {
                    if (typeInfo.FullName.Contains("F5074.Winforms") && typeInfo.BaseType.Name == "UserControl")
                    {
                        result.Add(new MenuVo() { Name = type.Name, FullName = type.FullName });
                        //Console.WriteLine("Type " + type.FullName + " has " + typeInfo.DeclaredProperties.Count().ToString() + " properties");
                    }
                }

            }
            assembly = Assembly.LoadFrom(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\F5074.DevExpressWInforms.dll");
            types = assembly.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                if (typeInfo.BaseType != null)
                {
                    if (typeInfo.FullName.Contains("F5074.DevExpressWinforms") && typeInfo.BaseType.Name == "UserControl")
                    {
                        result.Add(new MenuVo() { Name = type.Name, FullName = type.FullName });
                        //Console.WriteLine("Type " + type.FullName + " has " + typeInfo.DeclaredProperties.Count().ToString() + " properties");
                    }
                }

            }

            assembly = Assembly.LoadFrom(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\F5074.MVVM.dll");
            types = assembly.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                if (typeInfo.BaseType != null)
                {
                    if (typeInfo.FullName.Contains("F5074.MVVM") && typeInfo.BaseType.Name == "UserControl")
                    {
                        result.Add(new MenuVo() { Name = type.Name, FullName = type.FullName });
                    }
                }
            }
            return result;
        }


        public List<MenuVo> SearchFile()
        {
            //Directory : GetFiles(대상폴더, 검색패턴, SearchOption), GetDirectories(대상폴더, 검색패턴, SearchOption)
            //DirectoryInfo : GetFiles(검색패턴, SearchOption), GetDirectories(검색패턴, SearchOption)
            //SearchOption : AllDirectories : 모든 서브디렉토리 검색, TopDirectoryOnly : 지정한 폴더만 검색


            string[] files = Directory.GetFiles("C:\\DEV\\Repos\\cs_winforms\\F5074.Winforms\\MyForm", "*.cs", SearchOption.AllDirectories);
            List<MenuVo> result = new List<MenuVo>();
            foreach (string s in files)
            {
                if (!s.Contains("Designer"))
                {
                    result.Add(new MenuVo() { MenuFullPath = s, MenuName = Path.GetFileNameWithoutExtension(s), ClassName = Path.GetDirectoryName(s).Split(Path.DirectorySeparatorChar).Last(), AssemblyName = "F5074.Winforms" });
                }
            }

            files = Directory.GetFiles("C:\\DEV\\repos\\cs_winforms\\F5074.DevExpressWinforms\\MyForm", "*.cs", SearchOption.AllDirectories);
            foreach (string s in files)
            {
                if (!s.Contains("Designer"))
                {
                    result.Add(new MenuVo() { MenuFullPath = s, MenuName = Path.GetFileNameWithoutExtension(s), ClassName = Path.GetDirectoryName(s).Split(Path.DirectorySeparatorChar).Last(), AssemblyName = "F5074.DevExpressWinforms" });
                }
            }
            return result;
        }

        public List<string> SearchSHPFiles(string sDir = "C:\\DEV\\repos\\cs_winforms\\F5074.DevExpressWinforms\\MyForm")
        {
            // http://www.gisdeveloper.co.kr/?p=2073
            List<String> result = new List<String>();
            String filter = "*.cs";

            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, filter))
                    {
                        if (!f.Contains("Designer")) result.Add(f);
                    }

                    SearchSHPFiles(d);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }
        public class MenuVo
        {
            public string MenuFullPath { get; set; }
            public string MenuName { get; set; }
            public string ClassName { get; set; }
            public string AssemblyName { get; set; }
            public string Name { get; set; }
            public string FullName { get; set; }
        }

    }
}
