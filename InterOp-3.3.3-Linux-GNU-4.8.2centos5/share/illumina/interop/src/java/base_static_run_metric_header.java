/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class base_static_run_metric_header extends empty_header {
  private transient long swigCPtr;

  protected base_static_run_metric_header(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.base_static_run_metric_header_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(base_static_run_metric_header obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_base_static_run_metric_header(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public base_static_run_metric_header() {
    this(interop_metricsJNI.new_base_static_run_metric_header(), true);
  }

}
