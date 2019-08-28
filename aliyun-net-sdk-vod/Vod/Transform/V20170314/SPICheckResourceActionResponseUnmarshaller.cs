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
    public class SPICheckResourceActionResponseUnmarshaller
    {
        public static SPICheckResourceActionResponse Unmarshall(UnmarshallerContext context)
        {
			SPICheckResourceActionResponse sPICheckResourceActionResponse = new SPICheckResourceActionResponse();

			sPICheckResourceActionResponse.HttpResponse = context.HttpResponse;
			sPICheckResourceActionResponse.RequestId = context.StringValue("SPICheckResourceAction.RequestId");
			sPICheckResourceActionResponse.Interrupt = context.BooleanValue("SPICheckResourceAction.Interrupt");
			sPICheckResourceActionResponse.Invoker = context.StringValue("SPICheckResourceAction.Invoker");
			sPICheckResourceActionResponse.Pk = context.StringValue("SPICheckResourceAction.Pk");
			sPICheckResourceActionResponse.Bid = context.StringValue("SPICheckResourceAction.Bid");
			sPICheckResourceActionResponse.Hid = context.LongValue("SPICheckResourceAction.Hid");
			sPICheckResourceActionResponse.Country = context.StringValue("SPICheckResourceAction.Country");
			sPICheckResourceActionResponse.TaskIdentifier = context.StringValue("SPICheckResourceAction.TaskIdentifier");
			sPICheckResourceActionResponse.TaskExtraData = context.StringValue("SPICheckResourceAction.TaskExtraData");
			sPICheckResourceActionResponse.GmtWakeup = context.StringValue("SPICheckResourceAction.GmtWakeup");
			sPICheckResourceActionResponse.Success = context.BooleanValue("SPICheckResourceAction.Success");
			sPICheckResourceActionResponse.Message = context.StringValue("SPICheckResourceAction.Message");
			sPICheckResourceActionResponse.Level = context.LongValue("SPICheckResourceAction.Level");
			sPICheckResourceActionResponse.Url = context.StringValue("SPICheckResourceAction.Url");
			sPICheckResourceActionResponse.Prompt = context.StringValue("SPICheckResourceAction.Prompt");
        
			return sPICheckResourceActionResponse;
        }
    }
}
