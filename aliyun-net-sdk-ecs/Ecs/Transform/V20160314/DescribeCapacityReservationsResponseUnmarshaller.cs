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
    public class DescribeCapacityReservationsResponseUnmarshaller
    {
        public static DescribeCapacityReservationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCapacityReservationsResponse describeCapacityReservationsResponse = new DescribeCapacityReservationsResponse();

			describeCapacityReservationsResponse.HttpResponse = context.HttpResponse;
			describeCapacityReservationsResponse.RequestId = context.StringValue("DescribeCapacityReservations.RequestId");
			describeCapacityReservationsResponse.TotalCount = context.IntegerValue("DescribeCapacityReservations.TotalCount");
			describeCapacityReservationsResponse.PageNumber = context.IntegerValue("DescribeCapacityReservations.PageNumber");
			describeCapacityReservationsResponse.PageSize = context.IntegerValue("DescribeCapacityReservations.PageSize");

			List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservation> describeCapacityReservationsResponse_capacityReservations = new List<DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservation>();
			for (int i = 0; i < context.Length("DescribeCapacityReservations.CapacityReservations.Length"); i++) {
				DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservation capacityReservation = new DescribeCapacityReservationsResponse.DescribeCapacityReservations_CapacityReservation();
				capacityReservation.CapacityReservationId = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].CapacityReservationId");
				capacityReservation.RegionId = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].RegionId");
				capacityReservation.ZoneId = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].ZoneId");
				capacityReservation.CapacityReservationName = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].CapacityReservationName");
				capacityReservation.Status = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].Status");
				capacityReservation.Description = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].Description");
				capacityReservation.InstancePlatform = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].InstancePlatform");
				capacityReservation.TotalInstanceCount = context.IntegerValue("DescribeCapacityReservations.CapacityReservations["+ i +"].TotalInstanceCount");
				capacityReservation.AvailableInstanceCount = context.IntegerValue("DescribeCapacityReservations.CapacityReservations["+ i +"].AvailableInstanceCount");
				capacityReservation.NetworkType = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].NetworkType");
				capacityReservation.EndDateType = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].EndDateType");
				capacityReservation.InstanceMatchCriteria = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].InstanceMatchCriteria");
				capacityReservation.InstanceType = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].InstanceType");
				capacityReservation.TimeSlot = context.StringValue("DescribeCapacityReservations.CapacityReservations["+ i +"].TimeSlot");

				describeCapacityReservationsResponse_capacityReservations.Add(capacityReservation);
			}
			describeCapacityReservationsResponse.CapacityReservations = describeCapacityReservationsResponse_capacityReservations;
        
			return describeCapacityReservationsResponse;
        }
    }
}
