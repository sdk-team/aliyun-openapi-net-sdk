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
    public class CreateAccessKeyForAccountResponseUnmarshaller
    {
        public static CreateAccessKeyForAccountResponse Unmarshall(UnmarshallerContext context)
        {
			CreateAccessKeyForAccountResponse createAccessKeyForAccountResponse = new CreateAccessKeyForAccountResponse();

			createAccessKeyForAccountResponse.HttpResponse = context.HttpResponse;
			createAccessKeyForAccountResponse.RequestId = context.StringValue("CreateAccessKeyForAccount.RequestId");
			createAccessKeyForAccountResponse.PK = context.StringValue("CreateAccessKeyForAccount.PK");

			CreateAccessKeyForAccountResponse.CreateAccessKeyForAccount_AccessKey accessKey = new CreateAccessKeyForAccountResponse.CreateAccessKeyForAccount_AccessKey();
			accessKey.CreateTime = context.StringValue("CreateAccessKeyForAccount.AccessKey.CreateTime");
			accessKey.AccessKeyId = context.StringValue("CreateAccessKeyForAccount.AccessKey.AccessKeyId");
			accessKey.AccessKeySecret = context.StringValue("CreateAccessKeyForAccount.AccessKey.AccessKeySecret");
			accessKey.AccessKeyStatus = context.StringValue("CreateAccessKeyForAccount.AccessKey.AccessKeyStatus");
			accessKey.AccessKeyType = context.StringValue("CreateAccessKeyForAccount.AccessKey.AccessKeyType");
			createAccessKeyForAccountResponse.AccessKey = accessKey;
        
			return createAccessKeyForAccountResponse;
        }
    }
}
