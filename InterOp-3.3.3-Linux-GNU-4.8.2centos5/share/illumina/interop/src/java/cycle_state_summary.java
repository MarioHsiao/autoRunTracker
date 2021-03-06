/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class cycle_state_summary {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected cycle_state_summary(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(cycle_state_summary obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_summaryJNI.delete_cycle_state_summary(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public cycle_state_summary() {
    this(interop_summaryJNI.new_cycle_state_summary(), true);
  }

  public cycle_range extracted_cycle_range() {
    return new cycle_range(interop_summaryJNI.cycle_state_summary_extracted_cycle_range__SWIG_0(swigCPtr, this), false);
  }

  public cycle_range called_cycle_range() {
    return new cycle_range(interop_summaryJNI.cycle_state_summary_called_cycle_range__SWIG_0(swigCPtr, this), false);
  }

  public cycle_range qscored_cycle_range() {
    return new cycle_range(interop_summaryJNI.cycle_state_summary_qscored_cycle_range__SWIG_0(swigCPtr, this), false);
  }

  public cycle_range error_cycle_range() {
    return new cycle_range(interop_summaryJNI.cycle_state_summary_error_cycle_range__SWIG_0(swigCPtr, this), false);
  }

  public boolean empty() {
    return interop_summaryJNI.cycle_state_summary_empty(swigCPtr, this);
  }

  public void extracted_cycle_range(cycle_range val) {
    interop_summaryJNI.cycle_state_summary_extracted_cycle_range__SWIG_1(swigCPtr, this, cycle_range.getCPtr(val), val);
  }

  public void called_cycle_range(cycle_range val) {
    interop_summaryJNI.cycle_state_summary_called_cycle_range__SWIG_1(swigCPtr, this, cycle_range.getCPtr(val), val);
  }

  public void qscored_cycle_range(cycle_range val) {
    interop_summaryJNI.cycle_state_summary_qscored_cycle_range__SWIG_1(swigCPtr, this, cycle_range.getCPtr(val), val);
  }

  public void error_cycle_range(cycle_range val) {
    interop_summaryJNI.cycle_state_summary_error_cycle_range__SWIG_1(swigCPtr, this, cycle_range.getCPtr(val), val);
  }

}
