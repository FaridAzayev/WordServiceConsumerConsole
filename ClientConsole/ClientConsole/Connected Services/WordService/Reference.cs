﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsole.WordService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WordService.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClientConsole.WordService.HelloWorldResponse HelloWorld(ClientConsole.WordService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientConsole.WordService.HelloWorldResponse> HelloWorldAsync(ClientConsole.WordService.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name initial from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReverseWord", ReplyAction="*")]
        ClientConsole.WordService.ReverseWordResponse ReverseWord(ClientConsole.WordService.ReverseWordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReverseWord", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientConsole.WordService.ReverseWordResponse> ReverseWordAsync(ClientConsole.WordService.ReverseWordRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClientConsole.WordService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClientConsole.WordService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientConsole.WordService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClientConsole.WordService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseWordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseWord", Namespace="http://tempuri.org/", Order=0)]
        public ClientConsole.WordService.ReverseWordRequestBody Body;
        
        public ReverseWordRequest() {
        }
        
        public ReverseWordRequest(ClientConsole.WordService.ReverseWordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReverseWordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string initial;
        
        public ReverseWordRequestBody() {
        }
        
        public ReverseWordRequestBody(string initial) {
            this.initial = initial;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseWordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseWordResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientConsole.WordService.ReverseWordResponseBody Body;
        
        public ReverseWordResponse() {
        }
        
        public ReverseWordResponse(ClientConsole.WordService.ReverseWordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReverseWordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ReverseWordResult;
        
        public ReverseWordResponseBody() {
        }
        
        public ReverseWordResponseBody(string ReverseWordResult) {
            this.ReverseWordResult = ReverseWordResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ClientConsole.WordService.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ClientConsole.WordService.WebServiceSoap>, ClientConsole.WordService.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientConsole.WordService.HelloWorldResponse ClientConsole.WordService.WebServiceSoap.HelloWorld(ClientConsole.WordService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClientConsole.WordService.HelloWorldRequest inValue = new ClientConsole.WordService.HelloWorldRequest();
            inValue.Body = new ClientConsole.WordService.HelloWorldRequestBody();
            ClientConsole.WordService.HelloWorldResponse retVal = ((ClientConsole.WordService.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientConsole.WordService.HelloWorldResponse> ClientConsole.WordService.WebServiceSoap.HelloWorldAsync(ClientConsole.WordService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientConsole.WordService.HelloWorldResponse> HelloWorldAsync() {
            ClientConsole.WordService.HelloWorldRequest inValue = new ClientConsole.WordService.HelloWorldRequest();
            inValue.Body = new ClientConsole.WordService.HelloWorldRequestBody();
            return ((ClientConsole.WordService.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientConsole.WordService.ReverseWordResponse ClientConsole.WordService.WebServiceSoap.ReverseWord(ClientConsole.WordService.ReverseWordRequest request) {
            return base.Channel.ReverseWord(request);
        }
        
        public string ReverseWord(string initial) {
            ClientConsole.WordService.ReverseWordRequest inValue = new ClientConsole.WordService.ReverseWordRequest();
            inValue.Body = new ClientConsole.WordService.ReverseWordRequestBody();
            inValue.Body.initial = initial;
            ClientConsole.WordService.ReverseWordResponse retVal = ((ClientConsole.WordService.WebServiceSoap)(this)).ReverseWord(inValue);
            return retVal.Body.ReverseWordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientConsole.WordService.ReverseWordResponse> ClientConsole.WordService.WebServiceSoap.ReverseWordAsync(ClientConsole.WordService.ReverseWordRequest request) {
            return base.Channel.ReverseWordAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientConsole.WordService.ReverseWordResponse> ReverseWordAsync(string initial) {
            ClientConsole.WordService.ReverseWordRequest inValue = new ClientConsole.WordService.ReverseWordRequest();
            inValue.Body = new ClientConsole.WordService.ReverseWordRequestBody();
            inValue.Body.initial = initial;
            return ((ClientConsole.WordService.WebServiceSoap)(this)).ReverseWordAsync(inValue);
        }
    }
}
