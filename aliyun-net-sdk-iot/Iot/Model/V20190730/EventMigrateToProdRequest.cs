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
    public class EventMigrateToProdRequest : RpcAcsRequest<EventMigrateToProdResponse>
    {
        public EventMigrateToProdRequest()
            : base("Iot", "2019-07-30", "EventMigrateToProd", "iot", "openAPI")
        {
        }

		private string identifier;

		private List<OutputData> outputDatas;

		private string iotInstanceId;

		private string name;

		private string description;

		private List<Tag> tags;

		private string productKey;

		private string type;

		private string bizTenantId;

		private bool? required;

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

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".TagValue", tags[i].TagValue);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".TagKey", tags[i].TagKey);
				}
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

		public class Tag
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

        public override EventMigrateToProdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EventMigrateToProdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
