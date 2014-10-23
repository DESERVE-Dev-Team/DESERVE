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
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
