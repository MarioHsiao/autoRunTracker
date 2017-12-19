/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class run_diagnostics_table {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected run_diagnostics_table(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(run_diagnostics_table obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_tableJNI.delete_run_diagnostics_table(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public run_diagnostics_table() {
    this(interop_tableJNI.new_run_diagnostics_table(), true);
  }

  public void set_data(long rows, run_diagnostics_column_vector cols, ulong_vector data) {
    interop_tableJNI.run_diagnostics_table_set_data(swigCPtr, this, rows, run_diagnostics_column_vector.getCPtr(cols), cols, ulong_vector.getCPtr(data), data);
  }

  public java.math.BigInteger at(long r, run_diagnostics_column_id c) throws index_out_of_bounds_exception {
    return interop_tableJNI.run_diagnostics_table_at(swigCPtr, this, r, c.swigValue());
  }

  public run_diagnostics_column_vector columns() {
    return new run_diagnostics_column_vector(interop_tableJNI.run_diagnostics_table_columns(swigCPtr, this), false);
  }

  public boolean empty() {
    return interop_tableJNI.run_diagnostics_table_empty(swigCPtr, this);
  }

  public void clear() {
    interop_tableJNI.run_diagnostics_table_clear(swigCPtr, this);
  }

  public run_diagnostics_column column_at(long col_index) throws index_out_of_bounds_exception {
    return new run_diagnostics_column(interop_tableJNI.run_diagnostics_table_column_at(swigCPtr, this, col_index), false);
  }

  public long column_count() {
    return interop_tableJNI.run_diagnostics_table_column_count(swigCPtr, this);
  }

  public long total_column_count() {
    return interop_tableJNI.run_diagnostics_table_total_column_count(swigCPtr, this);
  }

  public long row_count() {
    return interop_tableJNI.run_diagnostics_table_row_count(swigCPtr, this);
  }

}
