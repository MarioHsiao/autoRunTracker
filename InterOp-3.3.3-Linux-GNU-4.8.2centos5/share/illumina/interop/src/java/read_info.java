/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class read_info extends cycle_range {
  private transient long swigCPtr;

  protected read_info(long cPtr, boolean cMemoryOwn) {
    super(interop_runJNI.read_info_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(read_info obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_runJNI.delete_read_info(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public read_info(long number, long first_cycle, long last_cycle, boolean is_index) {
    this(interop_runJNI.new_read_info__SWIG_0(number, first_cycle, last_cycle, is_index), true);
  }

  public read_info(long number, long first_cycle, long last_cycle) {
    this(interop_runJNI.new_read_info__SWIG_1(number, first_cycle, last_cycle), true);
  }

  public read_info(long number, long first_cycle) {
    this(interop_runJNI.new_read_info__SWIG_2(number, first_cycle), true);
  }

  public read_info(long number) {
    this(interop_runJNI.new_read_info__SWIG_3(number), true);
  }

  public read_info() {
    this(interop_runJNI.new_read_info__SWIG_4(), true);
  }

  public long number() {
    return interop_runJNI.read_info_number(swigCPtr, this);
  }

  public boolean is_index() {
    return interop_runJNI.read_info_is_index(swigCPtr, this);
  }

  public long total_cycles() {
    return interop_runJNI.read_info_total_cycles(swigCPtr, this);
  }

  public long useable_cycles() {
    return interop_runJNI.read_info_useable_cycles(swigCPtr, this);
  }

}
