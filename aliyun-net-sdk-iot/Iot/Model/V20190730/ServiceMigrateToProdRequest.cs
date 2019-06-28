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
    public class ServiceMigrateToProdRequest : RpcAcsRequest<ServiceMigrateToProdResponse>
    {
        public ServiceMigrateToProdRequest()
            : base("Iot", "2019-07-30", "ServiceMigrateToProd", "iot", "openAPI")
        {
        }

		private string identifier;

		private string description;

		private string productKey;

		private bool? required;

		private List<Tags> tagss;

		private List<InputData> inputDatas;

		private List<OutputData> outputDatas;

		private string iotInstanceId;

		private string name;

		private string categoryName;

		private string callType;

		private string bizTenantId;

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
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

		public bool? Required
		{
			get
			{
				return required;
			}
			set	
			{
				required = value;
				DictionaryUtil.Add(QueryParameters, "Required", value.ToString());
			}
		}

		public List<Tags> Tagss
		{
			get
			{
				return tagss;
			}

			set
			{
				tagss = value;
				for (int i = 0; i < tagss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tags." + (i + 1) + ".TagValue", tagss[i].TagValue);
					DictionaryUtil.Add(QueryParameters,"Tags." + (i + 1) + ".TagKey", tagss[i].TagKey);
				}
			}
		}

		public List<InputData> InputDatas
		{
			get
			{
				return inputDatas;
			}

			set
			{
				inputDatas = value;
				for (int i = 0; i < inputDatas.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".Identifier", inputDatas[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".InteractionId", inputDatas[i].InteractionId);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".InteractionType", inputDatas[i].InteractionType);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".DataType", inputDatas[i].DataType);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".Name", inputDatas[i].Name);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".Definition", inputDatas[i].Definition);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".ParaOrder", inputDatas[i].ParaOrder);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".DataSpecsId", inputDatas[i].DataSpecsId);
					DictionaryUtil.Add(QueryParameters,"InputData." + (i + 1) + ".Direction", inputDatas[i].Direction);
				}
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
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".InteractionId", outputDatas[i].InteractionId);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".InteractionType", outputDatas[i].InteractionType);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".DataType", outputDatas[i].DataType);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".Name", outputDatas[i].Name);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".Definition", outputDatas[i].Definition);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".ParaOrder", outputDatas[i].ParaOrder);
					DictionaryUtil.Add(QueryParameters,"OutputData." + (i + 1) + ".DataSpecsId", outputDatas[i].DataSpecsId);
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

		public string CategoryName
		{
			get
			{
				return categoryName;
			}
			set	
			{
				categoryName = value;
				DictionaryUtil.Add(QueryParameters, "CategoryName", value);
			}
		}

		public string CallType
		{
			get
			{
				return callType;
			}
			set	
			{
				callType = value;
				DictionaryUtil.Add(QueryParameters, "CallType", value);
			}
		}

		public string BizTenantId
		{
			get
			{
				return bizTenantId;
			}
			set	
			{
				bizTenantId = value;
				DictionaryUtil.Add(QueryParameters, "BizTenantId", value);
			}
		}

		public class Tags
		{

			private string tagValue;

			private string tagKey;

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}
		}

		public class InputData
		{

			private string identifier;

			private long? interactionId;

			private string interactionType;

			private string dataType;

			private string name;

			private string definition;

			private int? paraOrder;

			private string dataSpecsId;

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

			public long? InteractionId
			{
				get
				{
					return interactionId;
				}
				set	
				{
					interactionId = value;
				}
			}

			public string InteractionType
			{
				get
				{
					return interactionType;
				}
				set	
				{
					interactionType = value;
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

			public string Definition
			{
				get
				{
					return definition;
				}
				set	
				{
					definition = value;
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

			public string DataSpecsId
			{
				get
				{
					return dataSpecsId;
				}
				set	
				{
					dataSpecsId = value;
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

		public class OutputData
		{

			private string identifier;

			private long? interactionId;

			private string interactionType;

			private string dataType;

			private string name;

			private string definition;

			private int? paraOrder;

			private string dataSpecsId;

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

			public long? InteractionId
			{
				get
				{
					return interactionId;
				}
				set	
				{
					interactionId = value;
				}
			}

			public string InteractionType
			{
				get
				{
					return interactionType;
				}
				set	
				{
					interactionType = value;
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

			public string Definition
			{
				get
				{
					return definition;
				}
				set	
				{
					definition = value;
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

			public string DataSpecsId
			{
				get
				{
					return dataSpecsId;
				}
				set	
				{
					dataSpecsId = value;
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

        public override ServiceMigrateToProdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ServiceMigrateToProdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
