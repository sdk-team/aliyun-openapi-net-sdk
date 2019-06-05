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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeVpnGreTunnelsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeVpnGreTunnels_VpnGreTunnelsItem> vpnGreTunnels;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeVpnGreTunnels_VpnGreTunnelsItem> VpnGreTunnels
		{
			get
			{
				return vpnGreTunnels;
			}
			set	
			{
				vpnGreTunnels = value;
			}
		}

		public class DescribeVpnGreTunnels_VpnGreTunnelsItem
		{

			private string vpnGatewayInstanceId;

			private string instanceId;

			private string customerGatewayInstanceId;

			private string tunnelIp;

			private string source;

			private string destination;

			private string keepaliveEnable;

			private int? keepaliveSeconds;

			private int? keepaliveTimes;

			private string keepaliveState;

			private string checksumEnable;

			private int? greKey;

			private string name;

			private string description;

			private long? createTime;

			private string regionNo;

			private string tunnelPeerIp;

			private DescribeVpnGreTunnels_HealthCheck healthCheck;

			public string VpnGatewayInstanceId
			{
				get
				{
					return vpnGatewayInstanceId;
				}
				set	
				{
					vpnGatewayInstanceId = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string CustomerGatewayInstanceId
			{
				get
				{
					return customerGatewayInstanceId;
				}
				set	
				{
					customerGatewayInstanceId = value;
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
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string Destination
			{
				get
				{
					return destination;
				}
				set	
				{
					destination = value;
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
				}
			}

			public string KeepaliveState
			{
				get
				{
					return keepaliveState;
				}
				set	
				{
					keepaliveState = value;
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
				}
			}

			public int? GreKey
			{
				get
				{
					return greKey;
				}
				set	
				{
					greKey = value;
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
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
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
				}
			}

			public DescribeVpnGreTunnels_HealthCheck HealthCheck
			{
				get
				{
					return healthCheck;
				}
				set	
				{
					healthCheck = value;
				}
			}

			public class DescribeVpnGreTunnels_HealthCheck
			{

				private string enable;

				private string sip;

				private string dip;

				private int? interval;

				private int? retry;

				private string status;

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Sip
				{
					get
					{
						return sip;
					}
					set	
					{
						sip = value;
					}
				}

				public string Dip
				{
					get
					{
						return dip;
					}
					set	
					{
						dip = value;
					}
				}

				public int? Interval
				{
					get
					{
						return interval;
					}
					set	
					{
						interval = value;
					}
				}

				public int? Retry
				{
					get
					{
						return retry;
					}
					set	
					{
						retry = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
