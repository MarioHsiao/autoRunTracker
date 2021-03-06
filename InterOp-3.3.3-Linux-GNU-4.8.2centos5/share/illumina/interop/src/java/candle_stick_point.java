/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class candle_stick_point extends float_point {
  private transient long swigCPtr;

  protected candle_stick_point(long cPtr, boolean cMemoryOwn) {
    super(interop_plotJNI.candle_stick_point_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(candle_stick_point obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_plotJNI.delete_candle_stick_point(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public candle_stick_point(float x, float p25, float p50, float p75, float lower, float upper, long data_point_count, float_vector outliers) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_0(x, p25, p50, p75, lower, upper, data_point_count, float_vector.getCPtr(outliers), outliers), true);
  }

  public candle_stick_point(float x, float p25, float p50, float p75, float lower, float upper, long data_point_count) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_1(x, p25, p50, p75, lower, upper, data_point_count), true);
  }

  public candle_stick_point(float x, float p25, float p50, float p75, float lower, float upper) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_2(x, p25, p50, p75, lower, upper), true);
  }

  public candle_stick_point(float x, float p25, float p50, float p75, float lower) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_3(x, p25, p50, p75, lower), true);
  }

  public candle_stick_point(float x, float p25, float p50, float p75) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_4(x, p25, p50, p75), true);
  }

  public candle_stick_point(float x, float p25, float p50) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_5(x, p25, p50), true);
  }

  public candle_stick_point(float x, float p25) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_6(x, p25), true);
  }

  public candle_stick_point(float x) {
    this(interop_plotJNI.new_candle_stick_point__SWIG_7(x), true);
  }

  public candle_stick_point() {
    this(interop_plotJNI.new_candle_stick_point__SWIG_8(), true);
  }

  public float max_value() {
    return interop_plotJNI.candle_stick_point_max_value(swigCPtr, this);
  }

  public float min_value() {
    return interop_plotJNI.candle_stick_point_min_value(swigCPtr, this);
  }

  public float p25() {
    return interop_plotJNI.candle_stick_point_p25(swigCPtr, this);
  }

  public float p50() {
    return interop_plotJNI.candle_stick_point_p50(swigCPtr, this);
  }

  public float p75() {
    return interop_plotJNI.candle_stick_point_p75(swigCPtr, this);
  }

  public float lower() {
    return interop_plotJNI.candle_stick_point_lower(swigCPtr, this);
  }

  public float upper() {
    return interop_plotJNI.candle_stick_point_upper(swigCPtr, this);
  }

  public float_vector outliers() {
    return new float_vector(interop_plotJNI.candle_stick_point_outliers(swigCPtr, this), false);
  }

  public long data_point_count() {
    return interop_plotJNI.candle_stick_point_data_point_count(swigCPtr, this);
  }

}
