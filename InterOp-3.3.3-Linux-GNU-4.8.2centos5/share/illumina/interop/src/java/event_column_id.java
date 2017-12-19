/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public final class event_column_id {
  public final static event_column_id LaneEventColumn = new event_column_id("LaneEventColumn");
  public final static event_column_id TileEventColumn = new event_column_id("TileEventColumn");
  public final static event_column_id CycleEventColumn = new event_column_id("CycleEventColumn");
  public final static event_column_id ElapsedTicksEventColumn = new event_column_id("ElapsedTicksEventColumn");
  public final static event_column_id EventEventColumn = new event_column_id("EventEventColumn");
  public final static event_column_id PointTicksEventColumn = new event_column_id("PointTicksEventColumn");
  public final static event_column_id PointTimeEventColumn = new event_column_id("PointTimeEventColumn");
  public final static event_column_id ValueEventColumn = new event_column_id("ValueEventColumn");
  public final static event_column_id SurfaceEventColumn = new event_column_id("SurfaceEventColumn");
  public final static event_column_id SwathEventColumn = new event_column_id("SwathEventColumn");
  public final static event_column_id SectionEventColumn = new event_column_id("SectionEventColumn");
  public final static event_column_id TileNumberEventColumn = new event_column_id("TileNumberEventColumn");
  public final static event_column_id EventColumnCount = new event_column_id("EventColumnCount");
  public final static event_column_id UnknownEventColumnId = new event_column_id("UnknownEventColumnId", interop_tableJNI.UnknownEventColumnId_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static event_column_id swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + event_column_id.class + " with value " + swigValue);
  }

  private event_column_id(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private event_column_id(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private event_column_id(String swigName, event_column_id swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static event_column_id[] swigValues = { LaneEventColumn, TileEventColumn, CycleEventColumn, ElapsedTicksEventColumn, EventEventColumn, PointTicksEventColumn, PointTimeEventColumn, ValueEventColumn, SurfaceEventColumn, SwathEventColumn, SectionEventColumn, TileNumberEventColumn, EventColumnCount, UnknownEventColumnId };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

