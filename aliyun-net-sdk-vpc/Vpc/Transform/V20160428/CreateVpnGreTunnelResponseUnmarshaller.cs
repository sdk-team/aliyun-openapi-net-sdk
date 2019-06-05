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
    public class CreateVpnGreTunnelResponseUnmarshaller
    {
        public static CreateVpnGreTunnelResponse Unmarshall(UnmarshallerContext context)
        {
			CreateVpnGreTunnelResponse createVpnGreTunnelResponse = new CreateVpnGreTunnelResponse();

			createVpnGreTunnelResponse.HttpResponse = context.HttpResponse;
			createVpnGreTunnelResponse.RequestId = context.StringValue("CreateVpnGreTunnel.RequestId");
			createVpnGreTunnelResponse.InstanceId = context.StringValue("CreateVpnGreTunnel.InstanceId");
			createVpnGreTunnelResponse.VpnGatewayInstanceId = context.StringValue("CreateVpnGreTunnel.VpnGatewayInstanceId");
			createVpnGreTunnelResponse.CustomerGatewayInstanceId = context.StringValue("CreateVpnGreTunnel.CustomerGatewayInstanceId");
			createVpnGreTunnelResponse.TunnelIp = context.StringValue("CreateVpnGreTunnel.TunnelIp");
			createVpnGreTunnelResponse.Source = context.StringValue("CreateVpnGreTunnel.Source");
			createVpnGreTunnelResponse.Destination = context.StringValue("CreateVpnGreTunnel.Destination");
			createVpnGreTunnelResponse.KeepaliveEnable = context.StringValue("CreateVpnGreTunnel.KeepaliveEnable");
			createVpnGreTunnelResponse.KeepaliveSeconds = context.IntegerValue("CreateVpnGreTunnel.KeepaliveSeconds");
			createVpnGreTunnelResponse.KeepaliveTimes = context.IntegerValue("CreateVpnGreTunnel.KeepaliveTimes");
			createVpnGreTunnelResponse.ChecksumEnable = context.StringValue("CreateVpnGreTunnel.ChecksumEnable");
			createVpnGreTunnelResponse.GreKey = context.LongValue("CreateVpnGreTunnel.GreKey");
			createVpnGreTunnelResponse.Name = context.StringValue("CreateVpnGreTunnel.Name");
			createVpnGreTunnelResponse.Description = context.StringValue("CreateVpnGreTunnel.Description");
			createVpnGreTunnelResponse.CreateTime = context.LongValue("CreateVpnGreTunnel.CreateTime");
			createVpnGreTunnelResponse.RegionNo = context.StringValue("CreateVpnGreTunnel.RegionNo");
			createVpnGreTunnelResponse.TunnelPeerIp = context.StringValue("CreateVpnGreTunnel.TunnelPeerIp");

			CreateVpnGreTunnelResponse.CreateVpnGreTunnel_HealthCheck healthCheck = new CreateVpnGreTunnelResponse.CreateVpnGreTunnel_HealthCheck();
			healthCheck.Enable = context.StringValue("CreateVpnGreTunnel.HealthCheck.Enable");
			healthCheck.Sip = context.StringValue("CreateVpnGreTunnel.HealthCheck.Sip");
			healthCheck.Dip = context.StringValue("CreateVpnGreTunnel.HealthCheck.Dip");
			healthCheck.Interval = context.IntegerValue("CreateVpnGreTunnel.HealthCheck.Interval");
			healthCheck.Retry = context.IntegerValue("CreateVpnGreTunnel.HealthCheck.Retry");
			createVpnGreTunnelResponse.HealthCheck = healthCheck;
        
			return createVpnGreTunnelResponse;
        }
    }
}
