﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DESERVE.Manager.Marshall {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommandLineArgs", Namespace="http://schemas.datacontract.org/2004/07/DESERVE")]
    [System.SerializableAttribute()]
    public partial class CommandLineArgs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AutosaveMinutesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DebugField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullStringField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogDirectoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ModAPIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PluginsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool UpdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UpdateNewPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UpdateOldPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WCFField;
        
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
        public int AutosaveMinutes {
            get {
                return this.AutosaveMinutesField;
            }
            set {
                if ((this.AutosaveMinutesField.Equals(value) != true)) {
                    this.AutosaveMinutesField = value;
                    this.RaisePropertyChanged("AutosaveMinutes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Debug {
            get {
                return this.DebugField;
            }
            set {
                if ((this.DebugField.Equals(value) != true)) {
                    this.DebugField = value;
                    this.RaisePropertyChanged("Debug");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullString {
            get {
                return this.FullStringField;
            }
            set {
                if ((object.ReferenceEquals(this.FullStringField, value) != true)) {
                    this.FullStringField = value;
                    this.RaisePropertyChanged("FullString");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Instance {
            get {
                return this.InstanceField;
            }
            set {
                if ((object.ReferenceEquals(this.InstanceField, value) != true)) {
                    this.InstanceField = value;
                    this.RaisePropertyChanged("Instance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogDirectory {
            get {
                return this.LogDirectoryField;
            }
            set {
                if ((object.ReferenceEquals(this.LogDirectoryField, value) != true)) {
                    this.LogDirectoryField = value;
                    this.RaisePropertyChanged("LogDirectory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ModAPI {
            get {
                return this.ModAPIField;
            }
            set {
                if ((this.ModAPIField.Equals(value) != true)) {
                    this.ModAPIField = value;
                    this.RaisePropertyChanged("ModAPI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Plugins {
            get {
                return this.PluginsField;
            }
            set {
                if ((this.PluginsField.Equals(value) != true)) {
                    this.PluginsField = value;
                    this.RaisePropertyChanged("Plugins");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Update {
            get {
                return this.UpdateField;
            }
            set {
                if ((this.UpdateField.Equals(value) != true)) {
                    this.UpdateField = value;
                    this.RaisePropertyChanged("Update");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UpdateNewPath {
            get {
                return this.UpdateNewPathField;
            }
            set {
                if ((object.ReferenceEquals(this.UpdateNewPathField, value) != true)) {
                    this.UpdateNewPathField = value;
                    this.RaisePropertyChanged("UpdateNewPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UpdateOldPath {
            get {
                return this.UpdateOldPathField;
            }
            set {
                if ((object.ReferenceEquals(this.UpdateOldPathField, value) != true)) {
                    this.UpdateOldPathField = value;
                    this.RaisePropertyChanged("UpdateOldPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WCF {
            get {
                return this.WCFField;
            }
            set {
                if ((this.WCFField.Equals(value) != true)) {
                    this.WCFField = value;
                    this.RaisePropertyChanged("WCF");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Marshall.IServerMarshall")]
    public interface IServerMarshall {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerMarshall/get_Name", ReplyAction="http://tempuri.org/IServerMarshall/get_NameResponse")]
        string get_Name();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerMarshall/get_IsRunning", ReplyAction="http://tempuri.org/IServerMarshall/get_IsRunningResponse")]
        bool get_IsRunning();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerMarshall/get_Arguments", ReplyAction="http://tempuri.org/IServerMarshall/get_ArgumentsResponse")]
        DESERVE.Manager.Marshall.CommandLineArgs get_Arguments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerMarshall/Stop", ReplyAction="http://tempuri.org/IServerMarshall/StopResponse")]
        void Stop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerMarshall/Save", ReplyAction="http://tempuri.org/IServerMarshall/SaveResponse")]
        void Save();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerMarshallChannel : DESERVE.Manager.Marshall.IServerMarshall, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerMarshallClient : System.ServiceModel.ClientBase<DESERVE.Manager.Marshall.IServerMarshall>, DESERVE.Manager.Marshall.IServerMarshall {
        
        public ServerMarshallClient() {
        }
        
        public ServerMarshallClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerMarshallClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerMarshallClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerMarshallClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string get_Name() {
            return base.Channel.get_Name();
        }
        
        public bool get_IsRunning() {
            return base.Channel.get_IsRunning();
        }
        
        public DESERVE.Manager.Marshall.CommandLineArgs get_Arguments() {
            return base.Channel.get_Arguments();
        }
        
        public void Stop() {
            base.Channel.Stop();
        }
        
        public void Save() {
            base.Channel.Save();
        }
    }
}
