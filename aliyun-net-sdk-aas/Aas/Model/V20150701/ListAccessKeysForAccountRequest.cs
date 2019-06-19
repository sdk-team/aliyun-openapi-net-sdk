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
    public class ListAccessKeysForAccountRequest : RpcAcsRequest<ListAccessKeysForAccountResponse>
    {
        public ListAccessKeysForAccountRequest()
            : base("Aas", "2015-07-01", "ListAccessKeysForAccount", "aas", "openAPI")
        {
        }

		private string aKType;

		private string aKStatus;

		private string pK;

		public string AKType
		{
			get
			{
				return aKType;
			}
			set	
			{
				aKType = value;
				DictionaryUtil.Add(QueryParameters, "AKType", value);
			}
		}

		public string AKStatus
		{
			get
			{
				return aKStatus;
			}
			set	
			{
				aKStatus = value;
				DictionaryUtil.Add(QueryParameters, "AKStatus", value);
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

        public override ListAccessKeysForAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAccessKeysForAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
