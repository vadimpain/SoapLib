﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDocumentTender
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://inform.gazprom.ru/I/IUSPT2_SED/eDocumentTender", ConfigurationName="ServiceReference3.eDocumentTenderOut")]
    public interface eDocumentTenderOut
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://sap.com/xi/WebService/soap1.1")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task ExportAsyncAsync(EDocumentTender.ExportAsync request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://inform.gazprom.ru/C/IUSPT2/eDocumentTender")]
    public partial class eDocumentTender
    {
        
        private string gUIDField;
        
        private string kIND_PURCHField;
        
        private string nUM_PREDLOGField;
        
        private string dOC_BASE_CODEField;
        
        private string dOCUMENT_BASEField;
        
        private string dOCNUMBASE_PURCHField;
        
        private string dOCDATBASE_PURCHField;
        
        private string tYPE_PURCHField;
        
        private string kIND_TENDERField;
        
        private string sOURCE_FINField;
        
        private string oWN_FIPOSField;
        
        private string mETHOD_PURCHField;
        
        private string sMSP_ISKL_ZAKField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string KIND_PURCH
        {
            get
            {
                return this.kIND_PURCHField;
            }
            set
            {
                this.kIND_PURCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string NUM_PREDLOG
        {
            get
            {
                return this.nUM_PREDLOGField;
            }
            set
            {
                this.nUM_PREDLOGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string DOC_BASE_CODE
        {
            get
            {
                return this.dOC_BASE_CODEField;
            }
            set
            {
                this.dOC_BASE_CODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string DOCUMENT_BASE
        {
            get
            {
                return this.dOCUMENT_BASEField;
            }
            set
            {
                this.dOCUMENT_BASEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string DOCNUMBASE_PURCH
        {
            get
            {
                return this.dOCNUMBASE_PURCHField;
            }
            set
            {
                this.dOCNUMBASE_PURCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string DOCDATBASE_PURCH
        {
            get
            {
                return this.dOCDATBASE_PURCHField;
            }
            set
            {
                this.dOCDATBASE_PURCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string TYPE_PURCH
        {
            get
            {
                return this.tYPE_PURCHField;
            }
            set
            {
                this.tYPE_PURCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string KIND_TENDER
        {
            get
            {
                return this.kIND_TENDERField;
            }
            set
            {
                this.kIND_TENDERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string SOURCE_FIN
        {
            get
            {
                return this.sOURCE_FINField;
            }
            set
            {
                this.sOURCE_FINField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string OWN_FIPOS
        {
            get
            {
                return this.oWN_FIPOSField;
            }
            set
            {
                this.oWN_FIPOSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string METHOD_PURCH
        {
            get
            {
                return this.mETHOD_PURCHField;
            }
            set
            {
                this.mETHOD_PURCHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string SMSP_ISKL_ZAK
        {
            get
            {
                return this.sMSP_ISKL_ZAKField;
            }
            set
            {
                this.sMSP_ISKL_ZAKField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExportAsync
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://inform.gazprom.ru/C/IUSPT2/eDocumentTender", Order=0)]
        public EDocumentTender.eDocumentTender eDocumentTender;
        
        public ExportAsync()
        {
        }
        
        public ExportAsync(EDocumentTender.eDocumentTender eDocumentTender)
        {
            this.eDocumentTender = eDocumentTender;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface eDocumentTenderOutChannel : EDocumentTender.eDocumentTenderOut, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class eDocumentTenderOutClient : System.ServiceModel.ClientBase<EDocumentTender.eDocumentTenderOut>, EDocumentTender.eDocumentTenderOut
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public eDocumentTenderOutClient(EndpointConfiguration endpointConfiguration) : 
                base(eDocumentTenderOutClient.GetBindingForEndpoint(endpointConfiguration), eDocumentTenderOutClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public eDocumentTenderOutClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(eDocumentTenderOutClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public eDocumentTenderOutClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(eDocumentTenderOutClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public eDocumentTenderOutClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task EDocumentTender.eDocumentTenderOut.ExportAsyncAsync(EDocumentTender.ExportAsync request)
        {
            return base.Channel.ExportAsyncAsync(request);
        }
        
        public System.Threading.Tasks.Task ExportAsyncAsync(EDocumentTender.eDocumentTender eDocumentTender)
        {
            EDocumentTender.ExportAsync inValue = new EDocumentTender.ExportAsync();
            inValue.eDocumentTender = eDocumentTender;
            return ((EDocumentTender.eDocumentTenderOut)(this)).ExportAsyncAsync(inValue);
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
                        "nderService=GTCH_DIRECTUM_D&receiverParty=&receiverService=&interface=eDocumentT" +
                        "enderOut&interfaceNamespace=http%3A%2F%2Finform.gazprom.ru%2FI%2FIUSPT2_SED%2FeD" +
                        "ocumentTender");
            }
            if ((endpointConfiguration == EndpointConfiguration.HTTPS_Port))
            {
                return new System.ServiceModel.EndpointAddress("https://dx1-db.codm.gazprom.loc:50001/XISOAPAdapter/MessageServlet?senderParty=&s" +
                        "enderService=GTCH_DIRECTUM_D&receiverParty=&receiverService=&interface=eDocument" +
                        "TenderOut&interfaceNamespace=http%3A%2F%2Finform.gazprom.ru%2FI%2FIUSPT2_SED%2Fe" +
                        "DocumentTender");
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
