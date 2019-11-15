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
    public class DescribeReservedInstancesPriceResponseUnmarshaller
    {
        public static DescribeReservedInstancesPriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReservedInstancesPriceResponse describeReservedInstancesPriceResponse = new DescribeReservedInstancesPriceResponse();

			describeReservedInstancesPriceResponse.HttpResponse = context.HttpResponse;
			describeReservedInstancesPriceResponse.RequestId = context.StringValue("DescribeReservedInstancesPrice.RequestId");

			List<DescribeReservedInstancesPriceResponse.DescribeReservedInstancesPrice_ReservedInstance> describeReservedInstancesPriceResponse_reservedInstances = new List<DescribeReservedInstancesPriceResponse.DescribeReservedInstancesPrice_ReservedInstance>();
			for (int i = 0; i < context.Length("DescribeReservedInstancesPrice.ReservedInstances.Length"); i++) {
				DescribeReservedInstancesPriceResponse.DescribeReservedInstancesPrice_ReservedInstance reservedInstance = new DescribeReservedInstancesPriceResponse.DescribeReservedInstancesPrice_ReservedInstance();
				reservedInstance.ReservedInstanceId = context.StringValue("DescribeReservedInstancesPrice.ReservedInstances["+ i +"].ReservedInstanceId");
				reservedInstance.ReservedInstanceHourPrice = context.FloatValue("DescribeReservedInstancesPrice.ReservedInstances["+ i +"].ReservedInstanceHourPrice");
				reservedInstance.TradePrice = context.FloatValue("DescribeReservedInstancesPrice.ReservedInstances["+ i +"].TradePrice");

				describeReservedInstancesPriceResponse_reservedInstances.Add(reservedInstance);
			}
			describeReservedInstancesPriceResponse.ReservedInstances = describeReservedInstancesPriceResponse_reservedInstances;
        
			return describeReservedInstancesPriceResponse;
        }
    }
}
