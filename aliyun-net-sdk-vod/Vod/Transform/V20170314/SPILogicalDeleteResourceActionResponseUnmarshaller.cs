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
    public class SPILogicalDeleteResourceActionResponseUnmarshaller
    {
        public static SPILogicalDeleteResourceActionResponse Unmarshall(UnmarshallerContext context)
        {
			SPILogicalDeleteResourceActionResponse sPILogicalDeleteResourceActionResponse = new SPILogicalDeleteResourceActionResponse();

			sPILogicalDeleteResourceActionResponse.HttpResponse = context.HttpResponse;
			sPILogicalDeleteResourceActionResponse.RequestId = context.StringValue("SPILogicalDeleteResourceAction.RequestId");
			sPILogicalDeleteResourceActionResponse.Interrupt = context.BooleanValue("SPILogicalDeleteResourceAction.Interrupt");
			sPILogicalDeleteResourceActionResponse.Invoker = context.StringValue("SPILogicalDeleteResourceAction.Invoker");
			sPILogicalDeleteResourceActionResponse.Pk = context.StringValue("SPILogicalDeleteResourceAction.Pk");
			sPILogicalDeleteResourceActionResponse.Bid = context.StringValue("SPILogicalDeleteResourceAction.Bid");
			sPILogicalDeleteResourceActionResponse.Hid = context.LongValue("SPILogicalDeleteResourceAction.Hid");
			sPILogicalDeleteResourceActionResponse.Country = context.StringValue("SPILogicalDeleteResourceAction.Country");
			sPILogicalDeleteResourceActionResponse.TaskIdentifier = context.StringValue("SPILogicalDeleteResourceAction.TaskIdentifier");
			sPILogicalDeleteResourceActionResponse.TaskExtraData = context.StringValue("SPILogicalDeleteResourceAction.TaskExtraData");
			sPILogicalDeleteResourceActionResponse.GmtWakeup = context.StringValue("SPILogicalDeleteResourceAction.GmtWakeup");
			sPILogicalDeleteResourceActionResponse.Success = context.BooleanValue("SPILogicalDeleteResourceAction.Success");
			sPILogicalDeleteResourceActionResponse.Message = context.StringValue("SPILogicalDeleteResourceAction.Message");
        
			return sPILogicalDeleteResourceActionResponse;
        }
    }
}
