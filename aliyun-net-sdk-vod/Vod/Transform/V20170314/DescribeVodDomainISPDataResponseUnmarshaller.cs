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
    public class DescribeVodDomainISPDataResponseUnmarshaller
    {
        public static DescribeVodDomainISPDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainISPDataResponse describeVodDomainISPDataResponse = new DescribeVodDomainISPDataResponse();

			describeVodDomainISPDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainISPDataResponse.RequestId = context.StringValue("DescribeVodDomainISPData.RequestId");
			describeVodDomainISPDataResponse.DomainName = context.StringValue("DescribeVodDomainISPData.DomainName");
			describeVodDomainISPDataResponse.DataInterval = context.StringValue("DescribeVodDomainISPData.DataInterval");
			describeVodDomainISPDataResponse.StartTime = context.StringValue("DescribeVodDomainISPData.StartTime");
			describeVodDomainISPDataResponse.EndTime = context.StringValue("DescribeVodDomainISPData.EndTime");

			List<DescribeVodDomainISPDataResponse.DescribeVodDomainISPData_ISPProportionData> describeVodDomainISPDataResponse_value = new List<DescribeVodDomainISPDataResponse.DescribeVodDomainISPData_ISPProportionData>();
			for (int i = 0; i < context.Length("DescribeVodDomainISPData.Value.Length"); i++) {
				DescribeVodDomainISPDataResponse.DescribeVodDomainISPData_ISPProportionData iSPProportionData = new DescribeVodDomainISPDataResponse.DescribeVodDomainISPData_ISPProportionData();
				iSPProportionData.ISP = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].ISP");
				iSPProportionData.Proportion = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].Proportion");
				iSPProportionData.IspEname = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].IspEname");
				iSPProportionData.AvgObjectSize = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].AvgObjectSize");
				iSPProportionData.AvgResponseTime = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].AvgResponseTime");
				iSPProportionData.Bps = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].Bps");
				iSPProportionData.Qps = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].Qps");
				iSPProportionData.AvgResponseRate = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].AvgResponseRate");
				iSPProportionData.ReqErrRate = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].ReqErrRate");
				iSPProportionData.TotalBytes = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].TotalBytes");
				iSPProportionData.BytesProportion = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].BytesProportion");
				iSPProportionData.TotalQuery = context.StringValue("DescribeVodDomainISPData.Value["+ i +"].TotalQuery");

				describeVodDomainISPDataResponse_value.Add(iSPProportionData);
			}
			describeVodDomainISPDataResponse._Value = describeVodDomainISPDataResponse_value;
        
			return describeVodDomainISPDataResponse;
        }
    }
}
