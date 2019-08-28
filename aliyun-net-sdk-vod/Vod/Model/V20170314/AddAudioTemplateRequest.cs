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
    public class AddAudioTemplateRequest : RpcAcsRequest<AddAudioTemplateResponse>
    {
        public AddAudioTemplateRequest()
            : base("vod", "2017-03-14", "AddAudioTemplate", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string channel;

		private string bitrate;

		private string muxer;

		private long? ownerId;

		private string type;

		private string _remove;

		private string codec;

		private string name;

		private string isDefault;

		private string status;

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

		public string Bitrate
		{
			get
			{
				return bitrate;
			}
			set	
			{
				bitrate = value;
				DictionaryUtil.Add(QueryParameters, "Bitrate", value);
			}
		}

		public string Muxer
		{
			get
			{
				return muxer;
			}
			set	
			{
				muxer = value;
				DictionaryUtil.Add(QueryParameters, "Muxer", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string _Remove
		{
			get
			{
				return _remove;
			}
			set	
			{
				_remove = value;
				DictionaryUtil.Add(QueryParameters, "Remove", value);
			}
		}

		public string Codec
		{
			get
			{
				return codec;
			}
			set	
			{
				codec = value;
				DictionaryUtil.Add(QueryParameters, "Codec", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string IsDefault
		{
			get
			{
				return isDefault;
			}
			set	
			{
				isDefault = value;
				DictionaryUtil.Add(QueryParameters, "IsDefault", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override AddAudioTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddAudioTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
