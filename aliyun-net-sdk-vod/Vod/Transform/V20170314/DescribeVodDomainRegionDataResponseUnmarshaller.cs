/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class DescribeVodDomainRegionDataResponseUnmarshaller
    {
        public static DescribeVodDomainRegionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRegionDataResponse describeVodDomainRegionDataResponse = new DescribeVodDomainRegionDataResponse();

			describeVodDomainRegionDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRegionDataResponse.RequestId = context.StringValue("DescribeVodDomainRegionData.RequestId");
			describeVodDomainRegionDataResponse.DomainName = context.StringValue("DescribeVodDomainRegionData.DomainName");
			describeVodDomainRegionDataResponse.DataInterval = context.StringValue("DescribeVodDomainRegionData.DataInterval");
			describeVodDomainRegionDataResponse.StartTime = context.StringValue("DescribeVodDomainRegionData.StartTime");
			describeVodDomainRegionDataResponse.EndTime = context.StringValue("DescribeVodDomainRegionData.EndTime");

			List<DescribeVodDomainRegionDataResponse.DescribeVodDomainRegionData_RegionProportionData> describeVodDomainRegionDataResponse_value = new List<DescribeVodDomainRegionDataResponse.DescribeVodDomainRegionData_RegionProportionData>();
			for (int i = 0; i < context.Length("DescribeVodDomainRegionData.Value.Length"); i++) {
				DescribeVodDomainRegionDataResponse.DescribeVodDomainRegionData_RegionProportionData regionProportionData = new DescribeVodDomainRegionDataResponse.DescribeVodDomainRegionData_RegionProportionData();
				regionProportionData.Region = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].Region");
				regionProportionData.Proportion = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].Proportion");
				regionProportionData.RegionEname = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].RegionEname");
				regionProportionData.AvgObjectSize = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].AvgObjectSize");
				regionProportionData.AvgResponseTime = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].AvgResponseTime");
				regionProportionData.Bps = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].Bps");
				regionProportionData.Qps = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].Qps");
				regionProportionData.AvgResponseRate = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].AvgResponseRate");
				regionProportionData.ReqErrRate = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].ReqErrRate");
				regionProportionData.TotalBytes = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].TotalBytes");
				regionProportionData.BytesProportion = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].BytesProportion");
				regionProportionData.TotalQuery = context.StringValue("DescribeVodDomainRegionData.Value["+ i +"].TotalQuery");

				describeVodDomainRegionDataResponse_value.Add(regionProportionData);
			}
			describeVodDomainRegionDataResponse._Value = describeVodDomainRegionDataResponse_value;
        
			return describeVodDomainRegionDataResponse;
        }
    }
}
