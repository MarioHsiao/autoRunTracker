/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class invalid_filter_option extends base_exception {
  private transient long swigCPtr;

  protected invalid_filter_option(long cPtr, boolean cMemoryOwn) {
    super(interop_plotJNI.invalid_filter_option_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(invalid_filter_option obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_plotJNI.delete_invalid_filter_option(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public invalid_filter_option(String mesg) {
    this(interop_plotJNI.new_invalid_filter_option(mesg), true);
  }

}
