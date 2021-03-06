/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class q_score_bin_vector {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected q_score_bin_vector(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(q_score_bin_vector obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_q_score_bin_vector(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public q_score_bin_vector() {
    this(interop_metricsJNI.new_q_score_bin_vector__SWIG_0(), true);
  }

  public q_score_bin_vector(long n) {
    this(interop_metricsJNI.new_q_score_bin_vector__SWIG_1(n), true);
  }

  public long size() {
    return interop_metricsJNI.q_score_bin_vector_size(swigCPtr, this);
  }

  public long capacity() {
    return interop_metricsJNI.q_score_bin_vector_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    interop_metricsJNI.q_score_bin_vector_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return interop_metricsJNI.q_score_bin_vector_isEmpty(swigCPtr, this);
  }

  public void clear() {
    interop_metricsJNI.q_score_bin_vector_clear(swigCPtr, this);
  }

  public void add(q_score_bin x) {
    interop_metricsJNI.q_score_bin_vector_add(swigCPtr, this, q_score_bin.getCPtr(x), x);
  }

  public q_score_bin get(int i) {
    return new q_score_bin(interop_metricsJNI.q_score_bin_vector_get(swigCPtr, this, i), false);
  }

  public void set(int i, q_score_bin val) {
    interop_metricsJNI.q_score_bin_vector_set(swigCPtr, this, i, q_score_bin.getCPtr(val), val);
  }

}
