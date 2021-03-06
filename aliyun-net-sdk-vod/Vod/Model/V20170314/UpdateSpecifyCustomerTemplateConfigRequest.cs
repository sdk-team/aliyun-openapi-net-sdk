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
    public class UpdateSpecifyCustomerTemplateConfigRequest : RpcAcsRequest<UpdateSpecifyCustomerTemplateConfigResponse>
    {
        public UpdateSpecifyCustomerTemplateConfigRequest()
            : base("vod", "2017-03-14", "UpdateSpecifyCustomerTemplateConfig", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string encryptTemplateIds;

		private string resourceOwnerAccount;

		private string customerId;

		private long? ownerId;

		private string transcodeIds;

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

		public string EncryptTemplateIds
		{
			get
			{
				return encryptTemplateIds;
			}
			set	
			{
				encryptTemplateIds = value;
				DictionaryUtil.Add(QueryParameters, "EncryptTemplateIds", value);
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

		public string CustomerId
		{
			get
			{
				return customerId;
			}
			set	
			{
				customerId = value;
				DictionaryUtil.Add(QueryParameters, "CustomerId", value);
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

		public string TranscodeIds
		{
			get
			{
				return transcodeIds;
			}
			set	
			{
				transcodeIds = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeIds", value);
			}
		}

        public override UpdateSpecifyCustomerTemplateConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSpecifyCustomerTemplateConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
