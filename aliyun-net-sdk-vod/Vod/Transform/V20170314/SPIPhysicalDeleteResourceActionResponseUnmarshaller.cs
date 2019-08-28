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
    public class SPIPhysicalDeleteResourceActionResponseUnmarshaller
    {
        public static SPIPhysicalDeleteResourceActionResponse Unmarshall(UnmarshallerContext context)
        {
			SPIPhysicalDeleteResourceActionResponse sPIPhysicalDeleteResourceActionResponse = new SPIPhysicalDeleteResourceActionResponse();

			sPIPhysicalDeleteResourceActionResponse.HttpResponse = context.HttpResponse;
			sPIPhysicalDeleteResourceActionResponse.RequestId = context.StringValue("SPIPhysicalDeleteResourceAction.RequestId");
			sPIPhysicalDeleteResourceActionResponse.Interrupt = context.BooleanValue("SPIPhysicalDeleteResourceAction.Interrupt");
			sPIPhysicalDeleteResourceActionResponse.Invoker = context.StringValue("SPIPhysicalDeleteResourceAction.Invoker");
			sPIPhysicalDeleteResourceActionResponse.Pk = context.StringValue("SPIPhysicalDeleteResourceAction.Pk");
			sPIPhysicalDeleteResourceActionResponse.Bid = context.StringValue("SPIPhysicalDeleteResourceAction.Bid");
			sPIPhysicalDeleteResourceActionResponse.Hid = context.LongValue("SPIPhysicalDeleteResourceAction.Hid");
			sPIPhysicalDeleteResourceActionResponse.Country = context.StringValue("SPIPhysicalDeleteResourceAction.Country");
			sPIPhysicalDeleteResourceActionResponse.TaskIdentifier = context.StringValue("SPIPhysicalDeleteResourceAction.TaskIdentifier");
			sPIPhysicalDeleteResourceActionResponse.TaskExtraData = context.StringValue("SPIPhysicalDeleteResourceAction.TaskExtraData");
			sPIPhysicalDeleteResourceActionResponse.GmtWakeup = context.StringValue("SPIPhysicalDeleteResourceAction.GmtWakeup");
			sPIPhysicalDeleteResourceActionResponse.Success = context.BooleanValue("SPIPhysicalDeleteResourceAction.Success");
			sPIPhysicalDeleteResourceActionResponse.Message = context.StringValue("SPIPhysicalDeleteResourceAction.Message");
        
			return sPIPhysicalDeleteResourceActionResponse;
        }
    }
}
