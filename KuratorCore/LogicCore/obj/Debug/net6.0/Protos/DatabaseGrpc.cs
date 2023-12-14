// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/database.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace LogicCore.Communicators {
  public static partial class DatabaseCore
  {
    static readonly string __ServiceName = "database.DatabaseCore";

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
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetAllUsersRequest> __Marshaller_database_GetAllUsersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetAllUsersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetAllUsersResponse> __Marshaller_database_GetAllUsersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetAllUsersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetCuratorRequest> __Marshaller_database_GetCuratorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetCuratorRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetCuratorResponse> __Marshaller_database_GetCuratorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetCuratorResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetCuratorsByRoleRequest> __Marshaller_database_GetCuratorsByRoleRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetCuratorsByRoleRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetCuratorsByRoleResponse> __Marshaller_database_GetCuratorsByRoleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetCuratorsByRoleResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetSortedCuratorsRequest> __Marshaller_database_GetSortedCuratorsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetSortedCuratorsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetSortedCuratorsResponse> __Marshaller_database_GetSortedCuratorsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetSortedCuratorsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.AddCuratorRequest> __Marshaller_database_AddCuratorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.AddCuratorRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.AddCuratorResponse> __Marshaller_database_AddCuratorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.AddCuratorResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.AddMireaTokenRequest> __Marshaller_database_AddMireaTokenRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.AddMireaTokenRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.AddMireaTokenResponse> __Marshaller_database_AddMireaTokenResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.AddMireaTokenResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetMireaTokenRequest> __Marshaller_database_GetMireaTokenRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetMireaTokenRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LogicCore.Communicators.GetMireaTokenResponse> __Marshaller_database_GetMireaTokenResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LogicCore.Communicators.GetMireaTokenResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.GetAllUsersRequest, global::LogicCore.Communicators.GetAllUsersResponse> __Method_GetAllUsers = new grpc::Method<global::LogicCore.Communicators.GetAllUsersRequest, global::LogicCore.Communicators.GetAllUsersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllUsers",
        __Marshaller_database_GetAllUsersRequest,
        __Marshaller_database_GetAllUsersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.GetCuratorRequest, global::LogicCore.Communicators.GetCuratorResponse> __Method_GetCurator = new grpc::Method<global::LogicCore.Communicators.GetCuratorRequest, global::LogicCore.Communicators.GetCuratorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCurator",
        __Marshaller_database_GetCuratorRequest,
        __Marshaller_database_GetCuratorResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.GetCuratorsByRoleRequest, global::LogicCore.Communicators.GetCuratorsByRoleResponse> __Method_GetCuratorsByRole = new grpc::Method<global::LogicCore.Communicators.GetCuratorsByRoleRequest, global::LogicCore.Communicators.GetCuratorsByRoleResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCuratorsByRole",
        __Marshaller_database_GetCuratorsByRoleRequest,
        __Marshaller_database_GetCuratorsByRoleResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.GetSortedCuratorsRequest, global::LogicCore.Communicators.GetSortedCuratorsResponse> __Method_GetSortedCurators = new grpc::Method<global::LogicCore.Communicators.GetSortedCuratorsRequest, global::LogicCore.Communicators.GetSortedCuratorsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSortedCurators",
        __Marshaller_database_GetSortedCuratorsRequest,
        __Marshaller_database_GetSortedCuratorsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.AddCuratorRequest, global::LogicCore.Communicators.AddCuratorResponse> __Method_AddCurator = new grpc::Method<global::LogicCore.Communicators.AddCuratorRequest, global::LogicCore.Communicators.AddCuratorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCurator",
        __Marshaller_database_AddCuratorRequest,
        __Marshaller_database_AddCuratorResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.AddMireaTokenRequest, global::LogicCore.Communicators.AddMireaTokenResponse> __Method_AddMireaToken = new grpc::Method<global::LogicCore.Communicators.AddMireaTokenRequest, global::LogicCore.Communicators.AddMireaTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddMireaToken",
        __Marshaller_database_AddMireaTokenRequest,
        __Marshaller_database_AddMireaTokenResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LogicCore.Communicators.GetMireaTokenRequest, global::LogicCore.Communicators.GetMireaTokenResponse> __Method_GetMireaToken = new grpc::Method<global::LogicCore.Communicators.GetMireaTokenRequest, global::LogicCore.Communicators.GetMireaTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMireaToken",
        __Marshaller_database_GetMireaTokenRequest,
        __Marshaller_database_GetMireaTokenResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::LogicCore.Communicators.DatabaseReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DatabaseCore</summary>
    [grpc::BindServiceMethod(typeof(DatabaseCore), "BindService")]
    public abstract partial class DatabaseCoreBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.GetAllUsersResponse> GetAllUsers(global::LogicCore.Communicators.GetAllUsersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.GetCuratorResponse> GetCurator(global::LogicCore.Communicators.GetCuratorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.GetCuratorsByRoleResponse> GetCuratorsByRole(global::LogicCore.Communicators.GetCuratorsByRoleRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.GetSortedCuratorsResponse> GetSortedCurators(global::LogicCore.Communicators.GetSortedCuratorsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.AddCuratorResponse> AddCurator(global::LogicCore.Communicators.AddCuratorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.AddMireaTokenResponse> AddMireaToken(global::LogicCore.Communicators.AddMireaTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LogicCore.Communicators.GetMireaTokenResponse> GetMireaToken(global::LogicCore.Communicators.GetMireaTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DatabaseCore</summary>
    public partial class DatabaseCoreClient : grpc::ClientBase<DatabaseCoreClient>
    {
      /// <summary>Creates a new client for DatabaseCore</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DatabaseCoreClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DatabaseCore that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public DatabaseCoreClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DatabaseCoreClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected DatabaseCoreClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetAllUsersResponse GetAllUsers(global::LogicCore.Communicators.GetAllUsersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllUsers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetAllUsersResponse GetAllUsers(global::LogicCore.Communicators.GetAllUsersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllUsers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetAllUsersResponse> GetAllUsersAsync(global::LogicCore.Communicators.GetAllUsersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllUsersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetAllUsersResponse> GetAllUsersAsync(global::LogicCore.Communicators.GetAllUsersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllUsers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetCuratorResponse GetCurator(global::LogicCore.Communicators.GetCuratorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCurator(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetCuratorResponse GetCurator(global::LogicCore.Communicators.GetCuratorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCurator, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetCuratorResponse> GetCuratorAsync(global::LogicCore.Communicators.GetCuratorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCuratorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetCuratorResponse> GetCuratorAsync(global::LogicCore.Communicators.GetCuratorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCurator, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetCuratorsByRoleResponse GetCuratorsByRole(global::LogicCore.Communicators.GetCuratorsByRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCuratorsByRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetCuratorsByRoleResponse GetCuratorsByRole(global::LogicCore.Communicators.GetCuratorsByRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCuratorsByRole, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetCuratorsByRoleResponse> GetCuratorsByRoleAsync(global::LogicCore.Communicators.GetCuratorsByRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCuratorsByRoleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetCuratorsByRoleResponse> GetCuratorsByRoleAsync(global::LogicCore.Communicators.GetCuratorsByRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCuratorsByRole, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetSortedCuratorsResponse GetSortedCurators(global::LogicCore.Communicators.GetSortedCuratorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSortedCurators(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetSortedCuratorsResponse GetSortedCurators(global::LogicCore.Communicators.GetSortedCuratorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSortedCurators, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetSortedCuratorsResponse> GetSortedCuratorsAsync(global::LogicCore.Communicators.GetSortedCuratorsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSortedCuratorsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetSortedCuratorsResponse> GetSortedCuratorsAsync(global::LogicCore.Communicators.GetSortedCuratorsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSortedCurators, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.AddCuratorResponse AddCurator(global::LogicCore.Communicators.AddCuratorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddCurator(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.AddCuratorResponse AddCurator(global::LogicCore.Communicators.AddCuratorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddCurator, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.AddCuratorResponse> AddCuratorAsync(global::LogicCore.Communicators.AddCuratorRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddCuratorAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.AddCuratorResponse> AddCuratorAsync(global::LogicCore.Communicators.AddCuratorRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddCurator, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.AddMireaTokenResponse AddMireaToken(global::LogicCore.Communicators.AddMireaTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddMireaToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.AddMireaTokenResponse AddMireaToken(global::LogicCore.Communicators.AddMireaTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddMireaToken, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.AddMireaTokenResponse> AddMireaTokenAsync(global::LogicCore.Communicators.AddMireaTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddMireaTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.AddMireaTokenResponse> AddMireaTokenAsync(global::LogicCore.Communicators.AddMireaTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddMireaToken, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetMireaTokenResponse GetMireaToken(global::LogicCore.Communicators.GetMireaTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMireaToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::LogicCore.Communicators.GetMireaTokenResponse GetMireaToken(global::LogicCore.Communicators.GetMireaTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMireaToken, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetMireaTokenResponse> GetMireaTokenAsync(global::LogicCore.Communicators.GetMireaTokenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMireaTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::LogicCore.Communicators.GetMireaTokenResponse> GetMireaTokenAsync(global::LogicCore.Communicators.GetMireaTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMireaToken, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override DatabaseCoreClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DatabaseCoreClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(DatabaseCoreBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllUsers, serviceImpl.GetAllUsers)
          .AddMethod(__Method_GetCurator, serviceImpl.GetCurator)
          .AddMethod(__Method_GetCuratorsByRole, serviceImpl.GetCuratorsByRole)
          .AddMethod(__Method_GetSortedCurators, serviceImpl.GetSortedCurators)
          .AddMethod(__Method_AddCurator, serviceImpl.AddCurator)
          .AddMethod(__Method_AddMireaToken, serviceImpl.AddMireaToken)
          .AddMethod(__Method_GetMireaToken, serviceImpl.GetMireaToken).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DatabaseCoreBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllUsers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.GetAllUsersRequest, global::LogicCore.Communicators.GetAllUsersResponse>(serviceImpl.GetAllUsers));
      serviceBinder.AddMethod(__Method_GetCurator, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.GetCuratorRequest, global::LogicCore.Communicators.GetCuratorResponse>(serviceImpl.GetCurator));
      serviceBinder.AddMethod(__Method_GetCuratorsByRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.GetCuratorsByRoleRequest, global::LogicCore.Communicators.GetCuratorsByRoleResponse>(serviceImpl.GetCuratorsByRole));
      serviceBinder.AddMethod(__Method_GetSortedCurators, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.GetSortedCuratorsRequest, global::LogicCore.Communicators.GetSortedCuratorsResponse>(serviceImpl.GetSortedCurators));
      serviceBinder.AddMethod(__Method_AddCurator, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.AddCuratorRequest, global::LogicCore.Communicators.AddCuratorResponse>(serviceImpl.AddCurator));
      serviceBinder.AddMethod(__Method_AddMireaToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.AddMireaTokenRequest, global::LogicCore.Communicators.AddMireaTokenResponse>(serviceImpl.AddMireaToken));
      serviceBinder.AddMethod(__Method_GetMireaToken, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LogicCore.Communicators.GetMireaTokenRequest, global::LogicCore.Communicators.GetMireaTokenResponse>(serviceImpl.GetMireaToken));
    }

  }
}
#endregion
