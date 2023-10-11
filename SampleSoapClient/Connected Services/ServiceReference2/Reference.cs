﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://tempuri.org/")]
    public partial class Employee : object
    {
        
        private int IdField;
        
        private string NameField;
        
        private string DepartmentField;
        
        private System.Nullable<System.DateTime> CreatedDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Department
        {
            get
            {
                return this.DepartmentField;
            }
            set
            {
                this.DepartmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<System.DateTime> CreatedDate
        {
            get
            {
                return this.CreatedDateField;
            }
            set
            {
                this.CreatedDateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IDatabaseManager")]
    public interface IDatabaseManager
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/InsertData", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference2.InsertDataResponse> InsertDataAsync(ServiceReference2.InsertDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertData", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.InsertDataRequestBody Body;
        
        public InsertDataRequest()
        {
        }
        
        public InsertDataRequest(ServiceReference2.InsertDataRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertDataRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference2.Employee data;
        
        public InsertDataRequestBody()
        {
        }
        
        public InsertDataRequestBody(ServiceReference2.Employee data)
        {
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.InsertDataResponseBody Body;
        
        public InsertDataResponse()
        {
        }
        
        public InsertDataResponse(ServiceReference2.InsertDataResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertDataResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertDataResult;
        
        public InsertDataResponseBody()
        {
        }
        
        public InsertDataResponseBody(string InsertDataResult)
        {
            this.InsertDataResult = InsertDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IDatabaseManagerChannel : ServiceReference2.IDatabaseManager, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class DatabaseManagerClient : System.ServiceModel.ClientBase<ServiceReference2.IDatabaseManager>, ServiceReference2.IDatabaseManager
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DatabaseManagerClient() : 
                base(DatabaseManagerClient.GetDefaultBinding(), DatabaseManagerClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DatabaseManagerClient(EndpointConfiguration endpointConfiguration) : 
                base(DatabaseManagerClient.GetBindingForEndpoint(endpointConfiguration), DatabaseManagerClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DatabaseManagerClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DatabaseManagerClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DatabaseManagerClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DatabaseManagerClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DatabaseManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.InsertDataResponse> ServiceReference2.IDatabaseManager.InsertDataAsync(ServiceReference2.InsertDataRequest request)
        {
            return base.Channel.InsertDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.InsertDataResponse> InsertDataAsync(ServiceReference2.Employee data)
        {
            ServiceReference2.InsertDataRequest inValue = new ServiceReference2.InsertDataRequest();
            inValue.Body = new ServiceReference2.InsertDataRequestBody();
            inValue.Body.data = data;
            return ((ServiceReference2.IDatabaseManager)(this)).InsertDataAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7090/DbService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DatabaseManagerClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DatabaseManagerClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IDatabaseManager_soap);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IDatabaseManager_soap,
        }
    }
}
