/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.illumina.interop;

public class filter_options {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected filter_options(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(filter_options obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        interop_plotJNI.delete_filter_options(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base, long surface, long read, long cycle, long tile_number, long swath, long section) {
    this(interop_plotJNI.new_filter_options__SWIG_0(naming_method.swigValue(), lane, channel, base.swigValue(), surface, read, cycle, tile_number, swath, section), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base, long surface, long read, long cycle, long tile_number, long swath) {
    this(interop_plotJNI.new_filter_options__SWIG_1(naming_method.swigValue(), lane, channel, base.swigValue(), surface, read, cycle, tile_number, swath), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base, long surface, long read, long cycle, long tile_number) {
    this(interop_plotJNI.new_filter_options__SWIG_2(naming_method.swigValue(), lane, channel, base.swigValue(), surface, read, cycle, tile_number), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base, long surface, long read, long cycle) {
    this(interop_plotJNI.new_filter_options__SWIG_3(naming_method.swigValue(), lane, channel, base.swigValue(), surface, read, cycle), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base, long surface, long read) {
    this(interop_plotJNI.new_filter_options__SWIG_4(naming_method.swigValue(), lane, channel, base.swigValue(), surface, read), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base, long surface) {
    this(interop_plotJNI.new_filter_options__SWIG_5(naming_method.swigValue(), lane, channel, base.swigValue(), surface), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel, dna_bases base) {
    this(interop_plotJNI.new_filter_options__SWIG_6(naming_method.swigValue(), lane, channel, base.swigValue()), true);
  }

  public filter_options(tile_naming_method naming_method, long lane, short channel) {
    this(interop_plotJNI.new_filter_options__SWIG_7(naming_method.swigValue(), lane, channel), true);
  }

  public filter_options(tile_naming_method naming_method, long lane) {
    this(interop_plotJNI.new_filter_options__SWIG_8(naming_method.swigValue(), lane), true);
  }

  public filter_options(tile_naming_method naming_method) {
    this(interop_plotJNI.new_filter_options__SWIG_9(naming_method.swigValue()), true);
  }

  public void reset() {
    interop_plotJNI.filter_options_reset(swigCPtr, this);
  }

  public void validate(metric_type type, info run_info, boolean check_ignored) throws invalid_filter_option {
    interop_plotJNI.filter_options_validate__SWIG_0(swigCPtr, this, type.swigValue(), info.getCPtr(run_info), run_info, check_ignored);
  }

  public void validate(metric_type type, info run_info) throws invalid_filter_option {
    interop_plotJNI.filter_options_validate__SWIG_1(swigCPtr, this, type.swigValue(), info.getCPtr(run_info), run_info);
  }

  public boolean all_channels(metric_type type) {
    return interop_plotJNI.filter_options_all_channels__SWIG_0(swigCPtr, this, type.swigValue());
  }

  public boolean all_channels() {
    return interop_plotJNI.filter_options_all_channels__SWIG_1(swigCPtr, this);
  }

  public boolean all_bases(metric_type type) {
    return interop_plotJNI.filter_options_all_bases__SWIG_0(swigCPtr, this, type.swigValue());
  }

  public boolean all_bases() {
    return interop_plotJNI.filter_options_all_bases__SWIG_1(swigCPtr, this);
  }

  public boolean all_reads() {
    return interop_plotJNI.filter_options_all_reads(swigCPtr, this);
  }

  public boolean all_cycles() {
    return interop_plotJNI.filter_options_all_cycles(swigCPtr, this);
  }

  public boolean all_lanes() {
    return interop_plotJNI.filter_options_all_lanes(swigCPtr, this);
  }

  public boolean all_tile_numbers() {
    return interop_plotJNI.filter_options_all_tile_numbers(swigCPtr, this);
  }

  public boolean all_swaths() {
    return interop_plotJNI.filter_options_all_swaths(swigCPtr, this);
  }

  public boolean all_sections() {
    return interop_plotJNI.filter_options_all_sections(swigCPtr, this);
  }

  public boolean is_specific_read(metric_type type) {
    return interop_plotJNI.filter_options_is_specific_read__SWIG_0(swigCPtr, this, type.swigValue());
  }

  public boolean is_specific_read() {
    return interop_plotJNI.filter_options_is_specific_read__SWIG_1(swigCPtr, this);
  }

  public boolean is_specific_surface() {
    return interop_plotJNI.filter_options_is_specific_surface(swigCPtr, this);
  }

  public boolean valid_lane(long lane) {
    return interop_plotJNI.filter_options_valid_lane(swigCPtr, this, lane);
  }

  public boolean valid_surface(long surface) {
    return interop_plotJNI.filter_options_valid_surface(swigCPtr, this, surface);
  }

  public boolean valid_read(long read) {
    return interop_plotJNI.filter_options_valid_read(swigCPtr, this, read);
  }

  public boolean valid_cycle(long cycle) {
    return interop_plotJNI.filter_options_valid_cycle(swigCPtr, this, cycle);
  }

  public boolean valid_tile_number(long tile_number) {
    return interop_plotJNI.filter_options_valid_tile_number(swigCPtr, this, tile_number);
  }

  public boolean valid_swath(long swath) {
    return interop_plotJNI.filter_options_valid_swath(swigCPtr, this, swath);
  }

  public boolean valid_section(long section) {
    return interop_plotJNI.filter_options_valid_section(swigCPtr, this, section);
  }

  public boolean valid_channel(short channel) {
    return interop_plotJNI.filter_options_valid_channel(swigCPtr, this, channel);
  }

  public boolean valid_base(dna_bases base) {
    return interop_plotJNI.filter_options_valid_base(swigCPtr, this, base.swigValue());
  }

  public void tile_naming_method(tile_naming_method naming_method) {
    interop_plotJNI.filter_options_tile_naming_method(swigCPtr, this, naming_method.swigValue());
  }

  public void channel(short channel) {
    interop_plotJNI.filter_options_channel__SWIG_0(swigCPtr, this, channel);
  }

  public void dna_base(dna_bases base) {
    interop_plotJNI.filter_options_dna_base__SWIG_0(swigCPtr, this, base.swigValue());
  }

  public void read(long r) {
    interop_plotJNI.filter_options_read__SWIG_0(swigCPtr, this, r);
  }

  public void cycle(long c) {
    interop_plotJNI.filter_options_cycle__SWIG_0(swigCPtr, this, c);
  }

  public void surface(long s) {
    interop_plotJNI.filter_options_surface__SWIG_0(swigCPtr, this, s);
  }

  public void swath(long s) {
    interop_plotJNI.filter_options_swath(swigCPtr, this, s);
  }

  public void section(long s) {
    interop_plotJNI.filter_options_section(swigCPtr, this, s);
  }

  public void tile_number(long s) {
    interop_plotJNI.filter_options_tile_number(swigCPtr, this, s);
  }

  public void lane(long l) {
    interop_plotJNI.filter_options_lane__SWIG_0(swigCPtr, this, l);
  }

  public long lane() {
    return interop_plotJNI.filter_options_lane__SWIG_1(swigCPtr, this);
  }

  public short channel() {
    return interop_plotJNI.filter_options_channel__SWIG_1(swigCPtr, this);
  }

  public dna_bases dna_base() {
    return dna_bases.swigToEnum(interop_plotJNI.filter_options_dna_base__SWIG_1(swigCPtr, this));
  }

  public long read() {
    return interop_plotJNI.filter_options_read__SWIG_1(swigCPtr, this);
  }

  public long cycle() {
    return interop_plotJNI.filter_options_cycle__SWIG_1(swigCPtr, this);
  }

  public long surface() {
    return interop_plotJNI.filter_options_surface__SWIG_1(swigCPtr, this);
  }

  public String cycle_description() {
    return interop_plotJNI.filter_options_cycle_description(swigCPtr, this);
  }

  public String lane_description() {
    return interop_plotJNI.filter_options_lane_description(swigCPtr, this);
  }

  public String channel_description(string_vector channels) {
    return interop_plotJNI.filter_options_channel_description(swigCPtr, this, string_vector.getCPtr(channels), channels);
  }

  public String base_description() {
    return interop_plotJNI.filter_options_base_description(swigCPtr, this);
  }

  public String surface_description() {
    return interop_plotJNI.filter_options_surface_description(swigCPtr, this);
  }

  public String read_description() {
    return interop_plotJNI.filter_options_read_description(swigCPtr, this);
  }

  public tile_naming_method naming_method() {
    return tile_naming_method.swigToEnum(interop_plotJNI.filter_options_naming_method(swigCPtr, this));
  }

  public boolean supports_section(plot_types plot_type, info info) {
    return interop_plotJNI.filter_options_supports_section(swigCPtr, this, plot_type.swigValue(), info.getCPtr(info), info);
  }

  public boolean supports_swath(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_swath(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_tile(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_tile(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_all_lanes(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_all_lanes(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_lane(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_lane(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_all_bases(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_all_bases(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_base(metric_type metric_type) {
    return interop_plotJNI.filter_options_supports_base(swigCPtr, this, metric_type.swigValue());
  }

  public boolean supports_all_channels(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_all_channels(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_channel(metric_type metric_type) {
    return interop_plotJNI.filter_options_supports_channel(swigCPtr, this, metric_type.swigValue());
  }

  public boolean supports_all_cycles(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_all_cycles(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_cycle(metric_type metric_type, plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_cycle(swigCPtr, this, metric_type.swigValue(), plot_type.swigValue());
  }

  public boolean supports_all_reads(plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_all_reads(swigCPtr, this, plot_type.swigValue());
  }

  public boolean supports_read(metric_type metric_type, plot_types plot_type) {
    return interop_plotJNI.filter_options_supports_read(swigCPtr, this, metric_type.swigValue(), plot_type.swigValue());
  }

  public boolean supports_surface(metric_type metric_type, info info) {
    return interop_plotJNI.filter_options_supports_surface(swigCPtr, this, metric_type.swigValue(), info.getCPtr(info), info);
  }

  public final static class UseAll {
    public final static filter_options.UseAll ALL_IDS = new filter_options.UseAll("ALL_IDS", interop_plotJNI.filter_options_ALL_IDS_get());
    public final static filter_options.UseAll ALL_CHANNELS = new filter_options.UseAll("ALL_CHANNELS", interop_plotJNI.filter_options_ALL_CHANNELS_get());
    public final static filter_options.UseAll ALL_BASES = new filter_options.UseAll("ALL_BASES", interop_plotJNI.filter_options_ALL_BASES_get());

    public final int swigValue() {
      return swigValue;
    }

    public String toString() {
      return swigName;
    }

    public static UseAll swigToEnum(int swigValue) {
      if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
        return swigValues[swigValue];
      for (int i = 0; i < swigValues.length; i++)
        if (swigValues[i].swigValue == swigValue)
          return swigValues[i];
      throw new IllegalArgumentException("No enum " + UseAll.class + " with value " + swigValue);
    }

    private UseAll(String swigName) {
      this.swigName = swigName;
      this.swigValue = swigNext++;
    }

    private UseAll(String swigName, int swigValue) {
      this.swigName = swigName;
      this.swigValue = swigValue;
      swigNext = swigValue+1;
    }

    private UseAll(String swigName, UseAll swigEnum) {
      this.swigName = swigName;
      this.swigValue = swigEnum.swigValue;
      swigNext = this.swigValue+1;
    }

    private static UseAll[] swigValues = { ALL_IDS, ALL_CHANNELS, ALL_BASES };
    private static int swigNext = 0;
    private final int swigValue;
    private final String swigName;
  }

}
