// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpEndToEndTests.Oracle.Flatc
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct SortedVectorStringTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_22_10_26(); }
  public static SortedVectorStringTable GetRootAsSortedVectorStringTable(ByteBuffer _bb) { return GetRootAsSortedVectorStringTable(_bb, new SortedVectorStringTable()); }
  public static SortedVectorStringTable GetRootAsSortedVectorStringTable(ByteBuffer _bb, SortedVectorStringTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SortedVectorStringTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Value { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetValueBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetValueBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetValueArray() { return __p.__vector_as_array<byte>(4); }

  public static Offset<FlatSharpEndToEndTests.Oracle.Flatc.SortedVectorStringTable> CreateSortedVectorStringTable(FlatBufferBuilder builder,
      StringOffset ValueOffset = default(StringOffset)) {
    builder.StartTable(1);
    SortedVectorStringTable.AddValue(builder, ValueOffset);
    return SortedVectorStringTable.EndSortedVectorStringTable(builder);
  }

  public static void StartSortedVectorStringTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddValue(FlatBufferBuilder builder, StringOffset ValueOffset) { builder.AddOffset(0, ValueOffset.Value, 0); }
  public static Offset<FlatSharpEndToEndTests.Oracle.Flatc.SortedVectorStringTable> EndSortedVectorStringTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // Value
    return new Offset<FlatSharpEndToEndTests.Oracle.Flatc.SortedVectorStringTable>(o);
  }

  public static VectorOffset CreateSortedVectorOfSortedVectorStringTable(FlatBufferBuilder builder, Offset<SortedVectorStringTable>[] offsets) {
    Array.Sort(offsets,
      (Offset<SortedVectorStringTable> o1, Offset<SortedVectorStringTable> o2) =>
        new SortedVectorStringTable().__assign(builder.DataBuffer.Length - o1.Value, builder.DataBuffer).Value.CompareTo(new SortedVectorStringTable().__assign(builder.DataBuffer.Length - o2.Value, builder.DataBuffer).Value));
    return builder.CreateVectorOfTables(offsets);
  }

  public static SortedVectorStringTable? __lookup_by_key(int vectorLocation, string key, ByteBuffer bb) {
    SortedVectorStringTable obj_ = new SortedVectorStringTable();
    int span = bb.GetInt(vectorLocation - 4);
    int start = 0;
    while (span != 0) {
      int middle = span / 2;
      int tableOffset = Table.__indirect(vectorLocation + 4 * (start + middle), bb);
      obj_.__assign(tableOffset, bb);
      int comp = obj_.Value.CompareTo(key);
      if (comp > 0) {
        span = middle;
      } else if (comp < 0) {
        middle++;
        start += middle;
        span -= middle;
      } else {
        return obj_;
      }
    }
    return null;
  }
  public SortedVectorStringTableT UnPack() {
    var _o = new SortedVectorStringTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(SortedVectorStringTableT _o) {
    _o.Value = this.Value;
  }
  public static Offset<FlatSharpEndToEndTests.Oracle.Flatc.SortedVectorStringTable> Pack(FlatBufferBuilder builder, SortedVectorStringTableT _o) {
    if (_o == null) return default(Offset<FlatSharpEndToEndTests.Oracle.Flatc.SortedVectorStringTable>);
    var _Value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
    return CreateSortedVectorStringTable(
      builder,
      _Value);
  }
}

public class SortedVectorStringTableT
{
  public string Value { get; set; }

  public SortedVectorStringTableT() {
    this.Value = null;
  }
}


}
