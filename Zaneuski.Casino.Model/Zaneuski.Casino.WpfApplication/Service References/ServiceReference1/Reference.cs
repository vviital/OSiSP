﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zaneuski.Casino.WpfApplication.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAdministratorService")]
    public interface IAdministratorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Get", ReplyAction="http://tempuri.org/IAdministratorService/GetResponse")]
        Zaneuski.Casino.WcfServiceLibrary.AdministratorType Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Get", ReplyAction="http://tempuri.org/IAdministratorService/GetResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.AdministratorType> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/GetAll", ReplyAction="http://tempuri.org/IAdministratorService/GetAllResponse")]
        Zaneuski.Casino.WcfServiceLibrary.AdministratorType[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/GetAll", ReplyAction="http://tempuri.org/IAdministratorService/GetAllResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.AdministratorType[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Update", ReplyAction="http://tempuri.org/IAdministratorService/UpdateResponse")]
        void Update(Zaneuski.Casino.WcfServiceLibrary.AdministratorType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Update", ReplyAction="http://tempuri.org/IAdministratorService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.AdministratorType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Delete", ReplyAction="http://tempuri.org/IAdministratorService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Delete", ReplyAction="http://tempuri.org/IAdministratorService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Add", ReplyAction="http://tempuri.org/IAdministratorService/AddResponse")]
        void Add(Zaneuski.Casino.WcfServiceLibrary.AdministratorType country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministratorService/Add", ReplyAction="http://tempuri.org/IAdministratorService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.AdministratorType country);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministratorServiceChannel : Zaneuski.Casino.WpfApplication.ServiceReference1.IAdministratorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministratorServiceClient : System.ServiceModel.ClientBase<Zaneuski.Casino.WpfApplication.ServiceReference1.IAdministratorService>, Zaneuski.Casino.WpfApplication.ServiceReference1.IAdministratorService {
        
        public AdministratorServiceClient() {
        }
        
        public AdministratorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdministratorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministratorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministratorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.AdministratorType Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.AdministratorType> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.AdministratorType[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.AdministratorType[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(Zaneuski.Casino.WcfServiceLibrary.AdministratorType countryType) {
            base.Channel.Update(countryType);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.AdministratorType countryType) {
            return base.Channel.UpdateAsync(countryType);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Add(Zaneuski.Casino.WcfServiceLibrary.AdministratorType country) {
            base.Channel.Add(country);
        }
        
        public System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.AdministratorType country) {
            return base.Channel.AddAsync(country);
        }
    }
}