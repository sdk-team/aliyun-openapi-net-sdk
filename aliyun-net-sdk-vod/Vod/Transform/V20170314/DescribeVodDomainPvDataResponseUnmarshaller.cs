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
    public class DescribeVodDomainPvDataResponseUnmarshaller
    {
        public static DescribeVodDomainPvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainPvDataResponse describeVodDomainPvDataResponse = new DescribeVodDomainPvDataResponse();

			describeVodDomainPvDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainPvDataResponse.RequestId = context.StringValue("DescribeVodDomainPvData.RequestId");
			describeVodDomainPvDataResponse.DomainName = context.StringValue("DescribeVodDomainPvData.DomainName");
			describeVodDomainPvDataResponse.StartTime = context.StringValue("DescribeVodDomainPvData.StartTime");

			List<DescribeVodDomainPvDataResponse.DescribeVodDomainPvData_PvDataIntervalItem> describeVodDomainPvDataResponse_pvDataInterval = new List<DescribeVodDomainPvDataResponse.DescribeVodDomainPvData_PvDataIntervalItem>();
			for (int i = 0; i < context.Length("DescribeVodDomainPvData.PvDataInterval.Length"); i++) {
				DescribeVodDomainPvDataResponse.DescribeVodDomainPvData_PvDataIntervalItem pvDataIntervalItem = new DescribeVodDomainPvDataResponse.DescribeVodDomainPvData_PvDataIntervalItem();
				pvDataIntervalItem._Value = context.StringValue("DescribeVodDomainPvData.PvDataInterval["+ i +"]._Value");
				pvDataIntervalItem.TimeStamp = context.StringValue("DescribeVodDomainPvData.PvDataInterval["+ i +"].TimeStamp");

				describeVodDomainPvDataResponse_pvDataInterval.Add(pvDataIntervalItem);
			}
			describeVodDomainPvDataResponse.PvDataInterval = describeVodDomainPvDataResponse_pvDataInterval;
        
			return describeVodDomainPvDataResponse;
        }
    }
}
