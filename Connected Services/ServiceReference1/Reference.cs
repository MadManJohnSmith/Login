﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Login.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://CompLogin/", ConfigurationName="ServiceReference1.Auth")]
    public interface Auth {
        
        // CODEGEN: Generating message contract since element name username from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://CompLogin/Auth/validarUsuarioRequest", ReplyAction="http://CompLogin/Auth/validarUsuarioResponse")]
        Login.ServiceReference1.validarUsuarioResponse validarUsuario(Login.ServiceReference1.validarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CompLogin/Auth/validarUsuarioRequest", ReplyAction="http://CompLogin/Auth/validarUsuarioResponse")]
        System.Threading.Tasks.Task<Login.ServiceReference1.validarUsuarioResponse> validarUsuarioAsync(Login.ServiceReference1.validarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuario", Namespace="http://CompLogin/", Order=0)]
        public Login.ServiceReference1.validarUsuarioRequestBody Body;
        
        public validarUsuarioRequest() {
        }
        
        public validarUsuarioRequest(Login.ServiceReference1.validarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class validarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public validarUsuarioRequestBody() {
        }
        
        public validarUsuarioRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuarioResponse", Namespace="http://CompLogin/", Order=0)]
        public Login.ServiceReference1.validarUsuarioResponseBody Body;
        
        public validarUsuarioResponse() {
        }
        
        public validarUsuarioResponse(Login.ServiceReference1.validarUsuarioResponseBody Body) {
            this.Body = Body;
        }

        public static implicit operator bool(validarUsuarioResponse v)
        {
            throw new NotImplementedException();
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class validarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public validarUsuarioResponseBody() {
        }
        
        public validarUsuarioResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthChannel : Login.ServiceReference1.Auth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthClient : System.ServiceModel.ClientBase<Login.ServiceReference1.Auth>, Login.ServiceReference1.Auth {
        
        public AuthClient() {
        }
        
        public AuthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Login.ServiceReference1.validarUsuarioResponse Login.ServiceReference1.Auth.validarUsuario(Login.ServiceReference1.validarUsuarioRequest request) {
            return base.Channel.validarUsuario(request);
        }
        
        public bool validarUsuario(string username, string password) {
            Login.ServiceReference1.validarUsuarioRequest inValue = new Login.ServiceReference1.validarUsuarioRequest();
            inValue.Body = new Login.ServiceReference1.validarUsuarioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            Login.ServiceReference1.validarUsuarioResponse retVal = ((Login.ServiceReference1.Auth)(this)).validarUsuario(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Login.ServiceReference1.validarUsuarioResponse> Login.ServiceReference1.Auth.validarUsuarioAsync(Login.ServiceReference1.validarUsuarioRequest request) {
            return base.Channel.validarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<Login.ServiceReference1.validarUsuarioResponse> validarUsuarioAsync(string username, string password) {
            Login.ServiceReference1.validarUsuarioRequest inValue = new Login.ServiceReference1.validarUsuarioRequest();
            inValue.Body = new Login.ServiceReference1.validarUsuarioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((Login.ServiceReference1.Auth)(this)).validarUsuarioAsync(inValue);
        }
    }
}
