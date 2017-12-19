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

public class base_q_collapsed_metrics : q_collapsed_header {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal base_q_collapsed_metrics(global::System.IntPtr cPtr, bool cMemoryOwn) : base(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(base_q_collapsed_metrics obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~base_q_collapsed_metrics() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_metricsPINVOKE.delete_base_q_collapsed_metrics(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public base_q_collapsed_metrics(short version) : this(c_csharp_metricsPINVOKE.new_base_q_collapsed_metrics__SWIG_0(version), true) {
  }

  public base_q_collapsed_metrics(q_collapsed_header header, short version) : this(c_csharp_metricsPINVOKE.new_base_q_collapsed_metrics__SWIG_1(q_collapsed_header.getCPtr(header), version), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public base_q_collapsed_metrics(q_collapsed_header header) : this(c_csharp_metricsPINVOKE.new_base_q_collapsed_metrics__SWIG_2(q_collapsed_header.getCPtr(header)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public base_q_collapsed_metrics() : this(c_csharp_metricsPINVOKE.new_base_q_collapsed_metrics__SWIG_3(), true) {
  }

  public base_q_collapsed_metrics(vector_q_collapsed_metrics vec, short version, q_collapsed_header header) : this(c_csharp_metricsPINVOKE.new_base_q_collapsed_metrics__SWIG_4(vector_q_collapsed_metrics.getCPtr(vec), version, q_collapsed_header.getCPtr(header)), true) {
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool data_source_exists() {
    bool ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_data_source_exists__SWIG_0(swigCPtr);
    return ret;
  }

  public void data_source_exists(bool exists) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_data_source_exists__SWIG_1(swigCPtr, exists);
  }

  public void rebuild_index(bool update_ids) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_rebuild_index__SWIG_0(swigCPtr, update_ids);
  }

  public void rebuild_index() {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_rebuild_index__SWIG_1(swigCPtr);
  }

  public void resize(uint n) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_resize(swigCPtr, n);
  }

  public void reserve(uint n) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_reserve(swigCPtr, n);
  }

  public void trim(uint n) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_trim(swigCPtr, n);
  }

  public uint find(uint lane, uint tile, uint cycle) {
    uint ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_find__SWIG_0(swigCPtr, lane, tile, cycle);
    return ret;
  }

  public uint find(uint lane, uint tile) {
    uint ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_find__SWIG_1(swigCPtr, lane, tile);
    return ret;
  }

  public uint find(ulong id) {
    uint ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_find__SWIG_2(swigCPtr, id);
    return ret;
  }

  public bool has_metric(uint lane, uint tile, uint cycle) {
    bool ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_has_metric__SWIG_0(swigCPtr, lane, tile, cycle);
    return ret;
  }

  public bool has_metric(uint lane, uint tile) {
    bool ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_has_metric__SWIG_1(swigCPtr, lane, tile);
    return ret;
  }

  public bool has_metric(ulong id) {
    bool ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_has_metric__SWIG_2(swigCPtr, id);
    return ret;
  }

  public void insert(q_collapsed_metric metric) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_insert__SWIG_0(swigCPtr, q_collapsed_metric.getCPtr(metric));
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void insert(ulong id, q_collapsed_metric metric) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_insert__SWIG_1(swigCPtr, id, q_collapsed_metric.getCPtr(metric));
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public q_collapsed_metric get_metric(uint lane, uint tile, uint cycle) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_get_metric__SWIG_0(swigCPtr, lane, tile, cycle), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public q_collapsed_metric get_metric(uint lane, uint tile) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_get_metric__SWIG_1(swigCPtr, lane, tile), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public q_collapsed_metric get_metric(ulong key) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_get_metric__SWIG_2(swigCPtr, key), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public q_collapsed_metric at(uint n) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_at(swigCPtr, n), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set_version(short version) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_set_version(swigCPtr, version);
  }

  public ulong_vector keys() {
    ulong_vector ret = new ulong_vector(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_keys(swigCPtr), true);
    return ret;
  }

  public uint_vector lanes() {
    uint_vector ret = new uint_vector(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_lanes(swigCPtr), true);
    return ret;
  }

  public uint lane_count() {
    uint ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_lane_count(swigCPtr);
    return ret;
  }

  public uint max_lane() {
    uint ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_max_lane(swigCPtr);
    return ret;
  }

  public uint_vector tile_numbers_for_lane(uint lane) {
    uint_vector ret = new uint_vector(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_tile_numbers_for_lane(swigCPtr, lane), true);
    return ret;
  }

  public uint_vector tile_numbers() {
    uint_vector ret = new uint_vector(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_tile_numbers(swigCPtr), true);
    return ret;
  }

  public vector_q_collapsed_metrics metrics_for_lane(uint lane) {
    vector_q_collapsed_metrics ret = new vector_q_collapsed_metrics(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_metrics_for_lane__SWIG_0(swigCPtr, lane), true);
    return ret;
  }

  public void metrics_for_lane(vector_q_collapsed_metrics lane_metrics, uint lane) {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_metrics_for_lane__SWIG_1(swigCPtr, vector_q_collapsed_metrics.getCPtr(lane_metrics), lane);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint_vector cycles() {
    uint_vector ret = new uint_vector(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_cycles(swigCPtr), true);
    return ret;
  }

  public vector_q_collapsed_metrics metrics_for_cycle(uint cycle) {
    vector_q_collapsed_metrics ret = new vector_q_collapsed_metrics(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_metrics_for_cycle(swigCPtr, cycle), true);
    return ret;
  }

  public uint size() {
    uint ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_empty(swigCPtr);
    return ret;
  }

  public short version() {
    short ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_version(swigCPtr);
    return ret;
  }

  public new void clear() {
    c_csharp_metricsPINVOKE.base_q_collapsed_metrics_clear(swigCPtr);
  }

  public vector_q_collapsed_metrics metrics() {
    vector_q_collapsed_metrics ret = new vector_q_collapsed_metrics(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_metrics(swigCPtr), false);
    return ret;
  }

  public static string prefix() {
    string ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_prefix();
    return ret;
  }

  public static string suffix() {
    string ret = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_suffix();
    return ret;
  }

  public q_collapsed_metric get_metric_ref(uint lane, uint tile, uint cycle) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_get_metric_ref__SWIG_0(swigCPtr, lane, tile, cycle), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public q_collapsed_metric get_metric_ref(uint lane, uint tile) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_get_metric_ref__SWIG_1(swigCPtr, lane, tile), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public q_collapsed_metric get_metric_ref(ulong key) {
    q_collapsed_metric ret = new q_collapsed_metric(c_csharp_metricsPINVOKE.base_q_collapsed_metrics_get_metric_ref__SWIG_2(swigCPtr, key), false);
    if (c_csharp_metricsPINVOKE.SWIGPendingException.Pending) throw c_csharp_metricsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly int TYPE = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_TYPE_get();
  public static readonly int LATEST_VERSION = c_csharp_metricsPINVOKE.base_q_collapsed_metrics_LATEST_VERSION_get();

}

}