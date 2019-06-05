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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class ValidateSecurityGroupResponse : AcsResponse
	{

		private string requestId;

		private string policy;

		private ValidateSecurityGroup_TriggeredGroupRule triggeredGroupRule;

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

		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
			}
		}

		public ValidateSecurityGroup_TriggeredGroupRule TriggeredGroupRule
		{
			get
			{
				return triggeredGroupRule;
			}
			set	
			{
				triggeredGroupRule = value;
			}
		}

		public class ValidateSecurityGroup_TriggeredGroupRule
		{

			private string ipProtocol;

			private string portRange;

			private string sourceGroupId;

			private string sourceGroupName;

			private string sourceCidrIp;

			private string policy;

			private string nicType;

			private string sourceGroupOwnerAccount;

			private string destGroupId;

			private string destGroupName;

			private string destCidrIp;

			private string destGroupOwnerAccount;

			private string priority;

			private string direction;

			private string description;

			private string createTime;

			public string IpProtocol
			{
				get
				{
					return ipProtocol;
				}
				set	
				{
					ipProtocol = value;
				}
			}

			public string PortRange
			{
				get
				{
					return portRange;
				}
				set	
				{
					portRange = value;
				}
			}

			public string SourceGroupId
			{
				get
				{
					return sourceGroupId;
				}
				set	
				{
					sourceGroupId = value;
				}
			}

			public string SourceGroupName
			{
				get
				{
					return sourceGroupName;
				}
				set	
				{
					sourceGroupName = value;
				}
			}

			public string SourceCidrIp
			{
				get
				{
					return sourceCidrIp;
				}
				set	
				{
					sourceCidrIp = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public string NicType
			{
				get
				{
					return nicType;
				}
				set	
				{
					nicType = value;
				}
			}

			public string SourceGroupOwnerAccount
			{
				get
				{
					return sourceGroupOwnerAccount;
				}
				set	
				{
					sourceGroupOwnerAccount = value;
				}
			}

			public string DestGroupId
			{
				get
				{
					return destGroupId;
				}
				set	
				{
					destGroupId = value;
				}
			}

			public string DestGroupName
			{
				get
				{
					return destGroupName;
				}
				set	
				{
					destGroupName = value;
				}
			}

			public string DestCidrIp
			{
				get
				{
					return destCidrIp;
				}
				set	
				{
					destCidrIp = value;
				}
			}

			public string DestGroupOwnerAccount
			{
				get
				{
					return destGroupOwnerAccount;
				}
				set	
				{
					destGroupOwnerAccount = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
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

			public string CreateTime
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
		}
	}
}
