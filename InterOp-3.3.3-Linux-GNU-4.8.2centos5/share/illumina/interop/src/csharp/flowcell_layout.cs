//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Illumina.InterOp.Run {

public class flowcell_layout : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal flowcell_layout(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(flowcell_layout obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~flowcell_layout() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_runPINVOKE.delete_flowcell_layout(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count, uint tile_count, uint sections_per_lane, uint lanes_per_section, string_vector tiles, tile_naming_method naming_method, string barcode) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_0(lane_count, surface_count, swath_count, tile_count, sections_per_lane, lanes_per_section, string_vector.getCPtr(tiles), (int)naming_method, barcode), true) {
    if (c_csharp_runPINVOKE.SWIGPendingException.Pending) throw c_csharp_runPINVOKE.SWIGPendingException.Retrieve();
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count, uint tile_count, uint sections_per_lane, uint lanes_per_section, string_vector tiles, tile_naming_method naming_method) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_1(lane_count, surface_count, swath_count, tile_count, sections_per_lane, lanes_per_section, string_vector.getCPtr(tiles), (int)naming_method), true) {
    if (c_csharp_runPINVOKE.SWIGPendingException.Pending) throw c_csharp_runPINVOKE.SWIGPendingException.Retrieve();
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count, uint tile_count, uint sections_per_lane, uint lanes_per_section, string_vector tiles) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_2(lane_count, surface_count, swath_count, tile_count, sections_per_lane, lanes_per_section, string_vector.getCPtr(tiles)), true) {
    if (c_csharp_runPINVOKE.SWIGPendingException.Pending) throw c_csharp_runPINVOKE.SWIGPendingException.Retrieve();
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count, uint tile_count, uint sections_per_lane, uint lanes_per_section) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_3(lane_count, surface_count, swath_count, tile_count, sections_per_lane, lanes_per_section), true) {
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count, uint tile_count, uint sections_per_lane) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_4(lane_count, surface_count, swath_count, tile_count, sections_per_lane), true) {
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count, uint tile_count) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_5(lane_count, surface_count, swath_count, tile_count), true) {
  }

  public flowcell_layout(uint lane_count, uint surface_count, uint swath_count) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_6(lane_count, surface_count, swath_count), true) {
  }

  public flowcell_layout(uint lane_count, uint surface_count) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_7(lane_count, surface_count), true) {
  }

  public flowcell_layout(uint lane_count) : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_8(lane_count), true) {
  }

  public flowcell_layout() : this(c_csharp_runPINVOKE.new_flowcell_layout__SWIG_9(), true) {
  }

  public uint lane_count() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_lane_count__SWIG_0(swigCPtr);
    return ret;
  }

  public uint surface_count() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_surface_count__SWIG_0(swigCPtr);
    return ret;
  }

  public uint swath_count() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_swath_count__SWIG_0(swigCPtr);
    return ret;
  }

  public uint tile_count() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_tile_count__SWIG_0(swigCPtr);
    return ret;
  }

  public uint sections_per_lane() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_sections_per_lane__SWIG_0(swigCPtr);
    return ret;
  }

  public uint lanes_per_section() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_lanes_per_section__SWIG_0(swigCPtr);
    return ret;
  }

  public uint total_number_of_sections() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_total_number_of_sections(swigCPtr);
    return ret;
  }

  public tile_naming_method naming_method() {
    tile_naming_method ret = (tile_naming_method)c_csharp_runPINVOKE.flowcell_layout_naming_method(swigCPtr);
    return ret;
  }

  public string_vector tiles() {
    string_vector ret = new string_vector(c_csharp_runPINVOKE.flowcell_layout_tiles(swigCPtr), false);
    return ret;
  }

  public string barcode() {
    string ret = c_csharp_runPINVOKE.flowcell_layout_barcode(swigCPtr);
    return ret;
  }

  public uint total_swaths(bool all_surfaces) {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_total_swaths(swigCPtr, all_surfaces);
    return ret;
  }

  public uint tiles_per_lane() {
    uint ret = c_csharp_runPINVOKE.flowcell_layout_tiles_per_lane(swigCPtr);
    return ret;
  }

  public void set_naming_method(tile_naming_method naming_method) {
    c_csharp_runPINVOKE.flowcell_layout_set_naming_method(swigCPtr, (int)naming_method);
  }

  public void lane_count(uint lane_count) {
    c_csharp_runPINVOKE.flowcell_layout_lane_count__SWIG_1(swigCPtr, lane_count);
  }

  public void surface_count(uint surface_count) {
    c_csharp_runPINVOKE.flowcell_layout_surface_count__SWIG_1(swigCPtr, surface_count);
  }

  public void swath_count(uint swath_count) {
    c_csharp_runPINVOKE.flowcell_layout_swath_count__SWIG_1(swigCPtr, swath_count);
  }

  public void tile_count(uint tile_count) {
    c_csharp_runPINVOKE.flowcell_layout_tile_count__SWIG_1(swigCPtr, tile_count);
  }

  public void sections_per_lane(uint count) {
    c_csharp_runPINVOKE.flowcell_layout_sections_per_lane__SWIG_1(swigCPtr, count);
  }

  public void lanes_per_section(uint count) {
    c_csharp_runPINVOKE.flowcell_layout_lanes_per_section__SWIG_1(swigCPtr, count);
  }

}

}
