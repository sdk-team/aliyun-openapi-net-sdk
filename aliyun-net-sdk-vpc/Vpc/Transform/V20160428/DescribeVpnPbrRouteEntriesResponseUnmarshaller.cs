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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpnPbrRouteEntriesResponseUnmarshaller
    {
        public static DescribeVpnPbrRouteEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnPbrRouteEntriesResponse describeVpnPbrRouteEntriesResponse = new DescribeVpnPbrRouteEntriesResponse();

			describeVpnPbrRouteEntriesResponse.HttpResponse = context.HttpResponse;
			describeVpnPbrRouteEntriesResponse.RequestId = context.StringValue("DescribeVpnPbrRouteEntries.RequestId");
			describeVpnPbrRouteEntriesResponse.TotalCount = context.IntegerValue("DescribeVpnPbrRouteEntries.TotalCount");
			describeVpnPbrRouteEntriesResponse.PageNumber = context.IntegerValue("DescribeVpnPbrRouteEntries.PageNumber");
			describeVpnPbrRouteEntriesResponse.PageSize = context.IntegerValue("DescribeVpnPbrRouteEntries.PageSize");

			List<DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry> describeVpnPbrRouteEntriesResponse_vpnPbrRouteEntries = new List<DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry>();
			for (int i = 0; i < context.Length("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries.Length"); i++) {
				DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry vpnPbrRouteEntry = new DescribeVpnPbrRouteEntriesResponse.DescribeVpnPbrRouteEntries_VpnPbrRouteEntry();
				vpnPbrRouteEntry.VpnInstanceId = context.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].VpnInstanceId");
				vpnPbrRouteEntry.RouteSource = context.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].RouteSource");
				vpnPbrRouteEntry.RouteDest = context.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].RouteDest");
				vpnPbrRouteEntry.NextHop = context.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].NextHop");
				vpnPbrRouteEntry.Weight = context.IntegerValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].Weight");
				vpnPbrRouteEntry.CreateTime = context.LongValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].CreateTime");
				vpnPbrRouteEntry.State = context.StringValue("DescribeVpnPbrRouteEntries.VpnPbrRouteEntries["+ i +"].State");

				describeVpnPbrRouteEntriesResponse_vpnPbrRouteEntries.Add(vpnPbrRouteEntry);
			}
			describeVpnPbrRouteEntriesResponse.VpnPbrRouteEntries = describeVpnPbrRouteEntriesResponse_vpnPbrRouteEntries;
        
			return describeVpnPbrRouteEntriesResponse;
        }
    }
}
