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

public class static_run_metric : base_static_run_metric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal static_run_metric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.static_run_metric_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(static_run_metric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~static_run_metric() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_static_run_metric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static_run_metric() : this(c_csharp_metricsPINVOKE.new_static_run_metric__SWIG_0(), true) {
  }

  public static_run_metric(static_run_metric_header header) : this(c_csharp_metricsPINVOKE.new_static_run_metric__SWIG_1(static_run_metric_header.getCPtr(header)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static_run_metric(byte camera, byte channel, ushort distortion_type, float_vector x_values, float_vector y_values) : this(c_csharp_metricsPINVOKE.new_static_run_metric__SWIG_2(camera, channel, distortion_type, float_vector.getCPtr(x_values), float_vector.getCPtr(y_values)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static_run_metric(uint curve_length, uint curve_check) : this(c_csharp_metricsPINVOKE.new_static_run_metric__SWIG_3(curve_length, curve_check), true) {
  }

  public float x_values(uint curve_length) {
    float ret = c_csharp_metricsPINVOKE.static_run_metric_x_values(swigCPtr, curve_length);
    return ret;
  }

  public float y_values(uint curve_check) {
    float ret = c_csharp_metricsPINVOKE.static_run_metric_y_values(swigCPtr, curve_check);
    return ret;
  }

  public static string prefix() {
    string ret = c_csharp_metricsPINVOKE.static_run_metric_prefix();
    return ret;
  }

  public static readonly int TYPE = c_csharp_metricsPINVOKE.static_run_metric_TYPE_get();
  public static readonly int LATEST_VERSION = c_csharp_metricsPINVOKE.static_run_metric_LATEST_VERSION_get();

}

}