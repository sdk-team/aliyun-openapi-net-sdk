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
    public class UpdateProductUsedWirelessModuleForTmallGenieRequest : RpcAcsRequest<UpdateProductUsedWirelessModuleForTmallGenieResponse>
    {
        public UpdateProductUsedWirelessModuleForTmallGenieRequest()
            : base("Iot", "2019-07-30", "UpdateProductUsedWirelessModuleForTmallGenie", "Iot", "openAPI")
        {
        }

		private bool? isStandardNetwork;

		private string connectMode;

		private bool? isCertificationModule;

		private string modelType;

		private string iotInstanceId;

		private string moduleFunction;

		private string model;

		private string productKey;

		private string brand;

		public bool? IsStandardNetwork
		{
			get
			{
				return isStandardNetwork;
			}
			set	
			{
				isStandardNetwork = value;
				DictionaryUtil.Add(BodyParameters, "IsStandardNetwork", value.ToString());
			}
		}

		public string ConnectMode
		{
			get
			{
				return connectMode;
			}
			set	
			{
				connectMode = value;
				DictionaryUtil.Add(BodyParameters, "ConnectMode", value);
			}
		}

		public bool? IsCertificationModule
		{
			get
			{
				return isCertificationModule;
			}
			set	
			{
				isCertificationModule = value;
				DictionaryUtil.Add(BodyParameters, "IsCertificationModule", value.ToString());
			}
		}

		public string ModelType
		{
			get
			{
				return modelType;
			}
			set	
			{
				modelType = value;
				DictionaryUtil.Add(BodyParameters, "ModelType", value);
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

		public string ModuleFunction
		{
			get
			{
				return moduleFunction;
			}
			set	
			{
				moduleFunction = value;
				DictionaryUtil.Add(BodyParameters, "ModuleFunction", value);
			}
		}

		public string Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
				DictionaryUtil.Add(BodyParameters, "Model", value);
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
				DictionaryUtil.Add(BodyParameters, "ProductKey", value);
			}
		}

		public string Brand
		{
			get
			{
				return brand;
			}
			set	
			{
				brand = value;
				DictionaryUtil.Add(BodyParameters, "Brand", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateProductUsedWirelessModuleForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateProductUsedWirelessModuleForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
