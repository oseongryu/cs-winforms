using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Winforms.MyResources
{
    class MyReadTextFile
    {
        // http://www.csharp-examples.net/read-text-file/
        //https://rocabilly.tistory.com/114
        private void ReadTextFile()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            path = System.IO.Path.GetDirectoryName(path);
            Console.WriteLine(path);

            foreach (string line in File.ReadLines(path + "/MyResources/MyTextFile.txt", Encoding.UTF8))
            {
                Console.WriteLine(line);
            }
        }
    }
}
