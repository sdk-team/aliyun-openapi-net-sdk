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
    public class CreateShortTermAccessKeyForAccountRequest : RpcAcsRequest<CreateShortTermAccessKeyForAccountResponse>
    {
        public CreateShortTermAccessKeyForAccountRequest()
            : base("Aas", "2015-07-01", "CreateShortTermAccessKeyForAccount", "aas", "openAPI")
        {
        }

		private string expireTime;

		private bool? isMfaPresent;

		private string pK;

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
				DictionaryUtil.Add(QueryParameters, "ExpireTime", value);
			}
		}

		public bool? IsMfaPresent
		{
			get
			{
				return isMfaPresent;
			}
			set	
			{
				isMfaPresent = value;
				DictionaryUtil.Add(QueryParameters, "IsMfaPresent", value.ToString());
			}
		}

		public string PK
		{
			get
			{
				return pK;
			}
			set	
			{
				pK = value;
				DictionaryUtil.Add(QueryParameters, "PK", value);
			}
		}

        public override CreateShortTermAccessKeyForAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateShortTermAccessKeyForAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
