﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NETConverter.Domain.ConvertService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", ConfigurationName="ConvertService.ConvertServiceSoap")]
    public interface ConvertServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://developer.sharpdevelop.net/CodeConverter.NET/PerformConversion", ReplyAction="*")]
        NETConverter.Domain.ConvertService.PerformConversionResponse PerformConversion(NETConverter.Domain.ConvertService.PerformConversionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://developer.sharpdevelop.net/CodeConverter.NET/PerformConversion", ReplyAction="*")]
        System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.PerformConversionResponse> PerformConversionAsync(NETConverter.Domain.ConvertService.PerformConversionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://developer.sharpdevelop.net/CodeConverter.NET/Convert", ReplyAction="*")]
        NETConverter.Domain.ConvertService.ConvertResponse Convert(NETConverter.Domain.ConvertService.ConvertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://developer.sharpdevelop.net/CodeConverter.NET/Convert", ReplyAction="*")]
        System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.ConvertResponse> ConvertAsync(NETConverter.Domain.ConvertService.ConvertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://developer.sharpdevelop.net/CodeConverter.NET/ConvertSnippet", ReplyAction="*")]
        NETConverter.Domain.ConvertService.ConvertSnippetResponse ConvertSnippet(NETConverter.Domain.ConvertService.ConvertSnippetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://developer.sharpdevelop.net/CodeConverter.NET/ConvertSnippet", ReplyAction="*")]
        System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.ConvertSnippetResponse> ConvertSnippetAsync(NETConverter.Domain.ConvertService.ConvertSnippetRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PerformConversionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PerformConversion", Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", Order=0)]
        public NETConverter.Domain.ConvertService.PerformConversionRequestBody Body;
        
        public PerformConversionRequest() {
        }
        
        public PerformConversionRequest(NETConverter.Domain.ConvertService.PerformConversionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/")]
    public partial class PerformConversionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TypeOfConversion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string SourceCode;
        
        public PerformConversionRequestBody() {
        }
        
        public PerformConversionRequestBody(string TypeOfConversion, string SourceCode) {
            this.TypeOfConversion = TypeOfConversion;
            this.SourceCode = SourceCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PerformConversionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PerformConversionResponse", Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", Order=0)]
        public NETConverter.Domain.ConvertService.PerformConversionResponseBody Body;
        
        public PerformConversionResponse() {
        }
        
        public PerformConversionResponse(NETConverter.Domain.ConvertService.PerformConversionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/")]
    public partial class PerformConversionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool PerformConversionResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ConvertedCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ErrorMessage;
        
        public PerformConversionResponseBody() {
        }
        
        public PerformConversionResponseBody(bool PerformConversionResult, string ConvertedCode, string ErrorMessage) {
            this.PerformConversionResult = PerformConversionResult;
            this.ConvertedCode = ConvertedCode;
            this.ErrorMessage = ErrorMessage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Convert", Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", Order=0)]
        public NETConverter.Domain.ConvertService.ConvertRequestBody Body;
        
        public ConvertRequest() {
        }
        
        public ConvertRequest(NETConverter.Domain.ConvertService.ConvertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/")]
    public partial class ConvertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TypeOfConversion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string SourceCode;
        
        public ConvertRequestBody() {
        }
        
        public ConvertRequestBody(string TypeOfConversion, string SourceCode) {
            this.TypeOfConversion = TypeOfConversion;
            this.SourceCode = SourceCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertResponse", Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", Order=0)]
        public NETConverter.Domain.ConvertService.ConvertResponseBody Body;
        
        public ConvertResponse() {
        }
        
        public ConvertResponse(NETConverter.Domain.ConvertService.ConvertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/")]
    public partial class ConvertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ConvertResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ConvertedCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ErrorMessage;
        
        public ConvertResponseBody() {
        }
        
        public ConvertResponseBody(bool ConvertResult, string ConvertedCode, string ErrorMessage) {
            this.ConvertResult = ConvertResult;
            this.ConvertedCode = ConvertedCode;
            this.ErrorMessage = ErrorMessage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertSnippetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertSnippet", Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", Order=0)]
        public NETConverter.Domain.ConvertService.ConvertSnippetRequestBody Body;
        
        public ConvertSnippetRequest() {
        }
        
        public ConvertSnippetRequest(NETConverter.Domain.ConvertService.ConvertSnippetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/")]
    public partial class ConvertSnippetRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TypeOfConversion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string SourceCode;
        
        public ConvertSnippetRequestBody() {
        }
        
        public ConvertSnippetRequestBody(string TypeOfConversion, string SourceCode) {
            this.TypeOfConversion = TypeOfConversion;
            this.SourceCode = SourceCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertSnippetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertSnippetResponse", Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/", Order=0)]
        public NETConverter.Domain.ConvertService.ConvertSnippetResponseBody Body;
        
        public ConvertSnippetResponse() {
        }
        
        public ConvertSnippetResponse(NETConverter.Domain.ConvertService.ConvertSnippetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://developer.sharpdevelop.net/CodeConverter.NET/")]
    public partial class ConvertSnippetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ConvertSnippetResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string ConvertedCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ErrorMessage;
        
        public ConvertSnippetResponseBody() {
        }
        
        public ConvertSnippetResponseBody(bool ConvertSnippetResult, string ConvertedCode, string ErrorMessage) {
            this.ConvertSnippetResult = ConvertSnippetResult;
            this.ConvertedCode = ConvertedCode;
            this.ErrorMessage = ErrorMessage;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConvertServiceSoapChannel : NETConverter.Domain.ConvertService.ConvertServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConvertServiceSoapClient : System.ServiceModel.ClientBase<NETConverter.Domain.ConvertService.ConvertServiceSoap>, NETConverter.Domain.ConvertService.ConvertServiceSoap {
        
        public ConvertServiceSoapClient() {
        }
        
        public ConvertServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConvertServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NETConverter.Domain.ConvertService.PerformConversionResponse NETConverter.Domain.ConvertService.ConvertServiceSoap.PerformConversion(NETConverter.Domain.ConvertService.PerformConversionRequest request) {
            return base.Channel.PerformConversion(request);
        }
        
        public bool PerformConversion(string TypeOfConversion, string SourceCode, out string ConvertedCode, out string ErrorMessage) {
            NETConverter.Domain.ConvertService.PerformConversionRequest inValue = new NETConverter.Domain.ConvertService.PerformConversionRequest();
            inValue.Body = new NETConverter.Domain.ConvertService.PerformConversionRequestBody();
            inValue.Body.TypeOfConversion = TypeOfConversion;
            inValue.Body.SourceCode = SourceCode;
            NETConverter.Domain.ConvertService.PerformConversionResponse retVal = ((NETConverter.Domain.ConvertService.ConvertServiceSoap)(this)).PerformConversion(inValue);
            ConvertedCode = retVal.Body.ConvertedCode;
            ErrorMessage = retVal.Body.ErrorMessage;
            return retVal.Body.PerformConversionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.PerformConversionResponse> NETConverter.Domain.ConvertService.ConvertServiceSoap.PerformConversionAsync(NETConverter.Domain.ConvertService.PerformConversionRequest request) {
            return base.Channel.PerformConversionAsync(request);
        }
        
        public System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.PerformConversionResponse> PerformConversionAsync(string TypeOfConversion, string SourceCode) {
            NETConverter.Domain.ConvertService.PerformConversionRequest inValue = new NETConverter.Domain.ConvertService.PerformConversionRequest();
            inValue.Body = new NETConverter.Domain.ConvertService.PerformConversionRequestBody();
            inValue.Body.TypeOfConversion = TypeOfConversion;
            inValue.Body.SourceCode = SourceCode;
            return ((NETConverter.Domain.ConvertService.ConvertServiceSoap)(this)).PerformConversionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NETConverter.Domain.ConvertService.ConvertResponse NETConverter.Domain.ConvertService.ConvertServiceSoap.Convert(NETConverter.Domain.ConvertService.ConvertRequest request) {
            return base.Channel.Convert(request);
        }
        
        public bool Convert(string TypeOfConversion, string SourceCode, out string ConvertedCode, out string ErrorMessage) {
            NETConverter.Domain.ConvertService.ConvertRequest inValue = new NETConverter.Domain.ConvertService.ConvertRequest();
            inValue.Body = new NETConverter.Domain.ConvertService.ConvertRequestBody();
            inValue.Body.TypeOfConversion = TypeOfConversion;
            inValue.Body.SourceCode = SourceCode;
            NETConverter.Domain.ConvertService.ConvertResponse retVal = ((NETConverter.Domain.ConvertService.ConvertServiceSoap)(this)).Convert(inValue);
            ConvertedCode = retVal.Body.ConvertedCode;
            ErrorMessage = retVal.Body.ErrorMessage;
            return retVal.Body.ConvertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.ConvertResponse> NETConverter.Domain.ConvertService.ConvertServiceSoap.ConvertAsync(NETConverter.Domain.ConvertService.ConvertRequest request) {
            return base.Channel.ConvertAsync(request);
        }
        
        public System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.ConvertResponse> ConvertAsync(string TypeOfConversion, string SourceCode) {
            NETConverter.Domain.ConvertService.ConvertRequest inValue = new NETConverter.Domain.ConvertService.ConvertRequest();
            inValue.Body = new NETConverter.Domain.ConvertService.ConvertRequestBody();
            inValue.Body.TypeOfConversion = TypeOfConversion;
            inValue.Body.SourceCode = SourceCode;
            return ((NETConverter.Domain.ConvertService.ConvertServiceSoap)(this)).ConvertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NETConverter.Domain.ConvertService.ConvertSnippetResponse NETConverter.Domain.ConvertService.ConvertServiceSoap.ConvertSnippet(NETConverter.Domain.ConvertService.ConvertSnippetRequest request) {
            return base.Channel.ConvertSnippet(request);
        }
        
        public bool ConvertSnippet(string TypeOfConversion, string SourceCode, out string ConvertedCode, out string ErrorMessage) {
            NETConverter.Domain.ConvertService.ConvertSnippetRequest inValue = new NETConverter.Domain.ConvertService.ConvertSnippetRequest();
            inValue.Body = new NETConverter.Domain.ConvertService.ConvertSnippetRequestBody();
            inValue.Body.TypeOfConversion = TypeOfConversion;
            inValue.Body.SourceCode = SourceCode;
            NETConverter.Domain.ConvertService.ConvertSnippetResponse retVal = ((NETConverter.Domain.ConvertService.ConvertServiceSoap)(this)).ConvertSnippet(inValue);
            ConvertedCode = retVal.Body.ConvertedCode;
            ErrorMessage = retVal.Body.ErrorMessage;
            return retVal.Body.ConvertSnippetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.ConvertSnippetResponse> NETConverter.Domain.ConvertService.ConvertServiceSoap.ConvertSnippetAsync(NETConverter.Domain.ConvertService.ConvertSnippetRequest request) {
            return base.Channel.ConvertSnippetAsync(request);
        }
        
        public System.Threading.Tasks.Task<NETConverter.Domain.ConvertService.ConvertSnippetResponse> ConvertSnippetAsync(string TypeOfConversion, string SourceCode) {
            NETConverter.Domain.ConvertService.ConvertSnippetRequest inValue = new NETConverter.Domain.ConvertService.ConvertSnippetRequest();
            inValue.Body = new NETConverter.Domain.ConvertService.ConvertSnippetRequestBody();
            inValue.Body.TypeOfConversion = TypeOfConversion;
            inValue.Body.SourceCode = SourceCode;
            return ((NETConverter.Domain.ConvertService.ConvertServiceSoap)(this)).ConvertSnippetAsync(inValue);
        }
    }
}
