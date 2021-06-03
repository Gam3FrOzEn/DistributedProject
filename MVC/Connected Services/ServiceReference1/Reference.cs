﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        MVC.ServiceReference1.CompositeType GetDataUsingDataContract(MVC.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<MVC.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(MVC.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHotDogs", ReplyAction="http://tempuri.org/IService1/GetHotDogsResponse")]
        ApplicationService.DTOs.HotDogDTO[] GetHotDogs(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHotDogs", ReplyAction="http://tempuri.org/IService1/GetHotDogsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.HotDogDTO[]> GetHotDogsAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostHotDog", ReplyAction="http://tempuri.org/IService1/PostHotDogResponse")]
        string PostHotDog(ApplicationService.DTOs.HotDogDTO hotDogDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostHotDog", ReplyAction="http://tempuri.org/IService1/PostHotDogResponse")]
        System.Threading.Tasks.Task<string> PostHotDogAsync(ApplicationService.DTOs.HotDogDTO hotDogDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutHotDog", ReplyAction="http://tempuri.org/IService1/PutHotDogResponse")]
        string PutHotDog(ApplicationService.DTOs.HotDogDTO HotDogDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutHotDog", ReplyAction="http://tempuri.org/IService1/PutHotDogResponse")]
        System.Threading.Tasks.Task<string> PutHotDogAsync(ApplicationService.DTOs.HotDogDTO HotDogDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHotDogByID", ReplyAction="http://tempuri.org/IService1/GetHotDogByIDResponse")]
        ApplicationService.DTOs.HotDogDTO GetHotDogByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetHotDogByID", ReplyAction="http://tempuri.org/IService1/GetHotDogByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.HotDogDTO> GetHotDogByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteHotDog", ReplyAction="http://tempuri.org/IService1/DeleteHotDogResponse")]
        string DeleteHotDog(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteHotDog", ReplyAction="http://tempuri.org/IService1/DeleteHotDogResponse")]
        System.Threading.Tasks.Task<string> DeleteHotDogAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClients", ReplyAction="http://tempuri.org/IService1/GetClientsResponse")]
        ApplicationService.DTOs.ClientDTO[] GetClients(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClients", ReplyAction="http://tempuri.org/IService1/GetClientsResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.ClientDTO[]> GetClientsAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientByID", ReplyAction="http://tempuri.org/IService1/GetClientByIDResponse")]
        ApplicationService.DTOs.ClientDTO GetClientByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientByID", ReplyAction="http://tempuri.org/IService1/GetClientByIDResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.ClientDTO> GetClientByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostClient", ReplyAction="http://tempuri.org/IService1/PostClientResponse")]
        string PostClient(ApplicationService.DTOs.ClientDTO clientDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostClient", ReplyAction="http://tempuri.org/IService1/PostClientResponse")]
        System.Threading.Tasks.Task<string> PostClientAsync(ApplicationService.DTOs.ClientDTO clientDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutClient", ReplyAction="http://tempuri.org/IService1/PutClientResponse")]
        string PutClient(ApplicationService.DTOs.ClientDTO clientDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutClient", ReplyAction="http://tempuri.org/IService1/PutClientResponse")]
        System.Threading.Tasks.Task<string> PutClientAsync(ApplicationService.DTOs.ClientDTO clientDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        string DeleteClient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        System.Threading.Tasks.Task<string> DeleteClientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSales", ReplyAction="http://tempuri.org/IService1/GetSalesResponse")]
        ApplicationService.DTOs.SaleDTO[] GetSales(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSales", ReplyAction="http://tempuri.org/IService1/GetSalesResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.SaleDTO[]> GetSalesAsync(string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostSale", ReplyAction="http://tempuri.org/IService1/PostSaleResponse")]
        string PostSale(ApplicationService.DTOs.SaleDTO saleDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostSale", ReplyAction="http://tempuri.org/IService1/PostSaleResponse")]
        System.Threading.Tasks.Task<string> PostSaleAsync(ApplicationService.DTOs.SaleDTO saleDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSaleById", ReplyAction="http://tempuri.org/IService1/GetSaleByIdResponse")]
        ApplicationService.DTOs.SaleDTO GetSaleById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSaleById", ReplyAction="http://tempuri.org/IService1/GetSaleByIdResponse")]
        System.Threading.Tasks.Task<ApplicationService.DTOs.SaleDTO> GetSaleByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSale", ReplyAction="http://tempuri.org/IService1/DeleteSaleResponse")]
        string DeleteSale(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSale", ReplyAction="http://tempuri.org/IService1/DeleteSaleResponse")]
        System.Threading.Tasks.Task<string> DeleteSaleAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutSale", ReplyAction="http://tempuri.org/IService1/PutSaleResponse")]
        string PutSale(ApplicationService.DTOs.SaleDTO saleDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PutSale", ReplyAction="http://tempuri.org/IService1/PutSaleResponse")]
        System.Threading.Tasks.Task<string> PutSaleAsync(ApplicationService.DTOs.SaleDTO saleDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVC.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVC.ServiceReference1.IService1>, MVC.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public MVC.ServiceReference1.CompositeType GetDataUsingDataContract(MVC.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<MVC.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(MVC.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ApplicationService.DTOs.HotDogDTO[] GetHotDogs(string filter) {
            return base.Channel.GetHotDogs(filter);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.HotDogDTO[]> GetHotDogsAsync(string filter) {
            return base.Channel.GetHotDogsAsync(filter);
        }
        
        public string PostHotDog(ApplicationService.DTOs.HotDogDTO hotDogDTO) {
            return base.Channel.PostHotDog(hotDogDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostHotDogAsync(ApplicationService.DTOs.HotDogDTO hotDogDTO) {
            return base.Channel.PostHotDogAsync(hotDogDTO);
        }
        
        public string PutHotDog(ApplicationService.DTOs.HotDogDTO HotDogDto) {
            return base.Channel.PutHotDog(HotDogDto);
        }
        
        public System.Threading.Tasks.Task<string> PutHotDogAsync(ApplicationService.DTOs.HotDogDTO HotDogDto) {
            return base.Channel.PutHotDogAsync(HotDogDto);
        }
        
        public ApplicationService.DTOs.HotDogDTO GetHotDogByID(int id) {
            return base.Channel.GetHotDogByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.HotDogDTO> GetHotDogByIDAsync(int id) {
            return base.Channel.GetHotDogByIDAsync(id);
        }
        
        public string DeleteHotDog(int id) {
            return base.Channel.DeleteHotDog(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteHotDogAsync(int id) {
            return base.Channel.DeleteHotDogAsync(id);
        }
        
        public ApplicationService.DTOs.ClientDTO[] GetClients(string filter) {
            return base.Channel.GetClients(filter);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.ClientDTO[]> GetClientsAsync(string filter) {
            return base.Channel.GetClientsAsync(filter);
        }
        
        public ApplicationService.DTOs.ClientDTO GetClientByID(int id) {
            return base.Channel.GetClientByID(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.ClientDTO> GetClientByIDAsync(int id) {
            return base.Channel.GetClientByIDAsync(id);
        }
        
        public string PostClient(ApplicationService.DTOs.ClientDTO clientDto) {
            return base.Channel.PostClient(clientDto);
        }
        
        public System.Threading.Tasks.Task<string> PostClientAsync(ApplicationService.DTOs.ClientDTO clientDto) {
            return base.Channel.PostClientAsync(clientDto);
        }
        
        public string PutClient(ApplicationService.DTOs.ClientDTO clientDTO) {
            return base.Channel.PutClient(clientDTO);
        }
        
        public System.Threading.Tasks.Task<string> PutClientAsync(ApplicationService.DTOs.ClientDTO clientDTO) {
            return base.Channel.PutClientAsync(clientDTO);
        }
        
        public string DeleteClient(int id) {
            return base.Channel.DeleteClient(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteClientAsync(int id) {
            return base.Channel.DeleteClientAsync(id);
        }
        
        public ApplicationService.DTOs.SaleDTO[] GetSales(string filter) {
            return base.Channel.GetSales(filter);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.SaleDTO[]> GetSalesAsync(string filter) {
            return base.Channel.GetSalesAsync(filter);
        }
        
        public string PostSale(ApplicationService.DTOs.SaleDTO saleDto) {
            return base.Channel.PostSale(saleDto);
        }
        
        public System.Threading.Tasks.Task<string> PostSaleAsync(ApplicationService.DTOs.SaleDTO saleDto) {
            return base.Channel.PostSaleAsync(saleDto);
        }
        
        public ApplicationService.DTOs.SaleDTO GetSaleById(int id) {
            return base.Channel.GetSaleById(id);
        }
        
        public System.Threading.Tasks.Task<ApplicationService.DTOs.SaleDTO> GetSaleByIdAsync(int id) {
            return base.Channel.GetSaleByIdAsync(id);
        }
        
        public string DeleteSale(int id) {
            return base.Channel.DeleteSale(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteSaleAsync(int id) {
            return base.Channel.DeleteSaleAsync(id);
        }
        
        public string PutSale(ApplicationService.DTOs.SaleDTO saleDto) {
            return base.Channel.PutSale(saleDto);
        }
        
        public System.Threading.Tasks.Task<string> PutSaleAsync(ApplicationService.DTOs.SaleDTO saleDto) {
            return base.Channel.PutSaleAsync(saleDto);
        }
    }
}
