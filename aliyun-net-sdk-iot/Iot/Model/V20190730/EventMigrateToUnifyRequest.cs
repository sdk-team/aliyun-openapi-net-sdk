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
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class EventMigrateToUnifyRequest : RpcAcsRequest<EventMigrateToUnifyResponse>
    {
        public EventMigrateToUnifyRequest()
            : base("Iot", "2019-07-30", "EventMigrateToUnify")
        {
        }

		private string thingTemplateKey;

		private List<ArgsDTO> argsDTOs = new List<ArgsDTO>(){ };

		private string modifier;

		private string categoryKey;

		private string description;

		private string type;

		private string deviceType;

		private bool? required;

		private string templateType;

		private string iotInstanceId;

		private int? state;

		private List<Tag> tags = new List<Tag>(){ };

		private string identifier;

		private string creator;

		private string thingTemplateName;

		private string name;

		private string _namespace;

		private string categoryName;

		private string bizTenantId;

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

		public List<ArgsDTO> ArgsDTOs
		{
			get
			{
				return argsDTOs;
			}

			set
			{
				argsDTOs = value;
				for (int i = 0; i < argsDTOs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".Identifier", argsDTOs[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".InteractionId", argsDTOs[i].InteractionId);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".InteractionType", argsDTOs[i].InteractionType);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".DataType", argsDTOs[i].DataType);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".Name", argsDTOs[i].Name);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".Definition", argsDTOs[i].Definition);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".ParaOrder", argsDTOs[i].ParaOrder);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".DataSpecsId", argsDTOs[i].DataSpecsId);
					DictionaryUtil.Add(QueryParameters,"ArgsDTO." + (i + 1) + ".Direction", argsDTOs[i].Direction);
				}
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

		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value);
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

        public override EventMigrateToUnifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return EventMigrateToUnifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
