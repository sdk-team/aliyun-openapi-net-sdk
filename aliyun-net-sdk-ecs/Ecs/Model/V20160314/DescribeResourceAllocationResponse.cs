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
	public class DescribeResourceAllocationResponse : AcsResponse
	{

		private string requestId;

		private DescribeResourceAllocation_ResourcePlanningResponse resourcePlanningResponse;

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

		public DescribeResourceAllocation_ResourcePlanningResponse ResourcePlanningResponse
		{
			get
			{
				return resourcePlanningResponse;
			}
			set	
			{
				resourcePlanningResponse = value;
			}
		}

		public class DescribeResourceAllocation_ResourcePlanningResponse
		{

			private int? satisfiedAmount;

			private List<DescribeResourceAllocation_ResourceModel> resourceModels;

			public int? SatisfiedAmount
			{
				get
				{
					return satisfiedAmount;
				}
				set	
				{
					satisfiedAmount = value;
				}
			}

			public List<DescribeResourceAllocation_ResourceModel> ResourceModels
			{
				get
				{
					return resourceModels;
				}
				set	
				{
					resourceModels = value;
				}
			}

			public class DescribeResourceAllocation_ResourceModel
			{

				private string regionId;

				private string zoneId;

				private string instanceType;

				private string networkType;

				private string ioOptimized;

				private string instanceChargeType;

				private string spotStrategy;

				private float? price;

				private int? amount;

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string NetworkType
				{
					get
					{
						return networkType;
					}
					set	
					{
						networkType = value;
					}
				}

				public string IoOptimized
				{
					get
					{
						return ioOptimized;
					}
					set	
					{
						ioOptimized = value;
					}
				}

				public string InstanceChargeType
				{
					get
					{
						return instanceChargeType;
					}
					set	
					{
						instanceChargeType = value;
					}
				}

				public string SpotStrategy
				{
					get
					{
						return spotStrategy;
					}
					set	
					{
						spotStrategy = value;
					}
				}

				public float? Price
				{
					get
					{
						return price;
					}
					set	
					{
						price = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}
			}
		}
	}
}
