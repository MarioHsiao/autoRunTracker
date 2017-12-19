/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public final class sub_tile_offset_type {
  public final static sub_tile_offset_type OffsetX = new sub_tile_offset_type("OffsetX");
  public final static sub_tile_offset_type OffsetY = new sub_tile_offset_type("OffsetY");
  public final static sub_tile_offset_type Score = new sub_tile_offset_type("Score");
  public final static sub_tile_offset_type SubTileOffsetComponentCount = new sub_tile_offset_type("SubTileOffsetComponentCount");
  public final static sub_tile_offset_type UnknownSubTileOffsetType = new sub_tile_offset_type("UnknownSubTileOffsetType", interop_runJNI.UnknownSubTileOffsetType_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static sub_tile_offset_type swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + sub_tile_offset_type.class + " with value " + swigValue);
  }

  private sub_tile_offset_type(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private sub_tile_offset_type(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private sub_tile_offset_type(String swigName, sub_tile_offset_type swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static sub_tile_offset_type[] swigValues = { OffsetX, OffsetY, Score, SubTileOffsetComponentCount, UnknownSubTileOffsetType };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

