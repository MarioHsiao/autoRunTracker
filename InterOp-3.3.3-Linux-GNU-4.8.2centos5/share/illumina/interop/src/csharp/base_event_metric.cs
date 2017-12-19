//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Illumina.InterOp.Metrics {

using System;
using System.Runtime.InteropServices;
using Illumina.InterOp.Run;

public class base_event_metric : base_cycle_metric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal base_event_metric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.base_event_metric_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(base_event_metric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~base_event_metric() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_base_event_metric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public base_event_metric(uint lane, uint tile, uint cycle, event_type event_type) : this(c_csharp_metricsPINVOKE.new_base_event_metric__SWIG_0(lane, tile, cycle, (int)event_type), true) {
  }

  public base_event_metric(uint lane, uint tile, uint cycle) : this(c_csharp_metricsPINVOKE.new_base_event_metric__SWIG_1(lane, tile, cycle), true) {
  }

  public base_event_metric(uint lane, uint tile) : this(c_csharp_metricsPINVOKE.new_base_event_metric__SWIG_2(lane, tile), true) {
  }

  public base_event_metric(uint lane) : this(c_csharp_metricsPINVOKE.new_base_event_metric__SWIG_3(lane), true) {
  }

  public base_event_metric() : this(c_csharp_metricsPINVOKE.new_base_event_metric__SWIG_4(), true) {
  }

  public new void set_base(uint lane, uint tile) {
    c_csharp_metricsPINVOKE.base_event_metric_set_base__SWIG_0(swigCPtr, lane, tile);
  }

  public void set_base(uint lane, uint tile, uint cycle, event_type event_type) {
    c_csharp_metricsPINVOKE.base_event_metric_set_base__SWIG_1(swigCPtr, lane, tile, cycle, (int)event_type);
  }

  public event_type event_type() {
    event_type ret = (event_type)c_csharp_metricsPINVOKE.base_event_metric_event_type__SWIG_0(swigCPtr);
    return ret;
  }

  public ulong event_type_long() {
    ulong ret = c_csharp_metricsPINVOKE.base_event_metric_event_type_long(swigCPtr);
    return ret;
    }

  public void event_type(event_type event_type) {
    c_csharp_metricsPINVOKE.base_event_metric_event_type__SWIG_1(swigCPtr, (int)event_type);
  }

  public new ulong id() {
    ulong ret = c_csharp_metricsPINVOKE.base_event_metric_id(swigCPtr);
    return ret;
    }

  public static ulong create_id(ulong lane, ulong tile, ulong cycle, ulong event_type) {
    ulong ret = c_csharp_metricsPINVOKE.base_event_metric_create_id(lane, tile, cycle, event_type);
    return ret;
    }

}

}
