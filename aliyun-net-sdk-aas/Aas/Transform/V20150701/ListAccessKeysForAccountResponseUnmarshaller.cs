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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Aas.Model.V20150701;

namespace Aliyun.Acs.Aas.Transform.V20150701
{
    public class ListAccessKeysForAccountResponseUnmarshaller
    {
        public static ListAccessKeysForAccountResponse Unmarshall(UnmarshallerContext context)
        {
			ListAccessKeysForAccountResponse listAccessKeysForAccountResponse = new ListAccessKeysForAccountResponse();

			listAccessKeysForAccountResponse.HttpResponse = context.HttpResponse;
			listAccessKeysForAccountResponse.RequestId = context.StringValue("ListAccessKeysForAccount.RequestId");
			listAccessKeysForAccountResponse.PK = context.StringValue("ListAccessKeysForAccount.PK");

			List<ListAccessKeysForAccountResponse.ListAccessKeysForAccount_AccessKey> listAccessKeysForAccountResponse_accessKeys = new List<ListAccessKeysForAccountResponse.ListAccessKeysForAccount_AccessKey>();
			for (int i = 0; i < context.Length("ListAccessKeysForAccount.AccessKeys.Length"); i++) {
				ListAccessKeysForAccountResponse.ListAccessKeysForAccount_AccessKey accessKey = new ListAccessKeysForAccountResponse.ListAccessKeysForAccount_AccessKey();
				accessKey.CreateTime = context.StringValue("ListAccessKeysForAccount.AccessKeys["+ i +"].CreateTime");
				accessKey.AccessKeyId = context.StringValue("ListAccessKeysForAccount.AccessKeys["+ i +"].AccessKeyId");
				accessKey.AccessKeySecret = context.StringValue("ListAccessKeysForAccount.AccessKeys["+ i +"].AccessKeySecret");
				accessKey.AccessKeyStatus = context.StringValue("ListAccessKeysForAccount.AccessKeys["+ i +"].AccessKeyStatus");
				accessKey.AccessKeyType = context.StringValue("ListAccessKeysForAccount.AccessKeys["+ i +"].AccessKeyType");

				listAccessKeysForAccountResponse_accessKeys.Add(accessKey);
			}
			listAccessKeysForAccountResponse.AccessKeys = listAccessKeysForAccountResponse_accessKeys;
        
			return listAccessKeysForAccountResponse;
        }
    }
}
