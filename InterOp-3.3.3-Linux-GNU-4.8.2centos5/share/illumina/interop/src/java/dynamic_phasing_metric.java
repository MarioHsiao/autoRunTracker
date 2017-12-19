/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class dynamic_phasing_metric extends base_read_metric {
  private transient long swigCPtr;

  protected dynamic_phasing_metric(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.dynamic_phasing_metric_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(dynamic_phasing_metric obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_dynamic_phasing_metric(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public dynamic_phasing_metric() {
    this(interop_metricsJNI.new_dynamic_phasing_metric__SWIG_0(), true);
  }

  public dynamic_phasing_metric(base_read_metric_header arg0) {
    this(interop_metricsJNI.new_dynamic_phasing_metric__SWIG_1(base_read_metric_header.getCPtr(arg0), arg0), true);
  }

  public dynamic_phasing_metric(long lane, long tile, long read, float phasing_slope, float phasing_offset, float prephasing_slope, float prephasing_offset) {
    this(interop_metricsJNI.new_dynamic_phasing_metric__SWIG_2(lane, tile, read, phasing_slope, phasing_offset, prephasing_slope, prephasing_offset), true);
  }

  public float phasing_slope() {
    return interop_metricsJNI.dynamic_phasing_metric_phasing_slope(swigCPtr, this);
  }

  public float prephasing_slope() {
    return interop_metricsJNI.dynamic_phasing_metric_prephasing_slope(swigCPtr, this);
  }

  public float phasing_offset() {
    return interop_metricsJNI.dynamic_phasing_metric_phasing_offset(swigCPtr, this);
  }

  public float prephasing_offset() {
    return interop_metricsJNI.dynamic_phasing_metric_prephasing_offset(swigCPtr, this);
  }

  public static String prefix() {
    return interop_metricsJNI.dynamic_phasing_metric_prefix();
  }

  public final static int TYPE = interop_metricsJNI.dynamic_phasing_metric_TYPE_get();
  public final static int LATEST_VERSION = interop_metricsJNI.dynamic_phasing_metric_LATEST_VERSION_get();

}
