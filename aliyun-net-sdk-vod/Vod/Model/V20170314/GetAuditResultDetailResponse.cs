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
	public class GetAuditResultDetailResponse : AcsResponse
	{

		private string requestId;

		private GetAuditResultDetail_AIAuditResultDetail aIAuditResultDetail;

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

		public GetAuditResultDetail_AIAuditResultDetail AIAuditResultDetail
		{
			get
			{
				return aIAuditResultDetail;
			}
			set	
			{
				aIAuditResultDetail = value;
			}
		}

		public class GetAuditResultDetail_AIAuditResultDetail
		{

			private int? total;

			private List<GetAuditResultDetail_ListItem> list;

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

			public List<GetAuditResultDetail_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class GetAuditResultDetail_ListItem
			{

				private string pornLabel;

				private string pornScore;

				private string terrorismLabel;

				private string terrorismScore;

				private string index;

				private string _object;

				private string timestamp;

				public string PornLabel
				{
					get
					{
						return pornLabel;
					}
					set	
					{
						pornLabel = value;
					}
				}

				public string PornScore
				{
					get
					{
						return pornScore;
					}
					set	
					{
						pornScore = value;
					}
				}

				public string TerrorismLabel
				{
					get
					{
						return terrorismLabel;
					}
					set	
					{
						terrorismLabel = value;
					}
				}

				public string TerrorismScore
				{
					get
					{
						return terrorismScore;
					}
					set	
					{
						terrorismScore = value;
					}
				}

				public string Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string _Object
				{
					get
					{
						return _object;
					}
					set	
					{
						_object = value;
					}
				}

				public string Timestamp
				{
					get
					{
						return timestamp;
					}
					set	
					{
						timestamp = value;
					}
				}
			}
		}
	}
}
