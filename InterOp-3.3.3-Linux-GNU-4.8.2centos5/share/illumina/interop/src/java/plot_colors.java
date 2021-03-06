/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public final class plot_colors {
  public final static plot_colors Red = new plot_colors("Red");
  public final static plot_colors Green = new plot_colors("Green");
  public final static plot_colors Blue = new plot_colors("Blue");
  public final static plot_colors Black = new plot_colors("Black");
  public final static plot_colors PlotColorCount = new plot_colors("PlotColorCount");
  public final static plot_colors UnknownColor = new plot_colors("UnknownColor", interop_runJNI.UnknownColor_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static plot_colors swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + plot_colors.class + " with value " + swigValue);
  }

  private plot_colors(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private plot_colors(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private plot_colors(String swigName, plot_colors swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static plot_colors[] swigValues = { Red, Green, Blue, Black, PlotColorCount, UnknownColor };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

