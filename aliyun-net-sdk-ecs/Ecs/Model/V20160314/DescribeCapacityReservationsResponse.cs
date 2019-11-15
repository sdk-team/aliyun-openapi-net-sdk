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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ecs.Model.V20160314
{
	public class DescribeCapacityReservationsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeCapacityReservations_CapacityReservation> capacityReservations;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeCapacityReservations_CapacityReservation> CapacityReservations
		{
			get
			{
				return capacityReservations;
			}
			set	
			{
				capacityReservations = value;
			}
		}

		public class DescribeCapacityReservations_CapacityReservation
		{

			private string capacityReservationId;

			private string regionId;

			private string zoneId;

			private string capacityReservationName;

			private string status;

			private string description;

			private string instancePlatform;

			private int? totalInstanceCount;

			private int? availableInstanceCount;

			private string networkType;

			private string endDateType;

			private string instanceMatchCriteria;

			private string instanceType;

			private string timeSlot;

			public string CapacityReservationId
			{
				get
				{
					return capacityReservationId;
				}
				set	
				{
					capacityReservationId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string CapacityReservationName
			{
				get
				{
					return capacityReservationName;
				}
				set	
				{
					capacityReservationName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string InstancePlatform
			{
				get
				{
					return instancePlatform;
				}
				set	
				{
					instancePlatform = value;
				}
			}

			public int? TotalInstanceCount
			{
				get
				{
					return totalInstanceCount;
				}
				set	
				{
					totalInstanceCount = value;
				}
			}

			public int? AvailableInstanceCount
			{
				get
				{
					return availableInstanceCount;
				}
				set	
				{
					availableInstanceCount = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string EndDateType
			{
				get
				{
					return endDateType;
				}
				set	
				{
					endDateType = value;
				}
			}

			public string InstanceMatchCriteria
			{
				get
				{
					return instanceMatchCriteria;
				}
				set	
				{
					instanceMatchCriteria = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string TimeSlot
			{
				get
				{
					return timeSlot;
				}
				set	
				{
					timeSlot = value;
				}
			}
		}
	}
}
