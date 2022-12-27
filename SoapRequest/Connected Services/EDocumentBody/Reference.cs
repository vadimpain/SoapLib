﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDocumentBody
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://inform.gazprom.ru/I/IUSPT2_SED/eDocumentBody", ConfigurationName="ServiceReference2.eDocumentBodyOut")]
    public interface eDocumentBodyOut
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://sap.com/xi/WebService/soap1.1")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task ExportAsyncAsync(EDocumentBody.ExportAsync request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://inform.gazprom.ru/C/IUSPT2/eDocumentBody")]
    public partial class eDocumentBody
    {
        
        private string idField;
        
        private string gUIDField;
        
        private string formatField;
        
        private string regnumField;
        
        private string zPARTNERField;
        
        private string zPAYRCPField;
        
        private string zCNTRSUMField;
        
        private string zRELEVANT_NKField;
        
        private string bodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Regnum
        {
            get
            {
                return this.regnumField;
            }
            set
            {
                this.regnumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ZPARTNER
        {
            get
            {
                return this.zPARTNERField;
            }
            set
            {
                this.zPARTNERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string ZPAYRCP
        {
            get
            {
                return this.zPAYRCPField;
            }
            set
            {
                this.zPAYRCPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string ZCNTRSUM
        {
            get
            {
                return this.zCNTRSUMField;
            }
            set
            {
                this.zCNTRSUMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string ZRELEVANT_NK
        {
            get
            {
                return this.zRELEVANT_NKField;
            }
            set
            {
                this.zRELEVANT_NKField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportAsync
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://inform.gazprom.ru/C/IUSPT2/eDocumentBody", Order=0)]
        public EDocumentBody.eDocumentBody eDocumentBody;
        
        public ExportAsync()
        {
        }
        
        public ExportAsync(EDocumentBody.eDocumentBody eDocumentBody)
        {
            this.eDocumentBody = eDocumentBody;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface eDocumentBodyOutChannel : EDocumentBody.eDocumentBodyOut, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class eDocumentBodyOutClient : System.ServiceModel.ClientBase<EDocumentBody.eDocumentBodyOut>, EDocumentBody.eDocumentBodyOut
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public eDocumentBodyOutClient(EndpointConfiguration endpointConfiguration) : 
                base(eDocumentBodyOutClient.GetBindingForEndpoint(endpointConfiguration), eDocumentBodyOutClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public eDocumentBodyOutClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(eDocumentBodyOutClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public eDocumentBodyOutClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(eDocumentBodyOutClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public eDocumentBodyOutClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task EDocumentBody.eDocumentBodyOut.ExportAsyncAsync(EDocumentBody.ExportAsync request)
        {
            return base.Channel.ExportAsyncAsync(request);
        }
        
        public System.Threading.Tasks.Task ExportAsyncAsync(EDocumentBody.eDocumentBody eDocumentBody)
        {
            EDocumentBody.ExportAsync inValue = new EDocumentBody.ExportAsync();
            inValue.eDocumentBody = eDocumentBody;
            return ((EDocumentBody.eDocumentBodyOut)(this)).ExportAsyncAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HTTP_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.HTTPS_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HTTP_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://dx1-db.codm.gazprom.loc:50000/XISOAPAdapter/MessageServlet?senderParty=&se" +
                        "nderService=GTCH_DIRECTUM_D&receiverParty=&receiverService=&interface=eDocumentB" +
                        "odyOut&interfaceNamespace=http%3A%2F%2Finform.gazprom.ru%2FI%2FIUSPT2_SED%2FeDoc" +
                        "umentBody");
            }
            if ((endpointConfiguration == EndpointConfiguration.HTTPS_Port))
            {
                return new System.ServiceModel.EndpointAddress("https://dx1-db.codm.gazprom.loc:50001/XISOAPAdapter/MessageServlet?senderParty=&s" +
                        "enderService=GTCH_DIRECTUM_D&receiverParty=&receiverService=&interface=eDocument" +
                        "BodyOut&interfaceNamespace=http%3A%2F%2Finform.gazprom.ru%2FI%2FIUSPT2_SED%2FeDo" +
                        "cumentBody");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            HTTP_Port,
            
            HTTPS_Port,
        }
    }
}
