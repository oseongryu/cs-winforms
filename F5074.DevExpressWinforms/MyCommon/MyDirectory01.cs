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

        public List<MenuVo> SearchFile()
        {
            //Directory : GetFiles(대상폴더, 검색패턴, SearchOption), GetDirectories(대상폴더, 검색패턴, SearchOption)
            //DirectoryInfo : GetFiles(검색패턴, SearchOption), GetDirectories(검색패턴, SearchOption)
            //SearchOption : AllDirectories : 모든 서브디렉토리 검색, TopDirectoryOnly : 지정한 폴더만 검색
            string[] files = Directory.GetFiles("C:\\DEV\\repos\\cs_winforms\\F5074.DevExpressWinforms\\MyForm", "*.cs", SearchOption.AllDirectories);
            List<MenuVo> result = new List<MenuVo>();
            foreach (string s in files)
            {
                if (!s.Contains("Designer"))
                {
                    result.Add(new MenuVo() { MenuFullPath = s, MenuName = Path.GetFileNameWithoutExtension(s), ClassName = Path.GetDirectoryName(s).Split(Path.DirectorySeparatorChar).Last() });
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
            catch (System.Exception)
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
        }

    }
}
