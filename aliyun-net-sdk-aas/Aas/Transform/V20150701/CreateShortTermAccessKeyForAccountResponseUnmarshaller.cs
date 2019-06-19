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
    public class CreateShortTermAccessKeyForAccountResponseUnmarshaller
    {
        public static CreateShortTermAccessKeyForAccountResponse Unmarshall(UnmarshallerContext context)
        {
			CreateShortTermAccessKeyForAccountResponse createShortTermAccessKeyForAccountResponse = new CreateShortTermAccessKeyForAccountResponse();

			createShortTermAccessKeyForAccountResponse.HttpResponse = context.HttpResponse;
			createShortTermAccessKeyForAccountResponse.RequestId = context.StringValue("CreateShortTermAccessKeyForAccount.RequestId");
			createShortTermAccessKeyForAccountResponse.PK = context.StringValue("CreateShortTermAccessKeyForAccount.PK");

			CreateShortTermAccessKeyForAccountResponse.CreateShortTermAccessKeyForAccount_AccessKey accessKey = new CreateShortTermAccessKeyForAccountResponse.CreateShortTermAccessKeyForAccount_AccessKey();
			accessKey.CreateTime = context.StringValue("CreateShortTermAccessKeyForAccount.AccessKey.CreateTime");
			accessKey.AccessKeyId = context.StringValue("CreateShortTermAccessKeyForAccount.AccessKey.AccessKeyId");
			accessKey.AccessKeySecret = context.StringValue("CreateShortTermAccessKeyForAccount.AccessKey.AccessKeySecret");
			accessKey.AccessKeyStatus = context.StringValue("CreateShortTermAccessKeyForAccount.AccessKey.AccessKeyStatus");
			accessKey.AccessKeyType = context.StringValue("CreateShortTermAccessKeyForAccount.AccessKey.AccessKeyType");
			accessKey.ExpireTime = context.StringValue("CreateShortTermAccessKeyForAccount.AccessKey.ExpireTime");
			createShortTermAccessKeyForAccountResponse.AccessKey = accessKey;
        
			return createShortTermAccessKeyForAccountResponse;
        }
    }
}
