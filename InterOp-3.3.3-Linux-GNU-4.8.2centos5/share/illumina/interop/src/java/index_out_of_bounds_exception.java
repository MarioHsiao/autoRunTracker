/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class index_out_of_bounds_exception extends base_exception {
  private transient long swigCPtr;

  protected index_out_of_bounds_exception(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.index_out_of_bounds_exception_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(index_out_of_bounds_exception obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_index_out_of_bounds_exception(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public index_out_of_bounds_exception(String mesg) {
    this(interop_metricsJNI.new_index_out_of_bounds_exception(mesg), true);
  }

}
