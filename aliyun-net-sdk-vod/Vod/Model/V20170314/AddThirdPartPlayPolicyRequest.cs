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
    public class AddThirdPartPlayPolicyRequest : RpcAcsRequest<AddThirdPartPlayPolicyResponse>
    {
        public AddThirdPartPlayPolicyRequest()
            : base("vod", "2017-03-14", "AddThirdPartPlayPolicy", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string policyInfoList;

		private string resourceOwnerAccount;

		private long? authTimestamp;

		private long? resourceRealOwnerId;

		private string source;

		private long? ownerId;

		private string authInfo;

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

		public string PolicyInfoList
		{
			get
			{
				return policyInfoList;
			}
			set	
			{
				policyInfoList = value;
				DictionaryUtil.Add(QueryParameters, "PolicyInfoList", value);
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

		public long? AuthTimestamp
		{
			get
			{
				return authTimestamp;
			}
			set	
			{
				authTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "AuthTimestamp", value.ToString());
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

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(QueryParameters, "Source", value);
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

		public string AuthInfo
		{
			get
			{
				return authInfo;
			}
			set	
			{
				authInfo = value;
				DictionaryUtil.Add(QueryParameters, "AuthInfo", value);
			}
		}

        public override AddThirdPartPlayPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddThirdPartPlayPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
