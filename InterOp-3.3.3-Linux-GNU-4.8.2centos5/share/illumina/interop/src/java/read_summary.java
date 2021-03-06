/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class read_summary {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected read_summary(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(read_summary obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_summaryJNI.delete_read_summary(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public read_summary(read_info read, long channel_count) {
    this(interop_summaryJNI.new_read_summary__SWIG_0(read_info.getCPtr(read), read, channel_count), true);
  }

  public read_summary(read_info read) {
    this(interop_summaryJNI.new_read_summary__SWIG_1(read_info.getCPtr(read), read), true);
  }

  public read_summary() {
    this(interop_summaryJNI.new_read_summary__SWIG_2(), true);
  }

  public lane_summary at(long n) throws index_out_of_bounds_exception {
    return new lane_summary(interop_summaryJNI.read_summary_at(swigCPtr, this, n), false);
  }

  public void resize(long n) {
    interop_summaryJNI.read_summary_resize(swigCPtr, this, n);
  }

  public read_info read() {
    return new read_info(interop_summaryJNI.read_summary_read(swigCPtr, this), false);
  }

  public metric_summary summary() {
    return new metric_summary(interop_summaryJNI.read_summary_summary__SWIG_0(swigCPtr, this), false);
  }

  public void summary(metric_summary summary) {
    interop_summaryJNI.read_summary_summary__SWIG_1(swigCPtr, this, metric_summary.getCPtr(summary), summary);
  }

  public long size() {
    return interop_summaryJNI.read_summary_size(swigCPtr, this);
  }

  public long lane_count() {
    return interop_summaryJNI.read_summary_lane_count(swigCPtr, this);
  }

}
