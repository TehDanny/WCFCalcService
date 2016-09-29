﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFCalcClient.CalcService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IntDivisionResult", Namespace="http://schemas.datacontract.org/2004/07/WCFCalcService")]
    [System.SerializableAttribute()]
    public partial class IntDivisionResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuotientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RemainderField;
        
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
        public int Quotient {
            get {
                return this.QuotientField;
            }
            set {
                if ((this.QuotientField.Equals(value) != true)) {
                    this.QuotientField = value;
                    this.RaisePropertyChanged("Quotient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Remainder {
            get {
                return this.RemainderField;
            }
            set {
                if ((this.RemainderField.Equals(value) != true)) {
                    this.RemainderField = value;
                    this.RaisePropertyChanged("Remainder");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.ICalcService")]
    public interface ICalcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Add", ReplyAction="http://tempuri.org/ICalcService/AddResponse")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Add", ReplyAction="http://tempuri.org/ICalcService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Substract", ReplyAction="http://tempuri.org/ICalcService/SubstractResponse")]
        int Substract(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Substract", ReplyAction="http://tempuri.org/ICalcService/SubstractResponse")]
        System.Threading.Tasks.Task<int> SubstractAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Multiply", ReplyAction="http://tempuri.org/ICalcService/MultiplyResponse")]
        int Multiply(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Multiply", ReplyAction="http://tempuri.org/ICalcService/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Divide", ReplyAction="http://tempuri.org/ICalcService/DivideResponse")]
        WCFCalcClient.CalcService.IntDivisionResult Divide(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Divide", ReplyAction="http://tempuri.org/ICalcService/DivideResponse")]
        System.Threading.Tasks.Task<WCFCalcClient.CalcService.IntDivisionResult> DivideAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcServiceChannel : WCFCalcClient.CalcService.ICalcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceClient : System.ServiceModel.ClientBase<WCFCalcClient.CalcService.ICalcService>, WCFCalcClient.CalcService.ICalcService {
        
        public CalcServiceClient() {
        }
        
        public CalcServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public int Substract(int a, int b) {
            return base.Channel.Substract(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SubstractAsync(int a, int b) {
            return base.Channel.SubstractAsync(a, b);
        }
        
        public int Multiply(int a, int b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public WCFCalcClient.CalcService.IntDivisionResult Divide(int a, int b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<WCFCalcClient.CalcService.IntDivisionResult> DivideAsync(int a, int b) {
            return base.Channel.DivideAsync(a, b);
        }
    }
}
