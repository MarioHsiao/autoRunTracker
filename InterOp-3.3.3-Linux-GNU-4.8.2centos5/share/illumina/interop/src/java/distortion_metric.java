/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class distortion_metric extends base_metric {
  private transient long swigCPtr;

  protected distortion_metric(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.distortion_metric_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(distortion_metric obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_distortion_metric(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public distortion_metric() {
    this(interop_metricsJNI.new_distortion_metric__SWIG_0(), true);
  }

  public distortion_metric(distortion_metric_header header) {
    this(interop_metricsJNI.new_distortion_metric__SWIG_1(distortion_metric_header.getCPtr(header), header), true);
  }

  public float_vector coefficients() {
    return new float_vector(interop_metricsJNI.distortion_metric_coefficients(swigCPtr, this), false);
  }

  public float coefficient_at(long index) throws index_out_of_bounds_exception {
    return interop_metricsJNI.distortion_metric_coefficient_at(swigCPtr, this, index);
  }

  public void populate_coefficients_for(distortion_metric_header header, long channel, long curve_index, float_vector coeff) {
    interop_metricsJNI.distortion_metric_populate_coefficients_for__SWIG_0(swigCPtr, this, distortion_metric_header.getCPtr(header), header, channel, curve_index, float_vector.getCPtr(coeff), coeff);
  }

  public void populate_coefficients_for(distortion_metric_header header, long channel, long curve_index, float[] buffer, long arg4) {
    interop_metricsJNI.distortion_metric_populate_coefficients_for__SWIG_1(swigCPtr, this, distortion_metric_header.getCPtr(header), header, channel, curve_index, buffer, arg4);
  }

  public float absolute_distortion(distortion_metric_header header, long channel, long curve_index, long image_width) {
    return interop_metricsJNI.distortion_metric_absolute_distortion(swigCPtr, this, distortion_metric_header.getCPtr(header), header, channel, curve_index, image_width);
  }

  public static String prefix() {
    return interop_metricsJNI.distortion_metric_prefix();
  }

  public final static int TYPE = interop_metricsJNI.distortion_metric_TYPE_get();
  public final static int LATEST_VERSION = interop_metricsJNI.distortion_metric_LATEST_VERSION_get();

}