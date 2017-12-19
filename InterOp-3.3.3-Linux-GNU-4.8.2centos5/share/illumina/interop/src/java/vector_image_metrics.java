/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class vector_image_metrics {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected vector_image_metrics(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(vector_image_metrics obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_vector_image_metrics(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public vector_image_metrics() {
    this(interop_metricsJNI.new_vector_image_metrics__SWIG_0(), true);
  }

  public vector_image_metrics(long n) {
    this(interop_metricsJNI.new_vector_image_metrics__SWIG_1(n), true);
  }

  public long size() {
    return interop_metricsJNI.vector_image_metrics_size(swigCPtr, this);
  }

  public long capacity() {
    return interop_metricsJNI.vector_image_metrics_capacity(swigCPtr, this);
  }

  public void reserve(long n) {
    interop_metricsJNI.vector_image_metrics_reserve(swigCPtr, this, n);
  }

  public boolean isEmpty() {
    return interop_metricsJNI.vector_image_metrics_isEmpty(swigCPtr, this);
  }

  public void clear() {
    interop_metricsJNI.vector_image_metrics_clear(swigCPtr, this);
  }

  public void add(image_metric x) {
    interop_metricsJNI.vector_image_metrics_add(swigCPtr, this, image_metric.getCPtr(x), x);
  }

  public image_metric get(int i) {
    return new image_metric(interop_metricsJNI.vector_image_metrics_get(swigCPtr, this, i), false);
  }

  public void set(int i, image_metric val) {
    interop_metricsJNI.vector_image_metrics_set(swigCPtr, this, i, image_metric.getCPtr(val), val);
  }

}