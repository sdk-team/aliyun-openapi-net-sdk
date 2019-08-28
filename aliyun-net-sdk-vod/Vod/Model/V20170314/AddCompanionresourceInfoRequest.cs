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
    public class AddCompanionresourceInfoRequest : RpcAcsRequest<AddCompanionresourceInfoResponse>
    {
        public AddCompanionresourceInfoRequest()
            : base("vod", "2017-03-14", "AddCompanionresourceInfo", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string resourceTags;

		private string companionResourceType;

		private string resourceOwnerAccount;

		private string companionResourceConfig;

		private string resourceName;

		private long? ownerId;

		private string mediaFileId;

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

		public string ResourceTags
		{
			get
			{
				return resourceTags;
			}
			set	
			{
				resourceTags = value;
				DictionaryUtil.Add(QueryParameters, "ResourceTags", value);
			}
		}

		public string CompanionResourceType
		{
			get
			{
				return companionResourceType;
			}
			set	
			{
				companionResourceType = value;
				DictionaryUtil.Add(QueryParameters, "CompanionResourceType", value);
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

		public string CompanionResourceConfig
		{
			get
			{
				return companionResourceConfig;
			}
			set	
			{
				companionResourceConfig = value;
				DictionaryUtil.Add(QueryParameters, "CompanionResourceConfig", value);
			}
		}

		public string ResourceName
		{
			get
			{
				return resourceName;
			}
			set	
			{
				resourceName = value;
				DictionaryUtil.Add(QueryParameters, "ResourceName", value);
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

		public string MediaFileId
		{
			get
			{
				return mediaFileId;
			}
			set	
			{
				mediaFileId = value;
				DictionaryUtil.Add(QueryParameters, "MediaFileId", value);
			}
		}

        public override AddCompanionresourceInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCompanionresourceInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
