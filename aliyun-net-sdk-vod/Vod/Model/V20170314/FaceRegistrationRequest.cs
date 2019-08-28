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
    public class FaceRegistrationRequest : RpcAcsRequest<FaceRegistrationResponse>
    {
        public FaceRegistrationRequest()
            : base("vod", "2017-03-14", "FaceRegistration", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string resourceOwnerId;

		private string personLibrary;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string personId;

		private string ownerId;

		private string category;

		private string imageIds;

		private string personName;

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

		public string PersonLibrary
		{
			get
			{
				return personLibrary;
			}
			set	
			{
				personLibrary = value;
				DictionaryUtil.Add(QueryParameters, "PersonLibrary", value);
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

		public string PersonId
		{
			get
			{
				return personId;
			}
			set	
			{
				personId = value;
				DictionaryUtil.Add(QueryParameters, "PersonId", value);
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

		public string Category
		{
			get
			{
				return category;
			}
			set	
			{
				category = value;
				DictionaryUtil.Add(QueryParameters, "Category", value);
			}
		}

		public string ImageIds
		{
			get
			{
				return imageIds;
			}
			set	
			{
				imageIds = value;
				DictionaryUtil.Add(QueryParameters, "ImageIds", value);
			}
		}

		public string PersonName
		{
			get
			{
				return personName;
			}
			set	
			{
				personName = value;
				DictionaryUtil.Add(QueryParameters, "PersonName", value);
			}
		}

        public override FaceRegistrationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FaceRegistrationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
