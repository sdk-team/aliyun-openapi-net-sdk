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
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class UpdateApiAuthResponseUnmarshaller
    {
        public static UpdateApiAuthResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateApiAuthResponse updateApiAuthResponse = new UpdateApiAuthResponse();

			updateApiAuthResponse.HttpResponse = context.HttpResponse;
			updateApiAuthResponse.RequestId = context.StringValue("UpdateApiAuth.RequestId");

			UpdateApiAuthResponse.UpdateApiAuth_ApiAuth apiAuth = new UpdateApiAuthResponse.UpdateApiAuth_ApiAuth();
			apiAuth.CreateTime = context.StringValue("UpdateApiAuth.ApiAuth.CreateTime");
			apiAuth.ModifyTime = context.StringValue("UpdateApiAuth.ApiAuth.ModifyTime");
			apiAuth.Status = context.IntegerValue("UpdateApiAuth.ApiAuth.Status");
			apiAuth.ExpireTime = context.StringValue("UpdateApiAuth.ApiAuth.ExpireTime");
			apiAuth.SignVersion = context.StringValue("UpdateApiAuth.ApiAuth.SignVersion");
			apiAuth.Channel = context.StringValue("UpdateApiAuth.ApiAuth.Channel");
			apiAuth.Description = context.StringValue("UpdateApiAuth.ApiAuth.Description");
			apiAuth.ClientVersion = context.StringValue("UpdateApiAuth.ApiAuth.ClientVersion");
			updateApiAuthResponse.ApiAuth = apiAuth;
        
			return updateApiAuthResponse;
        }
    }
}
