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

public class index_metric_header : base_read_metric_header {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal index_metric_header(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.index_metric_header_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(index_metric_header obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~index_metric_header() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_index_metric_header(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public index_metric_header() : this(c_csharp_metricsPINVOKE.new_index_metric_header(), true) {
  }

  public string_vector index_order() {
    string_vector ret = new string_vector(c_csharp_metricsPINVOKE.index_metric_header_index_order__SWIG_0(swigCPtr), false);
    return ret;
  }

  public void index_order(string_vector order) {
    c_csharp_metricsPINVOKE.index_metric_header_index_order__SWIG_1(swigCPtr, string_vector.getCPtr(order));
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static index_metric_header default_header() {
    index_metric_header ret = new index_metric_header(c_csharp_metricsPINVOKE.index_metric_header_default_header(), true);
    return ret;
  }

  public void clear() {
    c_csharp_metricsPINVOKE.index_metric_header_clear(swigCPtr);
  }

}

}