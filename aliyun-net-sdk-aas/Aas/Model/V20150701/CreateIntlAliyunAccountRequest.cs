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
using Aliyun.Acs.Aas.Transform;
using Aliyun.Acs.Aas.Transform.V20150701;

namespace Aliyun.Acs.Aas.Model.V20150701
{
    public class CreateIntlAliyunAccountRequest : RpcAcsRequest<CreateIntlAliyunAccountResponse>
    {
        public CreateIntlAliyunAccountRequest()
            : base("Aas", "2015-07-01", "CreateIntlAliyunAccount", "aas", "openAPI")
        {
        }

		private string nationalityCode;

		public string NationalityCode
		{
			get
			{
				return nationalityCode;
			}
			set	
			{
				nationalityCode = value;
				DictionaryUtil.Add(QueryParameters, "NationalityCode", value);
			}
		}

        public override CreateIntlAliyunAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateIntlAliyunAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
