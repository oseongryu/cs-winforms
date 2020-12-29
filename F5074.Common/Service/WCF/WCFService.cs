using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Service {
    public static class WCFService<T> {


        public static T getChannelFactory(String serviceNm)
        {
            // http://taeyo.net/columns/View.aspx?SEQ=347&PSEQ=23&IDX=5
            Uri uri = new Uri(String.Format("http://localhost:53045/Services/{0}/{0}Service.svc", serviceNm));
            ServiceEndpoint ep = new ServiceEndpoint(
                ContractDescription.GetContract(typeof(T)),
                new BasicHttpBinding(),
                new EndpointAddress(uri));

            ChannelFactory<T> factory = new ChannelFactory<T>(ep);

            return factory.CreateChannel();
        }
    }
}
