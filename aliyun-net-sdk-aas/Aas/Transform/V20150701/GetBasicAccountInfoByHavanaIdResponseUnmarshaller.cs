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
    public class GetBasicAccountInfoByHavanaIdResponseUnmarshaller
    {
        public static GetBasicAccountInfoByHavanaIdResponse Unmarshall(UnmarshallerContext context)
        {
			GetBasicAccountInfoByHavanaIdResponse getBasicAccountInfoByHavanaIdResponse = new GetBasicAccountInfoByHavanaIdResponse();

			getBasicAccountInfoByHavanaIdResponse.HttpResponse = context.HttpResponse;
			getBasicAccountInfoByHavanaIdResponse.RequestId = context.StringValue("GetBasicAccountInfoByHavanaId.RequestId");
			getBasicAccountInfoByHavanaIdResponse.PK = context.StringValue("GetBasicAccountInfoByHavanaId.PK");
			getBasicAccountInfoByHavanaIdResponse.HavanaId = context.StringValue("GetBasicAccountInfoByHavanaId.HavanaId");
			getBasicAccountInfoByHavanaIdResponse.ParentPk = context.StringValue("GetBasicAccountInfoByHavanaId.ParentPk");
			getBasicAccountInfoByHavanaIdResponse.PartnerPk = context.StringValue("GetBasicAccountInfoByHavanaId.PartnerPk");
			getBasicAccountInfoByHavanaIdResponse.AccountStructure = context.StringValue("GetBasicAccountInfoByHavanaId.AccountStructure");
			getBasicAccountInfoByHavanaIdResponse.SymmetricAkLimit = context.IntegerValue("GetBasicAccountInfoByHavanaId.SymmetricAkLimit");
			getBasicAccountInfoByHavanaIdResponse.RSAAkLimit = context.IntegerValue("GetBasicAccountInfoByHavanaId.RSAAkLimit");
			getBasicAccountInfoByHavanaIdResponse.VirtualMFALimit = context.IntegerValue("GetBasicAccountInfoByHavanaId.VirtualMFALimit");
			getBasicAccountInfoByHavanaIdResponse.MulitiBidUser = context.BooleanValue("GetBasicAccountInfoByHavanaId.MulitiBidUser");
			getBasicAccountInfoByHavanaIdResponse.LastLoginTime = context.StringValue("GetBasicAccountInfoByHavanaId.LastLoginTime");
			getBasicAccountInfoByHavanaIdResponse.CreateTime = context.StringValue("GetBasicAccountInfoByHavanaId.CreateTime");
			getBasicAccountInfoByHavanaIdResponse.AccountStatus = context.StringValue("GetBasicAccountInfoByHavanaId.AccountStatus");
        
			return getBasicAccountInfoByHavanaIdResponse;
        }
    }
}
