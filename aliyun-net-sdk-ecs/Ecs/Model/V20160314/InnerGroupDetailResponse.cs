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
	public class InnerGroupDetailResponse : AcsResponse
	{

		private string requestId;

		private InnerGroupDetail_ErrorCode errorCode;

		private InnerGroupDetail_Data data;

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

		public InnerGroupDetail_ErrorCode ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public InnerGroupDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class InnerGroupDetail_ErrorCode
		{

			private string code;

			private string message;

			private bool? isSuccess;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public bool? IsSuccess
			{
				get
				{
					return isSuccess;
				}
				set	
				{
					isSuccess = value;
				}
			}
		}

		public class InnerGroupDetail_Data
		{

			private int? ecsCount;

			private string vpcInstanceId;

			private string groupDesc;

			private string regionNo;

			private string groupName;

			private string gmtCreated;

			private string groupNo;

			private string gmtModified;

			private List<InnerGroupDetail_Permission> permissions;

			private List<InnerGroupDetail_Tag> tags;

			public int? EcsCount
			{
				get
				{
					return ecsCount;
				}
				set	
				{
					ecsCount = value;
				}
			}

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
				}
			}

			public string GroupDesc
			{
				get
				{
					return groupDesc;
				}
				set	
				{
					groupDesc = value;
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

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}

			public string GroupNo
			{
				get
				{
					return groupNo;
				}
				set	
				{
					groupNo = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public List<InnerGroupDetail_Permission> Permissions
			{
				get
				{
					return permissions;
				}
				set	
				{
					permissions = value;
				}
			}

			public List<InnerGroupDetail_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class InnerGroupDetail_Permission
			{

				private string portRange;

				private string destCidrIp;

				private string direction;

				private string nic;

				private string sourceGroupOwnerUserAccount;

				private string policy;

				private string ipProtocal;

				private string destGroupNo;

				private string destGroupOwnerUserAccount;

				private string sourceGroupNo;

				private int? level;

				private string sourceCidrIp;

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

				public string Nic
				{
					get
					{
						return nic;
					}
					set	
					{
						nic = value;
					}
				}

				public string SourceGroupOwnerUserAccount
				{
					get
					{
						return sourceGroupOwnerUserAccount;
					}
					set	
					{
						sourceGroupOwnerUserAccount = value;
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

				public string IpProtocal
				{
					get
					{
						return ipProtocal;
					}
					set	
					{
						ipProtocal = value;
					}
				}

				public string DestGroupNo
				{
					get
					{
						return destGroupNo;
					}
					set	
					{
						destGroupNo = value;
					}
				}

				public string DestGroupOwnerUserAccount
				{
					get
					{
						return destGroupOwnerUserAccount;
					}
					set	
					{
						destGroupOwnerUserAccount = value;
					}
				}

				public string SourceGroupNo
				{
					get
					{
						return sourceGroupNo;
					}
					set	
					{
						sourceGroupNo = value;
					}
				}

				public int? Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
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
			}

			public class InnerGroupDetail_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
