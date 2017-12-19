/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class color_matrix_metric_header extends base_cycle_metric_header {
  private transient long swigCPtr;

  protected color_matrix_metric_header(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.color_matrix_metric_header_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(color_matrix_metric_header obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_color_matrix_metric_header(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public color_matrix_metric_header(int number_of_entries) {
    this(interop_metricsJNI.new_color_matrix_metric_header(number_of_entries), true);
  }

  public int number_of_entries() {
    return interop_metricsJNI.color_matrix_metric_header_number_of_entries(swigCPtr, this);
  }

  public static color_matrix_metric_header default_header() {
    return new color_matrix_metric_header(interop_metricsJNI.color_matrix_metric_header_default_header(), true);
  }

  public void clear() {
    interop_metricsJNI.color_matrix_metric_header_clear(swigCPtr, this);
  }

}
