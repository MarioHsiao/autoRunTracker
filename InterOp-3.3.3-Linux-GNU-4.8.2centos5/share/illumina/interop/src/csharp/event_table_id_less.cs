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

using System;
using System.Runtime.InteropServices;
using Illumina.InterOp.Metrics;
using Illumina.InterOp.Run;
using Illumina.InterOp.RunMetrics;

public class event_table_id_less : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal event_table_id_less(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(event_table_id_less obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~event_table_id_less() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_tablePINVOKE.delete_event_table_id_less(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public event_table_id_less(event_table table) : this(c_csharp_tablePINVOKE.new_event_table_id_less(event_table.getCPtr(table)), true) {
    if (c_csharp_tablePINVOKE.SWIGPendingException.Pending) throw c_csharp_tablePINVOKE.SWIGPendingException.Retrieve();
  }

}

}