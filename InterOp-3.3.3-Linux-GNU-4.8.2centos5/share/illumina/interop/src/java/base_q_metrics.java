/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class base_q_metrics extends q_score_header {
  private transient long swigCPtr;

  protected base_q_metrics(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.base_q_metrics_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(base_q_metrics obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_base_q_metrics(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public base_q_metrics(short version) {
    this(interop_metricsJNI.new_base_q_metrics__SWIG_0(version), true);
  }

  public base_q_metrics(q_score_header header, short version) {
    this(interop_metricsJNI.new_base_q_metrics__SWIG_1(q_score_header.getCPtr(header), header, version), true);
  }

  public base_q_metrics(q_score_header header) {
    this(interop_metricsJNI.new_base_q_metrics__SWIG_2(q_score_header.getCPtr(header), header), true);
  }

  public base_q_metrics() {
    this(interop_metricsJNI.new_base_q_metrics__SWIG_3(), true);
  }

  public base_q_metrics(vector_q_metrics vec, short version, q_score_header header) {
    this(interop_metricsJNI.new_base_q_metrics__SWIG_4(vector_q_metrics.getCPtr(vec), vec, version, q_score_header.getCPtr(header), header), true);
  }

  public boolean data_source_exists() {
    return interop_metricsJNI.base_q_metrics_data_source_exists__SWIG_0(swigCPtr, this);
  }

  public void data_source_exists(boolean exists) {
    interop_metricsJNI.base_q_metrics_data_source_exists__SWIG_1(swigCPtr, this, exists);
  }

  public void rebuild_index(boolean update_ids) {
    interop_metricsJNI.base_q_metrics_rebuild_index__SWIG_0(swigCPtr, this, update_ids);
  }

  public void rebuild_index() {
    interop_metricsJNI.base_q_metrics_rebuild_index__SWIG_1(swigCPtr, this);
  }

  public void resize(long n) {
    interop_metricsJNI.base_q_metrics_resize(swigCPtr, this, n);
  }

  public void reserve(long n) {
    interop_metricsJNI.base_q_metrics_reserve(swigCPtr, this, n);
  }

  public void trim(long n) {
    interop_metricsJNI.base_q_metrics_trim(swigCPtr, this, n);
  }

  public long find(long lane, long tile, long cycle) {
    return interop_metricsJNI.base_q_metrics_find__SWIG_0(swigCPtr, this, lane, tile, cycle);
  }

  public long find(long lane, long tile) {
    return interop_metricsJNI.base_q_metrics_find__SWIG_1(swigCPtr, this, lane, tile);
  }

  public long find(java.math.BigInteger id) {
    return interop_metricsJNI.base_q_metrics_find__SWIG_2(swigCPtr, this, id);
  }

  public boolean has_metric(long lane, long tile, long cycle) {
    return interop_metricsJNI.base_q_metrics_has_metric__SWIG_0(swigCPtr, this, lane, tile, cycle);
  }

  public boolean has_metric(long lane, long tile) {
    return interop_metricsJNI.base_q_metrics_has_metric__SWIG_1(swigCPtr, this, lane, tile);
  }

  public boolean has_metric(java.math.BigInteger id) {
    return interop_metricsJNI.base_q_metrics_has_metric__SWIG_2(swigCPtr, this, id);
  }

  public void insert(q_metric metric) {
    interop_metricsJNI.base_q_metrics_insert__SWIG_0(swigCPtr, this, q_metric.getCPtr(metric), metric);
  }

  public void insert(java.math.BigInteger id, q_metric metric) {
    interop_metricsJNI.base_q_metrics_insert__SWIG_1(swigCPtr, this, id, q_metric.getCPtr(metric), metric);
  }

  public q_metric get_metric(long lane, long tile, long cycle) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_get_metric__SWIG_0(swigCPtr, this, lane, tile, cycle), false);
  }

  public q_metric get_metric(long lane, long tile) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_get_metric__SWIG_1(swigCPtr, this, lane, tile), false);
  }

  public q_metric get_metric(java.math.BigInteger key) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_get_metric__SWIG_2(swigCPtr, this, key), false);
  }

  public q_metric at(long n) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_at(swigCPtr, this, n), false);
  }

  public void set_version(short version) {
    interop_metricsJNI.base_q_metrics_set_version(swigCPtr, this, version);
  }

  public ulong_vector keys() {
    return new ulong_vector(interop_metricsJNI.base_q_metrics_keys(swigCPtr, this), true);
  }

  public uint_vector lanes() {
    return new uint_vector(interop_metricsJNI.base_q_metrics_lanes(swigCPtr, this), true);
  }

  public long lane_count() {
    return interop_metricsJNI.base_q_metrics_lane_count(swigCPtr, this);
  }

  public long max_lane() {
    return interop_metricsJNI.base_q_metrics_max_lane(swigCPtr, this);
  }

  public uint_vector tile_numbers_for_lane(long lane) {
    return new uint_vector(interop_metricsJNI.base_q_metrics_tile_numbers_for_lane(swigCPtr, this, lane), true);
  }

  public uint_vector tile_numbers() {
    return new uint_vector(interop_metricsJNI.base_q_metrics_tile_numbers(swigCPtr, this), true);
  }

  public vector_q_metrics metrics_for_lane(long lane) {
    return new vector_q_metrics(interop_metricsJNI.base_q_metrics_metrics_for_lane__SWIG_0(swigCPtr, this, lane), true);
  }

  public void metrics_for_lane(vector_q_metrics lane_metrics, long lane) {
    interop_metricsJNI.base_q_metrics_metrics_for_lane__SWIG_1(swigCPtr, this, vector_q_metrics.getCPtr(lane_metrics), lane_metrics, lane);
  }

  public uint_vector cycles() {
    return new uint_vector(interop_metricsJNI.base_q_metrics_cycles(swigCPtr, this), true);
  }

  public vector_q_metrics metrics_for_cycle(long cycle) {
    return new vector_q_metrics(interop_metricsJNI.base_q_metrics_metrics_for_cycle(swigCPtr, this, cycle), true);
  }

  public long size() {
    return interop_metricsJNI.base_q_metrics_size(swigCPtr, this);
  }

  public boolean empty() {
    return interop_metricsJNI.base_q_metrics_empty(swigCPtr, this);
  }

  public short version() {
    return interop_metricsJNI.base_q_metrics_version(swigCPtr, this);
  }

  public void clear() {
    interop_metricsJNI.base_q_metrics_clear(swigCPtr, this);
  }

  public vector_q_metrics metrics() {
    return new vector_q_metrics(interop_metricsJNI.base_q_metrics_metrics(swigCPtr, this), false);
  }

  public static String prefix() {
    return interop_metricsJNI.base_q_metrics_prefix();
  }

  public static String suffix() {
    return interop_metricsJNI.base_q_metrics_suffix();
  }

  public q_metric get_metric_ref(long lane, long tile, long cycle) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_get_metric_ref__SWIG_0(swigCPtr, this, lane, tile, cycle), false);
  }

  public q_metric get_metric_ref(long lane, long tile) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_get_metric_ref__SWIG_1(swigCPtr, this, lane, tile), false);
  }

  public q_metric get_metric_ref(java.math.BigInteger key) throws index_out_of_bounds_exception {
    return new q_metric(interop_metricsJNI.base_q_metrics_get_metric_ref__SWIG_2(swigCPtr, this, key), false);
  }

  public final static int TYPE = interop_metricsJNI.base_q_metrics_TYPE_get();
  public final static int LATEST_VERSION = interop_metricsJNI.base_q_metrics_LATEST_VERSION_get();

}
