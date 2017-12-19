/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class tile_metric extends base_metric {
  private transient long swigCPtr;

  protected tile_metric(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.tile_metric_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(tile_metric obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_tile_metric(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public tile_metric() {
    this(interop_metricsJNI.new_tile_metric__SWIG_0(), true);
  }

  public tile_metric(tile_metric_header arg0) {
    this(interop_metricsJNI.new_tile_metric__SWIG_1(tile_metric_header.getCPtr(arg0), arg0), true);
  }

  public tile_metric(long lane, long tile, float cluster_density, float cluster_density_pf, float cluster_count, float cluster_count_pf, read_metric_vector read_metrics) {
    this(interop_metricsJNI.new_tile_metric__SWIG_2(lane, tile, cluster_density, cluster_density_pf, cluster_count, cluster_count_pf, read_metric_vector.getCPtr(read_metrics), read_metrics), true);
  }

  public tile_metric(long lane, long tile, float cluster_density, float cluster_density_pf, float cluster_count, float cluster_count_pf) {
    this(interop_metricsJNI.new_tile_metric__SWIG_3(lane, tile, cluster_density, cluster_density_pf, cluster_count, cluster_count_pf), true);
  }

  public tile_metric(long lane, long tile, read_metric_vector read_metrics) {
    this(interop_metricsJNI.new_tile_metric__SWIG_4(lane, tile, read_metric_vector.getCPtr(read_metrics), read_metrics), true);
  }

  public tile_metric(long lane, long tile) {
    this(interop_metricsJNI.new_tile_metric__SWIG_5(lane, tile), true);
  }

  public tile_metric(tile_metric metric, read_metric_vector read_metrics) {
    this(interop_metricsJNI.new_tile_metric__SWIG_6(tile_metric.getCPtr(metric), metric, read_metric_vector.getCPtr(read_metrics), read_metrics), true);
  }

  public tile_metric(tile_metric metric) {
    this(interop_metricsJNI.new_tile_metric__SWIG_7(tile_metric.getCPtr(metric), metric), true);
  }

  public tile_metric(long lane, long tile, float cluster_count, float cluster_count_pf, read_metric_vector read_metrics) {
    this(interop_metricsJNI.new_tile_metric__SWIG_8(lane, tile, cluster_count, cluster_count_pf, read_metric_vector.getCPtr(read_metrics), read_metrics), true);
  }

  public tile_metric(long lane, long tile, float cluster_count, float cluster_count_pf) {
    this(interop_metricsJNI.new_tile_metric__SWIG_9(lane, tile, cluster_count, cluster_count_pf), true);
  }

  public float cluster_density() {
    return interop_metricsJNI.tile_metric_cluster_density(swigCPtr, this);
  }

  public float cluster_density_k() {
    return interop_metricsJNI.tile_metric_cluster_density_k(swigCPtr, this);
  }

  public float cluster_density_pf() {
    return interop_metricsJNI.tile_metric_cluster_density_pf(swigCPtr, this);
  }

  public float cluster_density_pf_k() {
    return interop_metricsJNI.tile_metric_cluster_density_pf_k(swigCPtr, this);
  }

  public float cluster_count() {
    return interop_metricsJNI.tile_metric_cluster_count(swigCPtr, this);
  }

  public float cluster_count_k() {
    return interop_metricsJNI.tile_metric_cluster_count_k(swigCPtr, this);
  }

  public float cluster_count_m() {
    return interop_metricsJNI.tile_metric_cluster_count_m(swigCPtr, this);
  }

  public float cluster_count_pf() {
    return interop_metricsJNI.tile_metric_cluster_count_pf(swigCPtr, this);
  }

  public float cluster_count_pf_k() {
    return interop_metricsJNI.tile_metric_cluster_count_pf_k(swigCPtr, this);
  }

  public float cluster_count_pf_m() {
    return interop_metricsJNI.tile_metric_cluster_count_pf_m(swigCPtr, this);
  }

  public float percent_pf() {
    return interop_metricsJNI.tile_metric_percent_pf(swigCPtr, this);
  }

  public read_metric_vector read_metrics() {
    return new read_metric_vector(interop_metricsJNI.tile_metric_read_metrics(swigCPtr, this), false);
  }

  public float percent_aligned(long n) {
    return interop_metricsJNI.tile_metric_percent_aligned(swigCPtr, this, n);
  }

  public float percent_phasing(long n) {
    return interop_metricsJNI.tile_metric_percent_phasing(swigCPtr, this, n);
  }

  public float percent_prephasing(long n) {
    return interop_metricsJNI.tile_metric_percent_prephasing(swigCPtr, this, n);
  }

  public float percent_aligned_at(long number) {
    return interop_metricsJNI.tile_metric_percent_aligned_at(swigCPtr, this, number);
  }

  public float percent_phasing_at(long number) {
    return interop_metricsJNI.tile_metric_percent_phasing_at(swigCPtr, this, number);
  }

  public float percent_prephasing_at(long number) {
    return interop_metricsJNI.tile_metric_percent_prephasing_at(swigCPtr, this, number);
  }

  public long read_count() {
    return interop_metricsJNI.tile_metric_read_count(swigCPtr, this);
  }

  public boolean is_dead_tile() {
    return interop_metricsJNI.tile_metric_is_dead_tile(swigCPtr, this);
  }

  public void update_phasing_if_missing(long number, float phasing, float prephasing) {
    interop_metricsJNI.tile_metric_update_phasing_if_missing(swigCPtr, this, number, phasing, prephasing);
  }

  public float clusterDensity() {
    return interop_metricsJNI.tile_metric_clusterDensity(swigCPtr, this);
  }

  public float clusterDensityPf() {
    return interop_metricsJNI.tile_metric_clusterDensityPf(swigCPtr, this);
  }

  public float clusterCount() {
    return interop_metricsJNI.tile_metric_clusterCount(swigCPtr, this);
  }

  public float clusterCountPf() {
    return interop_metricsJNI.tile_metric_clusterCountPf(swigCPtr, this);
  }

  public static String prefix() {
    return interop_metricsJNI.tile_metric_prefix();
  }

  public final static int TYPE = interop_metricsJNI.tile_metric_TYPE_get();
  public final static int LATEST_VERSION = interop_metricsJNI.tile_metric_LATEST_VERSION_get();

}
