﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientGudang.ServiceReference4 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRegister", Namespace="http://schemas.datacontract.org/2004/07/ServiceGudang")]
    [System.SerializableAttribute()]
    public partial class DataRegister : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kategoriField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string kategori {
            get {
                return this.kategoriField;
            }
            set {
                if ((object.ReferenceEquals(this.kategoriField, value) != true)) {
                    this.kategoriField = value;
                    this.RaisePropertyChanged("kategori");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CekLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceGudang")]
    [System.SerializableAttribute()]
    public partial class CekLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaGudangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
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
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaGudang {
            get {
                return this.NamaGudangField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaGudangField, value) != true)) {
                    this.NamaGudangField = value;
                    this.RaisePropertyChanged("NamaGudang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceGudang")]
    [System.SerializableAttribute()]
    public partial class DetailLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlamatLengkapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaLokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StokField;
        
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
        public string AlamatLengkap {
            get {
                return this.AlamatLengkapField;
            }
            set {
                if ((object.ReferenceEquals(this.AlamatLengkapField, value) != true)) {
                    this.AlamatLengkapField = value;
                    this.RaisePropertyChanged("AlamatLengkap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDLokasi {
            get {
                return this.IDLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDLokasiField, value) != true)) {
                    this.IDLokasiField = value;
                    this.RaisePropertyChanged("IDLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaLokasi {
            get {
                return this.NamaLokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaLokasiField, value) != true)) {
                    this.NamaLokasiField = value;
                    this.RaisePropertyChanged("NamaLokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stok {
            get {
                return this.StokField;
            }
            set {
                if ((this.StokField.Equals(value) != true)) {
                    this.StokField = value;
                    this.RaisePropertyChanged("Stok");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataBarang", Namespace="http://schemas.datacontract.org/2004/07/ServiceGudang")]
    [System.SerializableAttribute()]
    public partial class DataBarang : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDBarangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JumlahBarangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaBrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UkuranField;
        
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
        public string IDBarang {
            get {
                return this.IDBarangField;
            }
            set {
                if ((object.ReferenceEquals(this.IDBarangField, value) != true)) {
                    this.IDBarangField = value;
                    this.RaisePropertyChanged("IDBarang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JumlahBarang {
            get {
                return this.JumlahBarangField;
            }
            set {
                if ((this.JumlahBarangField.Equals(value) != true)) {
                    this.JumlahBarangField = value;
                    this.RaisePropertyChanged("JumlahBarang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lokasi {
            get {
                return this.LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.LokasiField, value) != true)) {
                    this.LokasiField = value;
                    this.RaisePropertyChanged("Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaBrand {
            get {
                return this.NamaBrandField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaBrandField, value) != true)) {
                    this.NamaBrandField = value;
                    this.RaisePropertyChanged("NamaBrand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ukuran {
            get {
                return this.UkuranField;
            }
            set {
                if ((object.ReferenceEquals(this.UkuranField, value) != true)) {
                    this.UkuranField = value;
                    this.RaisePropertyChanged("Ukuran");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference4.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/databarang", ReplyAction="http://tempuri.org/IService1/databarangResponse")]
        string databarang(string IDBarang, string NamaBrand, string Ukuran, int JumlahBarang, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/databarang", ReplyAction="http://tempuri.org/IService1/databarangResponse")]
        System.Threading.Tasks.Task<string> databarangAsync(string IDBarang, string NamaBrand, string Ukuran, int JumlahBarang, string IDLokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editDataBarang", ReplyAction="http://tempuri.org/IService1/editDataBarangResponse")]
        string editDataBarang(string IDBarang, string NamaBrand, string Ukuran);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editDataBarang", ReplyAction="http://tempuri.org/IService1/editDataBarangResponse")]
        System.Threading.Tasks.Task<string> editDataBarangAsync(string IDBarang, string NamaBrand, string Ukuran);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteDataBarang", ReplyAction="http://tempuri.org/IService1/deleteDataBarangResponse")]
        string deleteDataBarang(string IDBarang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteDataBarang", ReplyAction="http://tempuri.org/IService1/deleteDataBarangResponse")]
        System.Threading.Tasks.Task<string> deleteDataBarangAsync(string IDBarang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        string Register(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        string UpdateRegister(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        string DeleteRegister(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        ClientGudang.ServiceReference4.DataRegister[] DataRegist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DataRegister[]> DataRegistAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ClientGudang.ServiceReference4.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ClientGudang.ServiceReference4.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ClientGudang.ServiceReference4.DetailLokasi[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DetailLokasi[]> DetailLokasiAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (DataBarang) of message DataBarangRequest does not match the default value (DataBarang1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataBarang", ReplyAction="http://tempuri.org/IService1/DataBarangResponse")]
        ClientGudang.ServiceReference4.DataBarangResponse DataBarang1(ClientGudang.ServiceReference4.DataBarangRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataBarang", ReplyAction="http://tempuri.org/IService1/DataBarangResponse")]
        System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DataBarangResponse> DataBarang1Async(ClientGudang.ServiceReference4.DataBarangRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DataBarang", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DataBarangRequest {
        
        public DataBarangRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DataBarangResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DataBarangResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientGudang.ServiceReference4.DataBarang[] DataBarangResult;
        
        public DataBarangResponse() {
        }
        
        public DataBarangResponse(ClientGudang.ServiceReference4.DataBarang[] DataBarangResult) {
            this.DataBarangResult = DataBarangResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientGudang.ServiceReference4.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientGudang.ServiceReference4.IService1>, ClientGudang.ServiceReference4.IService1 {
        
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
        
        public string databarang(string IDBarang, string NamaBrand, string Ukuran, int JumlahBarang, string IDLokasi) {
            return base.Channel.databarang(IDBarang, NamaBrand, Ukuran, JumlahBarang, IDLokasi);
        }
        
        public System.Threading.Tasks.Task<string> databarangAsync(string IDBarang, string NamaBrand, string Ukuran, int JumlahBarang, string IDLokasi) {
            return base.Channel.databarangAsync(IDBarang, NamaBrand, Ukuran, JumlahBarang, IDLokasi);
        }
        
        public string editDataBarang(string IDBarang, string NamaBrand, string Ukuran) {
            return base.Channel.editDataBarang(IDBarang, NamaBrand, Ukuran);
        }
        
        public System.Threading.Tasks.Task<string> editDataBarangAsync(string IDBarang, string NamaBrand, string Ukuran) {
            return base.Channel.editDataBarangAsync(IDBarang, NamaBrand, Ukuran);
        }
        
        public string deleteDataBarang(string IDBarang) {
            return base.Channel.deleteDataBarang(IDBarang);
        }
        
        public System.Threading.Tasks.Task<string> deleteDataBarangAsync(string IDBarang) {
            return base.Channel.deleteDataBarangAsync(IDBarang);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public string Register(string username, string password, string kategori) {
            return base.Channel.Register(username, password, kategori);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori) {
            return base.Channel.RegisterAsync(username, password, kategori);
        }
        
        public string UpdateRegister(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegister(username, password, kategori, id);
        }
        
        public System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegisterAsync(username, password, kategori, id);
        }
        
        public string DeleteRegister(string username) {
            return base.Channel.DeleteRegister(username);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username) {
            return base.Channel.DeleteRegisterAsync(username);
        }
        
        public ClientGudang.ServiceReference4.DataRegister[] DataRegist() {
            return base.Channel.DataRegist();
        }
        
        public System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DataRegister[]> DataRegistAsync() {
            return base.Channel.DataRegistAsync();
        }
        
        public ClientGudang.ServiceReference4.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientGudang.ServiceReference4.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ClientGudang.ServiceReference4.DetailLokasi[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DetailLokasi[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientGudang.ServiceReference4.DataBarangResponse ClientGudang.ServiceReference4.IService1.DataBarang1(ClientGudang.ServiceReference4.DataBarangRequest request) {
            return base.Channel.DataBarang1(request);
        }
        
        public ClientGudang.ServiceReference4.DataBarang[] DataBarang1() {
            ClientGudang.ServiceReference4.DataBarangRequest inValue = new ClientGudang.ServiceReference4.DataBarangRequest();
            ClientGudang.ServiceReference4.DataBarangResponse retVal = ((ClientGudang.ServiceReference4.IService1)(this)).DataBarang1(inValue);
            return retVal.DataBarangResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DataBarangResponse> ClientGudang.ServiceReference4.IService1.DataBarang1Async(ClientGudang.ServiceReference4.DataBarangRequest request) {
            return base.Channel.DataBarang1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientGudang.ServiceReference4.DataBarangResponse> DataBarang1Async() {
            ClientGudang.ServiceReference4.DataBarangRequest inValue = new ClientGudang.ServiceReference4.DataBarangRequest();
            return ((ClientGudang.ServiceReference4.IService1)(this)).DataBarang1Async(inValue);
        }
    }
}
