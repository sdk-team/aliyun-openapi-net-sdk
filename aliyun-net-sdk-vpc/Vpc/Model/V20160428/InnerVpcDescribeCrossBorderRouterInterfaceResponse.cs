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
	public class InnerVpcDescribeCrossBorderRouterInterfaceResponse : AcsResponse
	{

		private string requestId;

		private List<InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId> alreadyOpenedIds;

		private List<InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId> notOpenedIds;

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

		public List<InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId> AlreadyOpenedIds
		{
			get
			{
				return alreadyOpenedIds;
			}
			set	
			{
				alreadyOpenedIds = value;
			}
		}

		public List<InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId> NotOpenedIds
		{
			get
			{
				return notOpenedIds;
			}
			set	
			{
				notOpenedIds = value;
			}
		}

		public class InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId
		{

			private long? aliUid;

			private long? oppositeInterfaceOwnerId;

			private string instanceId;

			private string oppositeInterfaceId;

			private string regionNo;

			private string oppositeRegionNo;

			private string spec;

			private string oppositeInterfaceSpec;

			private string connectedTime;

			private string description;

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public long? OppositeInterfaceOwnerId
			{
				get
				{
					return oppositeInterfaceOwnerId;
				}
				set	
				{
					oppositeInterfaceOwnerId = value;
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

			public string OppositeInterfaceId
			{
				get
				{
					return oppositeInterfaceId;
				}
				set	
				{
					oppositeInterfaceId = value;
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

			public string OppositeRegionNo
			{
				get
				{
					return oppositeRegionNo;
				}
				set	
				{
					oppositeRegionNo = value;
				}
			}

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public string OppositeInterfaceSpec
			{
				get
				{
					return oppositeInterfaceSpec;
				}
				set	
				{
					oppositeInterfaceSpec = value;
				}
			}

			public string ConnectedTime
			{
				get
				{
					return connectedTime;
				}
				set	
				{
					connectedTime = value;
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
		}

		public class InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId
		{

			private long? aliUid;

			private long? oppositeInterfaceOwnerId;

			private string instanceId;

			private string oppositeInterfaceId;

			private string regionNo;

			private string oppositeRegionNo;

			private string spec;

			private string oppositeInterfaceSpec;

			private string connectedTime;

			private string description;

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public long? OppositeInterfaceOwnerId
			{
				get
				{
					return oppositeInterfaceOwnerId;
				}
				set	
				{
					oppositeInterfaceOwnerId = value;
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

			public string OppositeInterfaceId
			{
				get
				{
					return oppositeInterfaceId;
				}
				set	
				{
					oppositeInterfaceId = value;
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

			public string OppositeRegionNo
			{
				get
				{
					return oppositeRegionNo;
				}
				set	
				{
					oppositeRegionNo = value;
				}
			}

			public string Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public string OppositeInterfaceSpec
			{
				get
				{
					return oppositeInterfaceSpec;
				}
				set	
				{
					oppositeInterfaceSpec = value;
				}
			}

			public string ConnectedTime
			{
				get
				{
					return connectedTime;
				}
				set	
				{
					connectedTime = value;
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
		}
	}
}
