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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class AddPoolFunctionsForTmallGenieRequest : RpcAcsRequest<AddPoolFunctionsForTmallGenieResponse>
    {
        public AddPoolFunctionsForTmallGenieRequest()
            : base("Iot", "2019-07-30", "AddPoolFunctionsForTmallGenie", "Iot", "openAPI")
        {
        }

		private List<long?> tmallServiceIdLists;

		private string thingTemplateKey;

		private List<long?> tmallEventIdLists;

		private string iotInstanceId;

		private List<long?> tmallPropertyIdLists;

		public List<long?> TmallServiceIdLists
		{
			get
			{
				return tmallServiceIdLists;
			}

			set
			{
				tmallServiceIdLists = value;
				for (int i = 0; i < tmallServiceIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TmallServiceIdList." + (i + 1) , tmallServiceIdLists[i]);
				}
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

		public List<long?> TmallEventIdLists
		{
			get
			{
				return tmallEventIdLists;
			}

			set
			{
				tmallEventIdLists = value;
				for (int i = 0; i < tmallEventIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TmallEventIdList." + (i + 1) , tmallEventIdLists[i]);
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

		public List<long?> TmallPropertyIdLists
		{
			get
			{
				return tmallPropertyIdLists;
			}

			set
			{
				tmallPropertyIdLists = value;
				for (int i = 0; i < tmallPropertyIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TmallPropertyIdList." + (i + 1) , tmallPropertyIdLists[i]);
				}
			}
		}

        public override AddPoolFunctionsForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddPoolFunctionsForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
