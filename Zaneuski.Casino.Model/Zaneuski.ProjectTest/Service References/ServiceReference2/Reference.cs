﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zaneuski.ProjectTest.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ICountryService")]
    public interface ICountryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Get", ReplyAction="http://tempuri.org/ICountryService/GetResponse")]
        Zaneuski.Casino.WcfServiceLibrary.CountryType Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Get", ReplyAction="http://tempuri.org/ICountryService/GetResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.CountryType> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/GetAll", ReplyAction="http://tempuri.org/ICountryService/GetAllResponse")]
        Zaneuski.Casino.WcfServiceLibrary.CountryType[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/GetAll", ReplyAction="http://tempuri.org/ICountryService/GetAllResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.CountryType[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Update", ReplyAction="http://tempuri.org/ICountryService/UpdateResponse")]
        void Update(Zaneuski.Casino.WcfServiceLibrary.CountryType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Update", ReplyAction="http://tempuri.org/ICountryService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.CountryType countryType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Delete", ReplyAction="http://tempuri.org/ICountryService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Delete", ReplyAction="http://tempuri.org/ICountryService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Add", ReplyAction="http://tempuri.org/ICountryService/AddResponse")]
        void Add(Zaneuski.Casino.WcfServiceLibrary.CountryType country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountryService/Add", ReplyAction="http://tempuri.org/ICountryService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.CountryType country);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICountryServiceChannel : Zaneuski.ProjectTest.ServiceReference2.ICountryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CountryServiceClient : System.ServiceModel.ClientBase<Zaneuski.ProjectTest.ServiceReference2.ICountryService>, Zaneuski.ProjectTest.ServiceReference2.ICountryService {
        
        public CountryServiceClient() {
        }
        
        public CountryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CountryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CountryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CountryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.CountryType Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.CountryType> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.CountryType[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.CountryType[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(Zaneuski.Casino.WcfServiceLibrary.CountryType countryType) {
            base.Channel.Update(countryType);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.CountryType countryType) {
            return base.Channel.UpdateAsync(countryType);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Add(Zaneuski.Casino.WcfServiceLibrary.CountryType country) {
            base.Channel.Add(country);
        }
        
        public System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.CountryType country) {
            return base.Channel.AddAsync(country);
        }
    }
}
