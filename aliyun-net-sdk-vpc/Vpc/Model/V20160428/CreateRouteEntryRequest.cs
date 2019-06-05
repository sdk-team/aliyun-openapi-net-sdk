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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class CreateRouteEntryRequest : RpcAcsRequest<CreateRouteEntryResponse>
    {
        public CreateRouteEntryRequest()
            : base("Vpc", "2016-04-28", "CreateRouteEntry")
        {
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string nextHopId;

		private string nextHopType;

		private string routeTableId;

		private string resourceOwnerAccount;

		private string destinationCidrBlock;

		private string ownerAccount;

		private long? ownerId;

		private List<NextHopList> nextHopLists;

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string NextHopId
		{
			get
			{
				return nextHopId;
			}
			set	
			{
				nextHopId = value;
				DictionaryUtil.Add(QueryParameters, "NextHopId", value);
			}
		}

		public string NextHopType
		{
			get
			{
				return nextHopType;
			}
			set	
			{
				nextHopType = value;
				DictionaryUtil.Add(QueryParameters, "NextHopType", value);
			}
		}

		public string RouteTableId
		{
			get
			{
				return routeTableId;
			}
			set	
			{
				routeTableId = value;
				DictionaryUtil.Add(QueryParameters, "RouteTableId", value);
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

		public string DestinationCidrBlock
		{
			get
			{
				return destinationCidrBlock;
			}
			set	
			{
				destinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "DestinationCidrBlock", value);
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

		public List<NextHopList> NextHopLists
		{
			get
			{
				return nextHopLists;
			}

			set
			{
				nextHopLists = value;
				for (int i = 0; i < nextHopLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".Weight", nextHopLists[i].Weight);
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopId", nextHopLists[i].NextHopId);
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopType", nextHopLists[i].NextHopType);
				}
			}
		}

		public class NextHopList
		{

			private int? weight;

			private string nextHopId;

			private string nextHopType;

			public int? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}

			public string NextHopId
			{
				get
				{
					return nextHopId;
				}
				set	
				{
					nextHopId = value;
				}
			}

			public string NextHopType
			{
				get
				{
					return nextHopType;
				}
				set	
				{
					nextHopType = value;
				}
			}
		}

        public override CreateRouteEntryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
