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
	public class DescribeDedicatedHostTypesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDedicatedHostTypes_DedicatedHostType> dedicatedHostTypes;

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

		public List<DescribeDedicatedHostTypes_DedicatedHostType> DedicatedHostTypes
		{
			get
			{
				return dedicatedHostTypes;
			}
			set	
			{
				dedicatedHostTypes = value;
			}
		}

		public class DescribeDedicatedHostTypes_DedicatedHostType
		{

			private string dedicatedHostType;

			private string generation;

			private int? totalSockets;

			private int? totalVcpus;

			private int? totalPhysicalCores;

			private float? memorySize;

			private long? localStorageCapacity;

			private int? localStorageAmount;

			private string localStorageCategory;

			private List<string> supportInstanceTypeFamilies;

			public string DedicatedHostType
			{
				get
				{
					return dedicatedHostType;
				}
				set	
				{
					dedicatedHostType = value;
				}
			}

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

			public int? TotalSockets
			{
				get
				{
					return totalSockets;
				}
				set	
				{
					totalSockets = value;
				}
			}

			public int? TotalVcpus
			{
				get
				{
					return totalVcpus;
				}
				set	
				{
					totalVcpus = value;
				}
			}

			public int? TotalPhysicalCores
			{
				get
				{
					return totalPhysicalCores;
				}
				set	
				{
					totalPhysicalCores = value;
				}
			}

			public float? MemorySize
			{
				get
				{
					return memorySize;
				}
				set	
				{
					memorySize = value;
				}
			}

			public long? LocalStorageCapacity
			{
				get
				{
					return localStorageCapacity;
				}
				set	
				{
					localStorageCapacity = value;
				}
			}

			public int? LocalStorageAmount
			{
				get
				{
					return localStorageAmount;
				}
				set	
				{
					localStorageAmount = value;
				}
			}

			public string LocalStorageCategory
			{
				get
				{
					return localStorageCategory;
				}
				set	
				{
					localStorageCategory = value;
				}
			}

			public List<string> SupportInstanceTypeFamilies
			{
				get
				{
					return supportInstanceTypeFamilies;
				}
				set	
				{
					supportInstanceTypeFamilies = value;
				}
			}
		}
	}
}
