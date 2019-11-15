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
	public class DescribeRecommendProductResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRecommendProduct_RecommendProduct> recommendProducts;

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

		public List<DescribeRecommendProduct_RecommendProduct> RecommendProducts
		{
			get
			{
				return recommendProducts;
			}
			set	
			{
				recommendProducts = value;
			}
		}

		public class DescribeRecommendProduct_RecommendProduct
		{

			private string zoneNo;

			private List<DescribeRecommendProduct_RecommendInstanceType> recommendInstanceTypes;

			public string ZoneNo
			{
				get
				{
					return zoneNo;
				}
				set	
				{
					zoneNo = value;
				}
			}

			public List<DescribeRecommendProduct_RecommendInstanceType> RecommendInstanceTypes
			{
				get
				{
					return recommendInstanceTypes;
				}
				set	
				{
					recommendInstanceTypes = value;
				}
			}

			public class DescribeRecommendProduct_RecommendInstanceType
			{

				private string instanceChargeType;

				private string spotStrategy;

				private int? priority;

				private string networkType;

				private DescribeRecommendProduct_InstanceType instanceType;

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

				public int? Priority
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

				public DescribeRecommendProduct_InstanceType InstanceType
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

				public class DescribeRecommendProduct_InstanceType
				{

					private string generation;

					private string instanceTypeFamily;

					private string instanceType;

					private string supportIoOptimized;

					private int? cores;

					private int? memory;

					private string instanceFamilyLevel;

					public string Generation
					{
						get
						{
							return generation;
						}
						set	
						{
							generation = value;
						}
					}

					public string InstanceTypeFamily
					{
						get
						{
							return instanceTypeFamily;
						}
						set	
						{
							instanceTypeFamily = value;
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

					public string SupportIoOptimized
					{
						get
						{
							return supportIoOptimized;
						}
						set	
						{
							supportIoOptimized = value;
						}
					}

					public int? Cores
					{
						get
						{
							return cores;
						}
						set	
						{
							cores = value;
						}
					}

					public int? Memory
					{
						get
						{
							return memory;
						}
						set	
						{
							memory = value;
						}
					}

					public string InstanceFamilyLevel
					{
						get
						{
							return instanceFamilyLevel;
						}
						set	
						{
							instanceFamilyLevel = value;
						}
					}
				}
			}
		}
	}
}
