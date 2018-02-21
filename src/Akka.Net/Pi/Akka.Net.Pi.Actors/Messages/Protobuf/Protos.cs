// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protos.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SCG1lc3NhZ2VzIgcKBVN0YXJ0Ig0KC1N0YXJ0UmVt",
            "b3RlIhYKCFBpTnVtYmVyEgoKAlBpGAEgASgJIkoKC0NhbGNPcHRpb25zEg4K",
            "BkRpZ2l0cxgBIAEoBRISCgpJdGVyYXRpb25zGAIgASgFEhcKD1JlY2VpdmVy",
            "QWRkcmVzcxgDIAEoCUI8qgI5QWN0b3JNb2RlbEJlbmNobWFya3MuQWtrYS5O",
            "ZXQuUGkuQWN0b3JzLk1lc3NhZ2VzLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.Start), global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.Start.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.StartRemote), global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.StartRemote.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.PiNumber), global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.PiNumber.Parser, new[]{ "Pi" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.CalcOptions), global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.CalcOptions.Parser, new[]{ "Digits", "Iterations", "ReceiverAddress" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Start : pb::IMessage<Start> {
    private static readonly pb::MessageParser<Start> _parser = new pb::MessageParser<Start>(() => new Start());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Start> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Start() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Start(Start other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Start Clone() {
      return new Start(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Start);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Start other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Start other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class StartRemote : pb::IMessage<StartRemote> {
    private static readonly pb::MessageParser<StartRemote> _parser = new pb::MessageParser<StartRemote>(() => new StartRemote());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StartRemote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRemote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRemote(StartRemote other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRemote Clone() {
      return new StartRemote(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StartRemote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StartRemote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StartRemote other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class PiNumber : pb::IMessage<PiNumber> {
    private static readonly pb::MessageParser<PiNumber> _parser = new pb::MessageParser<PiNumber>(() => new PiNumber());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PiNumber> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PiNumber() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PiNumber(PiNumber other) : this() {
      pi_ = other.pi_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PiNumber Clone() {
      return new PiNumber(this);
    }

    /// <summary>Field number for the "Pi" field.</summary>
    public const int PiFieldNumber = 1;
    private string pi_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Pi {
      get { return pi_; }
      set {
        pi_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PiNumber);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PiNumber other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Pi != other.Pi) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Pi.Length != 0) hash ^= Pi.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Pi.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Pi);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Pi.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Pi);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PiNumber other) {
      if (other == null) {
        return;
      }
      if (other.Pi.Length != 0) {
        Pi = other.Pi;
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
            Pi = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CalcOptions : pb::IMessage<CalcOptions> {
    private static readonly pb::MessageParser<CalcOptions> _parser = new pb::MessageParser<CalcOptions>(() => new CalcOptions());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CalcOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ActorModelBenchmarks.Akka.Net.Pi.Actors.Messages.Protobuf.ProtosReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcOptions(CalcOptions other) : this() {
      digits_ = other.digits_;
      iterations_ = other.iterations_;
      receiverAddress_ = other.receiverAddress_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalcOptions Clone() {
      return new CalcOptions(this);
    }

    /// <summary>Field number for the "Digits" field.</summary>
    public const int DigitsFieldNumber = 1;
    private int digits_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Digits {
      get { return digits_; }
      set {
        digits_ = value;
      }
    }

    /// <summary>Field number for the "Iterations" field.</summary>
    public const int IterationsFieldNumber = 2;
    private int iterations_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Iterations {
      get { return iterations_; }
      set {
        iterations_ = value;
      }
    }

    /// <summary>Field number for the "ReceiverAddress" field.</summary>
    public const int ReceiverAddressFieldNumber = 3;
    private string receiverAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReceiverAddress {
      get { return receiverAddress_; }
      set {
        receiverAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CalcOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CalcOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Digits != other.Digits) return false;
      if (Iterations != other.Iterations) return false;
      if (ReceiverAddress != other.ReceiverAddress) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Digits != 0) hash ^= Digits.GetHashCode();
      if (Iterations != 0) hash ^= Iterations.GetHashCode();
      if (ReceiverAddress.Length != 0) hash ^= ReceiverAddress.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Digits != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Digits);
      }
      if (Iterations != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Iterations);
      }
      if (ReceiverAddress.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReceiverAddress);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Digits != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Digits);
      }
      if (Iterations != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Iterations);
      }
      if (ReceiverAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReceiverAddress);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CalcOptions other) {
      if (other == null) {
        return;
      }
      if (other.Digits != 0) {
        Digits = other.Digits;
      }
      if (other.Iterations != 0) {
        Iterations = other.Iterations;
      }
      if (other.ReceiverAddress.Length != 0) {
        ReceiverAddress = other.ReceiverAddress;
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
          case 8: {
            Digits = input.ReadInt32();
            break;
          }
          case 16: {
            Iterations = input.ReadInt32();
            break;
          }
          case 26: {
            ReceiverAddress = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
