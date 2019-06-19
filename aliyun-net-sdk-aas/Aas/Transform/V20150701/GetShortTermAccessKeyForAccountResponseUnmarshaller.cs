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
    public class GetShortTermAccessKeyForAccountResponseUnmarshaller
    {
        public static GetShortTermAccessKeyForAccountResponse Unmarshall(UnmarshallerContext context)
        {
			GetShortTermAccessKeyForAccountResponse getShortTermAccessKeyForAccountResponse = new GetShortTermAccessKeyForAccountResponse();

			getShortTermAccessKeyForAccountResponse.HttpResponse = context.HttpResponse;
			getShortTermAccessKeyForAccountResponse.RequestId = context.StringValue("GetShortTermAccessKeyForAccount.RequestId");
			getShortTermAccessKeyForAccountResponse.PK = context.StringValue("GetShortTermAccessKeyForAccount.PK");

			GetShortTermAccessKeyForAccountResponse.GetShortTermAccessKeyForAccount_AccessKey accessKey = new GetShortTermAccessKeyForAccountResponse.GetShortTermAccessKeyForAccount_AccessKey();
			accessKey.CreateTime = context.StringValue("GetShortTermAccessKeyForAccount.AccessKey.CreateTime");
			accessKey.AccessKeyId = context.StringValue("GetShortTermAccessKeyForAccount.AccessKey.AccessKeyId");
			accessKey.AccessKeySecret = context.StringValue("GetShortTermAccessKeyForAccount.AccessKey.AccessKeySecret");
			accessKey.AccessKeyStatus = context.StringValue("GetShortTermAccessKeyForAccount.AccessKey.AccessKeyStatus");
			accessKey.AccessKeyType = context.StringValue("GetShortTermAccessKeyForAccount.AccessKey.AccessKeyType");
			accessKey.ExpireTime = context.StringValue("GetShortTermAccessKeyForAccount.AccessKey.ExpireTime");
			getShortTermAccessKeyForAccountResponse.AccessKey = accessKey;
        
			return getShortTermAccessKeyForAccountResponse;
        }
    }
}
