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
    public class GetProductFunctionForTmallGenieRequest : RpcAcsRequest<GetProductFunctionForTmallGenieResponse>
    {
        public GetProductFunctionForTmallGenieRequest()
            : base("Iot", "2019-07-30", "GetProductFunctionForTmallGenie", "Iot", "openAPI")
        {
        }

		private string identifier;

		private long? tmallFunctionId;

		private string iotInstanceId;

		private string productKey;

		private string tmallFunctionType;

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

		public string TmallFunctionType
		{
			get
			{
				return tmallFunctionType;
			}
			set	
			{
				tmallFunctionType = value;
				DictionaryUtil.Add(QueryParameters, "TmallFunctionType", value);
			}
		}

        public override GetProductFunctionForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetProductFunctionForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}