/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class imaging_column {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected imaging_column(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(imaging_column obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_tableJNI.delete_imaging_column(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public imaging_column() {
    this(interop_tableJNI.new_imaging_column__SWIG_0(), true);
  }

  public imaging_column(long index, long offset) {
    this(interop_tableJNI.new_imaging_column__SWIG_1(index, offset), true);
  }

  public imaging_column(long index, long offset, string_vector sub_columns) {
    this(interop_tableJNI.new_imaging_column__SWIG_2(index, offset, string_vector.getCPtr(sub_columns), sub_columns), true);
  }

  public column_id id() {
    return column_id.swigToEnum(interop_tableJNI.imaging_column_id__SWIG_0(swigCPtr, this));
  }

  public String name() {
    return interop_tableJNI.imaging_column_name(swigCPtr, this);
  }

  public boolean has_children() {
    return interop_tableJNI.imaging_column_has_children(swigCPtr, this);
  }

  public long offset() {
    return interop_tableJNI.imaging_column_offset__SWIG_0(swigCPtr, this);
  }

  public string_vector subcolumns() {
    return new string_vector(interop_tableJNI.imaging_column_subcolumns(swigCPtr, this), false);
  }

  public String full_name(long sub_index) throws index_out_of_bounds_exception {
    return interop_tableJNI.imaging_column_full_name(swigCPtr, this, sub_index);
  }

  public void offset(long off) {
    interop_tableJNI.imaging_column_offset__SWIG_1(swigCPtr, this, off);
  }

  public void id(column_id val) {
    interop_tableJNI.imaging_column_id__SWIG_1(swigCPtr, this, val.swigValue());
  }

  public void parse_header_for_id(String header) {
    interop_tableJNI.imaging_column_parse_header_for_id(swigCPtr, this, header);
  }

  public long size() {
    return interop_tableJNI.imaging_column_size(swigCPtr, this);
  }

  public long column_count() {
    return interop_tableJNI.imaging_column_column_count(swigCPtr, this);
  }

  public static String to_header(column_id id) {
    return interop_tableJNI.imaging_column_to_header__SWIG_0(id.swigValue());
  }

  public static String to_header(String name) {
    return interop_tableJNI.imaging_column_to_header__SWIG_1(name);
  }

  public static String to_name(String header) {
    return interop_tableJNI.imaging_column_to_name__SWIG_0(header);
  }

  public static String to_name(imaging_column header) {
    return interop_tableJNI.imaging_column_to_name__SWIG_1(imaging_column.getCPtr(header), header);
  }

}