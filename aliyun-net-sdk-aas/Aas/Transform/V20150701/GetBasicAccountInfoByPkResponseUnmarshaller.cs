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
    public class GetBasicAccountInfoByPkResponseUnmarshaller
    {
        public static GetBasicAccountInfoByPkResponse Unmarshall(UnmarshallerContext context)
        {
			GetBasicAccountInfoByPkResponse getBasicAccountInfoByPkResponse = new GetBasicAccountInfoByPkResponse();

			getBasicAccountInfoByPkResponse.HttpResponse = context.HttpResponse;
			getBasicAccountInfoByPkResponse.RequestId = context.StringValue("GetBasicAccountInfoByPk.RequestId");
			getBasicAccountInfoByPkResponse.PK = context.StringValue("GetBasicAccountInfoByPk.PK");
			getBasicAccountInfoByPkResponse.HavanaId = context.StringValue("GetBasicAccountInfoByPk.HavanaId");
			getBasicAccountInfoByPkResponse.ParentPk = context.StringValue("GetBasicAccountInfoByPk.ParentPk");
			getBasicAccountInfoByPkResponse.PartnerPk = context.StringValue("GetBasicAccountInfoByPk.PartnerPk");
			getBasicAccountInfoByPkResponse.AccountStructure = context.StringValue("GetBasicAccountInfoByPk.AccountStructure");
			getBasicAccountInfoByPkResponse.SymmetricAkLimit = context.IntegerValue("GetBasicAccountInfoByPk.SymmetricAkLimit");
			getBasicAccountInfoByPkResponse.RSAAkLimit = context.IntegerValue("GetBasicAccountInfoByPk.RSAAkLimit");
			getBasicAccountInfoByPkResponse.VirtualMFALimit = context.IntegerValue("GetBasicAccountInfoByPk.VirtualMFALimit");
			getBasicAccountInfoByPkResponse.MulitiBidUser = context.BooleanValue("GetBasicAccountInfoByPk.MulitiBidUser");
			getBasicAccountInfoByPkResponse.LastLoginTime = context.StringValue("GetBasicAccountInfoByPk.LastLoginTime");
			getBasicAccountInfoByPkResponse.CreateTime = context.StringValue("GetBasicAccountInfoByPk.CreateTime");
			getBasicAccountInfoByPkResponse.AccountStatus = context.StringValue("GetBasicAccountInfoByPk.AccountStatus");
        
			return getBasicAccountInfoByPkResponse;
        }
    }
}
