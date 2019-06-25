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
    public class RemoveThingTemplateFunctionForTmallGenieRequest : RpcAcsRequest<RemoveThingTemplateFunctionForTmallGenieResponse>
    {
        public RemoveThingTemplateFunctionForTmallGenieRequest()
            : base("Iot", "2019-07-30", "RemoveThingTemplateFunctionForTmallGenie", "iot", "openAPI")
        {
        }

		private string thingTemplateKey;

		private List<long?> tmallServiceFunctionIdss;

		private string iotInstanceId;

		private List<long?> tmallEventFunctionIdss;

		private List<long?> tmallPropertyFunctionIdss;

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

		public List<long?> TmallServiceFunctionIdss
		{
			get
			{
				return tmallServiceFunctionIdss;
			}

			set
			{
				tmallServiceFunctionIdss = value;
				for (int i = 0; i < tmallServiceFunctionIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TmallServiceFunctionIds." + (i + 1) , tmallServiceFunctionIdss[i]);
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

		public List<long?> TmallEventFunctionIdss
		{
			get
			{
				return tmallEventFunctionIdss;
			}

			set
			{
				tmallEventFunctionIdss = value;
				for (int i = 0; i < tmallEventFunctionIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TmallEventFunctionIds." + (i + 1) , tmallEventFunctionIdss[i]);
				}
			}
		}

		public List<long?> TmallPropertyFunctionIdss
		{
			get
			{
				return tmallPropertyFunctionIdss;
			}

			set
			{
				tmallPropertyFunctionIdss = value;
				for (int i = 0; i < tmallPropertyFunctionIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TmallPropertyFunctionIds." + (i + 1) , tmallPropertyFunctionIdss[i]);
				}
			}
		}

        public override RemoveThingTemplateFunctionForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RemoveThingTemplateFunctionForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
