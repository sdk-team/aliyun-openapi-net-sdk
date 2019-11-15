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
    public class DescribeCapacityReservationResponseUnmarshaller
    {
        public static DescribeCapacityReservationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCapacityReservationResponse describeCapacityReservationResponse = new DescribeCapacityReservationResponse();

			describeCapacityReservationResponse.HttpResponse = context.HttpResponse;
			describeCapacityReservationResponse.RequestId = context.StringValue("DescribeCapacityReservation.RequestId");
			describeCapacityReservationResponse.TotalCount = context.IntegerValue("DescribeCapacityReservation.TotalCount");
			describeCapacityReservationResponse.PageNumber = context.IntegerValue("DescribeCapacityReservation.PageNumber");
			describeCapacityReservationResponse.PageSize = context.IntegerValue("DescribeCapacityReservation.PageSize");

			List<DescribeCapacityReservationResponse.DescribeCapacityReservation_CapacityReservation> describeCapacityReservationResponse_capacityReservations = new List<DescribeCapacityReservationResponse.DescribeCapacityReservation_CapacityReservation>();
			for (int i = 0; i < context.Length("DescribeCapacityReservation.CapacityReservations.Length"); i++) {
				DescribeCapacityReservationResponse.DescribeCapacityReservation_CapacityReservation capacityReservation = new DescribeCapacityReservationResponse.DescribeCapacityReservation_CapacityReservation();
				capacityReservation.CapacityReservationId = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].CapacityReservationId");
				capacityReservation.RegionId = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].RegionId");
				capacityReservation.ZoneId = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].ZoneId");
				capacityReservation.CapacityReservationName = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].CapacityReservationName");
				capacityReservation.Status = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].Status");
				capacityReservation.Description = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].Description");
				capacityReservation.InstancePlatform = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].InstancePlatform");
				capacityReservation.TotalInstanceCount = context.IntegerValue("DescribeCapacityReservation.CapacityReservations["+ i +"].TotalInstanceCount");
				capacityReservation.AvailableInstanceCount = context.IntegerValue("DescribeCapacityReservation.CapacityReservations["+ i +"].AvailableInstanceCount");
				capacityReservation.NetworkType = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].NetworkType");
				capacityReservation.EndDateType = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].EndDateType");
				capacityReservation.InstanceMatchCriteria = context.StringValue("DescribeCapacityReservation.CapacityReservations["+ i +"].InstanceMatchCriteria");

				describeCapacityReservationResponse_capacityReservations.Add(capacityReservation);
			}
			describeCapacityReservationResponse.CapacityReservations = describeCapacityReservationResponse_capacityReservations;
        
			return describeCapacityReservationResponse;
        }
    }
}
