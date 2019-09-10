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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class DataCleanSyncProductRequest : RpcAcsRequest<DataCleanSyncProductResponse>
    {
        public DataCleanSyncProductRequest()
            : base("Iot", "2019-07-30", "DataCleanSyncProduct", "Iot", "openAPI")
        {
        }

		private int? deviceCount;

		private string taobaoId;

		private string resourceGroupId;

		private string iotInstanceId;

		private long? categoryId;

		private string productModel;

		private string image;

		private int? dataFormat;

		private string actionStr;

		private string productKey;

		private int? netType;

		private string name;

		public int? DeviceCount
		{
			get
			{
				return deviceCount;
			}
			set	
			{
				deviceCount = value;
				DictionaryUtil.Add(QueryParameters, "DeviceCount", value.ToString());
			}
		}

		public string TaobaoId
		{
			get
			{
				return taobaoId;
			}
			set	
			{
				taobaoId = value;
				DictionaryUtil.Add(QueryParameters, "TaobaoId", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public long? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(QueryParameters, "CategoryId", value.ToString());
			}
		}

		public string ProductModel
		{
			get
			{
				return productModel;
			}
			set	
			{
				productModel = value;
				DictionaryUtil.Add(QueryParameters, "ProductModel", value);
			}
		}

		public string Image
		{
			get
			{
				return image;
			}
			set	
			{
				image = value;
				DictionaryUtil.Add(QueryParameters, "Image", value);
			}
		}

		public int? DataFormat
		{
			get
			{
				return dataFormat;
			}
			set	
			{
				dataFormat = value;
				DictionaryUtil.Add(QueryParameters, "DataFormat", value.ToString());
			}
		}

		public string ActionStr
		{
			get
			{
				return actionStr;
			}
			set	
			{
				actionStr = value;
				DictionaryUtil.Add(QueryParameters, "ActionStr", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public int? NetType
		{
			get
			{
				return netType;
			}
			set	
			{
				netType = value;
				DictionaryUtil.Add(QueryParameters, "NetType", value.ToString());
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

        public override DataCleanSyncProductResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DataCleanSyncProductResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
