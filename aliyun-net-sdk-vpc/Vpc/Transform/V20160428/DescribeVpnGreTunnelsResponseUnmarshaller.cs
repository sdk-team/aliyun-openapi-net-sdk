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
    public class DescribeVpnGreTunnelsResponseUnmarshaller
    {
        public static DescribeVpnGreTunnelsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnGreTunnelsResponse describeVpnGreTunnelsResponse = new DescribeVpnGreTunnelsResponse();

			describeVpnGreTunnelsResponse.HttpResponse = context.HttpResponse;
			describeVpnGreTunnelsResponse.RequestId = context.StringValue("DescribeVpnGreTunnels.RequestId");
			describeVpnGreTunnelsResponse.TotalCount = context.IntegerValue("DescribeVpnGreTunnels.TotalCount");
			describeVpnGreTunnelsResponse.PageNumber = context.IntegerValue("DescribeVpnGreTunnels.PageNumber");
			describeVpnGreTunnelsResponse.PageSize = context.IntegerValue("DescribeVpnGreTunnels.PageSize");

			List<DescribeVpnGreTunnelsResponse.DescribeVpnGreTunnels_VpnGreTunnelsItem> describeVpnGreTunnelsResponse_vpnGreTunnels = new List<DescribeVpnGreTunnelsResponse.DescribeVpnGreTunnels_VpnGreTunnelsItem>();
			for (int i = 0; i < context.Length("DescribeVpnGreTunnels.VpnGreTunnels.Length"); i++) {
				DescribeVpnGreTunnelsResponse.DescribeVpnGreTunnels_VpnGreTunnelsItem vpnGreTunnelsItem = new DescribeVpnGreTunnelsResponse.DescribeVpnGreTunnels_VpnGreTunnelsItem();
				vpnGreTunnelsItem.VpnGatewayInstanceId = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].VpnGatewayInstanceId");
				vpnGreTunnelsItem.InstanceId = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].InstanceId");
				vpnGreTunnelsItem.CustomerGatewayInstanceId = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].CustomerGatewayInstanceId");
				vpnGreTunnelsItem.TunnelIp = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].TunnelIp");
				vpnGreTunnelsItem.Source = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].Source");
				vpnGreTunnelsItem.Destination = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].Destination");
				vpnGreTunnelsItem.KeepaliveEnable = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].KeepaliveEnable");
				vpnGreTunnelsItem.KeepaliveSeconds = context.IntegerValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].KeepaliveSeconds");
				vpnGreTunnelsItem.KeepaliveTimes = context.IntegerValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].KeepaliveTimes");
				vpnGreTunnelsItem.KeepaliveState = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].KeepaliveState");
				vpnGreTunnelsItem.ChecksumEnable = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].ChecksumEnable");
				vpnGreTunnelsItem.GreKey = context.IntegerValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].GreKey");
				vpnGreTunnelsItem.Name = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].Name");
				vpnGreTunnelsItem.Description = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].Description");
				vpnGreTunnelsItem.CreateTime = context.LongValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].CreateTime");
				vpnGreTunnelsItem.RegionNo = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].RegionNo");
				vpnGreTunnelsItem.TunnelPeerIp = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].TunnelPeerIp");

				DescribeVpnGreTunnelsResponse.DescribeVpnGreTunnels_VpnGreTunnelsItem.DescribeVpnGreTunnels_HealthCheck healthCheck = new DescribeVpnGreTunnelsResponse.DescribeVpnGreTunnels_VpnGreTunnelsItem.DescribeVpnGreTunnels_HealthCheck();
				healthCheck.Enable = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].HealthCheck.Enable");
				healthCheck.Sip = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].HealthCheck.Sip");
				healthCheck.Dip = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].HealthCheck.Dip");
				healthCheck.Interval = context.IntegerValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].HealthCheck.Interval");
				healthCheck.Retry = context.IntegerValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].HealthCheck.Retry");
				healthCheck.Status = context.StringValue("DescribeVpnGreTunnels.VpnGreTunnels["+ i +"].HealthCheck.Status");
				vpnGreTunnelsItem.HealthCheck = healthCheck;

				describeVpnGreTunnelsResponse_vpnGreTunnels.Add(vpnGreTunnelsItem);
			}
			describeVpnGreTunnelsResponse.VpnGreTunnels = describeVpnGreTunnelsResponse_vpnGreTunnels;
        
			return describeVpnGreTunnelsResponse;
        }
    }
}
