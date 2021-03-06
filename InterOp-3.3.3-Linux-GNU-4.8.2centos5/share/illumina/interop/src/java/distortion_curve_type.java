/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public final class distortion_curve_type {
  public final static distortion_curve_type DistortionXonX = new distortion_curve_type("DistortionXonX");
  public final static distortion_curve_type DistortionXYonX = new distortion_curve_type("DistortionXYonX");
  public final static distortion_curve_type UnknownDistortionCurve = new distortion_curve_type("UnknownDistortionCurve", interop_runJNI.UnknownDistortionCurve_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static distortion_curve_type swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + distortion_curve_type.class + " with value " + swigValue);
  }

  private distortion_curve_type(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private distortion_curve_type(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private distortion_curve_type(String swigName, distortion_curve_type swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static distortion_curve_type[] swigValues = { DistortionXonX, DistortionXYonX, UnknownDistortionCurve };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

