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
    public class MigrateProdFunctionListRequest : RpcAcsRequest<MigrateProdFunctionListResponse>
    {
        public MigrateProdFunctionListRequest()
            : base("Iot", "2019-07-30", "MigrateProdFunctionList", "Iot", "openAPI")
        {
        }

		private string packInfo;

		private string extension;

		private string productKey;

		private string iotInstanceId;

		private string bizTenantId;

		public string PackInfo
		{
			get
			{
				return packInfo;
			}
			set	
			{
				packInfo = value;
				DictionaryUtil.Add(QueryParameters, "PackInfo", value);
			}
		}

		public string Extension
		{
			get
			{
				return extension;
			}
			set	
			{
				extension = value;
				DictionaryUtil.Add(QueryParameters, "Extension", value);
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

        public override MigrateProdFunctionListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MigrateProdFunctionListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
