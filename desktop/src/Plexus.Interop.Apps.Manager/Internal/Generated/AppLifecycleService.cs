/**
 * Copyright 2017 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: interop/AppLifecycleService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Apps.Internal.Generated {

  /// <summary>Holder for reflection information generated from interop/AppLifecycleService.proto</summary>
  internal static partial class AppLifecycleServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/AppLifecycleService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppLifecycleServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFpbnRlcm9wL0FwcExpZmVjeWNsZVNlcnZpY2UucHJvdG8SB2ludGVyb3Aa",
            "FmludGVyb3AvVW5pcXVlSWQucHJvdG8aFWludGVyb3AvT3B0aW9ucy5wcm90",
            "byJEChJBY3RpdmF0ZUFwcFJlcXVlc3QSDgoGYXBwX2lkGAEgASgJOh6S2wQa",
            "aW50ZXJvcC5BY3RpdmF0ZUFwcFJlcXVlc3QikAEKE0FjdGl2YXRlQXBwUmVz",
            "cG9uc2USKgoPYXBwX2luc3RhbmNlX2lkGAEgASgLMhEuaW50ZXJvcC5Vbmlx",
            "dWVJZBIsChFhcHBfY29ubmVjdGlvbl9pZBgCIAEoCzIRLmludGVyb3AuVW5p",
            "cXVlSWQ6H5LbBBtpbnRlcm9wLkFjdGl2YXRlQXBwUmVzcG9uc2UygAEKE0Fw",
            "cExpZmVjeWNsZVNlcnZpY2USSAoLQWN0aXZhdGVBcHASGy5pbnRlcm9wLkFj",
            "dGl2YXRlQXBwUmVxdWVzdBocLmludGVyb3AuQWN0aXZhdGVBcHBSZXNwb25z",
            "ZRofmtsEG2ludGVyb3AuQXBwTGlmZWN5Y2xlU2VydmljZUIpqgImUGxleHVz",
            "LkludGVyb3AuQXBwcy5JbnRlcm5hbC5HZW5lcmF0ZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Apps.Internal.Generated.UniqueIdReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.ActivateAppRequest), global::Plexus.Interop.Apps.Internal.Generated.ActivateAppRequest.Parser, new[]{ "AppId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.ActivateAppResponse), global::Plexus.Interop.Apps.Internal.Generated.ActivateAppResponse.Parser, new[]{ "AppInstanceId", "AppConnectionId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ActivateAppRequest : pb::IMessage<ActivateAppRequest> {
    private static readonly pb::MessageParser<ActivateAppRequest> _parser = new pb::MessageParser<ActivateAppRequest>(() => new ActivateAppRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ActivateAppRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActivateAppRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActivateAppRequest(ActivateAppRequest other) : this() {
      appId_ = other.appId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActivateAppRequest Clone() {
      return new ActivateAppRequest(this);
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 1;
    private string appId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppId {
      get { return appId_; }
      set {
        appId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ActivateAppRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ActivateAppRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppId != other.AppId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AppId.Length != 0) hash ^= AppId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AppId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AppId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ActivateAppRequest other) {
      if (other == null) {
        return;
      }
      if (other.AppId.Length != 0) {
        AppId = other.AppId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            AppId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ActivateAppResponse : pb::IMessage<ActivateAppResponse> {
    private static readonly pb::MessageParser<ActivateAppResponse> _parser = new pb::MessageParser<ActivateAppResponse>(() => new ActivateAppResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ActivateAppResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActivateAppResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActivateAppResponse(ActivateAppResponse other) : this() {
      AppInstanceId = other.appInstanceId_ != null ? other.AppInstanceId.Clone() : null;
      AppConnectionId = other.appConnectionId_ != null ? other.AppConnectionId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ActivateAppResponse Clone() {
      return new ActivateAppResponse(this);
    }

    /// <summary>Field number for the "app_instance_id" field.</summary>
    public const int AppInstanceIdFieldNumber = 1;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appInstanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppInstanceId {
      get { return appInstanceId_; }
      set {
        appInstanceId_ = value;
      }
    }

    /// <summary>Field number for the "app_connection_id" field.</summary>
    public const int AppConnectionIdFieldNumber = 2;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appConnectionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppConnectionId {
      get { return appConnectionId_; }
      set {
        appConnectionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ActivateAppResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ActivateAppResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AppInstanceId, other.AppInstanceId)) return false;
      if (!object.Equals(AppConnectionId, other.AppConnectionId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (appInstanceId_ != null) hash ^= AppInstanceId.GetHashCode();
      if (appConnectionId_ != null) hash ^= AppConnectionId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (appInstanceId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AppInstanceId);
      }
      if (appConnectionId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppConnectionId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (appInstanceId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppInstanceId);
      }
      if (appConnectionId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppConnectionId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ActivateAppResponse other) {
      if (other == null) {
        return;
      }
      if (other.appInstanceId_ != null) {
        if (appInstanceId_ == null) {
          appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppInstanceId.MergeFrom(other.AppInstanceId);
      }
      if (other.appConnectionId_ != null) {
        if (appConnectionId_ == null) {
          appConnectionId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppConnectionId.MergeFrom(other.AppConnectionId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (appInstanceId_ == null) {
              appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appInstanceId_);
            break;
          }
          case 18: {
            if (appConnectionId_ == null) {
              appConnectionId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appConnectionId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
