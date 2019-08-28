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
    public class DescribeVodDomainTopReferVisitResponseUnmarshaller
    {
        public static DescribeVodDomainTopReferVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainTopReferVisitResponse describeVodDomainTopReferVisitResponse = new DescribeVodDomainTopReferVisitResponse();

			describeVodDomainTopReferVisitResponse.HttpResponse = context.HttpResponse;
			describeVodDomainTopReferVisitResponse.RequestId = context.StringValue("DescribeVodDomainTopReferVisit.RequestId");
			describeVodDomainTopReferVisitResponse.DomainName = context.StringValue("DescribeVodDomainTopReferVisit.DomainName");
			describeVodDomainTopReferVisitResponse.StartTime = context.StringValue("DescribeVodDomainTopReferVisit.StartTime");

			List<DescribeVodDomainTopReferVisitResponse.DescribeVodDomainTopReferVisit_ReferList> describeVodDomainTopReferVisitResponse_topReferList = new List<DescribeVodDomainTopReferVisitResponse.DescribeVodDomainTopReferVisit_ReferList>();
			for (int i = 0; i < context.Length("DescribeVodDomainTopReferVisit.TopReferList.Length"); i++) {
				DescribeVodDomainTopReferVisitResponse.DescribeVodDomainTopReferVisit_ReferList referList = new DescribeVodDomainTopReferVisitResponse.DescribeVodDomainTopReferVisit_ReferList();
				referList.ReferDetail = context.StringValue("DescribeVodDomainTopReferVisit.TopReferList["+ i +"].ReferDetail");
				referList.VisitData = context.StringValue("DescribeVodDomainTopReferVisit.TopReferList["+ i +"].VisitData");
				referList.VisitProportion = context.FloatValue("DescribeVodDomainTopReferVisit.TopReferList["+ i +"].VisitProportion");
				referList.Flow = context.StringValue("DescribeVodDomainTopReferVisit.TopReferList["+ i +"].Flow");
				referList.FlowProportion = context.FloatValue("DescribeVodDomainTopReferVisit.TopReferList["+ i +"].FlowProportion");

				describeVodDomainTopReferVisitResponse_topReferList.Add(referList);
			}
			describeVodDomainTopReferVisitResponse.TopReferList = describeVodDomainTopReferVisitResponse_topReferList;
        
			return describeVodDomainTopReferVisitResponse;
        }
    }
}
