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
    public class CategoryPropertyMigrateRequest : RpcAcsRequest<CategoryPropertyMigrateResponse>
    {
        public CategoryPropertyMigrateRequest()
            : base("Iot", "2019-07-30", "CategoryPropertyMigrate", "Iot", "openAPI")
        {
        }

		private string iotInstanceId;

		private string _namespace;

		private List<Property> propertys;

		private string categoryKey;

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

		public List<Property> Propertys
		{
			get
			{
				return propertys;
			}

			set
			{
				propertys = value;
				for (int i = 0; i < propertys.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Identifier", propertys[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Creator", propertys[i].Creator);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".ThingTemplateKey", propertys[i].ThingTemplateKey);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Modifier", propertys[i].Modifier);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Description", propertys[i].Description);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".DeviceType", propertys[i].DeviceType);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Required", propertys[i].Required);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".DataSpecsId", propertys[i].DataSpecsId);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".ThingTemplateName", propertys[i].ThingTemplateName);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".DataType", propertys[i].DataType);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".TemplateType", propertys[i].TemplateType);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Name", propertys[i].Name);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Namespace", propertys[i].Namespace);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".CategoryName", propertys[i].CategoryName);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Definition", propertys[i].Definition);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".State", propertys[i].State);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".Tag", propertys[i].Tag);
					DictionaryUtil.Add(QueryParameters,"Property." + (i + 1) + ".AccessMode", propertys[i].AccessMode);
				}
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

		public class Property
		{

			private string identifier;

			private string creator;

			private string thingTemplateKey;

			private string modifier;

			private string description;

			private string deviceType;

			private bool? required;

			private string dataSpecsId;

			private string thingTemplateName;

			private string dataType;

			private string templateType;

			private string name;

			private string namespace_;

			private string categoryName;

			private string definition;

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

        public override CategoryPropertyMigrateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CategoryPropertyMigrateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
