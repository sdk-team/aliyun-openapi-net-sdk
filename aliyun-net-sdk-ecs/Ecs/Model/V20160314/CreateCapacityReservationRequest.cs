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
    public class CreateCapacityReservationRequest : RpcAcsRequest<CreateCapacityReservationResponse>
    {
        public CreateCapacityReservationRequest()
            : base("Ecs", "2016-03-14", "CreateCapacityReservation", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string description;

		private string networkType;

		private string resourceGroupId;

		private string instanceCount;

		private string instanceType;

		private List<Tag> tags = new List<Tag>(){ };

		private string instancePlatform;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string endDateType;

		private string instanceMatchCriteria;

		private string timeSlot;

		private string capacityReservationName;

		private string zoneId;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string InstanceCount
		{
			get
			{
				return instanceCount;
			}
			set	
			{
				instanceCount = value;
				DictionaryUtil.Add(QueryParameters, "InstanceCount", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
				}
			}
		}

		public string InstancePlatform
		{
			get
			{
				return instancePlatform;
			}
			set	
			{
				instancePlatform = value;
				DictionaryUtil.Add(QueryParameters, "InstancePlatform", value);
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

		public string EndDateType
		{
			get
			{
				return endDateType;
			}
			set	
			{
				endDateType = value;
				DictionaryUtil.Add(QueryParameters, "EndDateType", value);
			}
		}

		public string InstanceMatchCriteria
		{
			get
			{
				return instanceMatchCriteria;
			}
			set	
			{
				instanceMatchCriteria = value;
				DictionaryUtil.Add(QueryParameters, "InstanceMatchCriteria", value);
			}
		}

		public string TimeSlot
		{
			get
			{
				return timeSlot;
			}
			set	
			{
				timeSlot = value;
				DictionaryUtil.Add(QueryParameters, "TimeSlot", value);
			}
		}

		public string CapacityReservationName
		{
			get
			{
				return capacityReservationName;
			}
			set	
			{
				capacityReservationName = value;
				DictionaryUtil.Add(QueryParameters, "CapacityReservationName", value);
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
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}

        public override CreateCapacityReservationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCapacityReservationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
