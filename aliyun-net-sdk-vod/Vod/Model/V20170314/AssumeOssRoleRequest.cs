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
    public class AssumeOssRoleRequest : RpcAcsRequest<AssumeOssRoleResponse>
    {
        public AssumeOssRoleRequest()
            : base("vod", "2017-03-14", "AssumeOssRole", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string clientId;

		private string resourceOwnerAccount;

		private string prefix;

		private string appVersion;

		private string source;

		private long? ownerId;

		private string businessType;

		private long? authTimestamp;

		private string terminalType;

		private string authInfo;

		private string deviceModel;

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

		public string ClientId
		{
			get
			{
				return clientId;
			}
			set	
			{
				clientId = value;
				DictionaryUtil.Add(QueryParameters, "ClientId", value);
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

		public string Prefix
		{
			get
			{
				return prefix;
			}
			set	
			{
				prefix = value;
				DictionaryUtil.Add(QueryParameters, "Prefix", value);
			}
		}

		public string AppVersion
		{
			get
			{
				return appVersion;
			}
			set	
			{
				appVersion = value;
				DictionaryUtil.Add(QueryParameters, "AppVersion", value);
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

		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value);
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

		public string TerminalType
		{
			get
			{
				return terminalType;
			}
			set	
			{
				terminalType = value;
				DictionaryUtil.Add(QueryParameters, "TerminalType", value);
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

		public string DeviceModel
		{
			get
			{
				return deviceModel;
			}
			set	
			{
				deviceModel = value;
				DictionaryUtil.Add(QueryParameters, "DeviceModel", value);
			}
		}

        public override AssumeOssRoleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AssumeOssRoleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
