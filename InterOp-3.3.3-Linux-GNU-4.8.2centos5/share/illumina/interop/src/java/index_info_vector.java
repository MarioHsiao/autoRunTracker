/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class index_info_vector {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected index_info_vector(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(index_info_vector obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_index_info_vector(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public index_info_vector() {
    this(interop_metricsJNI.new_index_info_vector__SWIG_0(), true);
  }

  public index_info_vector(long n) {
    this(interop_metricsJNI.new_index_info_vector__SWIG_1(n), true);
  }

  public long size() {
    return interop_metricsJNI.index_info_vector_size(swigCPtr, this);
  }

  public long capacity() {
    return interop_metricsJNI.index_info_vector_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    interop_metricsJNI.index_info_vector_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return interop_metricsJNI.index_info_vector_isEmpty(swigCPtr, this);
  }

  public void clear() {
    interop_metricsJNI.index_info_vector_clear(swigCPtr, this);
  }

  public void add(index_info x) {
    interop_metricsJNI.index_info_vector_add(swigCPtr, this, index_info.getCPtr(x), x);
  }

  public index_info get(int i) {
    return new index_info(interop_metricsJNI.index_info_vector_get(swigCPtr, this, i), false);
  }

  public void set(int i, index_info val) {
    interop_metricsJNI.index_info_vector_set(swigCPtr, this, i, index_info.getCPtr(val), val);
  }

}
