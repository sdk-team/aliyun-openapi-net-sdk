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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20160314;

namespace Aliyun.Acs.Ecs.Model.V20160314
{
    public class DescribeResourceAllocationRequest : RpcAcsRequest<DescribeResourceAllocationResponse>
    {
        public DescribeResourceAllocationRequest()
            : base("Ecs", "2016-03-14", "DescribeResourceAllocation", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string networkType;

		private int? postPaidBaseCapacity;

		private string systemDiskCategory;

		private string defaultTargetCapacityType;

		private float? maxPrice;

		private int? spotBaseCapacity;

		private long? ownerId;

		private string spotStrategy;

		private List<string> zoneIds = new List<string>(){ };

		private List<InstanceTypeModel> instanceTypeModels = new List<InstanceTypeModel>(){ };

		private bool? strictSatisfiedTargetCapacity;

		private string ioOptimized;

		private string resourceAmountType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? spotInstancePools;

		private List<string> instanceTypeFamilys = new List<string>(){ };

		private string priorityStrategy;

		private int? targetCapacity;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
			}
		}

		public int? PostPaidBaseCapacity
		{
			get
			{
				return postPaidBaseCapacity;
			}
			set	
			{
				postPaidBaseCapacity = value;
				DictionaryUtil.Add(QueryParameters, "PostPaidBaseCapacity", value.ToString());
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskCategory", value);
			}
		}

		public string DefaultTargetCapacityType
		{
			get
			{
				return defaultTargetCapacityType;
			}
			set	
			{
				defaultTargetCapacityType = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTargetCapacityType", value);
			}
		}

		public float? MaxPrice
		{
			get
			{
				return maxPrice;
			}
			set	
			{
				maxPrice = value;
				DictionaryUtil.Add(QueryParameters, "MaxPrice", value.ToString());
			}
		}

		public int? SpotBaseCapacity
		{
			get
			{
				return spotBaseCapacity;
			}
			set	
			{
				spotBaseCapacity = value;
				DictionaryUtil.Add(QueryParameters, "SpotBaseCapacity", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public List<string> ZoneIds
		{
			get
			{
				return zoneIds;
			}

			set
			{
				zoneIds = value;
				for (int i = 0; i < zoneIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ZoneId." + (i + 1) , zoneIds[i]);
				}
			}
		}

		public List<InstanceTypeModel> InstanceTypeModels
		{
			get
			{
				return instanceTypeModels;
			}

			set
			{
				instanceTypeModels = value;
				for (int i = 0; i < instanceTypeModels.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceTypeModel." + (i + 1) + ".SpotStrategy", instanceTypeModels[i].SpotStrategy);
					DictionaryUtil.Add(QueryParameters,"InstanceTypeModel." + (i + 1) + ".MaxPrice", instanceTypeModels[i].MaxPrice);
					DictionaryUtil.Add(QueryParameters,"InstanceTypeModel." + (i + 1) + ".InstanceType", instanceTypeModels[i].InstanceType);
				}
			}
		}

		public bool? StrictSatisfiedTargetCapacity
		{
			get
			{
				return strictSatisfiedTargetCapacity;
			}
			set	
			{
				strictSatisfiedTargetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "StrictSatisfiedTargetCapacity", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
			}
		}

		public string ResourceAmountType
		{
			get
			{
				return resourceAmountType;
			}
			set	
			{
				resourceAmountType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceAmountType", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? SpotInstancePools
		{
			get
			{
				return spotInstancePools;
			}
			set	
			{
				spotInstancePools = value;
				DictionaryUtil.Add(QueryParameters, "SpotInstancePools", value.ToString());
			}
		}

		public List<string> InstanceTypeFamilys
		{
			get
			{
				return instanceTypeFamilys;
			}

			set
			{
				instanceTypeFamilys = value;
				for (int i = 0; i < instanceTypeFamilys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceTypeFamily." + (i + 1) , instanceTypeFamilys[i]);
				}
			}
		}

		public string PriorityStrategy
		{
			get
			{
				return priorityStrategy;
			}
			set	
			{
				priorityStrategy = value;
				DictionaryUtil.Add(QueryParameters, "PriorityStrategy", value);
			}
		}

		public int? TargetCapacity
		{
			get
			{
				return targetCapacity;
			}
			set	
			{
				targetCapacity = value;
				DictionaryUtil.Add(QueryParameters, "TargetCapacity", value.ToString());
			}
		}

		public class InstanceTypeModel
		{

			private string spotStrategy;

			private float? maxPrice;

			private string instanceType;

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

			public float? MaxPrice
			{
				get
				{
					return maxPrice;
				}
				set	
				{
					maxPrice = value;
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
		}

        public override DescribeResourceAllocationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeResourceAllocationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
