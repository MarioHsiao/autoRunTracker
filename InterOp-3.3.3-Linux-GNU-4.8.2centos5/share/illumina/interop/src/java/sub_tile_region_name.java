/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public final class sub_tile_region_name {
  public final static sub_tile_region_name NNW = new sub_tile_region_name("NNW");
  public final static sub_tile_region_name NNE = new sub_tile_region_name("NNE");
  public final static sub_tile_region_name NW = new sub_tile_region_name("NW");
  public final static sub_tile_region_name NE = new sub_tile_region_name("NE");
  public final static sub_tile_region_name SW = new sub_tile_region_name("SW");
  public final static sub_tile_region_name SE = new sub_tile_region_name("SE");
  public final static sub_tile_region_name SSW = new sub_tile_region_name("SSW");
  public final static sub_tile_region_name SSE = new sub_tile_region_name("SSE");
  public final static sub_tile_region_name SubTileRegionCount = new sub_tile_region_name("SubTileRegionCount");
  public final static sub_tile_region_name UnknownSubTileRegionName = new sub_tile_region_name("UnknownSubTileRegionName", interop_runJNI.UnknownSubTileRegionName_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static sub_tile_region_name swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + sub_tile_region_name.class + " with value " + swigValue);
  }

  private sub_tile_region_name(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private sub_tile_region_name(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private sub_tile_region_name(String swigName, sub_tile_region_name swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static sub_tile_region_name[] swigValues = { NNW, NNE, NW, NE, SW, SE, SSW, SSE, SubTileRegionCount, UnknownSubTileRegionName };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

