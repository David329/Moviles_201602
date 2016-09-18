﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuianClient.ServicePlace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.guian.com/", ConfigurationName="ServicePlace.ServicePlace")]
    public interface ServicePlace {
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/editPlaceRequest", ReplyAction="http://services.guian.com/ServicePlace/editPlaceResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServicePlace.editPlaceResponse editPlace(GuianClient.ServicePlace.editPlaceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/editPlaceRequest", ReplyAction="http://services.guian.com/ServicePlace/editPlaceResponse")]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.editPlaceResponse> editPlaceAsync(GuianClient.ServicePlace.editPlaceRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/getPlacesRequest", ReplyAction="http://services.guian.com/ServicePlace/getPlacesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        GuianClient.ServicePlace.getPlacesResponse getPlaces(GuianClient.ServicePlace.getPlacesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/getPlacesRequest", ReplyAction="http://services.guian.com/ServicePlace/getPlacesResponse")]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.getPlacesResponse> getPlacesAsync(GuianClient.ServicePlace.getPlacesRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/getPlacesByCityRequest", ReplyAction="http://services.guian.com/ServicePlace/getPlacesByCityResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        GuianClient.ServicePlace.getPlacesByCityResponse getPlacesByCity(GuianClient.ServicePlace.getPlacesByCityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/getPlacesByCityRequest", ReplyAction="http://services.guian.com/ServicePlace/getPlacesByCityResponse")]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.getPlacesByCityResponse> getPlacesByCityAsync(GuianClient.ServicePlace.getPlacesByCityRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/deletePlaceRequest", ReplyAction="http://services.guian.com/ServicePlace/deletePlaceResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServicePlace.deletePlaceResponse deletePlace(GuianClient.ServicePlace.deletePlaceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/deletePlaceRequest", ReplyAction="http://services.guian.com/ServicePlace/deletePlaceResponse")]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.deletePlaceResponse> deletePlaceAsync(GuianClient.ServicePlace.deletePlaceRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/addPlaceRequest", ReplyAction="http://services.guian.com/ServicePlace/addPlaceResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServicePlace.addPlaceResponse addPlace(GuianClient.ServicePlace.addPlaceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServicePlace/addPlaceRequest", ReplyAction="http://services.guian.com/ServicePlace/addPlaceResponse")]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.addPlaceResponse> addPlaceAsync(GuianClient.ServicePlace.addPlaceRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.guian.com/")]
    public partial class place : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string audioField;
        
        private int cityIDField;
        
        private string descriptionField;
        
        private string latitudField;
        
        private string longitudField;
        
        private string nameField;
        
        private int placeIDField;
        
        private int visitsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string audio {
            get {
                return this.audioField;
            }
            set {
                this.audioField = value;
                this.RaisePropertyChanged("audio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int cityID {
            get {
                return this.cityIDField;
            }
            set {
                this.cityIDField = value;
                this.RaisePropertyChanged("cityID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string latitud {
            get {
                return this.latitudField;
            }
            set {
                this.latitudField = value;
                this.RaisePropertyChanged("latitud");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string longitud {
            get {
                return this.longitudField;
            }
            set {
                this.longitudField = value;
                this.RaisePropertyChanged("longitud");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int placeID {
            get {
                return this.placeIDField;
            }
            set {
                this.placeIDField = value;
                this.RaisePropertyChanged("placeID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int visits {
            get {
                return this.visitsField;
            }
            set {
                this.visitsField = value;
                this.RaisePropertyChanged("visits");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editPlace", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class editPlaceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServicePlace.place arg0;
        
        public editPlaceRequest() {
        }
        
        public editPlaceRequest(GuianClient.ServicePlace.place arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editPlaceResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class editPlaceResponse {
        
        public editPlaceResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPlaces", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getPlacesRequest {
        
        public getPlacesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPlacesResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getPlacesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServicePlace.place[] @return;
        
        public getPlacesResponse() {
        }
        
        public getPlacesResponse(GuianClient.ServicePlace.place[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPlacesByCity", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getPlacesByCityRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public getPlacesByCityRequest() {
        }
        
        public getPlacesByCityRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPlacesByCityResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getPlacesByCityResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServicePlace.place[] @return;
        
        public getPlacesByCityResponse() {
        }
        
        public getPlacesByCityResponse(GuianClient.ServicePlace.place[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deletePlace", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class deletePlaceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServicePlace.place arg0;
        
        public deletePlaceRequest() {
        }
        
        public deletePlaceRequest(GuianClient.ServicePlace.place arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deletePlaceResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class deletePlaceResponse {
        
        public deletePlaceResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addPlace", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class addPlaceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServicePlace.place arg0;
        
        public addPlaceRequest() {
        }
        
        public addPlaceRequest(GuianClient.ServicePlace.place arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addPlaceResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class addPlaceResponse {
        
        public addPlaceResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicePlaceChannel : GuianClient.ServicePlace.ServicePlace, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePlaceClient : System.ServiceModel.ClientBase<GuianClient.ServicePlace.ServicePlace>, GuianClient.ServicePlace.ServicePlace {
        
        public ServicePlaceClient() {
        }
        
        public ServicePlaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePlaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePlaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePlaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServicePlace.editPlaceResponse GuianClient.ServicePlace.ServicePlace.editPlace(GuianClient.ServicePlace.editPlaceRequest request) {
            return base.Channel.editPlace(request);
        }
        
        public void editPlace(GuianClient.ServicePlace.place arg0) {
            GuianClient.ServicePlace.editPlaceRequest inValue = new GuianClient.ServicePlace.editPlaceRequest();
            inValue.arg0 = arg0;
            GuianClient.ServicePlace.editPlaceResponse retVal = ((GuianClient.ServicePlace.ServicePlace)(this)).editPlace(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.editPlaceResponse> GuianClient.ServicePlace.ServicePlace.editPlaceAsync(GuianClient.ServicePlace.editPlaceRequest request) {
            return base.Channel.editPlaceAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServicePlace.editPlaceResponse> editPlaceAsync(GuianClient.ServicePlace.place arg0) {
            GuianClient.ServicePlace.editPlaceRequest inValue = new GuianClient.ServicePlace.editPlaceRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServicePlace.ServicePlace)(this)).editPlaceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServicePlace.getPlacesResponse GuianClient.ServicePlace.ServicePlace.getPlaces(GuianClient.ServicePlace.getPlacesRequest request) {
            return base.Channel.getPlaces(request);
        }
        
        public GuianClient.ServicePlace.place[] getPlaces() {
            GuianClient.ServicePlace.getPlacesRequest inValue = new GuianClient.ServicePlace.getPlacesRequest();
            GuianClient.ServicePlace.getPlacesResponse retVal = ((GuianClient.ServicePlace.ServicePlace)(this)).getPlaces(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.getPlacesResponse> GuianClient.ServicePlace.ServicePlace.getPlacesAsync(GuianClient.ServicePlace.getPlacesRequest request) {
            return base.Channel.getPlacesAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServicePlace.getPlacesResponse> getPlacesAsync() {
            GuianClient.ServicePlace.getPlacesRequest inValue = new GuianClient.ServicePlace.getPlacesRequest();
            return ((GuianClient.ServicePlace.ServicePlace)(this)).getPlacesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServicePlace.getPlacesByCityResponse GuianClient.ServicePlace.ServicePlace.getPlacesByCity(GuianClient.ServicePlace.getPlacesByCityRequest request) {
            return base.Channel.getPlacesByCity(request);
        }
        
        public GuianClient.ServicePlace.place[] getPlacesByCity(int arg0) {
            GuianClient.ServicePlace.getPlacesByCityRequest inValue = new GuianClient.ServicePlace.getPlacesByCityRequest();
            inValue.arg0 = arg0;
            GuianClient.ServicePlace.getPlacesByCityResponse retVal = ((GuianClient.ServicePlace.ServicePlace)(this)).getPlacesByCity(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.getPlacesByCityResponse> GuianClient.ServicePlace.ServicePlace.getPlacesByCityAsync(GuianClient.ServicePlace.getPlacesByCityRequest request) {
            return base.Channel.getPlacesByCityAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServicePlace.getPlacesByCityResponse> getPlacesByCityAsync(int arg0) {
            GuianClient.ServicePlace.getPlacesByCityRequest inValue = new GuianClient.ServicePlace.getPlacesByCityRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServicePlace.ServicePlace)(this)).getPlacesByCityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServicePlace.deletePlaceResponse GuianClient.ServicePlace.ServicePlace.deletePlace(GuianClient.ServicePlace.deletePlaceRequest request) {
            return base.Channel.deletePlace(request);
        }
        
        public void deletePlace(GuianClient.ServicePlace.place arg0) {
            GuianClient.ServicePlace.deletePlaceRequest inValue = new GuianClient.ServicePlace.deletePlaceRequest();
            inValue.arg0 = arg0;
            GuianClient.ServicePlace.deletePlaceResponse retVal = ((GuianClient.ServicePlace.ServicePlace)(this)).deletePlace(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.deletePlaceResponse> GuianClient.ServicePlace.ServicePlace.deletePlaceAsync(GuianClient.ServicePlace.deletePlaceRequest request) {
            return base.Channel.deletePlaceAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServicePlace.deletePlaceResponse> deletePlaceAsync(GuianClient.ServicePlace.place arg0) {
            GuianClient.ServicePlace.deletePlaceRequest inValue = new GuianClient.ServicePlace.deletePlaceRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServicePlace.ServicePlace)(this)).deletePlaceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServicePlace.addPlaceResponse GuianClient.ServicePlace.ServicePlace.addPlace(GuianClient.ServicePlace.addPlaceRequest request) {
            return base.Channel.addPlace(request);
        }
        
        public void addPlace(GuianClient.ServicePlace.place arg0) {
            GuianClient.ServicePlace.addPlaceRequest inValue = new GuianClient.ServicePlace.addPlaceRequest();
            inValue.arg0 = arg0;
            GuianClient.ServicePlace.addPlaceResponse retVal = ((GuianClient.ServicePlace.ServicePlace)(this)).addPlace(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServicePlace.addPlaceResponse> GuianClient.ServicePlace.ServicePlace.addPlaceAsync(GuianClient.ServicePlace.addPlaceRequest request) {
            return base.Channel.addPlaceAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServicePlace.addPlaceResponse> addPlaceAsync(GuianClient.ServicePlace.place arg0) {
            GuianClient.ServicePlace.addPlaceRequest inValue = new GuianClient.ServicePlace.addPlaceRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServicePlace.ServicePlace)(this)).addPlaceAsync(inValue);
        }
    }
}