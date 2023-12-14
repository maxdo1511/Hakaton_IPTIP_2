// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/auth.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace EmailCore.Services {
  public static partial class Auth
  {
    static readonly string __ServiceName = "auth.Auth";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.SignUpRequest> __Marshaller_auth_SignUpRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.SignUpRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.SignUpReply> __Marshaller_auth_SignUpReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.SignUpReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.AuthRequest> __Marshaller_auth_AuthRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.AuthRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.AuthReply> __Marshaller_auth_AuthReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.AuthReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.ConfirmRequest> __Marshaller_auth_ConfirmRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.ConfirmRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.ConfirmReply> __Marshaller_auth_ConfirmReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.ConfirmReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.CreateConfRequest> __Marshaller_auth_CreateConfRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.CreateConfRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.CreateConfReply> __Marshaller_auth_CreateConfReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.CreateConfReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.BasicGetRequest> __Marshaller_auth_BasicGetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.BasicGetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.BasicGetReply> __Marshaller_auth_BasicGetReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.BasicGetReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.VerifyKeyRequest> __Marshaller_auth_VerifyKeyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.VerifyKeyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.VerifyKeyReply> __Marshaller_auth_VerifyKeyReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.VerifyKeyReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.RecoveryRequest> __Marshaller_auth_RecoveryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.RecoveryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::EmailCore.Services.RecoveryReply> __Marshaller_auth_RecoveryReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::EmailCore.Services.RecoveryReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.SignUpRequest, global::EmailCore.Services.SignUpReply> __Method_SignUp = new grpc::Method<global::EmailCore.Services.SignUpRequest, global::EmailCore.Services.SignUpReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SignUp",
        __Marshaller_auth_SignUpRequest,
        __Marshaller_auth_SignUpReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.AuthRequest, global::EmailCore.Services.AuthReply> __Method_Auth = new grpc::Method<global::EmailCore.Services.AuthRequest, global::EmailCore.Services.AuthReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Auth",
        __Marshaller_auth_AuthRequest,
        __Marshaller_auth_AuthReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.ConfirmRequest, global::EmailCore.Services.ConfirmReply> __Method_Confirm = new grpc::Method<global::EmailCore.Services.ConfirmRequest, global::EmailCore.Services.ConfirmReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Confirm",
        __Marshaller_auth_ConfirmRequest,
        __Marshaller_auth_ConfirmReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.CreateConfRequest, global::EmailCore.Services.CreateConfReply> __Method_CreateConfirmation = new grpc::Method<global::EmailCore.Services.CreateConfRequest, global::EmailCore.Services.CreateConfReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateConfirmation",
        __Marshaller_auth_CreateConfRequest,
        __Marshaller_auth_CreateConfReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.BasicGetRequest, global::EmailCore.Services.BasicGetReply> __Method_GetEmail = new grpc::Method<global::EmailCore.Services.BasicGetRequest, global::EmailCore.Services.BasicGetReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetEmail",
        __Marshaller_auth_BasicGetRequest,
        __Marshaller_auth_BasicGetReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.BasicGetRequest, global::EmailCore.Services.BasicGetReply> __Method_GetRole = new grpc::Method<global::EmailCore.Services.BasicGetRequest, global::EmailCore.Services.BasicGetReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRole",
        __Marshaller_auth_BasicGetRequest,
        __Marshaller_auth_BasicGetReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.VerifyKeyRequest, global::EmailCore.Services.VerifyKeyReply> __Method_VerifyKey = new grpc::Method<global::EmailCore.Services.VerifyKeyRequest, global::EmailCore.Services.VerifyKeyReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "VerifyKey",
        __Marshaller_auth_VerifyKeyRequest,
        __Marshaller_auth_VerifyKeyReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::EmailCore.Services.RecoveryRequest, global::EmailCore.Services.RecoveryReply> __Method_RecoveryPassword = new grpc::Method<global::EmailCore.Services.RecoveryRequest, global::EmailCore.Services.RecoveryReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RecoveryPassword",
        __Marshaller_auth_RecoveryRequest,
        __Marshaller_auth_RecoveryReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::EmailCore.Services.AuthReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Auth</summary>
    [grpc::BindServiceMethod(typeof(Auth), "BindService")]
    public abstract partial class AuthBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.SignUpReply> SignUp(global::EmailCore.Services.SignUpRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.AuthReply> Auth(global::EmailCore.Services.AuthRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.ConfirmReply> Confirm(global::EmailCore.Services.ConfirmRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.CreateConfReply> CreateConfirmation(global::EmailCore.Services.CreateConfRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.BasicGetReply> GetEmail(global::EmailCore.Services.BasicGetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.BasicGetReply> GetRole(global::EmailCore.Services.BasicGetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.VerifyKeyReply> VerifyKey(global::EmailCore.Services.VerifyKeyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::EmailCore.Services.RecoveryReply> RecoveryPassword(global::EmailCore.Services.RecoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Auth</summary>
    public partial class AuthClient : grpc::ClientBase<AuthClient>
    {
      /// <summary>Creates a new client for Auth</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AuthClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Auth that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AuthClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AuthClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AuthClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.SignUpReply SignUp(global::EmailCore.Services.SignUpRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignUp(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.SignUpReply SignUp(global::EmailCore.Services.SignUpRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SignUp, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.SignUpReply> SignUpAsync(global::EmailCore.Services.SignUpRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignUpAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.SignUpReply> SignUpAsync(global::EmailCore.Services.SignUpRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SignUp, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.AuthReply Auth(global::EmailCore.Services.AuthRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Auth(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.AuthReply Auth(global::EmailCore.Services.AuthRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Auth, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.AuthReply> AuthAsync(global::EmailCore.Services.AuthRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AuthAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.AuthReply> AuthAsync(global::EmailCore.Services.AuthRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Auth, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.ConfirmReply Confirm(global::EmailCore.Services.ConfirmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Confirm(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.ConfirmReply Confirm(global::EmailCore.Services.ConfirmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Confirm, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.ConfirmReply> ConfirmAsync(global::EmailCore.Services.ConfirmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConfirmAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.ConfirmReply> ConfirmAsync(global::EmailCore.Services.ConfirmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Confirm, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.CreateConfReply CreateConfirmation(global::EmailCore.Services.CreateConfRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateConfirmation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.CreateConfReply CreateConfirmation(global::EmailCore.Services.CreateConfRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateConfirmation, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.CreateConfReply> CreateConfirmationAsync(global::EmailCore.Services.CreateConfRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateConfirmationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.CreateConfReply> CreateConfirmationAsync(global::EmailCore.Services.CreateConfRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateConfirmation, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.BasicGetReply GetEmail(global::EmailCore.Services.BasicGetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmail(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.BasicGetReply GetEmail(global::EmailCore.Services.BasicGetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetEmail, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.BasicGetReply> GetEmailAsync(global::EmailCore.Services.BasicGetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmailAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.BasicGetReply> GetEmailAsync(global::EmailCore.Services.BasicGetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetEmail, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.BasicGetReply GetRole(global::EmailCore.Services.BasicGetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.BasicGetReply GetRole(global::EmailCore.Services.BasicGetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRole, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.BasicGetReply> GetRoleAsync(global::EmailCore.Services.BasicGetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRoleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.BasicGetReply> GetRoleAsync(global::EmailCore.Services.BasicGetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRole, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.VerifyKeyReply VerifyKey(global::EmailCore.Services.VerifyKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerifyKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.VerifyKeyReply VerifyKey(global::EmailCore.Services.VerifyKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_VerifyKey, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.VerifyKeyReply> VerifyKeyAsync(global::EmailCore.Services.VerifyKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return VerifyKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.VerifyKeyReply> VerifyKeyAsync(global::EmailCore.Services.VerifyKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_VerifyKey, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.RecoveryReply RecoveryPassword(global::EmailCore.Services.RecoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecoveryPassword(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::EmailCore.Services.RecoveryReply RecoveryPassword(global::EmailCore.Services.RecoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RecoveryPassword, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.RecoveryReply> RecoveryPasswordAsync(global::EmailCore.Services.RecoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecoveryPasswordAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::EmailCore.Services.RecoveryReply> RecoveryPasswordAsync(global::EmailCore.Services.RecoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RecoveryPassword, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AuthClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AuthClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AuthBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SignUp, serviceImpl.SignUp)
          .AddMethod(__Method_Auth, serviceImpl.Auth)
          .AddMethod(__Method_Confirm, serviceImpl.Confirm)
          .AddMethod(__Method_CreateConfirmation, serviceImpl.CreateConfirmation)
          .AddMethod(__Method_GetEmail, serviceImpl.GetEmail)
          .AddMethod(__Method_GetRole, serviceImpl.GetRole)
          .AddMethod(__Method_VerifyKey, serviceImpl.VerifyKey)
          .AddMethod(__Method_RecoveryPassword, serviceImpl.RecoveryPassword).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AuthBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SignUp, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.SignUpRequest, global::EmailCore.Services.SignUpReply>(serviceImpl.SignUp));
      serviceBinder.AddMethod(__Method_Auth, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.AuthRequest, global::EmailCore.Services.AuthReply>(serviceImpl.Auth));
      serviceBinder.AddMethod(__Method_Confirm, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.ConfirmRequest, global::EmailCore.Services.ConfirmReply>(serviceImpl.Confirm));
      serviceBinder.AddMethod(__Method_CreateConfirmation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.CreateConfRequest, global::EmailCore.Services.CreateConfReply>(serviceImpl.CreateConfirmation));
      serviceBinder.AddMethod(__Method_GetEmail, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.BasicGetRequest, global::EmailCore.Services.BasicGetReply>(serviceImpl.GetEmail));
      serviceBinder.AddMethod(__Method_GetRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.BasicGetRequest, global::EmailCore.Services.BasicGetReply>(serviceImpl.GetRole));
      serviceBinder.AddMethod(__Method_VerifyKey, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.VerifyKeyRequest, global::EmailCore.Services.VerifyKeyReply>(serviceImpl.VerifyKey));
      serviceBinder.AddMethod(__Method_RecoveryPassword, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EmailCore.Services.RecoveryRequest, global::EmailCore.Services.RecoveryReply>(serviceImpl.RecoveryPassword));
    }

  }
}
#endregion