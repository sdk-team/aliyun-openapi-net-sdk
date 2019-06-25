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
    public class QueryProductInfoForTmallGenieRequest : RpcAcsRequest<QueryProductInfoForTmallGenieResponse>
    {
        public QueryProductInfoForTmallGenieRequest()
            : base("Iot", "2019-07-30", "QueryProductInfoForTmallGenie", "iot", "openAPI")
        {
        }

		private string iotInstanceId;

		private string productKey;

		private List<object> fields;

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

		public List<object> Fields
		{
			get
			{
				return fields;
			}
			set	
			{
				fields = value;
				DictionaryUtil.Add(QueryParameters, "Fields", JsonConvert.SerializeObject(value));
			}
		}

        public override QueryProductInfoForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryProductInfoForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
