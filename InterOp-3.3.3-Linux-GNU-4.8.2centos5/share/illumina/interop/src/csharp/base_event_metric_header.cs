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

public class base_event_metric_header : empty_header {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal base_event_metric_header(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.base_event_metric_header_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(base_event_metric_header obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~base_event_metric_header() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_base_event_metric_header(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public base_event_metric_header() : this(c_csharp_metricsPINVOKE.new_base_event_metric_header(), true) {
  }

  public static base_event_metric_header default_header() {
    base_event_metric_header ret = new base_event_metric_header(c_csharp_metricsPINVOKE.base_event_metric_header_default_header(), true);
    return ret;
  }

  public uint max_cycle() {
    uint ret = c_csharp_metricsPINVOKE.base_event_metric_header_max_cycle(swigCPtr);
    return ret;
  }

  public void clear() {
    c_csharp_metricsPINVOKE.base_event_metric_header_clear(swigCPtr);
  }

}

}
