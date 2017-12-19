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

public class q_grid_metric : base_read_metric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal q_grid_metric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.q_grid_metric_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(q_grid_metric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~q_grid_metric() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_q_grid_metric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public q_grid_metric() : this(c_csharp_metricsPINVOKE.new_q_grid_metric__SWIG_0(), true) {
  }

  public q_grid_metric(q_grid_metric_header header) : this(c_csharp_metricsPINVOKE.new_q_grid_metric__SWIG_1(q_grid_metric_header.getCPtr(header)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public q_grid_metric(uint num_bins_x, uint num_bins_y) : this(c_csharp_metricsPINVOKE.new_q_grid_metric__SWIG_3(num_bins_x, num_bins_y), true) {
  }

  public uint raw_cluster_count(uint x_bin, uint y_bin) {
    uint ret = c_csharp_metricsPINVOKE.q_grid_metric_raw_cluster_count(swigCPtr, x_bin, y_bin);
    return ret;
  }

  public uint q30_cluster_count(uint x_bin, uint y_bin) {
    uint ret = c_csharp_metricsPINVOKE.q_grid_metric_q30_cluster_count(swigCPtr, x_bin, y_bin);
    return ret;
  }

  public float percent_q30(uint x_bin, uint y_bin) {
    float ret = c_csharp_metricsPINVOKE.q_grid_metric_percent_q30(swigCPtr, x_bin, y_bin);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string prefix() {
    string ret = c_csharp_metricsPINVOKE.q_grid_metric_prefix();
    return ret;
  }

  public static readonly int TYPE = c_csharp_metricsPINVOKE.q_grid_metric_TYPE_get();
  public static readonly int LATEST_VERSION = c_csharp_metricsPINVOKE.q_grid_metric_LATEST_VERSION_get();

}

}
