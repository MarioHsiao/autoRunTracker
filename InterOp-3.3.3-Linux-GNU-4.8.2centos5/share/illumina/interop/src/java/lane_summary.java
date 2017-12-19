/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class lane_summary extends stat_summary {
  private transient long swigCPtr;

  protected lane_summary(long cPtr, boolean cMemoryOwn) {
    super(interop_summaryJNI.lane_summary_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(lane_summary obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_summaryJNI.delete_lane_summary(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public lane_summary(long lane, long channel_count) {
    this(interop_summaryJNI.new_lane_summary__SWIG_0(lane, channel_count), true);
  }

  public lane_summary(long lane) {
    this(interop_summaryJNI.new_lane_summary__SWIG_1(lane), true);
  }

  public lane_summary() {
    this(interop_summaryJNI.new_lane_summary__SWIG_2(), true);
  }

  public surface_summary at(long n) throws index_out_of_bounds_exception {
    return new surface_summary(interop_summaryJNI.lane_summary_at(swigCPtr, this, n), false);
  }

  public void resize(long n) {
    interop_summaryJNI.lane_summary_resize(swigCPtr, this, n);
  }

  public void lane(long val) {
    interop_summaryJNI.lane_summary_lane__SWIG_0(swigCPtr, this, val);
  }

  public void tile_count(long val) {
    interop_summaryJNI.lane_summary_tile_count__SWIG_0(swigCPtr, this, val);
  }

  public cycle_state_summary cycle_state() {
    return new cycle_state_summary(interop_summaryJNI.lane_summary_cycle_state(swigCPtr, this), false);
  }

  public long lane() {
    return interop_summaryJNI.lane_summary_lane__SWIG_1(swigCPtr, this);
  }

  public long tile_count() {
    return interop_summaryJNI.lane_summary_tile_count__SWIG_1(swigCPtr, this);
  }

  public long size() {
    return interop_summaryJNI.lane_summary_size(swigCPtr, this);
  }

}
