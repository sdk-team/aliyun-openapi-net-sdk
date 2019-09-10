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
    public class UpdateThingTemplatePropertyForTmallGenieRequest : RpcAcsRequest<UpdateThingTemplatePropertyForTmallGenieResponse>
    {
        public UpdateThingTemplatePropertyForTmallGenieRequest()
            : base("Iot", "2019-07-30", "UpdateThingTemplatePropertyForTmallGenie", "Iot", "openAPI")
        {
        }

		private string dataSpecs;

		private string thingTemplateKey;

		private string description;

		private string dataSpecsList;

		private long? tmallFunctionId;

		private string iotInstanceId;

		private string identifier;

		private List<Tags> tagss = new List<Tags>(){ };

		private string rwType;

		private string name;

		public string DataSpecs
		{
			get
			{
				return dataSpecs;
			}
			set	
			{
				dataSpecs = value;
				DictionaryUtil.Add(QueryParameters, "DataSpecs", value);
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

		public string DataSpecsList
		{
			get
			{
				return dataSpecsList;
			}
			set	
			{
				dataSpecsList = value;
				DictionaryUtil.Add(QueryParameters, "DataSpecsList", value);
			}
		}

		public long? TmallFunctionId
		{
			get
			{
				return tmallFunctionId;
			}
			set	
			{
				tmallFunctionId = value;
				DictionaryUtil.Add(QueryParameters, "TmallFunctionId", value.ToString());
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

		public string RwType
		{
			get
			{
				return rwType;
			}
			set	
			{
				rwType = value;
				DictionaryUtil.Add(QueryParameters, "RwType", value);
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

        public override UpdateThingTemplatePropertyForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateThingTemplatePropertyForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
