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
	public class DescribeEventDetailResponse : AcsResponse
	{

		private string requestId;

		private string resourceId;

		private string eventType;

		private string eventCategory;

		private string status;

		private string supportModify;

		private string planTime;

		private string expireTime;

		private string eventId;

		private string startTime;

		private string endTime;

		private string effectTime;

		private string limitTime;

		private string mark;

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

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
			}
		}

		public string EventType
		{
			get
			{
				return eventType;
			}
			set	
			{
				eventType = value;
			}
		}

		public string EventCategory
		{
			get
			{
				return eventCategory;
			}
			set	
			{
				eventCategory = value;
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

		public string SupportModify
		{
			get
			{
				return supportModify;
			}
			set	
			{
				supportModify = value;
			}
		}

		public string PlanTime
		{
			get
			{
				return planTime;
			}
			set	
			{
				planTime = value;
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public string EventId
		{
			get
			{
				return eventId;
			}
			set	
			{
				eventId = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string EffectTime
		{
			get
			{
				return effectTime;
			}
			set	
			{
				effectTime = value;
			}
		}

		public string LimitTime
		{
			get
			{
				return limitTime;
			}
			set	
			{
				limitTime = value;
			}
		}

		public string Mark
		{
			get
			{
				return mark;
			}
			set	
			{
				mark = value;
			}
		}
	}
}
