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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class CreateVpnGreTunnelRequest : RpcAcsRequest<CreateVpnGreTunnelResponse>
    {
        public CreateVpnGreTunnelRequest()
            : base("Vpc", "2016-04-28", "CreateVpnGreTunnel")
        {
        }

		private long? resourceOwnerId;

		private int? keepaliveSeconds;

		private string clientToken;

		private string description;

		private string healthCheckConfig;

		private string customerGatewayId;

		private string keepaliveEnable;

		private string tunnelPeerIp;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string vpnGatewayId;

		private long? ownerId;

		private string name;

		private int? keepaliveTimes;

		private string tunnelIp;

		private string checksumEnable;

		private long? greKey;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? KeepaliveSeconds
		{
			get
			{
				return keepaliveSeconds;
			}
			set	
			{
				keepaliveSeconds = value;
				DictionaryUtil.Add(QueryParameters, "KeepaliveSeconds", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string HealthCheckConfig
		{
			get
			{
				return healthCheckConfig;
			}
			set	
			{
				healthCheckConfig = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConfig", value);
			}
		}

		public string CustomerGatewayId
		{
			get
			{
				return customerGatewayId;
			}
			set	
			{
				customerGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "CustomerGatewayId", value);
			}
		}

		public string KeepaliveEnable
		{
			get
			{
				return keepaliveEnable;
			}
			set	
			{
				keepaliveEnable = value;
				DictionaryUtil.Add(QueryParameters, "KeepaliveEnable", value);
			}
		}

		public string TunnelPeerIp
		{
			get
			{
				return tunnelPeerIp;
			}
			set	
			{
				tunnelPeerIp = value;
				DictionaryUtil.Add(QueryParameters, "TunnelPeerIp", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "VpnGatewayId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? KeepaliveTimes
		{
			get
			{
				return keepaliveTimes;
			}
			set	
			{
				keepaliveTimes = value;
				DictionaryUtil.Add(QueryParameters, "KeepaliveTimes", value.ToString());
			}
		}

		public string TunnelIp
		{
			get
			{
				return tunnelIp;
			}
			set	
			{
				tunnelIp = value;
				DictionaryUtil.Add(QueryParameters, "TunnelIp", value);
			}
		}

		public string ChecksumEnable
		{
			get
			{
				return checksumEnable;
			}
			set	
			{
				checksumEnable = value;
				DictionaryUtil.Add(QueryParameters, "ChecksumEnable", value);
			}
		}

		public long? GreKey
		{
			get
			{
				return greKey;
			}
			set	
			{
				greKey = value;
				DictionaryUtil.Add(QueryParameters, "GreKey", value.ToString());
			}
		}

        public override CreateVpnGreTunnelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVpnGreTunnelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
