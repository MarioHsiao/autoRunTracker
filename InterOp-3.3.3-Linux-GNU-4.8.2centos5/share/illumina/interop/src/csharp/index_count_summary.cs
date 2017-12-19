//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Illumina.InterOp.Summary {

using System;
using System.Runtime.InteropServices;
using Illumina.InterOp.Metrics;
using Illumina.InterOp.Run;
using Illumina.InterOp.RunMetrics;

public class index_count_summary : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal index_count_summary(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(index_count_summary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~index_count_summary() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_summaryPINVOKE.delete_index_count_summary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public index_count_summary(uint id, string index1, string index2, string sample_id, string project_name, ulong count, float fraction_mapped) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_0(id, index1, index2, sample_id, project_name, count, fraction_mapped), true) {
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
  }

  public index_count_summary(uint id, string index1, string index2, string sample_id, string project_name, ulong count) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_1(id, index1, index2, sample_id, project_name, count), true) {
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
  }

  public index_count_summary(uint id, string index1, string index2, string sample_id, string project_name) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_2(id, index1, index2, sample_id, project_name), true) {
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
  }

  public index_count_summary(uint id, string index1, string index2, string sample_id) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_3(id, index1, index2, sample_id), true) {
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
  }

  public index_count_summary(uint id, string index1, string index2) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_4(id, index1, index2), true) {
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
  }

  public index_count_summary(uint id, string index1) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_5(id, index1), true) {
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
  }

  public index_count_summary(uint id) : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_6(id), true) {
  }

  public index_count_summary() : this(c_csharp_summaryPINVOKE.new_index_count_summary__SWIG_7(), true) {
  }

  public uint id() {
    uint ret = c_csharp_summaryPINVOKE.index_count_summary_id__SWIG_0(swigCPtr);
    return ret;
  }

  public void id(uint n) {
    c_csharp_summaryPINVOKE.index_count_summary_id__SWIG_1(swigCPtr, n);
  }

  public string index1() {
    string ret = c_csharp_summaryPINVOKE.index_count_summary_index1(swigCPtr);
    return ret;
  }

  public string index2() {
    string ret = c_csharp_summaryPINVOKE.index_count_summary_index2(swigCPtr);
    return ret;
  }

  public float fraction_mapped() {
    float ret = c_csharp_summaryPINVOKE.index_count_summary_fraction_mapped(swigCPtr);
    return ret;
  }

  public ulong cluster_count() {
    ulong ret = c_csharp_summaryPINVOKE.index_count_summary_cluster_count(swigCPtr);
    return ret;
    }

  public string sample_id() {
    string ret = c_csharp_summaryPINVOKE.index_count_summary_sample_id(swigCPtr);
    return ret;
  }

  public string project_name() {
    string ret = c_csharp_summaryPINVOKE.index_count_summary_project_name(swigCPtr);
    return ret;
  }

  public index_count_summary add(ulong cluster_count) {
    index_count_summary ret = new index_count_summary(c_csharp_summaryPINVOKE.index_count_summary_add(swigCPtr, cluster_count), false);
    return ret;
  }

  public void update_fraction_mapped(double total_pf_cluster_count) {
    c_csharp_summaryPINVOKE.index_count_summary_update_fraction_mapped(swigCPtr, total_pf_cluster_count);
  }

  public bool is_less(index_count_summary rhs) {
    bool ret = c_csharp_summaryPINVOKE.index_count_summary_is_less(swigCPtr, index_count_summary.getCPtr(rhs));
    if (c_csharp_summaryPINVOKE.SWIGPendingException.Pending) throw c_csharp_summaryPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
