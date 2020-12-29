using F5074.Common.Service;
using F5074.Common.Service.WCF.ServiceInterface;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Windows.Forms;

namespace F5074.UI.Form.View {
    public partial class WCF01View : UserControl {
        public WCF01View()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Dictionary<String, Object> parameters = new Dictionary<String, Object>();
            parameters.Add("EQP_ID", "17");
            var result = WCFService<ICommonService>.getChannelFactory("Common").SelectDeptList(parameters);
            parameters.Add("ID", "aaa");
            var result2 = WCFService<IAutomationService>.getChannelFactory("Automation").SelectSiteList(parameters);

        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // http://taeyo.net/columns/View.aspx?SEQ=347&PSEQ=23&IDX=5
                Uri uri = new Uri("http://localhost:53045/Services/Common/CommonService.svc");
                ServiceEndpoint ep = new ServiceEndpoint(
                    ContractDescription.GetContract(typeof(ICommonService)),
                    new BasicHttpBinding(),
                    new EndpointAddress(uri));

                ChannelFactory<ICommonService> factory = new ChannelFactory<ICommonService>(ep);

                ICommonService proxy = factory.CreateChannel();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("EQP_ID", "17");
                //var result = proxy.SelectDeptList(parameters);

                var results = proxy.SelectDeptList(parameters);

                (proxy as IDisposable).Dispose();

                //PDAServiceClient client = new PDAServiceClient();
                //client.SelectDeptList(new PDADTO());
                //DataSet result =  client.SelectDeptList(new System.Collections.Generic.Dictionary<object, object>());
                //// 서비스에서 작업을 호출하려면 'client' 변수를 사용하십시오.
                //IList<PDADTO> result = client.SelectDeptList(new PDADTO());
                //// 항상 클라이언트를 닫으십시오.
                //client.Close();


                //PDAServiceClient client = new PDAServiceClient();

                //Dictionary<string, object> parameters = new Dictionary<string, object>();
                //parameters.Add("EQP_ID", "17");

                //var result = client.SelectDeptList2(parameters);
            }
            catch (Exception ex)
            {

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                // http://taeyo.net/columns/View.aspx?SEQ=347&PSEQ=23&IDX=5
                Uri uri = new Uri("http://localhost:53045/Services/Automation/AutomationService.svc");
                ServiceEndpoint ep = new ServiceEndpoint(
                    ContractDescription.GetContract(typeof(IAutomationService)),
                    new BasicHttpBinding(),
                    new EndpointAddress(uri));

                ChannelFactory<IAutomationService> factory = new ChannelFactory<IAutomationService>(ep);

                IAutomationService proxy = factory.CreateChannel();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("ID", "aaa");
                //var result = proxy.SelectDeptList(parameters);

                var results = proxy.SelectSiteList(parameters);

                (proxy as IDisposable).Dispose();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
