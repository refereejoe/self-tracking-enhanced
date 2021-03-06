﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnhancedClient.OrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ExtendedPropertiesDictionary", Namespace="http://schemas.datacontract.org/2004/07/EnhancedEntities", ItemName="ExtendedProperties", KeyName="Name", ValueName="ExtendedProperty")]
    [System.SerializableAttribute()]
    public class ExtendedPropertiesDictionary : System.Collections.Generic.Dictionary<string, object> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ObjectsAddedToCollectionProperties", Namespace="http://schemas.datacontract.org/2004/07/EnhancedEntities", ItemName="AddedObjectsForProperty", KeyName="CollectionPropertyName", ValueName="AddedObjects")]
    [System.SerializableAttribute()]
    public class ObjectsAddedToCollectionProperties : System.Collections.Generic.Dictionary<string, EnhancedClient.OrderService.ObjectList> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ObjectList", Namespace="http://schemas.datacontract.org/2004/07/EnhancedEntities", ItemName="ObjectValue")]
    [System.SerializableAttribute()]
    public class ObjectList : System.Collections.Generic.List<object> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ObjectsRemovedFromCollectionProperties", Namespace="http://schemas.datacontract.org/2004/07/EnhancedEntities", ItemName="DeletedObjectsForProperty", KeyName="CollectionPropertyName", ValueName="DeletedObjects")]
    [System.SerializableAttribute()]
    public class ObjectsRemovedFromCollectionProperties : System.Collections.Generic.Dictionary<string, EnhancedClient.OrderService.ObjectList> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="OriginalValuesDictionary", Namespace="http://schemas.datacontract.org/2004/07/EnhancedEntities", ItemName="OriginalValues", KeyName="Name", ValueName="OriginalValue")]
    [System.SerializableAttribute()]
    public class OriginalValuesDictionary : System.Collections.Generic.Dictionary<string, object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderService.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrders", ReplyAction="http://tempuri.org/IOrderService/GetOrdersResponse")]
        System.Collections.Generic.List<EnhancedEntities.OrderHeader> GetOrders();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IOrderService/GetOrders", ReplyAction="http://tempuri.org/IOrderService/GetOrdersResponse")]
        System.IAsyncResult BeginGetOrders(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<EnhancedEntities.OrderHeader> EndGetOrders(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/SaveOrder", ReplyAction="http://tempuri.org/IOrderService/SaveOrderResponse")]
        EnhancedEntities.OrderHeader SaveOrder(EnhancedEntities.OrderHeader order);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IOrderService/SaveOrder", ReplyAction="http://tempuri.org/IOrderService/SaveOrderResponse")]
        System.IAsyncResult BeginSaveOrder(EnhancedEntities.OrderHeader order, System.AsyncCallback callback, object asyncState);
        
        EnhancedEntities.OrderHeader EndSaveOrder(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : EnhancedClient.OrderService.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetOrdersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetOrdersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<EnhancedEntities.OrderHeader> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<EnhancedEntities.OrderHeader>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SaveOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SaveOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public EnhancedEntities.OrderHeader Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((EnhancedEntities.OrderHeader)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<EnhancedClient.OrderService.IOrderService>, EnhancedClient.OrderService.IOrderService {
        
        private BeginOperationDelegate onBeginGetOrdersDelegate;
        
        private EndOperationDelegate onEndGetOrdersDelegate;
        
        private System.Threading.SendOrPostCallback onGetOrdersCompletedDelegate;
        
        private BeginOperationDelegate onBeginSaveOrderDelegate;
        
        private EndOperationDelegate onEndSaveOrderDelegate;
        
        private System.Threading.SendOrPostCallback onSaveOrderCompletedDelegate;
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetOrdersCompletedEventArgs> GetOrdersCompleted;
        
        public event System.EventHandler<SaveOrderCompletedEventArgs> SaveOrderCompleted;
        
        public System.Collections.Generic.List<EnhancedEntities.OrderHeader> GetOrders() {
            return base.Channel.GetOrders();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetOrders(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetOrders(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<EnhancedEntities.OrderHeader> EndGetOrders(System.IAsyncResult result) {
            return base.Channel.EndGetOrders(result);
        }
        
        private System.IAsyncResult OnBeginGetOrders(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetOrders(callback, asyncState);
        }
        
        private object[] OnEndGetOrders(System.IAsyncResult result) {
            System.Collections.Generic.List<EnhancedEntities.OrderHeader> retVal = this.EndGetOrders(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetOrdersCompleted(object state) {
            if ((this.GetOrdersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetOrdersCompleted(this, new GetOrdersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetOrdersAsync() {
            this.GetOrdersAsync(null);
        }
        
        public void GetOrdersAsync(object userState) {
            if ((this.onBeginGetOrdersDelegate == null)) {
                this.onBeginGetOrdersDelegate = new BeginOperationDelegate(this.OnBeginGetOrders);
            }
            if ((this.onEndGetOrdersDelegate == null)) {
                this.onEndGetOrdersDelegate = new EndOperationDelegate(this.OnEndGetOrders);
            }
            if ((this.onGetOrdersCompletedDelegate == null)) {
                this.onGetOrdersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetOrdersCompleted);
            }
            base.InvokeAsync(this.onBeginGetOrdersDelegate, null, this.onEndGetOrdersDelegate, this.onGetOrdersCompletedDelegate, userState);
        }
        
        public EnhancedEntities.OrderHeader SaveOrder(EnhancedEntities.OrderHeader order) {
            return base.Channel.SaveOrder(order);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSaveOrder(EnhancedEntities.OrderHeader order, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSaveOrder(order, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public EnhancedEntities.OrderHeader EndSaveOrder(System.IAsyncResult result) {
            return base.Channel.EndSaveOrder(result);
        }
        
        private System.IAsyncResult OnBeginSaveOrder(object[] inValues, System.AsyncCallback callback, object asyncState) {
            EnhancedEntities.OrderHeader order = ((EnhancedEntities.OrderHeader)(inValues[0]));
            return this.BeginSaveOrder(order, callback, asyncState);
        }
        
        private object[] OnEndSaveOrder(System.IAsyncResult result) {
            EnhancedEntities.OrderHeader retVal = this.EndSaveOrder(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSaveOrderCompleted(object state) {
            if ((this.SaveOrderCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SaveOrderCompleted(this, new SaveOrderCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SaveOrderAsync(EnhancedEntities.OrderHeader order) {
            this.SaveOrderAsync(order, null);
        }
        
        public void SaveOrderAsync(EnhancedEntities.OrderHeader order, object userState) {
            if ((this.onBeginSaveOrderDelegate == null)) {
                this.onBeginSaveOrderDelegate = new BeginOperationDelegate(this.OnBeginSaveOrder);
            }
            if ((this.onEndSaveOrderDelegate == null)) {
                this.onEndSaveOrderDelegate = new EndOperationDelegate(this.OnEndSaveOrder);
            }
            if ((this.onSaveOrderCompletedDelegate == null)) {
                this.onSaveOrderCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSaveOrderCompleted);
            }
            base.InvokeAsync(this.onBeginSaveOrderDelegate, new object[] {
                        order}, this.onEndSaveOrderDelegate, this.onSaveOrderCompletedDelegate, userState);
        }
    }
}
