﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetSqlAzMan.NetSqlAzManWCFCacheService {
    using System.Runtime.Serialization;
    using System;


    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemType", Namespace="http://NetSqlAzMan/ServiceModel")]
    public enum ItemType : int {

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Role = 0,

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Task = 1,

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Operation = 2,
    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizationType", Namespace="http://NetSqlAzMan/ServiceModel")]
    public enum AuthorizationType : byte {

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Neutral = 0,

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Allow = 1,

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deny = 2,

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AllowWithDelegation = 3,
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizedItem", Namespace="http://schemas.datacontract.org/2004/07/NetSqlAzMan.Cache")]
    [System.SerializableAttribute()]
    public partial class AuthorizedItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.KeyValuePair<string, string>[] AttributesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType AuthorizationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NetSqlAzMan.NetSqlAzManWCFCacheService.ItemType TypeField;

        /// <summary>
        /// Gets or sets the structure that contains extra data.
        /// </summary>
        /// <value></value>
        /// <returns>An <see cref="T:System.Runtime.Serialization.ExtensionDataObject"/> that contains data that is not recognized as belonging to the data contract.</returns>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.KeyValuePair<string, string>[] Attributes {
            get {
                return this.AttributesField;
            }
            set {
                if ((object.ReferenceEquals(this.AttributesField, value) != true)) {
                    this.AttributesField = value;
                    this.RaisePropertyChanged("Attributes");
                }
            }
        }

        /// <summary>
        /// Gets or sets the authorization.
        /// </summary>
        /// <value>The authorization.</value>
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType Authorization {
            get {
                return this.AuthorizationField;
            }
            set {
                if ((this.AuthorizationField.Equals(value) != true)) {
                    this.AuthorizationField = value;
                    this.RaisePropertyChanged("Authorization");
                }
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NetSqlAzMan.NetSqlAzManWCFCacheService.ItemType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NetSqlAzManWCFCacheService.ICacheService")]
    public interface ICacheService {

        /// <summary>
        /// Checks the access for windows users with attributes retrieve.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="userSSid">The user S sid.</param>
        /// <param name="groupsSSid">The groups S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/CheckAccessForWindowsUsersWithAttributesRetrieve" +
            "", ReplyAction="http://tempuri.org/ICacheService/CheckAccessForWindowsUsersWithAttributesRetrieve" +
            "Response")]
        NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForWindowsUsersWithAttributesRetrieve(out System.Collections.Generic.KeyValuePair<string, string>[] attributes, string storeName, string applicationName, string itemName, string userSSid, string[] groupsSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters);

        /// <summary>
        /// Checks the access for windows users without attributes retrieve.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="userSSid">The user S sid.</param>
        /// <param name="groupsSSid">The groups S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/CheckAccessForWindowsUsersWithoutAttributesRetri" +
            "eve", ReplyAction="http://tempuri.org/ICacheService/CheckAccessForWindowsUsersWithoutAttributesRetri" +
            "eveResponse")]
        NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForWindowsUsersWithoutAttributesRetrieve(string storeName, string applicationName, string itemName, string userSSid, string[] groupsSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters);

        /// <summary>
        /// Checks the access for database users with attributes retrieve.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="DBuserSSid">The D buser S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/CheckAccessForDatabaseUsersWithAttributesRetriev" +
            "e", ReplyAction="http://tempuri.org/ICacheService/CheckAccessForDatabaseUsersWithAttributesRetriev" +
            "eResponse")]
        NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForDatabaseUsersWithAttributesRetrieve(out System.Collections.Generic.KeyValuePair<string, string>[] attributes, string storeName, string applicationName, string itemName, string DBuserSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters);

        /// <summary>
        /// Checks the access for database users without attributes retrieve.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="DBuserSSid">The D buser S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/CheckAccessForDatabaseUsersWithoutAttributesRetr" +
            "ieve", ReplyAction="http://tempuri.org/ICacheService/CheckAccessForDatabaseUsersWithoutAttributesRetr" +
            "ieveResponse")]
        NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForDatabaseUsersWithoutAttributesRetrieve(string storeName, string applicationName, string itemName, string DBuserSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters);

        /// <summary>
        /// Invalidates the cache.
        /// </summary>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/InvalidateCache", ReplyAction="http://tempuri.org/ICacheService/InvalidateCacheResponse")]
        void InvalidateCache();

        /// <summary>
        /// Invalidates the cache on service partners.
        /// </summary>
        /// <param name="invalidateCacheOnServicePartners1">if set to <c>true</c> [invalidate cache on service partners1].</param>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/InvalidateCacheOnServicePartners", ReplyAction="http://tempuri.org/ICacheService/InvalidateCacheOnServicePartnersResponse")]
        void InvalidateCacheOnServicePartners([System.ServiceModel.MessageParameterAttribute(Name="invalidateCacheOnServicePartners")] bool invalidateCacheOnServicePartners1);

        /// <summary>
        /// Gets the item names.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/GetItemNames", ReplyAction="http://tempuri.org/ICacheService/GetItemNamesResponse")]
        string[] GetItemNames(string storeName, string applicationName, NetSqlAzMan.NetSqlAzManWCFCacheService.ItemType type);

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/GetAllItems", ReplyAction="http://tempuri.org/ICacheService/GetAllItemsResponse")]
        System.Collections.Generic.KeyValuePair<string, NetSqlAzMan.NetSqlAzManWCFCacheService.ItemType>[] GetAllItems(string storeName, string applicationName);

        /// <summary>
        /// Gets the authorized items for database users.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="DBuserSSid">The D buser S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/GetAuthorizedItemsForDatabaseUsers", ReplyAction="http://tempuri.org/ICacheService/GetAuthorizedItemsForDatabaseUsersResponse")]
        NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizedItem[] GetAuthorizedItemsForDatabaseUsers(string storeName, string applicationName, string DBuserSSid, System.DateTime validFor, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters);

        /// <summary>
        /// Gets the authorized items for windows users.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="userSSid">The user S sid.</param>
        /// <param name="groupsSSid">The groups S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICacheService/GetAuthorizedItemsForWindowsUsers", ReplyAction="http://tempuri.org/ICacheService/GetAuthorizedItemsForWindowsUsersResponse")]
        NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizedItem[] GetAuthorizedItemsForWindowsUsers(string storeName, string applicationName, string userSSid, string[] groupsSSid, System.DateTime validFor, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters);
    }

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICacheServiceChannel : NetSqlAzMan.NetSqlAzManWCFCacheService.ICacheService, System.ServiceModel.IClientChannel {
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CacheServiceClient : System.ServiceModel.ClientBase<NetSqlAzMan.NetSqlAzManWCFCacheService.ICacheService>, NetSqlAzMan.NetSqlAzManWCFCacheService.ICacheService {

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheServiceClient"/> class.
        /// </summary>
        public CacheServiceClient() {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheServiceClient"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        public CacheServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheServiceClient"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public CacheServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheServiceClient"/> class.
        /// </summary>
        /// <param name="endpointConfigurationName">Name of the endpoint configuration.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public CacheServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheServiceClient"/> class.
        /// </summary>
        /// <param name="binding">The binding.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public CacheServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        /// <summary>
        /// Checks the access for windows users with attributes retrieve.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="userSSid">The user S sid.</param>
        /// <param name="groupsSSid">The groups S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForWindowsUsersWithAttributesRetrieve(out System.Collections.Generic.KeyValuePair<string, string>[] attributes, string storeName, string applicationName, string itemName, string userSSid, string[] groupsSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters) {
            return base.Channel.CheckAccessForWindowsUsersWithAttributesRetrieve(out attributes, storeName, applicationName, itemName, userSSid, groupsSSid, validFor, operationsOnly, contextParameters);
        }

        /// <summary>
        /// Checks the access for windows users without attributes retrieve.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="userSSid">The user S sid.</param>
        /// <param name="groupsSSid">The groups S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForWindowsUsersWithoutAttributesRetrieve(string storeName, string applicationName, string itemName, string userSSid, string[] groupsSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters) {
            return base.Channel.CheckAccessForWindowsUsersWithoutAttributesRetrieve(storeName, applicationName, itemName, userSSid, groupsSSid, validFor, operationsOnly, contextParameters);
        }

        /// <summary>
        /// Checks the access for database users with attributes retrieve.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="DBuserSSid">The D buser S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForDatabaseUsersWithAttributesRetrieve(out System.Collections.Generic.KeyValuePair<string, string>[] attributes, string storeName, string applicationName, string itemName, string DBuserSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters) {
            return base.Channel.CheckAccessForDatabaseUsersWithAttributesRetrieve(out attributes, storeName, applicationName, itemName, DBuserSSid, validFor, operationsOnly, contextParameters);
        }

        /// <summary>
        /// Checks the access for database users without attributes retrieve.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="DBuserSSid">The D buser S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="operationsOnly">if set to <c>true</c> [operations only].</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizationType CheckAccessForDatabaseUsersWithoutAttributesRetrieve(string storeName, string applicationName, string itemName, string DBuserSSid, System.DateTime validFor, bool operationsOnly, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters) {
            return base.Channel.CheckAccessForDatabaseUsersWithoutAttributesRetrieve(storeName, applicationName, itemName, DBuserSSid, validFor, operationsOnly, contextParameters);
        }

        /// <summary>
        /// Invalidates the cache.
        /// </summary>
        public void InvalidateCache() {
            base.Channel.InvalidateCache();
        }

        /// <summary>
        /// Invalidates the cache on service partners.
        /// </summary>
        /// <param name="invalidateCacheOnServicePartners1">if set to <c>true</c> [invalidate cache on service partners1].</param>
        public void InvalidateCacheOnServicePartners(bool invalidateCacheOnServicePartners1) {
            base.Channel.InvalidateCacheOnServicePartners(invalidateCacheOnServicePartners1);
        }

        /// <summary>
        /// Gets the item names.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public string[] GetItemNames(string storeName, string applicationName, NetSqlAzMan.NetSqlAzManWCFCacheService.ItemType type) {
            return base.Channel.GetItemNames(storeName, applicationName, type);
        }

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <returns></returns>
        public System.Collections.Generic.KeyValuePair<string, NetSqlAzMan.NetSqlAzManWCFCacheService.ItemType>[] GetAllItems(string storeName, string applicationName) {
            return base.Channel.GetAllItems(storeName, applicationName);
        }

        /// <summary>
        /// Gets the authorized items for database users.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="DBuserSSid">The D buser S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizedItem[] GetAuthorizedItemsForDatabaseUsers(string storeName, string applicationName, string DBuserSSid, System.DateTime validFor, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters) {
            return base.Channel.GetAuthorizedItemsForDatabaseUsers(storeName, applicationName, DBuserSSid, validFor, contextParameters);
        }

        /// <summary>
        /// Gets the authorized items for windows users.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="userSSid">The user S sid.</param>
        /// <param name="groupsSSid">The groups S sid.</param>
        /// <param name="validFor">The valid for.</param>
        /// <param name="contextParameters">The context parameters.</param>
        /// <returns></returns>
        public NetSqlAzMan.NetSqlAzManWCFCacheService.AuthorizedItem[] GetAuthorizedItemsForWindowsUsers(string storeName, string applicationName, string userSSid, string[] groupsSSid, System.DateTime validFor, System.Collections.Generic.KeyValuePair<string, object>[] contextParameters) {
            return base.Channel.GetAuthorizedItemsForWindowsUsers(storeName, applicationName, userSSid, groupsSSid, validFor, contextParameters);
        }
    }
}