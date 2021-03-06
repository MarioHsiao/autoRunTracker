//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Illumina.InterOp.Table {

using Illumina.InterOp.RunMetrics;
using Illumina.InterOp.Metrics;
using Illumina.InterOp.Run;

public class c_csharp_table {
  public static void populate_imaging_table_data(run_metrics metrics, imaging_column_vector columns, map_id_offset row_offset, float[] data_beg, uint n) {
    unsafe{ fixed ( float* swig_ptrTo_data_beg = data_beg ) {
    {
      c_csharp_tablePINVOKE.populate_imaging_table_data(run_metrics.getCPtr(metrics), imaging_column_vector.getCPtr(columns), map_id_offset.getCPtr(row_offset), (global::System.IntPtr)swig_ptrTo_data_beg, n);
      if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
    }
    }}
  }

  public static void count_table_rows(run_metrics metrics, map_id_offset row_offset) {
    c_csharp_tablePINVOKE.count_table_rows(run_metrics.getCPtr(metrics), map_id_offset.getCPtr(row_offset));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static uint count_table_columns(imaging_column_vector columns) {
    uint ret = c_csharp_tablePINVOKE.count_table_columns__SWIG_0(imaging_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void create_imaging_table(run_metrics metrics, imaging_table table) {
    c_csharp_tablePINVOKE.create_imaging_table(run_metrics.getCPtr(metrics), imaging_table.getCPtr(table));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void list_imaging_table_metrics_to_load(uchar_vector valid_to_load, bool show_iuo) {
    c_csharp_tablePINVOKE.list_imaging_table_metrics_to_load(uchar_vector.getCPtr(valid_to_load), show_iuo);
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static uint max_digits() {
    uint ret = c_csharp_tablePINVOKE.max_digits();
    return ret;
  }

  public static uint get_column_rounding(column_id index) {
    uint ret = c_csharp_tablePINVOKE.get_column_rounding((int)index);
    return ret;
  }

  public static void create_imaging_table_columns(string_vector channels, bool_vector filled, imaging_column_vector columns, uint registration_sub_region_count, layout_type fiducial_layout) {
    c_csharp_tablePINVOKE.create_imaging_table_columns__SWIG_0(string_vector.getCPtr(channels), bool_vector.getCPtr(filled), imaging_column_vector.getCPtr(columns), registration_sub_region_count, (int)fiducial_layout);
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void populate_column_offsets(imaging_column_vector columns) {
    c_csharp_tablePINVOKE.populate_column_offsets__SWIG_0(imaging_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void create_imaging_table_columns(run_metrics metrics, imaging_column_vector columns) {
    c_csharp_tablePINVOKE.create_imaging_table_columns__SWIG_1(run_metrics.getCPtr(metrics), imaging_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void populate_event_table_data(run_metrics metrics, event_column_vector columns, map_id_offset row_offset, ulong[] data_beg, uint n) {
    unsafe{ fixed ( ulong* swig_ptrTo_data_beg = data_beg ) {
    {
      c_csharp_tablePINVOKE.populate_event_table_data(run_metrics.getCPtr(metrics), event_column_vector.getCPtr(columns), map_id_offset.getCPtr(row_offset), (global::System.IntPtr)swig_ptrTo_data_beg, n);
      if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
    }
    }}
  }

  public static void count_event_table_rows(run_metrics metrics, map_id_offset row_offset) {
    c_csharp_tablePINVOKE.count_event_table_rows(run_metrics.getCPtr(metrics), map_id_offset.getCPtr(row_offset));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static uint count_table_columns(event_column_vector columns) {
    uint ret = c_csharp_tablePINVOKE.count_table_columns__SWIG_1(event_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void create_event_table(run_metrics metrics, event_table table) {
    c_csharp_tablePINVOKE.create_event_table(run_metrics.getCPtr(metrics), event_table.getCPtr(table));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void list_event_metrics(string_vector types) {
    c_csharp_tablePINVOKE.list_event_metrics(string_vector.getCPtr(types));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void create_event_table_columns(event_column_vector columns) {
    c_csharp_tablePINVOKE.create_event_table_columns__SWIG_0(event_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void populate_column_offsets(event_column_vector columns) {
    c_csharp_tablePINVOKE.populate_column_offsets__SWIG_1(event_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void create_event_table_columns(run_metrics metrics, event_column_vector columns) {
    c_csharp_tablePINVOKE.create_event_table_columns__SWIG_1(run_metrics.getCPtr(metrics), event_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void populate_run_diagnostics_table_data(run_metrics metrics, run_diagnostics_column_vector columns, map_id_offset row_offset, ulong[] data_beg, uint n) {
    unsafe{ fixed ( ulong* swig_ptrTo_data_beg = data_beg ) {
    {
      c_csharp_tablePINVOKE.populate_run_diagnostics_table_data(run_metrics.getCPtr(metrics), run_diagnostics_column_vector.getCPtr(columns), map_id_offset.getCPtr(row_offset), (global::System.IntPtr)swig_ptrTo_data_beg, n);
      if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
    }
    }}
  }

  public static void count_run_diagnostics_table_rows(run_metrics metrics, map_id_offset row_offset) {
    c_csharp_tablePINVOKE.count_run_diagnostics_table_rows(run_metrics.getCPtr(metrics), map_id_offset.getCPtr(row_offset));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static uint count_table_columns(run_diagnostics_column_vector columns) {
    uint ret = c_csharp_tablePINVOKE.count_table_columns__SWIG_2(run_diagnostics_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void create_run_diagnostics_table(run_metrics metrics, run_diagnostics_table table) {
    c_csharp_tablePINVOKE.create_run_diagnostics_table(run_metrics.getCPtr(metrics), run_diagnostics_table.getCPtr(table));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void list_run_diagnostics_metrics(string_vector types) {
    c_csharp_tablePINVOKE.list_run_diagnostics_metrics(string_vector.getCPtr(types));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void create_run_diagnostics_table_columns(run_diagnostics_column_vector columns, bool_vector filled) {
    c_csharp_tablePINVOKE.create_run_diagnostics_table_columns__SWIG_0(run_diagnostics_column_vector.getCPtr(columns), bool_vector.getCPtr(filled));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void populate_column_offsets(run_diagnostics_column_vector columns) {
    c_csharp_tablePINVOKE.populate_column_offsets__SWIG_2(run_diagnostics_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void create_run_diagnostics_table_columns(run_metrics metrics, run_diagnostics_column_vector columns) {
    c_csharp_tablePINVOKE.create_run_diagnostics_table_columns__SWIG_1(run_metrics.getCPtr(metrics), run_diagnostics_column_vector.getCPtr(columns));
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
