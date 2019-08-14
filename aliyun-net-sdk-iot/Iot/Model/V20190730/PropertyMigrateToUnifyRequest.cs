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
    public class PropertyMigrateToUnifyRequest : RpcAcsRequest<PropertyMigrateToUnifyResponse>
    {
        public PropertyMigrateToUnifyRequest()
            : base("Iot", "2019-07-30", "PropertyMigrateToUnify", "Iot", "openAPI")
        {
        }

		private string identifier;

		private string creator;

		private string thingTemplateKey;

		private string modifier;

		private string categoryKey;

		private string description;

		private string deviceType;

		private bool? required;

		private string dataSpecsId;

		private string thingTemplateName;

		private string dataType;

		private string templateType;

		private string iotInstanceId;

		private string name;

		private string _namespace;

		private string categoryName;

		private string definition;

		private int? state;

		private List<Tag> tags;

		private string bizTenantId;

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

		public string DataSpecsId
		{
			get
			{
				return dataSpecsId;
			}
			set	
			{
				dataSpecsId = value;
				DictionaryUtil.Add(QueryParameters, "DataSpecsId", value);
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

		public string DataType
		{
			get
			{
				return dataType;
			}
			set	
			{
				dataType = value;
				DictionaryUtil.Add(QueryParameters, "DataType", value);
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

		public string Definition
		{
			get
			{
				return definition;
			}
			set	
			{
				definition = value;
				DictionaryUtil.Add(QueryParameters, "Definition", value);
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

		public string AccessMode
		{
			get
			{
				return accessMode;
			}
			set	
			{
				accessMode = value;
				DictionaryUtil.Add(QueryParameters, "AccessMode", value);
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

        public override PropertyMigrateToUnifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PropertyMigrateToUnifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
