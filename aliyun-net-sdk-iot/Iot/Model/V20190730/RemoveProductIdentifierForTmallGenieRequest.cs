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
    public class RemoveProductIdentifierForTmallGenieRequest : RpcAcsRequest<RemoveProductIdentifierForTmallGenieResponse>
    {
        public RemoveProductIdentifierForTmallGenieRequest()
            : base("Iot", "2019-07-30", "RemoveProductIdentifierForTmallGenie", "Iot", "openAPI")
        {
        }

		private List<string> identifiers;

		private string iotInstanceId;

		private string productKey;

		public List<string> Identifiers
		{
			get
			{
				return identifiers;
			}

			set
			{
				identifiers = value;
				for (int i = 0; i < identifiers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Identifier." + (i + 1) , identifiers[i]);
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

        public override RemoveProductIdentifierForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RemoveProductIdentifierForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}