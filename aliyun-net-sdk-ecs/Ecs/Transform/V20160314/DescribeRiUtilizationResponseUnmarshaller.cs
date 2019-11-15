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
    public class DescribeRiUtilizationResponseUnmarshaller
    {
        public static DescribeRiUtilizationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRiUtilizationResponse describeRiUtilizationResponse = new DescribeRiUtilizationResponse();

			describeRiUtilizationResponse.HttpResponse = context.HttpResponse;
			describeRiUtilizationResponse.RequestId = context.StringValue("DescribeRiUtilization.RequestId");

			List<DescribeRiUtilizationResponse.DescribeRiUtilization_Utilization> describeRiUtilizationResponse_utilizations = new List<DescribeRiUtilizationResponse.DescribeRiUtilization_Utilization>();
			for (int i = 0; i < context.Length("DescribeRiUtilization.Utilizations.Length"); i++) {
				DescribeRiUtilizationResponse.DescribeRiUtilization_Utilization utilization = new DescribeRiUtilizationResponse.DescribeRiUtilization_Utilization();
				utilization.InstanceId = context.StringValue("DescribeRiUtilization.Utilizations["+ i +"].InstanceId");
				utilization.Utilization = context.StringValue("DescribeRiUtilization.Utilizations["+ i +"].Utilization");

				describeRiUtilizationResponse_utilizations.Add(utilization);
			}
			describeRiUtilizationResponse.Utilizations = describeRiUtilizationResponse_utilizations;
        
			return describeRiUtilizationResponse;
        }
    }
}
