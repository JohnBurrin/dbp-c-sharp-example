﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Accounts.com.despatchbay.api {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AccountServiceBinding", Namespace="urn:despatchbay")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(PaymentMethodType))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(ServiceType))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(SenderAddressType))]
    public partial class AccountService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAccountBalanceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSenderAddressesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetServicesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPaymentMethodsOperationCompleted;
        
        private System.Threading.SendOrPostCallback DisableAutomaticTopupsOperationCompleted;
        
        private System.Threading.SendOrPostCallback EnableAutomaticTopupsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AccountService() {
            this.Url = global::Accounts.Properties.Settings.Default.Accounts_com_despatchbay_api_AccountService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAccountCompletedEventHandler GetAccountCompleted;
        
        /// <remarks/>
        public event GetAccountBalanceCompletedEventHandler GetAccountBalanceCompleted;
        
        /// <remarks/>
        public event GetSenderAddressesCompletedEventHandler GetSenderAddressesCompleted;
        
        /// <remarks/>
        public event GetServicesCompletedEventHandler GetServicesCompleted;
        
        /// <remarks/>
        public event GetPaymentMethodsCompletedEventHandler GetPaymentMethodsCompleted;
        
        /// <remarks/>
        public event DisableAutomaticTopupsCompletedEventHandler DisableAutomaticTopupsCompleted;
        
        /// <remarks/>
        public event EnableAutomaticTopupsCompletedEventHandler EnableAutomaticTopupsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#GetAccount", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public AccountType GetAccount() {
            object[] results = this.Invoke("GetAccount", new object[0]);
            return ((AccountType)(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountAsync() {
            this.GetAccountAsync(null);
        }
        
        /// <remarks/>
        public void GetAccountAsync(object userState) {
            if ((this.GetAccountOperationCompleted == null)) {
                this.GetAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountOperationCompleted);
            }
            this.InvokeAsync("GetAccount", new object[0], this.GetAccountOperationCompleted, userState);
        }
        
        private void OnGetAccountOperationCompleted(object arg) {
            if ((this.GetAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountCompleted(this, new GetAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#GetAccountBalance", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public AccountBalanceType GetAccountBalance() {
            object[] results = this.Invoke("GetAccountBalance", new object[0]);
            return ((AccountBalanceType)(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountBalanceAsync() {
            this.GetAccountBalanceAsync(null);
        }
        
        /// <remarks/>
        public void GetAccountBalanceAsync(object userState) {
            if ((this.GetAccountBalanceOperationCompleted == null)) {
                this.GetAccountBalanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountBalanceOperationCompleted);
            }
            this.InvokeAsync("GetAccountBalance", new object[0], this.GetAccountBalanceOperationCompleted, userState);
        }
        
        private void OnGetAccountBalanceOperationCompleted(object arg) {
            if ((this.GetAccountBalanceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountBalanceCompleted(this, new GetAccountBalanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#GetSenderAddresses", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public SenderAddressType[] GetSenderAddresses() {
            object[] results = this.Invoke("GetSenderAddresses", new object[0]);
            return ((SenderAddressType[])(results[0]));
        }
        
        /// <remarks/>
        public void GetSenderAddressesAsync() {
            this.GetSenderAddressesAsync(null);
        }
        
        /// <remarks/>
        public void GetSenderAddressesAsync(object userState) {
            if ((this.GetSenderAddressesOperationCompleted == null)) {
                this.GetSenderAddressesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSenderAddressesOperationCompleted);
            }
            this.InvokeAsync("GetSenderAddresses", new object[0], this.GetSenderAddressesOperationCompleted, userState);
        }
        
        private void OnGetSenderAddressesOperationCompleted(object arg) {
            if ((this.GetSenderAddressesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSenderAddressesCompleted(this, new GetSenderAddressesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#GetServices", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public ServiceType[] GetServices() {
            object[] results = this.Invoke("GetServices", new object[0]);
            return ((ServiceType[])(results[0]));
        }
        
        /// <remarks/>
        public void GetServicesAsync() {
            this.GetServicesAsync(null);
        }
        
        /// <remarks/>
        public void GetServicesAsync(object userState) {
            if ((this.GetServicesOperationCompleted == null)) {
                this.GetServicesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServicesOperationCompleted);
            }
            this.InvokeAsync("GetServices", new object[0], this.GetServicesOperationCompleted, userState);
        }
        
        private void OnGetServicesOperationCompleted(object arg) {
            if ((this.GetServicesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServicesCompleted(this, new GetServicesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#GetPaymentMethods", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public PaymentMethodType[] GetPaymentMethods() {
            object[] results = this.Invoke("GetPaymentMethods", new object[0]);
            return ((PaymentMethodType[])(results[0]));
        }
        
        /// <remarks/>
        public void GetPaymentMethodsAsync() {
            this.GetPaymentMethodsAsync(null);
        }
        
        /// <remarks/>
        public void GetPaymentMethodsAsync(object userState) {
            if ((this.GetPaymentMethodsOperationCompleted == null)) {
                this.GetPaymentMethodsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPaymentMethodsOperationCompleted);
            }
            this.InvokeAsync("GetPaymentMethods", new object[0], this.GetPaymentMethodsOperationCompleted, userState);
        }
        
        private void OnGetPaymentMethodsOperationCompleted(object arg) {
            if ((this.GetPaymentMethodsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPaymentMethodsCompleted(this, new GetPaymentMethodsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#DisableAutomaticTopups", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public bool DisableAutomaticTopups() {
            object[] results = this.Invoke("DisableAutomaticTopups", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void DisableAutomaticTopupsAsync() {
            this.DisableAutomaticTopupsAsync(null);
        }
        
        /// <remarks/>
        public void DisableAutomaticTopupsAsync(object userState) {
            if ((this.DisableAutomaticTopupsOperationCompleted == null)) {
                this.DisableAutomaticTopupsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDisableAutomaticTopupsOperationCompleted);
            }
            this.InvokeAsync("DisableAutomaticTopups", new object[0], this.DisableAutomaticTopupsOperationCompleted, userState);
        }
        
        private void OnDisableAutomaticTopupsOperationCompleted(object arg) {
            if ((this.DisableAutomaticTopupsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DisableAutomaticTopupsCompleted(this, new DisableAutomaticTopupsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:despatchbay#EnableAutomaticTopups", RequestNamespace="urn:despatchbay", ResponseNamespace="urn:despatchbay")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public bool EnableAutomaticTopups(AutomaticTopupsSettingsRequestType AutomaticTopupsSettings) {
            object[] results = this.Invoke("EnableAutomaticTopups", new object[] {
                        AutomaticTopupsSettings});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void EnableAutomaticTopupsAsync(AutomaticTopupsSettingsRequestType AutomaticTopupsSettings) {
            this.EnableAutomaticTopupsAsync(AutomaticTopupsSettings, null);
        }
        
        /// <remarks/>
        public void EnableAutomaticTopupsAsync(AutomaticTopupsSettingsRequestType AutomaticTopupsSettings, object userState) {
            if ((this.EnableAutomaticTopupsOperationCompleted == null)) {
                this.EnableAutomaticTopupsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEnableAutomaticTopupsOperationCompleted);
            }
            this.InvokeAsync("EnableAutomaticTopups", new object[] {
                        AutomaticTopupsSettings}, this.EnableAutomaticTopupsOperationCompleted, userState);
        }
        
        private void OnEnableAutomaticTopupsOperationCompleted(object arg) {
            if ((this.EnableAutomaticTopupsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EnableAutomaticTopupsCompleted(this, new EnableAutomaticTopupsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class AccountType {
        
        private int accountIDField;
        
        private string accountNameField;
        
        private AccountBalanceType accountBalanceField;
        
        /// <remarks/>
        public int AccountID {
            get {
                return this.accountIDField;
            }
            set {
                this.accountIDField = value;
            }
        }
        
        /// <remarks/>
        public string AccountName {
            get {
                return this.accountNameField;
            }
            set {
                this.accountNameField = value;
            }
        }
        
        /// <remarks/>
        public AccountBalanceType AccountBalance {
            get {
                return this.accountBalanceField;
            }
            set {
                this.accountBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class AccountBalanceType {
        
        private float balanceField;
        
        private float availableBalanceField;
        
        /// <remarks/>
        public float Balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }
        
        /// <remarks/>
        public float AvailableBalance {
            get {
                return this.availableBalanceField;
            }
            set {
                this.availableBalanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class AutomaticTopupsSettingsRequestType {
        
        private int minimumBalanceField;
        
        private int topupAmountField;
        
        private string paymentMethodIDField;
        
        /// <remarks/>
        public int MinimumBalance {
            get {
                return this.minimumBalanceField;
            }
            set {
                this.minimumBalanceField = value;
            }
        }
        
        /// <remarks/>
        public int TopupAmount {
            get {
                return this.topupAmountField;
            }
            set {
                this.topupAmountField = value;
            }
        }
        
        /// <remarks/>
        public string PaymentMethodID {
            get {
                return this.paymentMethodIDField;
            }
            set {
                this.paymentMethodIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class PaymentMethodType {
        
        private string paymentMethodIDField;
        
        private string typeField;
        
        private string descriptionField;
        
        /// <remarks/>
        public string PaymentMethodID {
            get {
                return this.paymentMethodIDField;
            }
            set {
                this.paymentMethodIDField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class CourierType {
        
        private string courierIDField;
        
        private string courierNameField;
        
        /// <remarks/>
        public string CourierID {
            get {
                return this.courierIDField;
            }
            set {
                this.courierIDField = value;
            }
        }
        
        /// <remarks/>
        public string CourierName {
            get {
                return this.courierNameField;
            }
            set {
                this.courierNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class ServiceType {
        
        private int serviceIDField;
        
        private string formatField;
        
        private string nameField;
        
        private float costField;
        
        private bool costFieldSpecified;
        
        private CourierType courierField;
        
        /// <remarks/>
        public int ServiceID {
            get {
                return this.serviceIDField;
            }
            set {
                this.serviceIDField = value;
            }
        }
        
        /// <remarks/>
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public float Cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool CostSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CourierType Courier {
            get {
                return this.courierField;
            }
            set {
                this.courierField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class AddressType {
        
        private string companyNameField;
        
        private string streetField;
        
        private string localityField;
        
        private string townCityField;
        
        private string countyField;
        
        private string postalCodeField;
        
        private string countryCodeField;
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string Street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        public string Locality {
            get {
                return this.localityField;
            }
            set {
                this.localityField = value;
            }
        }
        
        /// <remarks/>
        public string TownCity {
            get {
                return this.townCityField;
            }
            set {
                this.townCityField = value;
            }
        }
        
        /// <remarks/>
        public string County {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        public string PostalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CountryCode {
            get {
                return this.countryCodeField;
            }
            set {
                this.countryCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:despatchbay")]
    public partial class SenderAddressType {
        
        private string senderNameField;
        
        private string senderTelephoneField;
        
        private string senderEmailField;
        
        private AddressType senderAddressField;
        
        private int senderAddressIDField;
        
        private bool senderAddressIDFieldSpecified;
        
        /// <remarks/>
        public string SenderName {
            get {
                return this.senderNameField;
            }
            set {
                this.senderNameField = value;
            }
        }
        
        /// <remarks/>
        public string SenderTelephone {
            get {
                return this.senderTelephoneField;
            }
            set {
                this.senderTelephoneField = value;
            }
        }
        
        /// <remarks/>
        public string SenderEmail {
            get {
                return this.senderEmailField;
            }
            set {
                this.senderEmailField = value;
            }
        }
        
        /// <remarks/>
        public AddressType SenderAddress {
            get {
                return this.senderAddressField;
            }
            set {
                this.senderAddressField = value;
            }
        }
        
        /// <remarks/>
        public int SenderAddressID {
            get {
                return this.senderAddressIDField;
            }
            set {
                this.senderAddressIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool SenderAddressIDSpecified {
            get {
                return this.senderAddressIDFieldSpecified;
            }
            set {
                this.senderAddressIDFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetAccountCompletedEventHandler(object sender, GetAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AccountType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AccountType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetAccountBalanceCompletedEventHandler(object sender, GetAccountBalanceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountBalanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountBalanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AccountBalanceType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AccountBalanceType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetSenderAddressesCompletedEventHandler(object sender, GetSenderAddressesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSenderAddressesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSenderAddressesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SenderAddressType[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SenderAddressType[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetServicesCompletedEventHandler(object sender, GetServicesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServicesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetServicesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ServiceType[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ServiceType[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void GetPaymentMethodsCompletedEventHandler(object sender, GetPaymentMethodsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPaymentMethodsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPaymentMethodsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PaymentMethodType[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PaymentMethodType[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void DisableAutomaticTopupsCompletedEventHandler(object sender, DisableAutomaticTopupsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DisableAutomaticTopupsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DisableAutomaticTopupsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void EnableAutomaticTopupsCompletedEventHandler(object sender, EnableAutomaticTopupsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EnableAutomaticTopupsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EnableAutomaticTopupsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591