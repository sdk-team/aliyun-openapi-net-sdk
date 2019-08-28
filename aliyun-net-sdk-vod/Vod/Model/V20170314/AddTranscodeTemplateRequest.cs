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
    public class AddTranscodeTemplateRequest : RpcAcsRequest<AddTranscodeTemplateResponse>
    {
        public AddTranscodeTemplateRequest()
            : base("vod", "2017-03-14", "AddTranscodeTemplate", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string muxer;

		private long? ownerId;

		private string resolution;

		private string audioCodec;

		private string audioBitrate;

		private string name;

		private string detail;

		private string videoBitrate;

		private string videoCodec;

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

		public string Resolution
		{
			get
			{
				return resolution;
			}
			set	
			{
				resolution = value;
				DictionaryUtil.Add(QueryParameters, "Resolution", value);
			}
		}

		public string AudioCodec
		{
			get
			{
				return audioCodec;
			}
			set	
			{
				audioCodec = value;
				DictionaryUtil.Add(QueryParameters, "AudioCodec", value);
			}
		}

		public string AudioBitrate
		{
			get
			{
				return audioBitrate;
			}
			set	
			{
				audioBitrate = value;
				DictionaryUtil.Add(QueryParameters, "AudioBitrate", value);
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

		public string Detail
		{
			get
			{
				return detail;
			}
			set	
			{
				detail = value;
				DictionaryUtil.Add(QueryParameters, "Detail", value);
			}
		}

		public string VideoBitrate
		{
			get
			{
				return videoBitrate;
			}
			set	
			{
				videoBitrate = value;
				DictionaryUtil.Add(QueryParameters, "VideoBitrate", value);
			}
		}

		public string VideoCodec
		{
			get
			{
				return videoCodec;
			}
			set	
			{
				videoCodec = value;
				DictionaryUtil.Add(QueryParameters, "VideoCodec", value);
			}
		}

        public override AddTranscodeTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddTranscodeTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
