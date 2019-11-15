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
using Aliyun.Acs.Ecs.Model.V20160314;

namespace Aliyun.Acs.Ecs.Transform.V20160314
{
    public class DefaultVPCRunInstancesResponseUnmarshaller
    {
        public static DefaultVPCRunInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DefaultVPCRunInstancesResponse defaultVPCRunInstancesResponse = new DefaultVPCRunInstancesResponse();

			defaultVPCRunInstancesResponse.HttpResponse = context.HttpResponse;
			defaultVPCRunInstancesResponse.RequestId = context.StringValue("DefaultVPCRunInstances.RequestId");
			defaultVPCRunInstancesResponse.TaskId = context.StringValue("DefaultVPCRunInstances.TaskId");

			List<string> defaultVPCRunInstancesResponse_instanceIdSets = new List<string>();
			for (int i = 0; i < context.Length("DefaultVPCRunInstances.InstanceIdSets.Length"); i++) {
				defaultVPCRunInstancesResponse_instanceIdSets.Add(context.StringValue("DefaultVPCRunInstances.InstanceIdSets["+ i +"]"));
			}
			defaultVPCRunInstancesResponse.InstanceIdSets = defaultVPCRunInstancesResponse_instanceIdSets;
        
			return defaultVPCRunInstancesResponse;
        }
    }
}
