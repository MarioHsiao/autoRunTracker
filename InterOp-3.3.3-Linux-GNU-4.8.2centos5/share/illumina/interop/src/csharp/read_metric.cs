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

public class read_metric : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal read_metric(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(read_metric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~read_metric() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_read_metric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public read_metric(uint read, float percent_aligned, float percent_phasing, float percent_prephasing) : this(c_csharp_metricsPINVOKE.new_read_metric__SWIG_0(read, percent_aligned, percent_phasing, percent_prephasing), true) {
  }

  public read_metric(uint read, float percent_aligned, float percent_phasing) : this(c_csharp_metricsPINVOKE.new_read_metric__SWIG_1(read, percent_aligned, percent_phasing), true) {
  }

  public read_metric(uint read, float percent_aligned) : this(c_csharp_metricsPINVOKE.new_read_metric__SWIG_2(read, percent_aligned), true) {
  }

  public read_metric(uint read) : this(c_csharp_metricsPINVOKE.new_read_metric__SWIG_3(read), true) {
  }

  public read_metric() : this(c_csharp_metricsPINVOKE.new_read_metric__SWIG_4(), true) {
  }

  public uint read() {
    uint ret = c_csharp_metricsPINVOKE.read_metric_read(swigCPtr);
    return ret;
  }

  public float percent_aligned() {
    float ret = c_csharp_metricsPINVOKE.read_metric_percent_aligned__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_phasing() {
    float ret = c_csharp_metricsPINVOKE.read_metric_percent_phasing__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_prephasing() {
    float ret = c_csharp_metricsPINVOKE.read_metric_percent_prephasing__SWIG_0(swigCPtr);
    return ret;
  }

  public void percent_aligned(float val) {
    c_csharp_metricsPINVOKE.read_metric_percent_aligned__SWIG_1(swigCPtr, val);
  }

  public void percent_phasing(float val) {
    c_csharp_metricsPINVOKE.read_metric_percent_phasing__SWIG_1(swigCPtr, val);
  }

  public void percent_prephasing(float val) {
    c_csharp_metricsPINVOKE.read_metric_percent_prephasing__SWIG_1(swigCPtr, val);
  }

}

}
