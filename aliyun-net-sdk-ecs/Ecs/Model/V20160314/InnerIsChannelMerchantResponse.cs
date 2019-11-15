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

namespace Aliyun.Acs.Ecs.Model.V20160314
{
	public class InnerIsChannelMerchantResponse : AcsResponse
	{

		private string requestId;

		private InnerIsChannelMerchant_EcsChannel ecsChannel;

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

		public InnerIsChannelMerchant_EcsChannel EcsChannel
		{
			get
			{
				return ecsChannel;
			}
			set	
			{
				ecsChannel = value;
			}
		}

		public class InnerIsChannelMerchant_EcsChannel
		{

			private bool? isChannelMerchant;

			private long? aliUid;

			private string bid;

			private string channel;

			private string instanceId;

			public bool? IsChannelMerchant
			{
				get
				{
					return isChannelMerchant;
				}
				set	
				{
					isChannelMerchant = value;
				}
			}

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

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public string Channel
			{
				get
				{
					return channel;
				}
				set	
				{
					channel = value;
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
		}
	}
}
