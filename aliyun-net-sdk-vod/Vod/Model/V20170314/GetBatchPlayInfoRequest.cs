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
    public class GetBatchPlayInfoRequest : RpcAcsRequest<GetBatchPlayInfoResponse>
    {
        public GetBatchPlayInfoRequest()
            : base("vod", "2017-03-14", "GetBatchPlayInfo", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string streamType;

		private string formats;

		private string resourceOwnerAccount;

		private string channel;

		private string playerVersion;

		private long? resourceRealOwnerId;

		private long? ownerId;

		private string rand;

		private string reAuthInfo;

		private string outputType;

		private string videoIds;

		private long? authTimeout;

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

		public string StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(QueryParameters, "StreamType", value);
			}
		}

		public string Formats
		{
			get
			{
				return formats;
			}
			set	
			{
				formats = value;
				DictionaryUtil.Add(QueryParameters, "Formats", value);
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

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string PlayerVersion
		{
			get
			{
				return playerVersion;
			}
			set	
			{
				playerVersion = value;
				DictionaryUtil.Add(QueryParameters, "PlayerVersion", value);
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

		public string Rand
		{
			get
			{
				return rand;
			}
			set	
			{
				rand = value;
				DictionaryUtil.Add(QueryParameters, "Rand", value);
			}
		}

		public string ReAuthInfo
		{
			get
			{
				return reAuthInfo;
			}
			set	
			{
				reAuthInfo = value;
				DictionaryUtil.Add(QueryParameters, "ReAuthInfo", value);
			}
		}

		public string OutputType
		{
			get
			{
				return outputType;
			}
			set	
			{
				outputType = value;
				DictionaryUtil.Add(QueryParameters, "OutputType", value);
			}
		}

		public string VideoIds
		{
			get
			{
				return videoIds;
			}
			set	
			{
				videoIds = value;
				DictionaryUtil.Add(QueryParameters, "VideoIds", value);
			}
		}

		public long? AuthTimeout
		{
			get
			{
				return authTimeout;
			}
			set	
			{
				authTimeout = value;
				DictionaryUtil.Add(QueryParameters, "AuthTimeout", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetBatchPlayInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetBatchPlayInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
