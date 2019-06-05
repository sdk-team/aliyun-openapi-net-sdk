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
    public class ModifyVpnGreTunnelResponseUnmarshaller
    {
        public static ModifyVpnGreTunnelResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyVpnGreTunnelResponse modifyVpnGreTunnelResponse = new ModifyVpnGreTunnelResponse();

			modifyVpnGreTunnelResponse.HttpResponse = context.HttpResponse;
			modifyVpnGreTunnelResponse.RequestId = context.StringValue("ModifyVpnGreTunnel.RequestId");
			modifyVpnGreTunnelResponse.InstanceId = context.StringValue("ModifyVpnGreTunnel.InstanceId");
			modifyVpnGreTunnelResponse.VpnGatewayInstanceId = context.StringValue("ModifyVpnGreTunnel.VpnGatewayInstanceId");
			modifyVpnGreTunnelResponse.CustomerGatewayInstanceId = context.StringValue("ModifyVpnGreTunnel.CustomerGatewayInstanceId");
			modifyVpnGreTunnelResponse.TunnelIp = context.StringValue("ModifyVpnGreTunnel.TunnelIp");
			modifyVpnGreTunnelResponse.Source = context.StringValue("ModifyVpnGreTunnel.Source");
			modifyVpnGreTunnelResponse.Destination = context.StringValue("ModifyVpnGreTunnel.Destination");
			modifyVpnGreTunnelResponse.KeepaliveEnable = context.StringValue("ModifyVpnGreTunnel.KeepaliveEnable");
			modifyVpnGreTunnelResponse.KeepaliveSeconds = context.IntegerValue("ModifyVpnGreTunnel.KeepaliveSeconds");
			modifyVpnGreTunnelResponse.KeepaliveTimes = context.IntegerValue("ModifyVpnGreTunnel.KeepaliveTimes");
			modifyVpnGreTunnelResponse.ChecksumEnable = context.StringValue("ModifyVpnGreTunnel.ChecksumEnable");
			modifyVpnGreTunnelResponse.GreKey = context.LongValue("ModifyVpnGreTunnel.GreKey");
			modifyVpnGreTunnelResponse.Name = context.StringValue("ModifyVpnGreTunnel.Name");
			modifyVpnGreTunnelResponse.Description = context.StringValue("ModifyVpnGreTunnel.Description");
			modifyVpnGreTunnelResponse.CreateTime = context.LongValue("ModifyVpnGreTunnel.CreateTime");
			modifyVpnGreTunnelResponse.RegionNo = context.StringValue("ModifyVpnGreTunnel.RegionNo");
			modifyVpnGreTunnelResponse.TunnelPeerIp = context.StringValue("ModifyVpnGreTunnel.TunnelPeerIp");

			ModifyVpnGreTunnelResponse.ModifyVpnGreTunnel_HealthCheck healthCheck = new ModifyVpnGreTunnelResponse.ModifyVpnGreTunnel_HealthCheck();
			healthCheck.Enable = context.StringValue("ModifyVpnGreTunnel.HealthCheck.Enable");
			healthCheck.Sip = context.StringValue("ModifyVpnGreTunnel.HealthCheck.Sip");
			healthCheck.Dip = context.StringValue("ModifyVpnGreTunnel.HealthCheck.Dip");
			healthCheck.Interval = context.IntegerValue("ModifyVpnGreTunnel.HealthCheck.Interval");
			healthCheck.Retry = context.IntegerValue("ModifyVpnGreTunnel.HealthCheck.Retry");
			modifyVpnGreTunnelResponse.HealthCheck = healthCheck;
        
			return modifyVpnGreTunnelResponse;
        }
    }
}
