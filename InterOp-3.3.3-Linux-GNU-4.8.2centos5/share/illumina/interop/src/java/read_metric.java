/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class read_metric {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected read_metric(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(read_metric obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_read_metric(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public read_metric(long read, float percent_aligned, float percent_phasing, float percent_prephasing) {
    this(interop_metricsJNI.new_read_metric__SWIG_0(read, percent_aligned, percent_phasing, percent_prephasing), true);
  }

  public read_metric(long read, float percent_aligned, float percent_phasing) {
    this(interop_metricsJNI.new_read_metric__SWIG_1(read, percent_aligned, percent_phasing), true);
  }

  public read_metric(long read, float percent_aligned) {
    this(interop_metricsJNI.new_read_metric__SWIG_2(read, percent_aligned), true);
  }

  public read_metric(long read) {
    this(interop_metricsJNI.new_read_metric__SWIG_3(read), true);
  }

  public read_metric() {
    this(interop_metricsJNI.new_read_metric__SWIG_4(), true);
  }

  public long read() {
    return interop_metricsJNI.read_metric_read(swigCPtr, this);
  }

  public float percent_aligned() {
    return interop_metricsJNI.read_metric_percent_aligned__SWIG_0(swigCPtr, this);
  }

  public float percent_phasing() {
    return interop_metricsJNI.read_metric_percent_phasing__SWIG_0(swigCPtr, this);
  }

  public float percent_prephasing() {
    return interop_metricsJNI.read_metric_percent_prephasing__SWIG_0(swigCPtr, this);
  }

  public void percent_aligned(float val) {
    interop_metricsJNI.read_metric_percent_aligned__SWIG_1(swigCPtr, this, val);
  }

  public void percent_phasing(float val) {
    interop_metricsJNI.read_metric_percent_phasing__SWIG_1(swigCPtr, this, val);
  }

  public void percent_prephasing(float val) {
    interop_metricsJNI.read_metric_percent_prephasing__SWIG_1(swigCPtr, this, val);
  }

}