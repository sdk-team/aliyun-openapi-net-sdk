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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170314;

namespace Aliyun.Acs.vod.Model.V20170314
{
    public class AddStorageRequest : RpcAcsRequest<AddStorageResponse>
    {
        public AddStorageRequest()
            : base("vod", "2017-03-14", "AddStorage", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string resourceOwnerId;

		private string storageRegion;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? resourceRealOwnerId;

		private string ownerId;

		private string storageType;

		private string storageLocation;

		public string ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value);
			}
		}

		public string StorageRegion
		{
			get
			{
				return storageRegion;
			}
			set	
			{
				storageRegion = value;
				DictionaryUtil.Add(QueryParameters, "StorageRegion", value);
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

		public long? ResourceRealOwnerId
		{
			get
			{
				return resourceRealOwnerId;
			}
			set	
			{
				resourceRealOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceRealOwnerId", value.ToString());
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string StorageLocation
		{
			get
			{
				return storageLocation;
			}
			set	
			{
				storageLocation = value;
				DictionaryUtil.Add(QueryParameters, "StorageLocation", value);
			}
		}

        public override AddStorageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddStorageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
