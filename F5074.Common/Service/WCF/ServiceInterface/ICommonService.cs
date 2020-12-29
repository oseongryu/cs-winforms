using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Service.WCF.ServiceInterface {
    [ServiceContract]
    public interface ICommonService {

        [OperationContract]
        IList<Hashtable> SelectDeptList(Dictionary<string, object> parameters);
    }
}
