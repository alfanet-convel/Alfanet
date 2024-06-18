﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3053
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.3053.
// 
#pragma warning disable 1591

namespace Plantillas.autocomplete {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AutoCompleteSoap", Namespace="http://tempuri.org/")]
    public partial class AutoComplete : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDependenciaByTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetExpedienteByTextNombreOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMedioByTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetNaturalezaByTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProcedenciaByTextNombreOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSerieByTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRadicadoByCodigoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetWFAccionTextByTextOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AutoComplete() {
            this.Url = global::Plantillas.Properties.Settings.Default.Plantillas_autocomplete_AutoComplete;
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
        public event GetDependenciaByTextCompletedEventHandler GetDependenciaByTextCompleted;
        
        /// <remarks/>
        public event GetExpedienteByTextNombreCompletedEventHandler GetExpedienteByTextNombreCompleted;
        
        /// <remarks/>
        public event GetMedioByTextCompletedEventHandler GetMedioByTextCompleted;
        
        /// <remarks/>
        public event GetNaturalezaByTextCompletedEventHandler GetNaturalezaByTextCompleted;
        
        /// <remarks/>
        public event GetProcedenciaByTextNombreCompletedEventHandler GetProcedenciaByTextNombreCompleted;
        
        /// <remarks/>
        public event GetSerieByTextCompletedEventHandler GetSerieByTextCompleted;
        
        /// <remarks/>
        public event GetRadicadoByCodigoCompletedEventHandler GetRadicadoByCodigoCompleted;
        
