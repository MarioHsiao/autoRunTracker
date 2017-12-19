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

public class bar_vector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<bar_point>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal bar_vector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(bar_vector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~bar_vector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          c_csharp_plotPINVOKE.delete_bar_vector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bar_vector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (bar_point element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public bar_point this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(bar_point[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(bar_point[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, bar_point[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<bar_point> global::System.Collections.Generic.IEnumerable<bar_point>.GetEnumerator() {
    return new bar_vectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new bar_vectorEnumerator(this);
  }

  public bar_vectorEnumerator GetEnumerator() {
    return new bar_vectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class bar_vectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<bar_point>
  {
    private bar_vector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public bar_vectorEnumerator(bar_vector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public bar_point Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (bar_point)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    c_csharp_plotPINVOKE.bar_vector_Clear(swigCPtr);
  }

  public void Add(bar_point x) {
    c_csharp_plotPINVOKE.bar_vector_Add(swigCPtr, bar_point.getCPtr(x));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = c_csharp_plotPINVOKE.bar_vector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = c_csharp_plotPINVOKE.bar_vector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    c_csharp_plotPINVOKE.bar_vector_reserve(swigCPtr, n);
  }

  public bar_vector() : this(c_csharp_plotPINVOKE.new_bar_vector__SWIG_0(), true) {
  }

  public bar_vector(bar_vector other) : this(c_csharp_plotPINVOKE.new_bar_vector__SWIG_1(bar_vector.getCPtr(other)), true) {
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public bar_vector(int capacity) : this(c_csharp_plotPINVOKE.new_bar_vector__SWIG_2(capacity), true) {
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  private bar_point getitemcopy(int index) {
    bar_point ret = new bar_point(c_csharp_plotPINVOKE.bar_vector_getitemcopy(swigCPtr, index), true);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bar_point getitem(int index) {
    bar_point ret = new bar_point(c_csharp_plotPINVOKE.bar_vector_getitem(swigCPtr, index), false);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, bar_point val) {
    c_csharp_plotPINVOKE.bar_vector_setitem(swigCPtr, index, bar_point.getCPtr(val));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(bar_vector values) {
    c_csharp_plotPINVOKE.bar_vector_AddRange(swigCPtr, bar_vector.getCPtr(values));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public bar_vector GetRange(int index, int count) {
    global::System.IntPtr cPtr = c_csharp_plotPINVOKE.bar_vector_GetRange(swigCPtr, index, count);
    bar_vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new bar_vector(cPtr, true);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, bar_point x) {
    c_csharp_plotPINVOKE.bar_vector_Insert(swigCPtr, index, bar_point.getCPtr(x));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, bar_vector values) {
    c_csharp_plotPINVOKE.bar_vector_InsertRange(swigCPtr, index, bar_vector.getCPtr(values));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    c_csharp_plotPINVOKE.bar_vector_RemoveAt(swigCPtr, index);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    c_csharp_plotPINVOKE.bar_vector_RemoveRange(swigCPtr, index, count);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public static bar_vector Repeat(bar_point value, int count) {
    global::System.IntPtr cPtr = c_csharp_plotPINVOKE.bar_vector_Repeat(bar_point.getCPtr(value), count);
    bar_vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new bar_vector(cPtr, true);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    c_csharp_plotPINVOKE.bar_vector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    c_csharp_plotPINVOKE.bar_vector_Reverse__SWIG_1(swigCPtr, index, count);
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, bar_vector values) {
    c_csharp_plotPINVOKE.bar_vector_SetRange(swigCPtr, index, bar_vector.getCPtr(values));
    if (c_csharp_plotPINVOKE.SWIGPendingException.Pending) throw c_csharp_plotPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
