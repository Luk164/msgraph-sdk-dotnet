// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartRequestBuilder.
    /// </summary>
    public partial class WorkbookChartRequestBuilder : EntityRequestBuilder, IWorkbookChartRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Axes.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartAxesRequestBuilder"/>.</returns>
        public IWorkbookChartAxesRequestBuilder Axes
        {
            get
            {
                return new WorkbookChartAxesRequestBuilder(this.AppendSegmentToRequestUrl("axes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DataLabels.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartDataLabelsRequestBuilder"/>.</returns>
        public IWorkbookChartDataLabelsRequestBuilder DataLabels
        {
            get
            {
                return new WorkbookChartDataLabelsRequestBuilder(this.AppendSegmentToRequestUrl("dataLabels"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Format.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartAreaFormatRequestBuilder"/>.</returns>
        public IWorkbookChartAreaFormatRequestBuilder Format
        {
            get
            {
                return new WorkbookChartAreaFormatRequestBuilder(this.AppendSegmentToRequestUrl("format"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Legend.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartLegendRequestBuilder"/>.</returns>
        public IWorkbookChartLegendRequestBuilder Legend
        {
            get
            {
                return new WorkbookChartLegendRequestBuilder(this.AppendSegmentToRequestUrl("legend"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Series.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesCollectionRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesCollectionRequestBuilder Series
        {
            get
            {
                return new WorkbookChartSeriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("series"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Title.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartTitleRequestBuilder"/>.</returns>
        public IWorkbookChartTitleRequestBuilder Title
        {
            get
            {
                return new WorkbookChartTitleRequestBuilder(this.AppendSegmentToRequestUrl("title"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Worksheet.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        public IWorkbookWorksheetRequestBuilder Worksheet
        {
            get
            {
                return new WorkbookWorksheetRequestBuilder(this.AppendSegmentToRequestUrl("worksheet"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookChartSetData.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSetDataRequestBuilder"/>.</returns>
        public IWorkbookChartSetDataRequestBuilder SetData(
            string seriesBy,
            Newtonsoft.Json.Linq.JToken sourceData = null)
        {
            return new WorkbookChartSetDataRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setData"),
                this.Client,
                seriesBy,
                sourceData);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartSetPosition.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSetPositionRequestBuilder"/>.</returns>
        public IWorkbookChartSetPositionRequestBuilder SetPosition(
            Newtonsoft.Json.Linq.JToken startCell = null,
            Newtonsoft.Json.Linq.JToken endCell = null)
        {
            return new WorkbookChartSetPositionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setPosition"),
                this.Client,
                startCell,
                endCell);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartImage.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartImageRequestBuilder"/>.</returns>
        public IWorkbookChartImageRequestBuilder Image()
        {
            return new WorkbookChartImageRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.image"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartImage.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartImageRequestBuilder"/>.</returns>
        public IWorkbookChartImageRequestBuilder Image(
            Int32 width)
        {
            return new WorkbookChartImageRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.image"),
                this.Client,
                width);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartImage.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartImageRequestBuilder"/>.</returns>
        public IWorkbookChartImageRequestBuilder Image(
            Int32 width,
            Int32 height)
        {
            return new WorkbookChartImageRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.image"),
                this.Client,
                width,
                height);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartImage.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartImageRequestBuilder"/>.</returns>
        public IWorkbookChartImageRequestBuilder Image(
            Int32 width,
            Int32 height,
            string fittingMode)
        {
            return new WorkbookChartImageRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.image"),
                this.Client,
                width,
                height,
                fittingMode);
        }
    
    }
}
