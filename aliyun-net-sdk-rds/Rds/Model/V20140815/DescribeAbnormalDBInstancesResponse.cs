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
	public class DescribeAbnormalDBInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeAbnormalDBInstances_InstanceResult> items;

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

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public List<DescribeAbnormalDBInstances_InstanceResult> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAbnormalDBInstances_InstanceResult
		{

			private string dBInstanceDescription;

			private string dBInstanceId;

			private List<DescribeAbnormalDBInstances_AbnormalItem> abnormalItems;

			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public List<DescribeAbnormalDBInstances_AbnormalItem> AbnormalItems
			{
				get
				{
					return abnormalItems;
				}
				set	
				{
					abnormalItems = value;
				}
			}

			public class DescribeAbnormalDBInstances_AbnormalItem
			{

				private string checkTime;

				private string checkItem;

				private string abnormalReason;

				private string abnormalValue;

				private string abnormalDetail;

				private string adviceKey;

				private List<string> adviseValue;

				public string CheckTime
				{
					get
					{
						return checkTime;
					}
					set	
					{
						checkTime = value;
					}
				}

				public string CheckItem
				{
					get
					{
						return checkItem;
					}
					set	
					{
						checkItem = value;
					}
				}

				public string AbnormalReason
				{
					get
					{
						return abnormalReason;
					}
					set	
					{
						abnormalReason = value;
					}
				}

				public string AbnormalValue
				{
					get
					{
						return abnormalValue;
					}
					set	
					{
						abnormalValue = value;
					}
				}

				public string AbnormalDetail
				{
					get
					{
						return abnormalDetail;
					}
					set	
					{
						abnormalDetail = value;
					}
				}

				public string AdviceKey
				{
					get
					{
						return adviceKey;
					}
					set	
					{
						adviceKey = value;
					}
				}

				public List<string> AdviseValue
				{
					get
					{
						return adviseValue;
					}
					set	
					{
						adviseValue = value;
					}
				}
			}
		}
	}
}
