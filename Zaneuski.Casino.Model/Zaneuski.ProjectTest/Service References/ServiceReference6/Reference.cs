﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zaneuski.ProjectTest.ServiceReference6 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference6.IRoundResultService")]
    public interface IRoundResultService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Get", ReplyAction="http://tempuri.org/IRoundResultService/GetResponse")]
        Zaneuski.Casino.WcfServiceLibrary.RoundResultType Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Get", ReplyAction="http://tempuri.org/IRoundResultService/GetResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundResultType> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/GetAll", ReplyAction="http://tempuri.org/IRoundResultService/GetAllResponse")]
        Zaneuski.Casino.WcfServiceLibrary.RoundResultType[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/GetAll", ReplyAction="http://tempuri.org/IRoundResultService/GetAllResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundResultType[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Update", ReplyAction="http://tempuri.org/IRoundResultService/UpdateResponse")]
        void Update(Zaneuski.Casino.WcfServiceLibrary.RoundResultType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Update", ReplyAction="http://tempuri.org/IRoundResultService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.RoundResultType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Delete", ReplyAction="http://tempuri.org/IRoundResultService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Delete", ReplyAction="http://tempuri.org/IRoundResultService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Add", ReplyAction="http://tempuri.org/IRoundResultService/AddResponse")]
        void Add(Zaneuski.Casino.WcfServiceLibrary.RoundResultType country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoundResultService/Add", ReplyAction="http://tempuri.org/IRoundResultService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.RoundResultType country);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoundResultServiceChannel : Zaneuski.ProjectTest.ServiceReference6.IRoundResultService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoundResultServiceClient : System.ServiceModel.ClientBase<Zaneuski.ProjectTest.ServiceReference6.IRoundResultService>, Zaneuski.ProjectTest.ServiceReference6.IRoundResultService {
        
        public RoundResultServiceClient() {
        }
        
        public RoundResultServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoundResultServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoundResultServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoundResultServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.RoundResultType Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundResultType> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.RoundResultType[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.RoundResultType[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(Zaneuski.Casino.WcfServiceLibrary.RoundResultType countryType) {
            base.Channel.Update(countryType);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.RoundResultType countryType) {
            return base.Channel.UpdateAsync(countryType);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Add(Zaneuski.Casino.WcfServiceLibrary.RoundResultType country) {
            base.Channel.Add(country);
        }
        
        public System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.RoundResultType country) {
            return base.Channel.AddAsync(country);
        }
    }
}
