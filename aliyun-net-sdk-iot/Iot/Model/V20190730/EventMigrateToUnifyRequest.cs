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
    public class EventMigrateToUnifyRequest : RpcAcsRequest<EventMigrateToUnifyResponse>
    {
        public EventMigrateToUnifyRequest()
            : base("Iot", "2019-07-30", "EventMigrateToUnify", "iot", "openAPI")
        {
        }

		private string identifier;

		private string creator;

		private string thingTemplateKey;

		private string modifier;

		private string categoryKey;

		private string description;

		private string type;

		private bool? required;

		private string thingTemplateName;

		private List<Tags> tagss;

		private List<OutputData> outputDatas;

		private string templateType;

		private string iotInstanceId;

		private string name;

		private string _namespace;

		private string categoryName;

		private int? state;

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

		public string Creator
		{
			get
			{
				return creator;
			}
			set	
			{
				creator = value;
				DictionaryUtil.Add(QueryParameters, "Creator", value);
			}
		}

		public string ThingTemplateKey
		{
			get
			{
				return thingTemplateKey;
			}
			set	
			{
				thingTemplateKey = value;
				DictionaryUtil.Add(QueryParameters, "ThingTemplateKey", value);
			}
		}

		public string Modifier
		{
			get
			{
				return modifier;
			}
			set	
			{
				modifier = value;
				DictionaryUtil.Add(QueryParameters, "Modifier", value);
			}
		}

		public string CategoryKey
		{
			get
			{
				return categoryKey;
			}
			set	
			{
				categoryKey = value;
				DictionaryUtil.Add(QueryParameters, "CategoryKey", value);
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

		public string ThingTemplateName
		{
			get
			{
				return thingTemplateName;
			}
			set	
			{
				thingTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "ThingTemplateName", value);
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

		public string TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
				DictionaryUtil.Add(QueryParameters, "TemplateType", value);
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

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
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

		public int? State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value.ToString());
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

        public override EventMigrateToUnifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EventMigrateToUnifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
