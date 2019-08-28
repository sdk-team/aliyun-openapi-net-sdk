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
    public class GetCheckChannelResponseUnmarshaller
    {
        public static GetCheckChannelResponse Unmarshall(UnmarshallerContext context)
        {
			GetCheckChannelResponse getCheckChannelResponse = new GetCheckChannelResponse();

			getCheckChannelResponse.HttpResponse = context.HttpResponse;
			getCheckChannelResponse.RequestId = context.StringValue("GetCheckChannel.RequestId");

			GetCheckChannelResponse.GetCheckChannel_Audit audit = new GetCheckChannelResponse.GetCheckChannel_Audit();
			audit.CreateTime = context.StringValue("GetCheckChannel.Audit.CreateTime");
			audit.UpdateTime = context.StringValue("GetCheckChannel.Audit.UpdateTime");
			audit.Channel = context.StringValue("GetCheckChannel.Audit.Channel");
			audit.CustomerId = context.StringValue("GetCheckChannel.Audit.CustomerId");
			audit.LegalSwitch = context.StringValue("GetCheckChannel.Audit.LegalSwitch");
			getCheckChannelResponse.Audit = audit;
        
			return getCheckChannelResponse;
        }
    }
}
