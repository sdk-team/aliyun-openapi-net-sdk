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
using Aliyun.Acs.cr.Model.V20150506;

namespace Aliyun.Acs.cr.Transform.V20150506
{
    public class DoCheckResourceResponseUnmarshaller
    {
        public static DoCheckResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DoCheckResourceResponse doCheckResourceResponse = new DoCheckResourceResponse();

			doCheckResourceResponse.HttpResponse = context.HttpResponse;
			doCheckResourceResponse.Interrupt = context.BooleanValue("DoCheckResource.Interrupt");
			doCheckResourceResponse.Invoker = context.StringValue("DoCheckResource.Invoker");
			doCheckResourceResponse.Pk = context.StringValue("DoCheckResource.Pk");
			doCheckResourceResponse.Bid = context.StringValue("DoCheckResource.Bid");
			doCheckResourceResponse.Hid = context.LongValue("DoCheckResource.Hid");
			doCheckResourceResponse.Country = context.StringValue("DoCheckResource.Country");
			doCheckResourceResponse.TaskIdentifier = context.StringValue("DoCheckResource.TaskIdentifier");
			doCheckResourceResponse.TaskExtraData = context.StringValue("DoCheckResource.TaskExtraData");
			doCheckResourceResponse.GmtWakeup = context.StringValue("DoCheckResource.GmtWakeup");
			doCheckResourceResponse.Success = context.BooleanValue("DoCheckResource.Success");
			doCheckResourceResponse.Message = context.StringValue("DoCheckResource.Message");
			doCheckResourceResponse.Level = context.LongValue("DoCheckResource.Level");
			doCheckResourceResponse.Url = context.StringValue("DoCheckResource.Url");
			doCheckResourceResponse.Prompt = context.StringValue("DoCheckResource.Prompt");
        
			return doCheckResourceResponse;
        }
    }
}
