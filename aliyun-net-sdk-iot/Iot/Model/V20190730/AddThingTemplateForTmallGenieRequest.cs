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
    public class AddThingTemplateForTmallGenieRequest : RpcAcsRequest<AddThingTemplateForTmallGenieResponse>
    {
        public AddThingTemplateForTmallGenieRequest()
            : base("Iot", "2019-07-30", "AddThingTemplateForTmallGenie", "Iot", "openAPI")
        {
        }

		private string thingTemplateKey;

		private string thingTemplateName;

		private List<Tags> tagss = new List<Tags>(){ };

		private long? thingTemplateId;

		private string iotInstanceId;

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

		public long? ThingTemplateId
		{
			get
			{
				return thingTemplateId;
			}
			set	
			{
				thingTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ThingTemplateId", value.ToString());
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

        public override AddThingTemplateForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddThingTemplateForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
