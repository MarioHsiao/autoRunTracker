/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class color_matrix_metric extends base_cycle_metric {
  private transient long swigCPtr;

  protected color_matrix_metric(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.color_matrix_metric_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(color_matrix_metric obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_color_matrix_metric(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public color_matrix_metric() {
    this(interop_metricsJNI.new_color_matrix_metric__SWIG_0(), true);
  }

  public color_matrix_metric(color_matrix_metric_header header) {
    this(interop_metricsJNI.new_color_matrix_metric__SWIG_1(color_matrix_metric_header.getCPtr(header), header), true);
  }

  public float_vector color_matrix() {
    return new float_vector(interop_metricsJNI.color_matrix_metric_color_matrix(swigCPtr, this), false);
  }

  public static String prefix() {
    return interop_metricsJNI.color_matrix_metric_prefix();
  }

  public final static int TYPE = interop_metricsJNI.color_matrix_metric_TYPE_get();
  public final static int LATEST_VERSION = interop_metricsJNI.color_matrix_metric_LATEST_VERSION_get();

}
