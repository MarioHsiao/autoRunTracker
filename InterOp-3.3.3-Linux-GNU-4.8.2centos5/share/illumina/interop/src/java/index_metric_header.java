/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class index_metric_header extends base_read_metric_header {
  private transient long swigCPtr;

  protected index_metric_header(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.index_metric_header_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(index_metric_header obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_index_metric_header(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public index_metric_header() {
    this(interop_metricsJNI.new_index_metric_header(), true);
  }

  public string_vector index_order() {
    return new string_vector(interop_metricsJNI.index_metric_header_index_order__SWIG_0(swigCPtr, this), false);
  }

  public void index_order(string_vector order) {
    interop_metricsJNI.index_metric_header_index_order__SWIG_1(swigCPtr, this, string_vector.getCPtr(order), order);
  }

  public static index_metric_header default_header() {
    return new index_metric_header(interop_metricsJNI.index_metric_header_default_header(), true);
  }

  public void clear() {
    interop_metricsJNI.index_metric_header_clear(swigCPtr, this);
  }

}
