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
    public class CategoryEventMigrateRequest : RpcAcsRequest<CategoryEventMigrateResponse>
    {
        public CategoryEventMigrateRequest()
            : base("Iot", "2019-07-30", "CategoryEventMigrate", "Iot", "openAPI")
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
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".ArgsDTO", _events[i].ArgsDTO);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Modifier", _events[i].Modifier);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Description", _events[i].Description);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Type", _events[i].Type);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".DeviceType", _events[i].DeviceType);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Required", _events[i].Required);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".DataSpecsId", _events[i].DataSpecsId);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".ThingTemplateName", _events[i].ThingTemplateName);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".TemplateType", _events[i].TemplateType);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Name", _events[i].Name);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Namespace", _events[i].Namespace);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".CategoryName", _events[i].CategoryName);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".State", _events[i].State);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".Tag", _events[i].Tag);
					DictionaryUtil.Add(QueryParameters,"Event." + (i + 1) + ".AccessMode", _events[i].AccessMode);
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

			private string argsDTO;

			private string modifier;

			private string description;

			private string type;

			private string deviceType;

			private bool? required;

			private string dataSpecsId;

			private string thingTemplateName;

			private string templateType;

			private string name;

			private string namespace_;

			private string categoryName;

			private int? state;

			private string tag;

			private string accessMode;

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

			public string ArgsDTO
			{
				get
				{
					return argsDTO;
				}
				set	
				{
					argsDTO = value;
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

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public string AccessMode
			{
				get
				{
					return accessMode;
				}
				set	
				{
					accessMode = value;
				}
			}
		}

        public override CategoryEventMigrateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CategoryEventMigrateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
