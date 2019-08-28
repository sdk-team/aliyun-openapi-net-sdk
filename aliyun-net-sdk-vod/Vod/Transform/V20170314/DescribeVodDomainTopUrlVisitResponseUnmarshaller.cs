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
    public class DescribeVodDomainTopUrlVisitResponseUnmarshaller
    {
        public static DescribeVodDomainTopUrlVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainTopUrlVisitResponse describeVodDomainTopUrlVisitResponse = new DescribeVodDomainTopUrlVisitResponse();

			describeVodDomainTopUrlVisitResponse.HttpResponse = context.HttpResponse;
			describeVodDomainTopUrlVisitResponse.RequestId = context.StringValue("DescribeVodDomainTopUrlVisit.RequestId");
			describeVodDomainTopUrlVisitResponse.DomainName = context.StringValue("DescribeVodDomainTopUrlVisit.DomainName");
			describeVodDomainTopUrlVisitResponse.StartTime = context.StringValue("DescribeVodDomainTopUrlVisit.StartTime");

			List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList> describeVodDomainTopUrlVisitResponse_allUrlList = new List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeVodDomainTopUrlVisit.AllUrlList.Length"); i++) {
				DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList urlList = new DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeVodDomainTopUrlVisit.AllUrlList["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeVodDomainTopUrlVisit.AllUrlList["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.AllUrlList["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeVodDomainTopUrlVisit.AllUrlList["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.AllUrlList["+ i +"].FlowProportion");

				describeVodDomainTopUrlVisitResponse_allUrlList.Add(urlList);
			}
			describeVodDomainTopUrlVisitResponse.AllUrlList = describeVodDomainTopUrlVisitResponse_allUrlList;

			List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList> describeVodDomainTopUrlVisitResponse_url200List = new List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeVodDomainTopUrlVisit.Url200List.Length"); i++) {
				DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList urlList = new DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeVodDomainTopUrlVisit.Url200List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeVodDomainTopUrlVisit.Url200List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url200List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeVodDomainTopUrlVisit.Url200List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url200List["+ i +"].FlowProportion");

				describeVodDomainTopUrlVisitResponse_url200List.Add(urlList);
			}
			describeVodDomainTopUrlVisitResponse.Url200List = describeVodDomainTopUrlVisitResponse_url200List;

			List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList> describeVodDomainTopUrlVisitResponse_url300List = new List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeVodDomainTopUrlVisit.Url300List.Length"); i++) {
				DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList urlList = new DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeVodDomainTopUrlVisit.Url300List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeVodDomainTopUrlVisit.Url300List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url300List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeVodDomainTopUrlVisit.Url300List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url300List["+ i +"].FlowProportion");

				describeVodDomainTopUrlVisitResponse_url300List.Add(urlList);
			}
			describeVodDomainTopUrlVisitResponse.Url300List = describeVodDomainTopUrlVisitResponse_url300List;

			List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList> describeVodDomainTopUrlVisitResponse_url400List = new List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeVodDomainTopUrlVisit.Url400List.Length"); i++) {
				DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList urlList = new DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeVodDomainTopUrlVisit.Url400List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeVodDomainTopUrlVisit.Url400List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url400List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeVodDomainTopUrlVisit.Url400List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url400List["+ i +"].FlowProportion");

				describeVodDomainTopUrlVisitResponse_url400List.Add(urlList);
			}
			describeVodDomainTopUrlVisitResponse.Url400List = describeVodDomainTopUrlVisitResponse_url400List;

			List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList> describeVodDomainTopUrlVisitResponse_url500List = new List<DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeVodDomainTopUrlVisit.Url500List.Length"); i++) {
				DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList urlList = new DescribeVodDomainTopUrlVisitResponse.DescribeVodDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeVodDomainTopUrlVisit.Url500List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeVodDomainTopUrlVisit.Url500List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url500List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeVodDomainTopUrlVisit.Url500List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeVodDomainTopUrlVisit.Url500List["+ i +"].FlowProportion");

				describeVodDomainTopUrlVisitResponse_url500List.Add(urlList);
			}
			describeVodDomainTopUrlVisitResponse.Url500List = describeVodDomainTopUrlVisitResponse_url500List;
        
			return describeVodDomainTopUrlVisitResponse;
        }
    }
}
