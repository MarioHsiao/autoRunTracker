/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class point2d_vector {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected point2d_vector(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(point2d_vector obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_point2d_vector(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public point2d_vector() {
    this(interop_metricsJNI.new_point2d_vector__SWIG_0(), true);
  }

  public point2d_vector(long n) {
    this(interop_metricsJNI.new_point2d_vector__SWIG_1(n), true);
  }

  public long size() {
    return interop_metricsJNI.point2d_vector_size(swigCPtr, this);
  }

  public long capacity() {
    return interop_metricsJNI.point2d_vector_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    interop_metricsJNI.point2d_vector_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return interop_metricsJNI.point2d_vector_isEmpty(swigCPtr, this);
  }

  public void clear() {
    interop_metricsJNI.point2d_vector_clear(swigCPtr, this);
  }

  public void add(point2d x) {
    interop_metricsJNI.point2d_vector_add(swigCPtr, this, point2d.getCPtr(x), x);
  }

  public point2d get(int i) {
    return new point2d(interop_metricsJNI.point2d_vector_get(swigCPtr, this, i), false);
  }

  public void set(int i, point2d val) {
    interop_metricsJNI.point2d_vector_set(swigCPtr, this, i, point2d.getCPtr(val), val);
  }

}