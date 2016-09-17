﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuianClient.ServiceTour {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.guian.com/", ConfigurationName="ServiceTour.ServiceTour")]
    public interface ServiceTour {
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/addPlaceTourRequest", ReplyAction="http://services.guian.com/ServiceTour/addPlaceTourResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServiceTour.addPlaceTourResponse addPlaceTour(GuianClient.ServiceTour.addPlaceTourRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/addPlaceTourRequest", ReplyAction="http://services.guian.com/ServiceTour/addPlaceTourResponse")]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.addPlaceTourResponse> addPlaceTourAsync(GuianClient.ServiceTour.addPlaceTourRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/addTourRequest", ReplyAction="http://services.guian.com/ServiceTour/addTourResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServiceTour.addTourResponse addTour(GuianClient.ServiceTour.addTourRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/addTourRequest", ReplyAction="http://services.guian.com/ServiceTour/addTourResponse")]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.addTourResponse> addTourAsync(GuianClient.ServiceTour.addTourRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/deleteTourRequest", ReplyAction="http://services.guian.com/ServiceTour/deleteTourResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServiceTour.deleteTourResponse deleteTour(GuianClient.ServiceTour.deleteTourRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/deleteTourRequest", ReplyAction="http://services.guian.com/ServiceTour/deleteTourResponse")]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.deleteTourResponse> deleteTourAsync(GuianClient.ServiceTour.deleteTourRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/editTourRequest", ReplyAction="http://services.guian.com/ServiceTour/editTourResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        GuianClient.ServiceTour.editTourResponse editTour(GuianClient.ServiceTour.editTourRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/editTourRequest", ReplyAction="http://services.guian.com/ServiceTour/editTourResponse")]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.editTourResponse> editTourAsync(GuianClient.ServiceTour.editTourRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/getToursRequest", ReplyAction="http://services.guian.com/ServiceTour/getToursResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        GuianClient.ServiceTour.getToursResponse getTours(GuianClient.ServiceTour.getToursRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/getToursRequest", ReplyAction="http://services.guian.com/ServiceTour/getToursResponse")]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.getToursResponse> getToursAsync(GuianClient.ServiceTour.getToursRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/getToursByEnterpriseRequest", ReplyAction="http://services.guian.com/ServiceTour/getToursByEnterpriseResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        GuianClient.ServiceTour.getToursByEnterpriseResponse getToursByEnterprise(GuianClient.ServiceTour.getToursByEnterpriseRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.guian.com/ServiceTour/getToursByEnterpriseRequest", ReplyAction="http://services.guian.com/ServiceTour/getToursByEnterpriseResponse")]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.getToursByEnterpriseResponse> getToursByEnterpriseAsync(GuianClient.ServiceTour.getToursByEnterpriseRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.guian.com/")]
    public partial class placeTour : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int placeIDField;
        
        private int tourIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int tourID {
            get {
                return this.tourIDField;
            }
            set {
                this.tourIDField = value;
                this.RaisePropertyChanged("tourID");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.guian.com/")]
    public partial class tour : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal costField;
        
        private bool costFieldSpecified;
        
        private string descriptionField;
        
        private int enterpriseIDField;
        
        private string logoField;
        
        private string nameField;
        
        private int starField;
        
        private int tourIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
                this.RaisePropertyChanged("cost");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool costSpecified {
            get {
                return this.costFieldSpecified;
            }
            set {
                this.costFieldSpecified = value;
                this.RaisePropertyChanged("costSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int enterpriseID {
            get {
                return this.enterpriseIDField;
            }
            set {
                this.enterpriseIDField = value;
                this.RaisePropertyChanged("enterpriseID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
                this.RaisePropertyChanged("logo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int star {
            get {
                return this.starField;
            }
            set {
                this.starField = value;
                this.RaisePropertyChanged("star");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int tourID {
            get {
                return this.tourIDField;
            }
            set {
                this.tourIDField = value;
                this.RaisePropertyChanged("tourID");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="addPlaceTour", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class addPlaceTourRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServiceTour.placeTour arg0;
        
        public addPlaceTourRequest() {
        }
        
        public addPlaceTourRequest(GuianClient.ServiceTour.placeTour arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addPlaceTourResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class addPlaceTourResponse {
        
        public addPlaceTourResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addTour", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class addTourRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServiceTour.tour arg0;
        
        public addTourRequest() {
        }
        
        public addTourRequest(GuianClient.ServiceTour.tour arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="addTourResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class addTourResponse {
        
        public addTourResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteTour", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class deleteTourRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServiceTour.tour arg0;
        
        public deleteTourRequest() {
        }
        
        public deleteTourRequest(GuianClient.ServiceTour.tour arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteTourResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class deleteTourResponse {
        
        public deleteTourResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editTour", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class editTourRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServiceTour.tour arg0;
        
        public editTourRequest() {
        }
        
        public editTourRequest(GuianClient.ServiceTour.tour arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editTourResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class editTourResponse {
        
        public editTourResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTours", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getToursRequest {
        
        public getToursRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getToursResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getToursResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServiceTour.tour[] @return;
        
        public getToursResponse() {
        }
        
        public getToursResponse(GuianClient.ServiceTour.tour[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getToursByEnterprise", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getToursByEnterpriseRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public getToursByEnterpriseRequest() {
        }
        
        public getToursByEnterpriseRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getToursByEnterpriseResponse", WrapperNamespace="http://services.guian.com/", IsWrapped=true)]
    public partial class getToursByEnterpriseResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.guian.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GuianClient.ServiceTour.tour[] @return;
        
        public getToursByEnterpriseResponse() {
        }
        
        public getToursByEnterpriseResponse(GuianClient.ServiceTour.tour[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceTourChannel : GuianClient.ServiceTour.ServiceTour, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceTourClient : System.ServiceModel.ClientBase<GuianClient.ServiceTour.ServiceTour>, GuianClient.ServiceTour.ServiceTour {
        
        public ServiceTourClient() {
        }
        
        public ServiceTourClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceTourClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTourClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTourClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServiceTour.addPlaceTourResponse GuianClient.ServiceTour.ServiceTour.addPlaceTour(GuianClient.ServiceTour.addPlaceTourRequest request) {
            return base.Channel.addPlaceTour(request);
        }
        
        public void addPlaceTour(GuianClient.ServiceTour.placeTour arg0) {
            GuianClient.ServiceTour.addPlaceTourRequest inValue = new GuianClient.ServiceTour.addPlaceTourRequest();
            inValue.arg0 = arg0;
            GuianClient.ServiceTour.addPlaceTourResponse retVal = ((GuianClient.ServiceTour.ServiceTour)(this)).addPlaceTour(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.addPlaceTourResponse> GuianClient.ServiceTour.ServiceTour.addPlaceTourAsync(GuianClient.ServiceTour.addPlaceTourRequest request) {
            return base.Channel.addPlaceTourAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServiceTour.addPlaceTourResponse> addPlaceTourAsync(GuianClient.ServiceTour.placeTour arg0) {
            GuianClient.ServiceTour.addPlaceTourRequest inValue = new GuianClient.ServiceTour.addPlaceTourRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServiceTour.ServiceTour)(this)).addPlaceTourAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServiceTour.addTourResponse GuianClient.ServiceTour.ServiceTour.addTour(GuianClient.ServiceTour.addTourRequest request) {
            return base.Channel.addTour(request);
        }
        
        public void addTour(GuianClient.ServiceTour.tour arg0) {
            GuianClient.ServiceTour.addTourRequest inValue = new GuianClient.ServiceTour.addTourRequest();
            inValue.arg0 = arg0;
            GuianClient.ServiceTour.addTourResponse retVal = ((GuianClient.ServiceTour.ServiceTour)(this)).addTour(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.addTourResponse> GuianClient.ServiceTour.ServiceTour.addTourAsync(GuianClient.ServiceTour.addTourRequest request) {
            return base.Channel.addTourAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServiceTour.addTourResponse> addTourAsync(GuianClient.ServiceTour.tour arg0) {
            GuianClient.ServiceTour.addTourRequest inValue = new GuianClient.ServiceTour.addTourRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServiceTour.ServiceTour)(this)).addTourAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServiceTour.deleteTourResponse GuianClient.ServiceTour.ServiceTour.deleteTour(GuianClient.ServiceTour.deleteTourRequest request) {
            return base.Channel.deleteTour(request);
        }
        
        public void deleteTour(GuianClient.ServiceTour.tour arg0) {
            GuianClient.ServiceTour.deleteTourRequest inValue = new GuianClient.ServiceTour.deleteTourRequest();
            inValue.arg0 = arg0;
            GuianClient.ServiceTour.deleteTourResponse retVal = ((GuianClient.ServiceTour.ServiceTour)(this)).deleteTour(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.deleteTourResponse> GuianClient.ServiceTour.ServiceTour.deleteTourAsync(GuianClient.ServiceTour.deleteTourRequest request) {
            return base.Channel.deleteTourAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServiceTour.deleteTourResponse> deleteTourAsync(GuianClient.ServiceTour.tour arg0) {
            GuianClient.ServiceTour.deleteTourRequest inValue = new GuianClient.ServiceTour.deleteTourRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServiceTour.ServiceTour)(this)).deleteTourAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServiceTour.editTourResponse GuianClient.ServiceTour.ServiceTour.editTour(GuianClient.ServiceTour.editTourRequest request) {
            return base.Channel.editTour(request);
        }
        
        public void editTour(GuianClient.ServiceTour.tour arg0) {
            GuianClient.ServiceTour.editTourRequest inValue = new GuianClient.ServiceTour.editTourRequest();
            inValue.arg0 = arg0;
            GuianClient.ServiceTour.editTourResponse retVal = ((GuianClient.ServiceTour.ServiceTour)(this)).editTour(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.editTourResponse> GuianClient.ServiceTour.ServiceTour.editTourAsync(GuianClient.ServiceTour.editTourRequest request) {
            return base.Channel.editTourAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServiceTour.editTourResponse> editTourAsync(GuianClient.ServiceTour.tour arg0) {
            GuianClient.ServiceTour.editTourRequest inValue = new GuianClient.ServiceTour.editTourRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServiceTour.ServiceTour)(this)).editTourAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServiceTour.getToursResponse GuianClient.ServiceTour.ServiceTour.getTours(GuianClient.ServiceTour.getToursRequest request) {
            return base.Channel.getTours(request);
        }
        
        public GuianClient.ServiceTour.tour[] getTours() {
            GuianClient.ServiceTour.getToursRequest inValue = new GuianClient.ServiceTour.getToursRequest();
            GuianClient.ServiceTour.getToursResponse retVal = ((GuianClient.ServiceTour.ServiceTour)(this)).getTours(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.getToursResponse> GuianClient.ServiceTour.ServiceTour.getToursAsync(GuianClient.ServiceTour.getToursRequest request) {
            return base.Channel.getToursAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServiceTour.getToursResponse> getToursAsync() {
            GuianClient.ServiceTour.getToursRequest inValue = new GuianClient.ServiceTour.getToursRequest();
            return ((GuianClient.ServiceTour.ServiceTour)(this)).getToursAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GuianClient.ServiceTour.getToursByEnterpriseResponse GuianClient.ServiceTour.ServiceTour.getToursByEnterprise(GuianClient.ServiceTour.getToursByEnterpriseRequest request) {
            return base.Channel.getToursByEnterprise(request);
        }
        
        public GuianClient.ServiceTour.tour[] getToursByEnterprise(int arg0) {
            GuianClient.ServiceTour.getToursByEnterpriseRequest inValue = new GuianClient.ServiceTour.getToursByEnterpriseRequest();
            inValue.arg0 = arg0;
            GuianClient.ServiceTour.getToursByEnterpriseResponse retVal = ((GuianClient.ServiceTour.ServiceTour)(this)).getToursByEnterprise(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GuianClient.ServiceTour.getToursByEnterpriseResponse> GuianClient.ServiceTour.ServiceTour.getToursByEnterpriseAsync(GuianClient.ServiceTour.getToursByEnterpriseRequest request) {
            return base.Channel.getToursByEnterpriseAsync(request);
        }
        
        public System.Threading.Tasks.Task<GuianClient.ServiceTour.getToursByEnterpriseResponse> getToursByEnterpriseAsync(int arg0) {
            GuianClient.ServiceTour.getToursByEnterpriseRequest inValue = new GuianClient.ServiceTour.getToursByEnterpriseRequest();
            inValue.arg0 = arg0;
            return ((GuianClient.ServiceTour.ServiceTour)(this)).getToursByEnterpriseAsync(inValue);
        }
    }
}
