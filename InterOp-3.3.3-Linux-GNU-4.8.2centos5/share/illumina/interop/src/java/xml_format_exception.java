/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class xml_format_exception extends base_exception {
  private transient long swigCPtr;

  protected xml_format_exception(long cPtr, boolean cMemoryOwn) {
    super(interop_runJNI.xml_format_exception_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(xml_format_exception obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_runJNI.delete_xml_format_exception(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public xml_format_exception(String mesg) {
    this(interop_runJNI.new_xml_format_exception(mesg), true);
  }

}
