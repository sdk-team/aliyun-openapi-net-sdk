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
    public class DoLogicalDeleteResourceResponseUnmarshaller
    {
        public static DoLogicalDeleteResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DoLogicalDeleteResourceResponse doLogicalDeleteResourceResponse = new DoLogicalDeleteResourceResponse();

			doLogicalDeleteResourceResponse.HttpResponse = context.HttpResponse;
			doLogicalDeleteResourceResponse.Interrupt = context.BooleanValue("DoLogicalDeleteResource.Interrupt");
			doLogicalDeleteResourceResponse.Invoker = context.StringValue("DoLogicalDeleteResource.Invoker");
			doLogicalDeleteResourceResponse.Pk = context.StringValue("DoLogicalDeleteResource.Pk");
			doLogicalDeleteResourceResponse.Bid = context.StringValue("DoLogicalDeleteResource.Bid");
			doLogicalDeleteResourceResponse.Hid = context.LongValue("DoLogicalDeleteResource.Hid");
			doLogicalDeleteResourceResponse.Country = context.StringValue("DoLogicalDeleteResource.Country");
			doLogicalDeleteResourceResponse.TaskIdentifier = context.StringValue("DoLogicalDeleteResource.TaskIdentifier");
			doLogicalDeleteResourceResponse.TaskExtraData = context.StringValue("DoLogicalDeleteResource.TaskExtraData");
			doLogicalDeleteResourceResponse.GmtWakeup = context.StringValue("DoLogicalDeleteResource.GmtWakeup");
			doLogicalDeleteResourceResponse.Success = context.BooleanValue("DoLogicalDeleteResource.Success");
			doLogicalDeleteResourceResponse.Message = context.StringValue("DoLogicalDeleteResource.Message");
        
			return doLogicalDeleteResourceResponse;
        }
    }
}
