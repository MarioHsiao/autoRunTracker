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

public class color_matrix_metric_header : base_cycle_metric_header {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal color_matrix_metric_header(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.color_matrix_metric_header_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(color_matrix_metric_header obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~color_matrix_metric_header() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_color_matrix_metric_header(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public color_matrix_metric_header(ushort number_of_entries) : this(c_csharp_metricsPINVOKE.new_color_matrix_metric_header(number_of_entries), true) {
  }

  public ushort number_of_entries() {
    ushort ret = c_csharp_metricsPINVOKE.color_matrix_metric_header_number_of_entries(swigCPtr);
    return ret;
  }

  public new static color_matrix_metric_header default_header() {
    color_matrix_metric_header ret = new color_matrix_metric_header(c_csharp_metricsPINVOKE.color_matrix_metric_header_default_header(), true);
    return ret;
  }

  public new void clear() {
    c_csharp_metricsPINVOKE.color_matrix_metric_header_clear(swigCPtr);
  }

}

}
