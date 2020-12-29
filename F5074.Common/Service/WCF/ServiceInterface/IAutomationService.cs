using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Service.WCF.ServiceInterface {
    [ServiceContract]
    public interface IAutomationService {

        [OperationContract]
        IList<Hashtable> SelectSiteList(Dictionary<string, object> parameters);
    }
}
