/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class flowcell_data extends heatmap_data {
  private transient long swigCPtr;

  protected flowcell_data(long cPtr, boolean cMemoryOwn) {
    super(interop_plotJNI.flowcell_data_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(flowcell_data obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_plotJNI.delete_flowcell_data(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public flowcell_data() {
    this(interop_plotJNI.new_flowcell_data(), true);
  }

  public void set_buffer(float[] data_buffer, int[] id_buffer, long lanes, long swaths, long tiles) throws invalid_parameter {
    interop_plotJNI.flowcell_data_set_buffer(swigCPtr, this, data_buffer, id_buffer, lanes, swaths, tiles);
  }

  public void resize(long lanes, long swaths, long tiles) {
    interop_plotJNI.flowcell_data_resize(swigCPtr, this, lanes, swaths, tiles);
  }

  public void clear() {
    interop_plotJNI.flowcell_data_clear(swigCPtr, this);
  }

  public long tile_at(long index) {
    return interop_plotJNI.flowcell_data_tile_at(swigCPtr, this, index);
  }

  public void set_data(long lane_idx, long loc, long tile_id, float value) throws index_out_of_bounds_exception {
    interop_plotJNI.flowcell_data_set_data(swigCPtr, this, lane_idx, loc, tile_id, value);
  }

  public long tile_id(long lane_idx, long loc) throws index_out_of_bounds_exception {
    return interop_plotJNI.flowcell_data_tile_id(swigCPtr, this, lane_idx, loc);
  }

  public void set_saxis(axis plot_axis) {
    interop_plotJNI.flowcell_data_set_saxis(swigCPtr, this, axis.getCPtr(plot_axis), plot_axis);
  }

  public void set_label(String label) {
    interop_plotJNI.flowcell_data_set_label(swigCPtr, this, label);
  }

  public axis saxis() {
    return new axis(interop_plotJNI.flowcell_data_saxis(swigCPtr, this), false);
  }

  public void set_subtitle(String subtitle) {
    interop_plotJNI.flowcell_data_set_subtitle(swigCPtr, this, subtitle);
  }

  public void set_range(float vmin, float vmax) {
    interop_plotJNI.flowcell_data_set_range(swigCPtr, this, vmin, vmax);
  }

  public String subtitle() {
    return interop_plotJNI.flowcell_data_subtitle(swigCPtr, this);
  }

  public long lane_count() {
    return interop_plotJNI.flowcell_data_lane_count(swigCPtr, this);
  }

  public long swath_count() {
    return interop_plotJNI.flowcell_data_swath_count(swigCPtr, this);
  }

  public long tile_count() {
    return interop_plotJNI.flowcell_data_tile_count(swigCPtr, this);
  }

  public long total_tile_count() {
    return interop_plotJNI.flowcell_data_total_tile_count(swigCPtr, this);
  }

}