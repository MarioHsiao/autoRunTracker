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

public class metric_summary : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal metric_summary(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(metric_summary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~metric_summary() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_summaryPINVOKE.delete_metric_summary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public metric_summary(uint channel_count) : this(c_csharp_summaryPINVOKE.new_metric_summary(channel_count), true) {
  }

  public float error_rate() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_error_rate__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_aligned() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_percent_aligned__SWIG_0(swigCPtr);
    return ret;
  }

  public float first_cycle_intensity() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_first_cycle_intensity__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_gt_q30() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_percent_gt_q30__SWIG_0(swigCPtr);
    return ret;
  }

  public float yield_g() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_yield_g__SWIG_0(swigCPtr);
    return ret;
  }

  public float projected_yield_g() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_projected_yield_g__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_gt_q30_last_10_cycles() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_percent_gt_q30_last_10_cycles__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_occupied() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_percent_occupied__SWIG_0(swigCPtr);
    return ret;
  }

  public float theta_z() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_theta_z__SWIG_0(swigCPtr);
    return ret;
  }

  public float theta() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_theta__SWIG_0(swigCPtr);
    return ret;
  }

  public void first_cycle_intensity(float val) {
    c_csharp_summaryPINVOKE.metric_summary_first_cycle_intensity__SWIG_1(swigCPtr, val);
  }

  public void error_rate(float val) {
    c_csharp_summaryPINVOKE.metric_summary_error_rate__SWIG_1(swigCPtr, val);
  }

  public void percent_aligned(float val) {
    c_csharp_summaryPINVOKE.metric_summary_percent_aligned__SWIG_1(swigCPtr, val);
  }

  public void percent_gt_q30(float val) {
    c_csharp_summaryPINVOKE.metric_summary_percent_gt_q30__SWIG_1(swigCPtr, val);
  }

  public void yield_g(float val) {
    c_csharp_summaryPINVOKE.metric_summary_yield_g__SWIG_1(swigCPtr, val);
  }

  public void projected_yield_g(float val) {
    c_csharp_summaryPINVOKE.metric_summary_projected_yield_g__SWIG_1(swigCPtr, val);
  }

  public void percent_gt_q30_last_10_cycles(float val) {
    c_csharp_summaryPINVOKE.metric_summary_percent_gt_q30_last_10_cycles__SWIG_1(swigCPtr, val);
  }

  public void percent_occupied(float val) {
    c_csharp_summaryPINVOKE.metric_summary_percent_occupied__SWIG_1(swigCPtr, val);
  }

  public void theta_z(float val) {
    c_csharp_summaryPINVOKE.metric_summary_theta_z__SWIG_1(swigCPtr, val);
  }

  public void theta(float val) {
    c_csharp_summaryPINVOKE.metric_summary_theta__SWIG_1(swigCPtr, val);
  }

  public float percent_pf() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_percent_pf(swigCPtr);
    return ret;
  }

  public float cluster_density() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_cluster_density__SWIG_0(swigCPtr);
    return ret;
  }

  public float cluster_density_pf() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_cluster_density_pf__SWIG_0(swigCPtr);
    return ret;
  }

  public float_vector percent_base() {
    float_vector ret = new float_vector(c_csharp_summaryPINVOKE.metric_summary_percent_base__SWIG_0(swigCPtr), false);
    return ret;
  }

  public float phasing() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_phasing__SWIG_0(swigCPtr);
    return ret;
  }

  public float prephasing() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_prephasing__SWIG_0(swigCPtr);
    return ret;
  }

  public float percent_no_call() {
    float ret = c_csharp_summaryPINVOKE.metric_summary_percent_no_call__SWIG_0(swigCPtr);
    return ret;
  }

  public float_vector fwhm() {
    float_vector ret = new float_vector(c_csharp_summaryPINVOKE.metric_summary_fwhm__SWIG_0(swigCPtr), false);
    return ret;
  }

  public float_vector resynthesis() {
    float_vector ret = new float_vector(c_csharp_summaryPINVOKE.metric_summary_resynthesis__SWIG_0(swigCPtr), false);
    return ret;
  }

  public void fwhm(uint channel, float val) {
    c_csharp_summaryPINVOKE.metric_summary_fwhm__SWIG_1(swigCPtr, channel, val);
  }

  public void resynthesis(uint channel, float val) {
    c_csharp_summaryPINVOKE.metric_summary_resynthesis__SWIG_1(swigCPtr, channel, val);
  }

  public void percent_base(uint channel, float val) {
    c_csharp_summaryPINVOKE.metric_summary_percent_base__SWIG_1(swigCPtr, channel, val);
  }

  public void phasing(float val) {
    c_csharp_summaryPINVOKE.metric_summary_phasing__SWIG_1(swigCPtr, val);
  }

  public void prephasing(float val) {
    c_csharp_summaryPINVOKE.metric_summary_prephasing__SWIG_1(swigCPtr, val);
  }

  public void percent_no_call(float val) {
    c_csharp_summaryPINVOKE.metric_summary_percent_no_call__SWIG_1(swigCPtr, val);
  }

  public void cluster_density(float val) {
    c_csharp_summaryPINVOKE.metric_summary_cluster_density__SWIG_1(swigCPtr, val);
  }

  public void cluster_density_pf(float val) {
    c_csharp_summaryPINVOKE.metric_summary_cluster_density_pf__SWIG_1(swigCPtr, val);
  }

  public void resize(uint channel_count) {
    c_csharp_summaryPINVOKE.metric_summary_resize(swigCPtr, channel_count);
  }

}

}
