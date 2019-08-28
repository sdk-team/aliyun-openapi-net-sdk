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
    public class AddWatermarkRequest : RpcAcsRequest<AddWatermarkResponse>
    {
        public AddWatermarkRequest()
            : base("vod", "2017-03-14", "AddWatermark", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string verticalOffset;

		private int? screenWidth;

		private long? resourceOwnerId;

		private string horizontalOffset;

		private string resourceOwnerAccount;

		private string screenMode;

		private string horizontalOffet;

		private string active;

		private int? videoHeight;

		private long? resourceRealOwnerId;

		private long? ownerId;

		private string type;

		private string watermarkConfig;

		private string bucket;

		private int? videoWidth;

		private string name;

		private string width;

		private string fileUrl;

		private string position;

		private int? screenHeight;

		private string _object;

		private string height;

		public string VerticalOffset
		{
			get
			{
				return verticalOffset;
			}
			set	
			{
				verticalOffset = value;
				DictionaryUtil.Add(QueryParameters, "VerticalOffset", value);
			}
		}

		public int? ScreenWidth
		{
			get
			{
				return screenWidth;
			}
			set	
			{
				screenWidth = value;
				DictionaryUtil.Add(QueryParameters, "ScreenWidth", value.ToString());
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

		public string HorizontalOffset
		{
			get
			{
				return horizontalOffset;
			}
			set	
			{
				horizontalOffset = value;
				DictionaryUtil.Add(QueryParameters, "HorizontalOffset", value);
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

		public string ScreenMode
		{
			get
			{
				return screenMode;
			}
			set	
			{
				screenMode = value;
				DictionaryUtil.Add(QueryParameters, "ScreenMode", value);
			}
		}

		public string HorizontalOffet
		{
			get
			{
				return horizontalOffet;
			}
			set	
			{
				horizontalOffet = value;
				DictionaryUtil.Add(QueryParameters, "HorizontalOffet", value);
			}
		}

		public string Active
		{
			get
			{
				return active;
			}
			set	
			{
				active = value;
				DictionaryUtil.Add(QueryParameters, "Active", value);
			}
		}

		public int? VideoHeight
		{
			get
			{
				return videoHeight;
			}
			set	
			{
				videoHeight = value;
				DictionaryUtil.Add(QueryParameters, "VideoHeight", value.ToString());
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

		public string WatermarkConfig
		{
			get
			{
				return watermarkConfig;
			}
			set	
			{
				watermarkConfig = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkConfig", value);
			}
		}

		public string Bucket
		{
			get
			{
				return bucket;
			}
			set	
			{
				bucket = value;
				DictionaryUtil.Add(QueryParameters, "Bucket", value);
			}
		}

		public int? VideoWidth
		{
			get
			{
				return videoWidth;
			}
			set	
			{
				videoWidth = value;
				DictionaryUtil.Add(QueryParameters, "VideoWidth", value.ToString());
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

		public string Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value);
			}
		}

		public string FileUrl
		{
			get
			{
				return fileUrl;
			}
			set	
			{
				fileUrl = value;
				DictionaryUtil.Add(QueryParameters, "FileUrl", value);
			}
		}

		public string Position
		{
			get
			{
				return position;
			}
			set	
			{
				position = value;
				DictionaryUtil.Add(QueryParameters, "Position", value);
			}
		}

		public int? ScreenHeight
		{
			get
			{
				return screenHeight;
			}
			set	
			{
				screenHeight = value;
				DictionaryUtil.Add(QueryParameters, "ScreenHeight", value.ToString());
			}
		}

		public string _Object
		{
			get
			{
				return _object;
			}
			set	
			{
				_object = value;
				DictionaryUtil.Add(QueryParameters, "Object", value);
			}
		}

		public string Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value);
			}
		}

        public override AddWatermarkResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddWatermarkResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
