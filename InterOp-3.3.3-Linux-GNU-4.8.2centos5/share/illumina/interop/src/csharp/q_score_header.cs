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

public class q_score_header : base_cycle_metric_header {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal q_score_header(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.q_score_header_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(q_score_header obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~q_score_header() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_q_score_header(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public q_score_header() : this(c_csharp_metricsPINVOKE.new_q_score_header__SWIG_0(), true) {
  }

  public q_score_header(q_score_bin_vector bins) : this(c_csharp_metricsPINVOKE.new_q_score_header__SWIG_1(q_score_bin_vector.getCPtr(bins)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public q_score_bin bin_at(uint n) {
    q_score_bin ret = new q_score_bin(c_csharp_metricsPINVOKE.q_score_header_bin_at(swigCPtr, n), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public q_score_bin_vector get_bins() {
    q_score_bin_vector ret = new q_score_bin_vector(c_csharp_metricsPINVOKE.q_score_header_get_bins(swigCPtr), false);
    return ret;
  }

  public q_score_bin_vector bins() {
    q_score_bin_vector ret = new q_score_bin_vector(c_csharp_metricsPINVOKE.q_score_header_bins(swigCPtr), false);
    return ret;
  }

  public uint bin_count() {
    uint ret = c_csharp_metricsPINVOKE.q_score_header_bin_count(swigCPtr);
    return ret;
  }

  public uint q_val_count() {
    uint ret = c_csharp_metricsPINVOKE.q_score_header_q_val_count(swigCPtr);
    return ret;
  }

  public uint index_for_q_value(uint qval) {
    uint ret = c_csharp_metricsPINVOKE.q_score_header_index_for_q_value(swigCPtr, qval);
    return ret;
  }

  public uint binCount() {
    uint ret = c_csharp_metricsPINVOKE.q_score_header_binCount(swigCPtr);
    return ret;
  }

  public new static q_score_header default_header() {
    q_score_header ret = new q_score_header(c_csharp_metricsPINVOKE.q_score_header_default_header(), true);
    return ret;
  }

  public q_score_bin binAt(uint n) {
    q_score_bin ret = new q_score_bin(c_csharp_metricsPINVOKE.q_score_header_binAt(swigCPtr, n), false);
    return ret;
  }

  public new void clear() {
    c_csharp_metricsPINVOKE.q_score_header_clear(swigCPtr);
  }

  public static readonly int MAX_Q_BINS = c_csharp_metricsPINVOKE.q_score_header_MAX_Q_BINS_get();

}

}
