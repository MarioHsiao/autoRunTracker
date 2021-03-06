/** Logic to populate the run diagnostics table columns
 *
 *  @file
 *  @date  7/20/16
 *  @version 1.0
 *  @copyright Illumina Use Only
 */
#pragma once
#include "interop/model/run_metrics.h"
#include "interop/model/table/run_diagnostics_column.h"
#include "interop/logic/table/table_util.h"


namespace illumina { namespace interop { namespace logic { namespace table
{
    /** Create the run diagnostics table columns
     *
     * @param columns destination column vector
     * @param filled array that indicates whether a column should be filled
     */
    void create_run_diagnostics_table_columns(std::vector< model::table::run_diagnostics_column >& columns,
                                              const std::vector< bool >& filled)
                                      throw(model::invalid_column_type,
                                      model::index_out_of_bounds_exception,
                                      model::invalid_channel_exception);
    /** Populate the value offsets from the column headers
     *
     * @param columns column headers
     */
    void populate_column_offsets(std::vector<model::table::run_diagnostics_column>& columns)
    throw(model::invalid_column_type);
    /** Create a vector of column descriptors
     *
     * @param metrics source collection of InterOp metrics from the run
     * @param columns destination vector of column descriptors
     */
    void create_run_diagnostics_table_columns(model::metrics::run_metrics& metrics,
                                      std::vector< model::table::run_diagnostics_column >& columns)
    throw(model::invalid_column_type,
    model::index_out_of_bounds_exception,
    model::invalid_channel_exception);


}}}}

