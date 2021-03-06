/**
 * Copyright 2017-2020 Plexus Interop Deutsche Bank AG
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
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fx/ccy_pair_rate_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Samples.CcyPairRateProvider.Generated {

  /// <summary>Holder for reflection information generated from fx/ccy_pair_rate_service.proto</summary>
  public static partial class CcyPairRateServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for fx/ccy_pair_rate_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CcyPairRateServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5meC9jY3lfcGFpcl9yYXRlX3NlcnZpY2UucHJvdG8SAmZ4GhVpbnRlcm9w",
            "L29wdGlvbnMucHJvdG8iMAoHQ2N5UGFpchIVCg1jY3lfcGFpcl9uYW1lGAEg",
            "ASgJOg6S2wQKZnguQ2N5UGFpciJGCgtDY3lQYWlyUmF0ZRIVCg1jY3lfcGFp",
            "cl9uYW1lGAEgASgJEgwKBHJhdGUYAiABKAE6EpLbBA5meC5DY3lQYWlyUmF0",
            "ZTJYChJDY3lQYWlyUmF0ZVNlcnZpY2USJwoHR2V0UmF0ZRILLmZ4LkNjeVBh",
            "aXIaDy5meC5DY3lQYWlyUmF0ZRoZktsEFWZ4LkNjeVBhaXJSYXRlU2Vydmlj",
            "ZUI3qgI0UGxleHVzLkludGVyb3AuU2FtcGxlcy5DY3lQYWlyUmF0ZVByb3Zp",
            "ZGVyLkdlbmVyYXRlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair), global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPair.Parser, new[]{ "CcyPairName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate), global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRate.Parser, new[]{ "CcyPairName", "Rate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CcyPair : pb::IMessage<CcyPair> {
    private static readonly pb::MessageParser<CcyPair> _parser = new pb::MessageParser<CcyPair>(() => new CcyPair());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CcyPair> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRateServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CcyPair() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CcyPair(CcyPair other) : this() {
      ccyPairName_ = other.ccyPairName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CcyPair Clone() {
      return new CcyPair(this);
    }

    /// <summary>Field number for the "ccy_pair_name" field.</summary>
    public const int CcyPairNameFieldNumber = 1;
    private string ccyPairName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CcyPairName {
      get { return ccyPairName_; }
      set {
        ccyPairName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CcyPair);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CcyPair other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CcyPairName != other.CcyPairName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CcyPairName.Length != 0) hash ^= CcyPairName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CcyPairName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CcyPairName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CcyPairName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CcyPairName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CcyPair other) {
      if (other == null) {
        return;
      }
      if (other.CcyPairName.Length != 0) {
        CcyPairName = other.CcyPairName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CcyPairName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CcyPairRate : pb::IMessage<CcyPairRate> {
    private static readonly pb::MessageParser<CcyPairRate> _parser = new pb::MessageParser<CcyPairRate>(() => new CcyPairRate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CcyPairRate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Samples.CcyPairRateProvider.Generated.CcyPairRateServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CcyPairRate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CcyPairRate(CcyPairRate other) : this() {
      ccyPairName_ = other.ccyPairName_;
      rate_ = other.rate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CcyPairRate Clone() {
      return new CcyPairRate(this);
    }

    /// <summary>Field number for the "ccy_pair_name" field.</summary>
    public const int CcyPairNameFieldNumber = 1;
    private string ccyPairName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CcyPairName {
      get { return ccyPairName_; }
      set {
        ccyPairName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rate" field.</summary>
    public const int RateFieldNumber = 2;
    private double rate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Rate {
      get { return rate_; }
      set {
        rate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CcyPairRate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CcyPairRate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CcyPairName != other.CcyPairName) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Rate, other.Rate)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CcyPairName.Length != 0) hash ^= CcyPairName.GetHashCode();
      if (Rate != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Rate);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CcyPairName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CcyPairName);
      }
      if (Rate != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Rate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CcyPairName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CcyPairName);
      }
      if (Rate != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CcyPairRate other) {
      if (other == null) {
        return;
      }
      if (other.CcyPairName.Length != 0) {
        CcyPairName = other.CcyPairName;
      }
      if (other.Rate != 0D) {
        Rate = other.Rate;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CcyPairName = input.ReadString();
            break;
          }
          case 17: {
            Rate = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
