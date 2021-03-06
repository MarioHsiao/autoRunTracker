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

public class phasing_metric : base_cycle_metric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal phasing_metric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.phasing_metric_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(phasing_metric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~phasing_metric() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_phasing_metric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public phasing_metric() : this(c_csharp_metricsPINVOKE.new_phasing_metric__SWIG_0(), true) {
  }

  public phasing_metric(base_cycle_metric_header arg0) : this(c_csharp_metricsPINVOKE.new_phasing_metric__SWIG_1(base_cycle_metric_header.getCPtr(arg0)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public phasing_metric(uint lane, uint tile, uint cycle, float phasing_weight, float prephasing_weight) : this(c_csharp_metricsPINVOKE.new_phasing_metric__SWIG_2(lane, tile, cycle, phasing_weight, prephasing_weight), true) {
  }

  public float phasing_weight() {
    float ret = c_csharp_metricsPINVOKE.phasing_metric_phasing_weight(swigCPtr);
    return ret;
  }

  public float prephasing_weight() {
    float ret = c_csharp_metricsPINVOKE.phasing_metric_prephasing_weight(swigCPtr);
    return ret;
  }

  public static string prefix() {
    string ret = c_csharp_metricsPINVOKE.phasing_metric_prefix();
    return ret;
  }

  public static readonly int TYPE = c_csharp_metricsPINVOKE.phasing_metric_TYPE_get();
  public static readonly int LATEST_VERSION = c_csharp_metricsPINVOKE.phasing_metric_LATEST_VERSION_get();

}

}
