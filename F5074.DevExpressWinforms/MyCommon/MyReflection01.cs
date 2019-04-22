using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace F5074.DevExpressWinforms.MyCommon
{
    public class MyReflection01
    {
        public object InstanceClass()
        {
            string className = "F5074.DevExpressWinforms.MyForm.D_TileBar.MyTileBar02";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type t = assembly.GetType(className);
            Object obj = Activator.CreateInstance(t);
            return obj;
        }
        public void InstanceTestClass()
        {
            // https://wer3799.tistory.com/91
            Type type = Type.GetType("F5074.DevExpressWinforms.MyCommon.TestClass");

            TestClass instance = Activator.CreateInstance(type) as TestClass;
            Console.WriteLine(type.GetType());
            instance.Print();
        }
    }

    class TestClass
    {
        public void Print()
        {
            Console.WriteLine("?");
        }
    }
}
