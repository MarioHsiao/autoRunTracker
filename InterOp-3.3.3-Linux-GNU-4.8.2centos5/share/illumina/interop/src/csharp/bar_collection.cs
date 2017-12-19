//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Illumina.InterOp.Plot {

using System;
using System.Runtime.InteropServices;
using Illumina.InterOp.RunMetrics;
using Illumina.InterOp.Metrics;
using Illumina.InterOp.Run;

public class bar_collection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal bar_collection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(bar_collection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~bar_collection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_plotPINVOKE.delete_bar_collection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void push_back(bar_point point) {
    c_csharp_plotPINVOKE.bar_collection_push_back(swigCPtr, bar_point.getCPtr(point));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public bar_point at(uint index) {
    bar_point ret = new bar_point(c_csharp_plotPINVOKE.bar_collection_at(swigCPtr, index), false);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = c_csharp_plotPINVOKE.bar_collection_size(swigCPtr);
    return ret;
  }

  public void assign(uint n, bar_point val) {
    c_csharp_plotPINVOKE.bar_collection_assign(swigCPtr, n, bar_point.getCPtr(val));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(uint n) {
    c_csharp_plotPINVOKE.bar_collection_resize(swigCPtr, n);
  }

  public bar_collection() : this(c_csharp_plotPINVOKE.new_bar_collection(), true) {
  }

}

}
