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
    public class AddCustomTemplateRequest : RpcAcsRequest<AddCustomTemplateResponse>
    {
        public AddCustomTemplateRequest()
            : base("vod", "2017-03-14", "AddCustomTemplate", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string container;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string groupId;

		private string muxConfig;

		private string video;

		private long? ownerId;

		private string useWaterMark;

		private string condition;

		private string encrypt;

		private string transConfig;

		private string definition;

		private string audio;

		private string narrowBand;

		public string Container
		{
			get
			{
				return container;
			}
			set	
			{
				container = value;
				DictionaryUtil.Add(QueryParameters, "Container", value);
			}
		}

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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string MuxConfig
		{
			get
			{
				return muxConfig;
			}
			set	
			{
				muxConfig = value;
				DictionaryUtil.Add(QueryParameters, "MuxConfig", value);
			}
		}

		public string Video
		{
			get
			{
				return video;
			}
			set	
			{
				video = value;
				DictionaryUtil.Add(QueryParameters, "Video", value);
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

		public string UseWaterMark
		{
			get
			{
				return useWaterMark;
			}
			set	
			{
				useWaterMark = value;
				DictionaryUtil.Add(QueryParameters, "UseWaterMark", value);
			}
		}

		public string Condition
		{
			get
			{
				return condition;
			}
			set	
			{
				condition = value;
				DictionaryUtil.Add(QueryParameters, "Condition", value);
			}
		}

		public string Encrypt
		{
			get
			{
				return encrypt;
			}
			set	
			{
				encrypt = value;
				DictionaryUtil.Add(QueryParameters, "Encrypt", value);
			}
		}

		public string TransConfig
		{
			get
			{
				return transConfig;
			}
			set	
			{
				transConfig = value;
				DictionaryUtil.Add(QueryParameters, "TransConfig", value);
			}
		}

		public string Definition
		{
			get
			{
				return definition;
			}
			set	
			{
				definition = value;
				DictionaryUtil.Add(QueryParameters, "Definition", value);
			}
		}

		public string Audio
		{
			get
			{
				return audio;
			}
			set	
			{
				audio = value;
				DictionaryUtil.Add(QueryParameters, "Audio", value);
			}
		}

		public string NarrowBand
		{
			get
			{
				return narrowBand;
			}
			set	
			{
				narrowBand = value;
				DictionaryUtil.Add(QueryParameters, "NarrowBand", value);
			}
		}

        public override AddCustomTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCustomTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