        /// <remarks/>
        public event GetWFAccionTextByTextCompletedEventHandler GetWFAccionTextByTextCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDependenciaByText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetDependenciaByText(string prefixText) {
            object[] results = this.Invoke("GetDependenciaByText", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetDependenciaByTextAsync(string prefixText) {
            this.GetDependenciaByTextAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetDependenciaByTextAsync(string prefixText, object userState) {
            if ((this.GetDependenciaByTextOperationCompleted == null)) {
                this.GetDependenciaByTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDependenciaByTextOperationCompleted);
            }
            this.InvokeAsync("GetDependenciaByText", new object[] {
                        prefixText}, this.GetDependenciaByTextOperationCompleted, userState);
        }
        
        private void OnGetDependenciaByTextOperationCompleted(object arg) {
            if ((this.GetDependenciaByTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDependenciaByTextCompleted(this, new GetDependenciaByTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetExpedienteByTextNombre", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetExpedienteByTextNombre(string prefixText) {
            object[] results = this.Invoke("GetExpedienteByTextNombre", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetExpedienteByTextNombreAsync(string prefixText) {
            this.GetExpedienteByTextNombreAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetExpedienteByTextNombreAsync(string prefixText, object userState) {
            if ((this.GetExpedienteByTextNombreOperationCompleted == null)) {
                this.GetExpedienteByTextNombreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExpedienteByTextNombreOperationCompleted);
            }
            this.InvokeAsync("GetExpedienteByTextNombre", new object[] {
                        prefixText}, this.GetExpedienteByTextNombreOperationCompleted, userState);
        }
        
        private void OnGetExpedienteByTextNombreOperationCompleted(object arg) {
            if ((this.GetExpedienteByTextNombreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExpedienteByTextNombreCompleted(this, new GetExpedienteByTextNombreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMedioByText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetMedioByText(string prefixText) {
            object[] results = this.Invoke("GetMedioByText", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetMedioByTextAsync(string prefixText) {
            this.GetMedioByTextAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetMedioByTextAsync(string prefixText, object userState) {
            if ((this.GetMedioByTextOperationCompleted == null)) {
                this.GetMedioByTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMedioByTextOperationCompleted);
            }
            this.InvokeAsync("GetMedioByText", new object[] {
                        prefixText}, this.GetMedioByTextOperationCompleted, userState);
        }
        
        private void OnGetMedioByTextOperationCompleted(object arg) {
            if ((this.GetMedioByTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMedioByTextCompleted(this, new GetMedioByTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNaturalezaByText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetNaturalezaByText(string prefixText) {
            object[] results = this.Invoke("GetNaturalezaByText", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetNaturalezaByTextAsync(string prefixText) {
            this.GetNaturalezaByTextAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetNaturalezaByTextAsync(string prefixText, object userState) {
            if ((this.GetNaturalezaByTextOperationCompleted == null)) {
                this.GetNaturalezaByTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetNaturalezaByTextOperationCompleted);
            }
            this.InvokeAsync("GetNaturalezaByText", new object[] {
                        prefixText}, this.GetNaturalezaByTextOperationCompleted, userState);
        }
        
        private void OnGetNaturalezaByTextOperationCompleted(object arg) {
            if ((this.GetNaturalezaByTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetNaturalezaByTextCompleted(this, new GetNaturalezaByTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProcedenciaByTextNombre", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetProcedenciaByTextNombre(string prefixText) {
            object[] results = this.Invoke("GetProcedenciaByTextNombre", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetProcedenciaByTextNombreAsync(string prefixText) {
            this.GetProcedenciaByTextNombreAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetProcedenciaByTextNombreAsync(string prefixText, object userState) {
            if ((this.GetProcedenciaByTextNombreOperationCompleted == null)) {
                this.GetProcedenciaByTextNombreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProcedenciaByTextNombreOperationCompleted);
            }
            this.InvokeAsync("GetProcedenciaByTextNombre", new object[] {
                        prefixText}, this.GetProcedenciaByTextNombreOperationCompleted, userState);
        }
        
        private void OnGetProcedenciaByTextNombreOperationCompleted(object arg) {
            if ((this.GetProcedenciaByTextNombreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProcedenciaByTextNombreCompleted(this, new GetProcedenciaByTextNombreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSerieByText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetSerieByText(string prefixText) {
            object[] results = this.Invoke("GetSerieByText", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetSerieByTextAsync(string prefixText) {
            this.GetSerieByTextAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetSerieByTextAsync(string prefixText, object userState) {
            if ((this.GetSerieByTextOperationCompleted == null)) {
                this.GetSerieByTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSerieByTextOperationCompleted);
            }
            this.InvokeAsync("GetSerieByText", new object[] {
                        prefixText}, this.GetSerieByTextOperationCompleted, userState);
        }
        
        private void OnGetSerieByTextOperationCompleted(object arg) {
            if ((this.GetSerieByTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSerieByTextCompleted(this, new GetSerieByTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetRadicadoByCodigo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetRadicadoByCodigo(string prefixText) {
            object[] results = this.Invoke("GetRadicadoByCodigo", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetRadicadoByCodigoAsync(string prefixText) {
            this.GetRadicadoByCodigoAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetRadicadoByCodigoAsync(string prefixText, object userState) {
            if ((this.GetRadicadoByCodigoOperationCompleted == null)) {
                this.GetRadicadoByCodigoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRadicadoByCodigoOperationCompleted);
            }
            this.InvokeAsync("GetRadicadoByCodigo", new object[] {
                        prefixText}, this.GetRadicadoByCodigoOperationCompleted, userState);
        }
        
        private void OnGetRadicadoByCodigoOperationCompleted(object arg) {
            if ((this.GetRadicadoByCodigoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRadicadoByCodigoCompleted(this, new GetRadicadoByCodigoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetWFAccionTextByText", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetWFAccionTextByText(string prefixText) {
            object[] results = this.Invoke("GetWFAccionTextByText", new object[] {
                        prefixText});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetWFAccionTextByTextAsync(string prefixText) {
            this.GetWFAccionTextByTextAsync(prefixText, null);
        }
        
        /// <remarks/>
        public void GetWFAccionTextByTextAsync(string prefixText, object userState) {
            if ((this.GetWFAccionTextByTextOperationCompleted == null)) {
                this.GetWFAccionTextByTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetWFAccionTextByTextOperationCompleted);
            }
            this.InvokeAsync("GetWFAccionTextByText", new object[] {
                        prefixText}, this.GetWFAccionTextByTextOperationCompleted, userState);
        }
        
        private void OnGetWFAccionTextByTextOperationCompleted(object arg) {
            if ((this.GetWFAccionTextByTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetWFAccionTextByTextCompleted(this, new GetWFAccionTextByTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetDependenciaByTextCompletedEventHandler(object sender, GetDependenciaByTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDependenciaByTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDependenciaByTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetExpedienteByTextNombreCompletedEventHandler(object sender, GetExpedienteByTextNombreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExpedienteByTextNombreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetExpedienteByTextNombreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetMedioByTextCompletedEventHandler(object sender, GetMedioByTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMedioByTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMedioByTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetNaturalezaByTextCompletedEventHandler(object sender, GetNaturalezaByTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetNaturalezaByTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetNaturalezaByTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetProcedenciaByTextNombreCompletedEventHandler(object sender, GetProcedenciaByTextNombreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProcedenciaByTextNombreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProcedenciaByTextNombreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSerieByTextCompletedEventHandler(object sender, GetSerieByTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSerieByTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSerieByTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetRadicadoByCodigoCompletedEventHandler(object sender, GetRadicadoByCodigoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRadicadoByCodigoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRadicadoByCodigoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetWFAccionTextByTextCompletedEventHandler(object sender, GetWFAccionTextByTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetWFAccionTextByTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetWFAccionTextByTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591