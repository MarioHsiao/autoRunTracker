/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public final class metric_data {
  public final static metric_data IdType = new metric_data("IdType");
  public final static metric_data ValueType = new metric_data("ValueType");
  public final static metric_data StructType = new metric_data("StructType");
  public final static metric_data ChannelArray = new metric_data("ChannelArray");
  public final static metric_data BaseArray = new metric_data("BaseArray");
  public final static metric_data UpperLeftPoint = new metric_data("UpperLeftPoint");
  public final static metric_data AffineTransformArray = new metric_data("AffineTransformArray");
  public final static metric_data SubTileOffsetArray = new metric_data("SubTileOffsetArray");
  public final static metric_data BaseXYArray = new metric_data("BaseXYArray");
  public final static metric_data Base2DArray = new metric_data("Base2DArray");
  public final static metric_data ColorMatrixArray = new metric_data("ColorMatrixArray");
  public final static metric_data RunDiagnosticsArray = new metric_data("RunDiagnosticsArray");
  public final static metric_data MetricDataCount = new metric_data("MetricDataCount");
  public final static metric_data UnknownMetricData = new metric_data("UnknownMetricData", interop_runJNI.UnknownMetricData_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static metric_data swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + metric_data.class + " with value " + swigValue);
  }

  private metric_data(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private metric_data(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private metric_data(String swigName, metric_data swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static metric_data[] swigValues = { IdType, ValueType, StructType, ChannelArray, BaseArray, UpperLeftPoint, AffineTransformArray, SubTileOffsetArray, BaseXYArray, Base2DArray, ColorMatrixArray, RunDiagnosticsArray, MetricDataCount, UnknownMetricData };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}
