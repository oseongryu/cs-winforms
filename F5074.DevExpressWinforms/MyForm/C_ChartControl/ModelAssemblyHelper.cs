using System.IO;
using System.Reflection;

namespace F5074.DevExpressWinforms.MyForm.C_ChartControl
{
    public static class ModelAssemblyHelper {
        static Assembly modelAssembly = null;
        public static Assembly ModelAssembly {
            get {
                if(modelAssembly == null)
                    modelAssembly = typeof(ModelAssemblyHelper).Assembly;
                return modelAssembly;
            }
        }
        static string[] resourceNames = null;
        public static string GetResourcePath(string resourceName) {
            if(resourceNames == null)
                resourceNames = ModelAssembly.GetManifestResourceNames();
            foreach(string name in resourceNames)
                if(name.EndsWith(resourceName))
                    return name;
            return null;
        }
        public static Stream GetResourceStream(string resourceName) {
            return ModelAssembly.GetManifestResourceStream(GetResourcePath(resourceName));
        }
    }
}
