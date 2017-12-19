/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class error_metric extends base_cycle_metric {
  private transient long swigCPtr;

  protected error_metric(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.error_metric_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(error_metric obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_error_metric(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public error_metric() {
    this(interop_metricsJNI.new_error_metric__SWIG_0(), true);
  }

  public error_metric(base_cycle_metric_header arg0) {
    this(interop_metricsJNI.new_error_metric__SWIG_1(base_cycle_metric_header.getCPtr(arg0), arg0), true);
  }

  public error_metric(long lane, long tile, long cycle, float error) {
    this(interop_metricsJNI.new_error_metric__SWIG_2(lane, tile, cycle, error), true);
  }

  public float error_rate() {
    return interop_metricsJNI.error_metric_error_rate(swigCPtr, this);
  }

  public long mismatch_cluster_count(long n) throws index_out_of_bounds_exception {
    return interop_metricsJNI.error_metric_mismatch_cluster_count(swigCPtr, this, n);
  }

  public long mismatch_count() {
    return interop_metricsJNI.error_metric_mismatch_count(swigCPtr, this);
  }

  public uint_vector mismatch_cluster_counts() {
    return new uint_vector(interop_metricsJNI.error_metric_mismatch_cluster_counts(swigCPtr, this), false);
  }

  public float errorRate() {
    return interop_metricsJNI.error_metric_errorRate(swigCPtr, this);
  }

  public static String prefix() {
    return interop_metricsJNI.error_metric_prefix();
  }

  public final static int MAX_MISMATCH = interop_metricsJNI.error_metric_MAX_MISMATCH_get();
  public final static int TYPE = interop_metricsJNI.error_metric_TYPE_get();
  public final static int LATEST_VERSION = interop_metricsJNI.error_metric_LATEST_VERSION_get();

}
