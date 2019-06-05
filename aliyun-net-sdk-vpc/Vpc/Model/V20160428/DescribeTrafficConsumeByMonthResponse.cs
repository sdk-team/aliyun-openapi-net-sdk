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
	public class DescribeTrafficConsumeByMonthResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary> productTrafficConsumeSummaryList;

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

		public List<DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary> ProductTrafficConsumeSummaryList
		{
			get
			{
				return productTrafficConsumeSummaryList;
			}
			set	
			{
				productTrafficConsumeSummaryList = value;
			}
		}

		public class DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary
		{

			private string productName;

			private List<DescribeTrafficConsumeByMonth_RegionConsumeSummary> regionConsumeSummaryList;

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public List<DescribeTrafficConsumeByMonth_RegionConsumeSummary> RegionConsumeSummaryList
			{
				get
				{
					return regionConsumeSummaryList;
				}
				set	
				{
					regionConsumeSummaryList = value;
				}
			}

			public class DescribeTrafficConsumeByMonth_RegionConsumeSummary
			{

				private string region;

				private string monthTrafficSummary;

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string MonthTrafficSummary
				{
					get
					{
						return monthTrafficSummary;
					}
					set	
					{
						monthTrafficSummary = value;
					}
				}
			}
		}
	}
}
