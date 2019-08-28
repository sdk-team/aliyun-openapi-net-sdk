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
    public class GetPlayChannelKeyRequest : RpcAcsRequest<GetPlayChannelKeyResponse>
    {
        public GetPlayChannelKeyRequest()
            : base("vod", "2017-03-14", "GetPlayChannelKey", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string signVersion;

		private string channel;

		private long? resourceRealOwnerId;

		private string ownerId;

		public string SignVersion
		{
			get
			{
				return signVersion;
			}
			set	
			{
				signVersion = value;
				DictionaryUtil.Add(QueryParameters, "SignVersion", value);
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

        public override GetPlayChannelKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPlayChannelKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
