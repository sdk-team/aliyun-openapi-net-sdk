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
    public class BatchEventMigrateToUnifyRequest : RpcAcsRequest<BatchEventMigrateToUnifyResponse>
    {
        public BatchEventMigrateToUnifyRequest()
            : base("Iot", "2019-07-30", "BatchEventMigrateToUnify", "Iot", "openAPI")
        {
        }

		private string iotInstanceId;

		private string _namespace;

		private string categoryKey;

		private List<Event> _events;

		private string bizTenantId;

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

		public List<Event> _Events
		{
			get
			{
				return _events;
			}

			set
			{
				_events = value;
				for (int i = 0; i < _events.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Identifier", _events[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Creator", _events[i].Creator);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".ThingTemplateKey", _events[i].ThingTemplateKey);
					for (int j = 0; j < _events[i].ArgsDTOs.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".ArgsDTO." +(j + 1), _events[i].ArgsDTOs[j]);
					}
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Modifier", _events[i].Modifier);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Description", _events[i].Description);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Type", _events[i].Type);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".DeviceType", _events[i].DeviceType);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Required", _events[i].Required);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".ThingTemplateName", _events[i].ThingTemplateName);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".TemplateType", _events[i].TemplateType);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Name", _events[i].Name);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Namespace", _events[i].Namespace);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".CategoryName", _events[i].CategoryName);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".State", _events[i].State);
					for (int j = 0; j < _events[i].Tags.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Tag." +(j + 1), _events[i].Tags[j]);
					}
				}
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

		public class Event
		{

			private string identifier;

			private string creator;

			private string thingTemplateKey;

			private List<ArgsDTO> argsDTOs;

			private string modifier;

			private string description;

			private string type;

			private string deviceType;

			private bool? required;

			private string thingTemplateName;

			private string templateType;

			private string name;

			private string namespace_;

			private string categoryName;

			private int? state;

			private List<Tag> tags;

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

			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
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
				}
			}

			public List<ArgsDTO> ArgsDTOs
			{
				get
				{
					return argsDTOs;
				}
				set	
				{
					argsDTOs = value;
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
				}
			}

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
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

			public string Namespace
			{
				get
				{
					return namespace_;
				}
				set	
				{
					namespace_ = value;
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
				}
			}

			public class ArgsDTO
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
		}

        public override BatchEventMigrateToUnifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchEventMigrateToUnifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
