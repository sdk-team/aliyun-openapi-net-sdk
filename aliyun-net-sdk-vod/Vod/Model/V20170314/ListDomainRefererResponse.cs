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

namespace Aliyun.Acs.vod.Model.V20170314
{
	public class ListDomainRefererResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private string allowEmpty;

		private List<ListDomainReferer_RefererItem> refererList;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public string AllowEmpty
		{
			get
			{
				return allowEmpty;
			}
			set	
			{
				allowEmpty = value;
			}
		}

		public List<ListDomainReferer_RefererItem> RefererList
		{
			get
			{
				return refererList;
			}
			set	
			{
				refererList = value;
			}
		}

		public class ListDomainReferer_RefererItem
		{

			private long? refererId;

			private string referer;

			private string createTime;

			public long? RefererId
			{
				get
				{
					return refererId;
				}
				set	
				{
					refererId = value;
				}
			}

			public string Referer
			{
				get
				{
					return referer;
				}
				set	
				{
					referer = value;
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
