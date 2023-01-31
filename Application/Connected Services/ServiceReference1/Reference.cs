﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.pzm.nautavis.com/")]
    public partial class Exception
    {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.pzm.nautavis.com/")]
    public partial class maschineOperatingtimeDataDto
    {
        
        private string machineNumberField;
        
        private string timestampFromField;
        
        private string timestampToField;
        
        private double totalTimeField;
        
        private double upTimeField;
        
        private double productiveTimeField;
        
        private double standbyTimeField;
        
        private double engineeringTimeField;
        
        private double downTimeField;
        
        private double scheduledDownTimeField;
        
        private double unscheduledDownTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string MachineNumber
        {
            get
            {
                return this.machineNumberField;
            }
            set
            {
                this.machineNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TimestampFrom
        {
            get
            {
                return this.timestampFromField;
            }
            set
            {
                this.timestampFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string TimestampTo
        {
            get
            {
                return this.timestampToField;
            }
            set
            {
                this.timestampToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double TotalTime
        {
            get
            {
                return this.totalTimeField;
            }
            set
            {
                this.totalTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public double UpTime
        {
            get
            {
                return this.upTimeField;
            }
            set
            {
                this.upTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double ProductiveTime
        {
            get
            {
                return this.productiveTimeField;
            }
            set
            {
                this.productiveTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public double StandbyTime
        {
            get
            {
                return this.standbyTimeField;
            }
            set
            {
                this.standbyTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public double EngineeringTime
        {
            get
            {
                return this.engineeringTimeField;
            }
            set
            {
                this.engineeringTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public double DownTime
        {
            get
            {
                return this.downTimeField;
            }
            set
            {
                this.downTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public double ScheduledDownTime
        {
            get
            {
                return this.scheduledDownTimeField;
            }
            set
            {
                this.scheduledDownTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public double UnscheduledDownTime
        {
            get
            {
                return this.unscheduledDownTimeField;
            }
            set
            {
                this.unscheduledDownTimeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice.pzm.nautavis.com/", ConfigurationName="ServiceReference1.ToolboxService")]
    public interface ToolboxService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineOperatingtimeDataLi" +
            "stRequest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineOperatingtimeDataLi" +
            "stResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.Exception), Action="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineOperatingtimeDataLi" +
            "st/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.saveMaschineOperatingtimeDataListResponse saveMaschineOperatingtimeDataList(ServiceReference1.saveMaschineOperatingtimeDataListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineOperatingtimeDataLi" +
            "stRequest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineOperatingtimeDataLi" +
            "stResponse")]
        System.Threading.Tasks.Task<ServiceReference1.saveMaschineOperatingtimeDataListResponse> saveMaschineOperatingtimeDataListAsync(ServiceReference1.saveMaschineOperatingtimeDataListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineProductionDataListR" +
            "equest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineProductionDataListR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.Exception), Action="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineProductionDataList/" +
            "Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.saveMaschineProductionDataListResponse saveMaschineProductionDataList(ServiceReference1.saveMaschineProductionDataListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineProductionDataListR" +
            "equest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/saveMaschineProductionDataListR" +
            "esponse")]
        System.Threading.Tasks.Task<ServiceReference1.saveMaschineProductionDataListResponse> saveMaschineProductionDataListAsync(ServiceReference1.saveMaschineProductionDataListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/saveVersionInfoRequest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/saveVersionInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.Exception), Action="http://webservice.pzm.nautavis.com/ToolboxService/saveVersionInfo/Fault/Exception" +
            "", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.saveVersionInfoResponse saveVersionInfo(ServiceReference1.saveVersionInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/saveVersionInfoRequest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/saveVersionInfoResponse")]
        System.Threading.Tasks.Task<ServiceReference1.saveVersionInfoResponse> saveVersionInfoAsync(ServiceReference1.saveVersionInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/getMachinesRequest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/getMachinesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.Exception), Action="http://webservice.pzm.nautavis.com/ToolboxService/getMachines/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference1.getMachinesResponse getMachines(ServiceReference1.getMachinesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservice.pzm.nautavis.com/ToolboxService/getMachinesRequest", ReplyAction="http://webservice.pzm.nautavis.com/ToolboxService/getMachinesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.getMachinesResponse> getMachinesAsync(ServiceReference1.getMachinesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saveMaschineOperatingtimeDataList", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class saveMaschineOperatingtimeDataListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.maschineOperatingtimeDataDto[] arg0;
        
        public saveMaschineOperatingtimeDataListRequest()
        {
        }
        
        public saveMaschineOperatingtimeDataListRequest(ServiceReference1.maschineOperatingtimeDataDto[] arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saveMaschineOperatingtimeDataListResponse", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class saveMaschineOperatingtimeDataListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public saveMaschineOperatingtimeDataListResponse()
        {
        }
        
        public saveMaschineOperatingtimeDataListResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.pzm.nautavis.com/")]
    public partial class maschineProductionDataDto
    {
        
        private string machineNumberField;
        
        private string timestampFromField;
        
        private string timestampToField;
        
        private int totalCountField;
        
        private int processOkCountField;
        
        private int processFailedCountField;
        
        private int bypassCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string MachineNumber
        {
            get
            {
                return this.machineNumberField;
            }
            set
            {
                this.machineNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string TimestampFrom
        {
            get
            {
                return this.timestampFromField;
            }
            set
            {
                this.timestampFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string TimestampTo
        {
            get
            {
                return this.timestampToField;
            }
            set
            {
                this.timestampToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int TotalCount
        {
            get
            {
                return this.totalCountField;
            }
            set
            {
                this.totalCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int ProcessOkCount
        {
            get
            {
                return this.processOkCountField;
            }
            set
            {
                this.processOkCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int ProcessFailedCount
        {
            get
            {
                return this.processFailedCountField;
            }
            set
            {
                this.processFailedCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int BypassCount
        {
            get
            {
                return this.bypassCountField;
            }
            set
            {
                this.bypassCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saveMaschineProductionDataList", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class saveMaschineProductionDataListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.maschineProductionDataDto[] arg0;
        
        public saveMaschineProductionDataListRequest()
        {
        }
        
        public saveMaschineProductionDataListRequest(ServiceReference1.maschineProductionDataDto[] arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saveMaschineProductionDataListResponse", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class saveMaschineProductionDataListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public saveMaschineProductionDataListResponse()
        {
        }
        
        public saveMaschineProductionDataListResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.pzm.nautavis.com/")]
    public partial class maschineVersionInfoDto
    {
        
        private string machineNumberField;
        
        private string frameworkVersionField;
        
        private string windowsVersionField;
        
        private string databaseVersionField;
        
        private string ipcImageVersionField;
        
        private string dotNetVersionField;
        
        private string plcProgramVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string MachineNumber
        {
            get
            {
                return this.machineNumberField;
            }
            set
            {
                this.machineNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string FrameworkVersion
        {
            get
            {
                return this.frameworkVersionField;
            }
            set
            {
                this.frameworkVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string WindowsVersion
        {
            get
            {
                return this.windowsVersionField;
            }
            set
            {
                this.windowsVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string DatabaseVersion
        {
            get
            {
                return this.databaseVersionField;
            }
            set
            {
                this.databaseVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string IpcImageVersion
        {
            get
            {
                return this.ipcImageVersionField;
            }
            set
            {
                this.ipcImageVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string DotNetVersion
        {
            get
            {
                return this.dotNetVersionField;
            }
            set
            {
                this.dotNetVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string PlcProgramVersion
        {
            get
            {
                return this.plcProgramVersionField;
            }
            set
            {
                this.plcProgramVersionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saveVersionInfo", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class saveVersionInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.maschineVersionInfoDto arg0;
        
        public saveVersionInfoRequest()
        {
        }
        
        public saveVersionInfoRequest(ServiceReference1.maschineVersionInfoDto arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="saveVersionInfoResponse", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class saveVersionInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public saveVersionInfoResponse()
        {
        }
        
        public saveVersionInfoResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.pzm.nautavis.com/")]
    public partial class maschineDto
    {
        
        private string machineNumberField;
        
        private string productGroupField;
        
        private string productField;
        
        private string variantField;
        
        private string companyGroupField;
        
        private string cityField;
        
        private string countryField;
        
        private string statusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string MachineNumber
        {
            get
            {
                return this.machineNumberField;
            }
            set
            {
                this.machineNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ProductGroup
        {
            get
            {
                return this.productGroupField;
            }
            set
            {
                this.productGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Variant
        {
            get
            {
                return this.variantField;
            }
            set
            {
                this.variantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string CompanyGroup
        {
            get
            {
                return this.companyGroupField;
            }
            set
            {
                this.companyGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getMachines", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class getMachinesRequest
    {
        
        public getMachinesRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getMachinesResponse", WrapperNamespace="http://webservice.pzm.nautavis.com/", IsWrapped=true)]
    public partial class getMachinesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.pzm.nautavis.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.maschineDto[] @return;
        
        public getMachinesResponse()
        {
        }
        
        public getMachinesResponse(ServiceReference1.maschineDto[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ToolboxServiceChannel : ServiceReference1.ToolboxService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ToolboxServiceClient : System.ServiceModel.ClientBase<ServiceReference1.ToolboxService>, ServiceReference1.ToolboxService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ToolboxServiceClient() : 
                base(ToolboxServiceClient.GetDefaultBinding(), ToolboxServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ToolboxServiceImplPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ToolboxServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ToolboxServiceClient.GetBindingForEndpoint(endpointConfiguration), ToolboxServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ToolboxServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ToolboxServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ToolboxServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ToolboxServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ToolboxServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.saveMaschineOperatingtimeDataListResponse saveMaschineOperatingtimeDataList(ServiceReference1.saveMaschineOperatingtimeDataListRequest request)
        {
            return base.Channel.saveMaschineOperatingtimeDataList(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.saveMaschineOperatingtimeDataListResponse> saveMaschineOperatingtimeDataListAsync(ServiceReference1.saveMaschineOperatingtimeDataListRequest request)
        {
            return base.Channel.saveMaschineOperatingtimeDataListAsync(request);
        }
        
        public ServiceReference1.saveMaschineProductionDataListResponse saveMaschineProductionDataList(ServiceReference1.saveMaschineProductionDataListRequest request)
        {
            return base.Channel.saveMaschineProductionDataList(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.saveMaschineProductionDataListResponse> saveMaschineProductionDataListAsync(ServiceReference1.saveMaschineProductionDataListRequest request)
        {
            return base.Channel.saveMaschineProductionDataListAsync(request);
        }
        
        public ServiceReference1.saveVersionInfoResponse saveVersionInfo(ServiceReference1.saveVersionInfoRequest request)
        {
            return base.Channel.saveVersionInfo(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.saveVersionInfoResponse> saveVersionInfoAsync(ServiceReference1.saveVersionInfoRequest request)
        {
            return base.Channel.saveVersionInfoAsync(request);
        }
        
        public ServiceReference1.getMachinesResponse getMachines(ServiceReference1.getMachinesRequest request)
        {
            return base.Channel.getMachines(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.getMachinesResponse> getMachinesAsync(ServiceReference1.getMachinesRequest request)
        {
            return base.Channel.getMachinesAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ToolboxServiceImplPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ToolboxServiceImplPort))
            {
                return new System.ServiceModel.EndpointAddress("http://test1.toolbox.4jet.local:4443/toolbox-ws");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ToolboxServiceClient.GetBindingForEndpoint(EndpointConfiguration.ToolboxServiceImplPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ToolboxServiceClient.GetEndpointAddress(EndpointConfiguration.ToolboxServiceImplPort);
        }
        
        public enum EndpointConfiguration
        {
            
            ToolboxServiceImplPort,
        }
    }
}