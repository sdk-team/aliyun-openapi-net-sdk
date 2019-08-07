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
            : base("Iot", "2019-07-30", "ServiceMigrateToProd", "Iot", "openAPI")
        {
        }

		private string identifier;

		private List<ArgsDTO> argsDTOs;

		private string description;

		private string productKey;

		private string deviceType;

		private bool? required;

		private string iotInstanceId;

		private string name;

		private string categoryName;

		private List<Tag> tags;

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

        public override ServiceMigrateToProdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ServiceMigrateToProdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}