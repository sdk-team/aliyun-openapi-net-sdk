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
    public class CategoryServiceMigrateRequest : RpcAcsRequest<CategoryServiceMigrateResponse>
    {
        public CategoryServiceMigrateRequest()
            : base("Iot", "2019-07-30", "CategoryServiceMigrate", "Iot", "openAPI")
        {
        }

		private List<Service> services;

		private string iotInstanceId;

		private string _namespace;

		private string categoryKey;

		private string bizTenantId;

		public List<Service> Services
		{
			get
			{
				return services;
			}

			set
			{
				services = value;
				for (int i = 0; i < services.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Identifier", services[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Creator", services[i].Creator);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".ThingTemplateKey", services[i].ThingTemplateKey);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".ArgsDTO", services[i].ArgsDTO);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Modifier", services[i].Modifier);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Description", services[i].Description);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".DeviceType", services[i].DeviceType);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Required", services[i].Required);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".DataSpecsId", services[i].DataSpecsId);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".ThingTemplateName", services[i].ThingTemplateName);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".TemplateType", services[i].TemplateType);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Name", services[i].Name);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Namespace", services[i].Namespace);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".CategoryName", services[i].CategoryName);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".State", services[i].State);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".Tag", services[i].Tag);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".CallType", services[i].CallType);
					DictionaryUtil.Add(QueryParameters,"Service." + (i + 1) + ".AccessMode", services[i].AccessMode);
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

		public class Service
		{

			private string identifier;

			private string creator;

			private string thingTemplateKey;

			private string argsDTO;

			private string modifier;

			private string description;

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

			private string callType;

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

			public string CallType
			{
				get
				{
					return callType;
				}
				set	
				{
					callType = value;
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

        public override CategoryServiceMigrateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CategoryServiceMigrateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
