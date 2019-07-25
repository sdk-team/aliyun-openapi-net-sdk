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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class GetServiceSecurityListResponse : AcsResponse
	{

		private string requestId;

		private List<GetServiceSecurityList_ServiceSg> serviceSgs;

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

		public List<GetServiceSecurityList_ServiceSg> ServiceSgs
		{
			get
			{
				return serviceSgs;
			}
			set	
			{
				serviceSgs = value;
			}
		}

		public class GetServiceSecurityList_ServiceSg
		{

			private string createdAt;

			private string updateAt;

			private string groupName;

			private string netType;

			private string serviceId;

			private string ips;

			private string enabled;

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public string UpdateAt
			{
				get
				{
					return updateAt;
				}
				set	
				{
					updateAt = value;
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

			public string NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}

			public string ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public string Ips
			{
				get
				{
					return ips;
				}
				set	
				{
					ips = value;
				}
			}

			public string Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}
		}
	}
}
