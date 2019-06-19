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
    public class DoPhysicalDeleteResourceResponseUnmarshaller
    {
        public static DoPhysicalDeleteResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DoPhysicalDeleteResourceResponse doPhysicalDeleteResourceResponse = new DoPhysicalDeleteResourceResponse();

			doPhysicalDeleteResourceResponse.HttpResponse = context.HttpResponse;
			doPhysicalDeleteResourceResponse.Interrupt = context.BooleanValue("DoPhysicalDeleteResource.Interrupt");
			doPhysicalDeleteResourceResponse.Invoker = context.StringValue("DoPhysicalDeleteResource.Invoker");
			doPhysicalDeleteResourceResponse.Pk = context.StringValue("DoPhysicalDeleteResource.Pk");
			doPhysicalDeleteResourceResponse.Bid = context.StringValue("DoPhysicalDeleteResource.Bid");
			doPhysicalDeleteResourceResponse.Hid = context.LongValue("DoPhysicalDeleteResource.Hid");
			doPhysicalDeleteResourceResponse.Country = context.StringValue("DoPhysicalDeleteResource.Country");
			doPhysicalDeleteResourceResponse.TaskIdentifier = context.StringValue("DoPhysicalDeleteResource.TaskIdentifier");
			doPhysicalDeleteResourceResponse.TaskExtraData = context.StringValue("DoPhysicalDeleteResource.TaskExtraData");
			doPhysicalDeleteResourceResponse.GmtWakeup = context.StringValue("DoPhysicalDeleteResource.GmtWakeup");
			doPhysicalDeleteResourceResponse.Success = context.BooleanValue("DoPhysicalDeleteResource.Success");
			doPhysicalDeleteResourceResponse.Message = context.StringValue("DoPhysicalDeleteResource.Message");
        
			return doPhysicalDeleteResourceResponse;
        }
    }
}
