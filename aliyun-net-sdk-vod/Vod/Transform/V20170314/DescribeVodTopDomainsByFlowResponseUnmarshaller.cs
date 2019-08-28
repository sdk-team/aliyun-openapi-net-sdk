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
    public class DescribeVodTopDomainsByFlowResponseUnmarshaller
    {
        public static DescribeVodTopDomainsByFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodTopDomainsByFlowResponse describeVodTopDomainsByFlowResponse = new DescribeVodTopDomainsByFlowResponse();

			describeVodTopDomainsByFlowResponse.HttpResponse = context.HttpResponse;
			describeVodTopDomainsByFlowResponse.RequestId = context.StringValue("DescribeVodTopDomainsByFlow.RequestId");
			describeVodTopDomainsByFlowResponse.StartTime = context.StringValue("DescribeVodTopDomainsByFlow.StartTime");
			describeVodTopDomainsByFlowResponse.EndTime = context.StringValue("DescribeVodTopDomainsByFlow.EndTime");
			describeVodTopDomainsByFlowResponse.DomainCount = context.LongValue("DescribeVodTopDomainsByFlow.DomainCount");
			describeVodTopDomainsByFlowResponse.DomainOnlineCount = context.LongValue("DescribeVodTopDomainsByFlow.DomainOnlineCount");

			List<DescribeVodTopDomainsByFlowResponse.DescribeVodTopDomainsByFlow_TopDomain> describeVodTopDomainsByFlowResponse_topDomains = new List<DescribeVodTopDomainsByFlowResponse.DescribeVodTopDomainsByFlow_TopDomain>();
			for (int i = 0; i < context.Length("DescribeVodTopDomainsByFlow.TopDomains.Length"); i++) {
				DescribeVodTopDomainsByFlowResponse.DescribeVodTopDomainsByFlow_TopDomain topDomain = new DescribeVodTopDomainsByFlowResponse.DescribeVodTopDomainsByFlow_TopDomain();
				topDomain.DomainName = context.StringValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].DomainName");
				topDomain.Rank = context.LongValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].Rank");
				topDomain.TotalTraffic = context.StringValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].TotalTraffic");
				topDomain.TrafficPercent = context.StringValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].TrafficPercent");
				topDomain.MaxBps = context.LongValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].MaxBps");
				topDomain.MaxBpsTime = context.StringValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].MaxBpsTime");
				topDomain.TotalAccess = context.LongValue("DescribeVodTopDomainsByFlow.TopDomains["+ i +"].TotalAccess");

				describeVodTopDomainsByFlowResponse_topDomains.Add(topDomain);
			}
			describeVodTopDomainsByFlowResponse.TopDomains = describeVodTopDomainsByFlowResponse_topDomains;
        
			return describeVodTopDomainsByFlowResponse;
        }
    }
}
