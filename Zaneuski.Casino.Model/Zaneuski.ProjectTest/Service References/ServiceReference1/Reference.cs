﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zaneuski.ProjectTest.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITournamentService")]
    public interface ITournamentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Get", ReplyAction="http://tempuri.org/ITournamentService/GetResponse")]
        Zaneuski.Casino.WcfServiceLibrary.TournamentType Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Get", ReplyAction="http://tempuri.org/ITournamentService/GetResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.TournamentType> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/GetAll", ReplyAction="http://tempuri.org/ITournamentService/GetAllResponse")]
        Zaneuski.Casino.WcfServiceLibrary.TournamentType[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/GetAll", ReplyAction="http://tempuri.org/ITournamentService/GetAllResponse")]
        System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.TournamentType[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Update", ReplyAction="http://tempuri.org/ITournamentService/UpdateResponse")]
        void Update(Zaneuski.Casino.WcfServiceLibrary.TournamentType gameType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Update", ReplyAction="http://tempuri.org/ITournamentService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.TournamentType gameType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Delete", ReplyAction="http://tempuri.org/ITournamentService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Delete", ReplyAction="http://tempuri.org/ITournamentService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Add", ReplyAction="http://tempuri.org/ITournamentService/AddResponse")]
        void Add(Zaneuski.Casino.WcfServiceLibrary.TournamentType country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITournamentService/Add", ReplyAction="http://tempuri.org/ITournamentService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.TournamentType country);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITournamentServiceChannel : Zaneuski.ProjectTest.ServiceReference1.ITournamentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TournamentServiceClient : System.ServiceModel.ClientBase<Zaneuski.ProjectTest.ServiceReference1.ITournamentService>, Zaneuski.ProjectTest.ServiceReference1.ITournamentService {
        
        public TournamentServiceClient() {
        }
        
        public TournamentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TournamentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TournamentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TournamentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.TournamentType Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.TournamentType> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public Zaneuski.Casino.WcfServiceLibrary.TournamentType[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Zaneuski.Casino.WcfServiceLibrary.TournamentType[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(Zaneuski.Casino.WcfServiceLibrary.TournamentType gameType) {
            base.Channel.Update(gameType);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(Zaneuski.Casino.WcfServiceLibrary.TournamentType gameType) {
            return base.Channel.UpdateAsync(gameType);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Add(Zaneuski.Casino.WcfServiceLibrary.TournamentType country) {
            base.Channel.Add(country);
        }
        
        public System.Threading.Tasks.Task AddAsync(Zaneuski.Casino.WcfServiceLibrary.TournamentType country) {
            return base.Channel.AddAsync(country);
        }
    }
}
