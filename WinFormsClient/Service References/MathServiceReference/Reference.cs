﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsClient.MathServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyNumbers", Namespace="http://schemas.datacontract.org/2004/07/MathServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class MyNumbers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number2Field;
        
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
        public int Number1 {
            get {
                return this.Number1Field;
            }
            set {
                if ((this.Number1Field.Equals(value) != true)) {
                    this.Number1Field = value;
                    this.RaisePropertyChanged("Number1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number2 {
            get {
                return this.Number2Field;
            }
            set {
                if ((this.Number2Field.Equals(value) != true)) {
                    this.Number2Field = value;
                    this.RaisePropertyChanged("Number2");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceReference.IMathService")]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        int Add(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Sutract", ReplyAction="http://tempuri.org/IMathService/SutractResponse")]
        int Sutract(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Sutract", ReplyAction="http://tempuri.org/IMathService/SutractResponse")]
        System.Threading.Tasks.Task<int> SutractAsync(WinFormsClient.MathServiceReference.MyNumbers obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : WinFormsClient.MathServiceReference.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<WinFormsClient.MathServiceReference.IMathService>, WinFormsClient.MathServiceReference.IMathService {
        
        public MathServiceClient() {
        }
        
        public MathServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.Add(obj);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.AddAsync(obj);
        }
        
        public int Sutract(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.Sutract(obj);
        }
        
        public System.Threading.Tasks.Task<int> SutractAsync(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.SutractAsync(obj);
        }
    }
}
