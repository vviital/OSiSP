﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zaneuski.Casino.WpfApplication.ServiceReference7 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference7.IRoundService")]
    public interface IRoundService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Get", ReplyAction="http://tempuri.org/IRoundService/GetResponse")]
        Zaneuski.Casino.WcfServiceLibrary.RoundType Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Get", ReplyAction="http://tempuri.org/IRoundService/GetResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundType> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/GetAll", ReplyAction="http://tempuri.org/IRoundService/GetAllResponse")]
        Zaneuski.Casino.WcfServiceLibrary.RoundType[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/GetAll", ReplyAction="http://tempuri.org/IRoundService/GetAllResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundType[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Update", ReplyAction="http://tempuri.org/IRoundService/UpdateResponse")]
        void Update(Zaneuski.Casino.WcfServiceLibrary.RoundType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Update", ReplyAction="http://tempuri.org/IRoundService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.RoundType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Delete", ReplyAction="http://tempuri.org/IRoundService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Delete", ReplyAction="http://tempuri.org/IRoundService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Add", ReplyAction="http://tempuri.org/IRoundService/AddResponse")]
        void Add(Zaneuski.Casino.WcfServiceLibrary.RoundType country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundService/Add", ReplyAction="http://tempuri.org/IRoundService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.RoundType country);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoundServiceChannel : Zaneuski.Casino.WpfApplication.ServiceReference7.IRoundService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoundServiceClient : System.ServiceModel.ClientBase<Zaneuski.Casino.WpfApplication.ServiceReference7.IRoundService>, Zaneuski.Casino.WpfApplication.ServiceReference7.IRoundService {
        
        public RoundServiceClient() {
        }
        
        public RoundServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoundServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoundServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoundServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.RoundType Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundType> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.RoundType[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundType[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(Zaneuski.Casino.WcfServiceLibrary.RoundType countryType) {
            base.Channel.Update(countryType);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.RoundType countryType) {
            return base.Channel.UpdateAsync(countryType);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Add(Zaneuski.Casino.WcfServiceLibrary.RoundType country) {
            base.Channel.Add(country);
        }
        
        public System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.RoundType country) {
            return base.Channel.AddAsync(country);
        }
    }
}
