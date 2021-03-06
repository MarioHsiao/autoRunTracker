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

public class base_static_run_metric : empty_metric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal base_static_run_metric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.base_static_run_metric_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(base_static_run_metric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~base_static_run_metric() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_base_static_run_metric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public base_static_run_metric(ushort camera, ushort channel, ushort distortion_type) : this(c_csharp_metricsPINVOKE.new_base_static_run_metric(camera, channel, distortion_type), true) {
  }

  public void set_base(ushort camera, ushort channel, ushort distortion_type) {
    c_csharp_metricsPINVOKE.base_static_run_metric_set_base(swigCPtr, camera, channel, distortion_type);
  }

  public static string suffix() {
    string ret = c_csharp_metricsPINVOKE.base_static_run_metric_suffix();
    return ret;
  }

  public uint id() {
    uint ret = c_csharp_metricsPINVOKE.base_static_run_metric_id(swigCPtr);
    return ret;
  }

  public static uint create_id(uint camera, uint channel, uint distortion_type) {
    uint ret = c_csharp_metricsPINVOKE.base_static_run_metric_create_id(camera, channel, distortion_type);
    return ret;
  }

  public ushort camera() {
    ushort ret = c_csharp_metricsPINVOKE.base_static_run_metric_camera(swigCPtr);
    return ret;
  }

  public ushort channel() {
    ushort ret = c_csharp_metricsPINVOKE.base_static_run_metric_channel(swigCPtr);
    return ret;
  }

  public ushort distortion_type() {
    ushort ret = c_csharp_metricsPINVOKE.base_static_run_metric_distortion_type(swigCPtr);
    return ret;
  }

  public uint lane() {
    uint ret = c_csharp_metricsPINVOKE.base_static_run_metric_lane(swigCPtr);
    return ret;
  }

  public uint tile() {
    uint ret = c_csharp_metricsPINVOKE.base_static_run_metric_tile(swigCPtr);
    return ret;
  }

  public static readonly int CHANNEL_BIT_SHIFT = c_csharp_metricsPINVOKE.base_static_run_metric_CHANNEL_BIT_SHIFT_get();
  public static readonly int DISTORTION_BIT_SHIFT = c_csharp_metricsPINVOKE.base_static_run_metric_DISTORTION_BIT_SHIFT_get();

}

}
