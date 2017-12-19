//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Illumina.InterOp.Plot {

using System;
using System.Runtime.InteropServices;
using Illumina.InterOp.RunMetrics;
using Illumina.InterOp.Metrics;
using Illumina.InterOp.Run;

public class bar_plot_data : chart_data {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal bar_plot_data(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_plotPINVOKE.bar_plot_data_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(bar_plot_data obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~bar_plot_data() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_plotPINVOKE.delete_bar_plot_data(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new void clear() {
    c_csharp_plotPINVOKE.bar_plot_data_clear(swigCPtr);
  }

  public void resize(uint n) {
    c_csharp_plotPINVOKE.bar_plot_data_resize(swigCPtr, n);
  }

  public void assign(uint n, bar_series val) {
    c_csharp_plotPINVOKE.bar_plot_data_assign(swigCPtr, n, bar_series.getCPtr(val));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void push_back(bar_series val) {
    c_csharp_plotPINVOKE.bar_plot_data_push_back(swigCPtr, bar_series.getCPtr(val));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public bar_series at(uint index) {
    bar_series ret = new bar_series(c_csharp_plotPINVOKE.bar_plot_data_at(swigCPtr, index), false);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = c_csharp_plotPINVOKE.bar_plot_data_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = c_csharp_plotPINVOKE.bar_plot_data_empty(swigCPtr);
    return ret;
  }

  public bar_plot_data() : this(c_csharp_plotPINVOKE.new_bar_plot_data(), true) {
  }

}

}