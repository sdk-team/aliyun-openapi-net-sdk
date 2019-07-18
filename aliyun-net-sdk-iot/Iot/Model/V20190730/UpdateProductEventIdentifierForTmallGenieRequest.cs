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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class UpdateProductEventIdentifierForTmallGenieRequest : RpcAcsRequest<UpdateProductEventIdentifierForTmallGenieResponse>
    {
        public UpdateProductEventIdentifierForTmallGenieRequest()
            : base("Iot", "2019-07-30", "UpdateProductEventIdentifierForTmallGenie", "Iot", "openAPI")
        {
        }

		private string identifier;

		private List<OutputData> outputDatas;

		private string iotInstanceId;

		private string description;

		private string eventType;

		private string productKey;

		private Dictionary<object,object> extendConfig;

		private string eventName;

		public string Identifier
		{
			get
			{
				return identifier;
			}
			set	
			{
				identifier = value;
				DictionaryUtil.Add(QueryParameters, "Identifier", value);
			}
		}

		public List<OutputData> OutputDatas
		{
			get
			{
				return outputDatas;
			}

			set
			{
				outputDatas = value;
				for (int i = 0; i < outputDatas.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".Identifier", outputDatas[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".DataSpecs", outputDatas[i].DataSpecs);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".DataType", outputDatas[i].DataType);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".Name", outputDatas[i].Name);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".DataSpecsList", outputDatas[i].DataSpecsList);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".ParaOrder", outputDatas[i].ParaOrder);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".Direction", outputDatas[i].Direction);
				}
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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string EventType
		{
			get
			{
				return eventType;
			}
			set	
			{
				eventType = value;
				DictionaryUtil.Add(BodyParameters, "EventType", value);
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

		public Dictionary<object,object> ExtendConfig
		{
			get
			{
				return extendConfig;
			}
			set	
			{
				extendConfig = value;
				DictionaryUtil.Add(BodyParameters, "ExtendConfig", JsonConvert.SerializeObject(value));
			}
		}

		public string EventName
		{
			get
			{
				return eventName;
			}
			set	
			{
				eventName = value;
				DictionaryUtil.Add(BodyParameters, "EventName", value);
			}
		}

		public class OutputData
		{

			private string identifier;

			private string dataSpecs;

			private string dataType;

			private string name;

			private string dataSpecsList;

			private int? paraOrder;

			private string direction;

			public string Identifier
			{
				get
				{
					return identifier;
				}
				set	
				{
					identifier = value;
				}
			}

			public string DataSpecs
			{
				get
				{
					return dataSpecs;
				}
				set	
				{
					dataSpecs = value;
				}
			}

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
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
				}
			}

			public string DataSpecsList
			{
				get
				{
					return dataSpecsList;
				}
				set	
				{
					dataSpecsList = value;
				}
			}

			public int? ParaOrder
			{
				get
				{
					return paraOrder;
				}
				set	
				{
					paraOrder = value;
				}
			}

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
				}
			}
		}

        public override UpdateProductEventIdentifierForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateProductEventIdentifierForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
