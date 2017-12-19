/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class extraction_metric_header extends base_cycle_metric_header {
  private transient long swigCPtr;

  protected extraction_metric_header(long cPtr, boolean cMemoryOwn) {
    super(interop_metricsJNI.extraction_metric_header_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(extraction_metric_header obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_metricsJNI.delete_extraction_metric_header(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public extraction_metric_header(int channel_count) {
    this(interop_metricsJNI.new_extraction_metric_header(channel_count), true);
  }

  public int channel_count() {
    return interop_metricsJNI.extraction_metric_header_channel_count__SWIG_0(swigCPtr, this);
  }

  public void channel_count(long channel_count) {
    interop_metricsJNI.extraction_metric_header_channel_count__SWIG_1(swigCPtr, this, channel_count);
  }

  public static extraction_metric_header default_header() {
    return new extraction_metric_header(interop_metricsJNI.extraction_metric_header_default_header(), true);
  }

  public void clear() {
    interop_metricsJNI.extraction_metric_header_clear(swigCPtr, this);
  }

  public final static int MAX_CHANNELS = interop_metricsJNI.extraction_metric_header_MAX_CHANNELS_get();

}
