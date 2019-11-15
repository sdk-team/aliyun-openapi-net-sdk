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
    public class DescribeResourceAllocationResponseUnmarshaller
    {
        public static DescribeResourceAllocationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResourceAllocationResponse describeResourceAllocationResponse = new DescribeResourceAllocationResponse();

			describeResourceAllocationResponse.HttpResponse = context.HttpResponse;
			describeResourceAllocationResponse.RequestId = context.StringValue("DescribeResourceAllocation.RequestId");

			DescribeResourceAllocationResponse.DescribeResourceAllocation_ResourcePlanningResponse resourcePlanningResponse = new DescribeResourceAllocationResponse.DescribeResourceAllocation_ResourcePlanningResponse();
			resourcePlanningResponse.SatisfiedAmount = context.IntegerValue("DescribeResourceAllocation.ResourcePlanningResponse.SatisfiedAmount");

			List<DescribeResourceAllocationResponse.DescribeResourceAllocation_ResourcePlanningResponse.DescribeResourceAllocation_ResourceModel> resourcePlanningResponse_resourceModels = new List<DescribeResourceAllocationResponse.DescribeResourceAllocation_ResourcePlanningResponse.DescribeResourceAllocation_ResourceModel>();
			for (int i = 0; i < context.Length("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels.Length"); i++) {
				DescribeResourceAllocationResponse.DescribeResourceAllocation_ResourcePlanningResponse.DescribeResourceAllocation_ResourceModel resourceModel = new DescribeResourceAllocationResponse.DescribeResourceAllocation_ResourcePlanningResponse.DescribeResourceAllocation_ResourceModel();
				resourceModel.RegionId = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].regionId");
				resourceModel.ZoneId = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].ZoneId");
				resourceModel.InstanceType = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].InstanceType");
				resourceModel.NetworkType = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].NetworkType");
				resourceModel.IoOptimized = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].IoOptimized");
				resourceModel.InstanceChargeType = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].InstanceChargeType");
				resourceModel.SpotStrategy = context.StringValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].SpotStrategy");
				resourceModel.Price = context.FloatValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].Price");
				resourceModel.Amount = context.IntegerValue("DescribeResourceAllocation.ResourcePlanningResponse.ResourceModels["+ i +"].Amount");

				resourcePlanningResponse_resourceModels.Add(resourceModel);
			}
			resourcePlanningResponse.ResourceModels = resourcePlanningResponse_resourceModels;
			describeResourceAllocationResponse.ResourcePlanningResponse = resourcePlanningResponse;
        
			return describeResourceAllocationResponse;
        }
    }
}
