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
    public class DescribeReservedInstancePricesResponseUnmarshaller
    {
        public static DescribeReservedInstancePricesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReservedInstancePricesResponse describeReservedInstancePricesResponse = new DescribeReservedInstancePricesResponse();

			describeReservedInstancePricesResponse.HttpResponse = context.HttpResponse;
			describeReservedInstancePricesResponse.RequestId = context.StringValue("DescribeReservedInstancePrices.RequestId");

			List<DescribeReservedInstancePricesResponse.DescribeReservedInstancePrices_ReservedInstance> describeReservedInstancePricesResponse_reservedInstances = new List<DescribeReservedInstancePricesResponse.DescribeReservedInstancePrices_ReservedInstance>();
			for (int i = 0; i < context.Length("DescribeReservedInstancePrices.ReservedInstances.Length"); i++) {
				DescribeReservedInstancePricesResponse.DescribeReservedInstancePrices_ReservedInstance reservedInstance = new DescribeReservedInstancePricesResponse.DescribeReservedInstancePrices_ReservedInstance();
				reservedInstance.ReservedInstanceId = context.StringValue("DescribeReservedInstancePrices.ReservedInstances["+ i +"].ReservedInstanceId");
				reservedInstance.ReservedInstanceHourPrice = context.FloatValue("DescribeReservedInstancePrices.ReservedInstances["+ i +"].ReservedInstanceHourPrice");
				reservedInstance.TradePrice = context.FloatValue("DescribeReservedInstancePrices.ReservedInstances["+ i +"].TradePrice");

				describeReservedInstancePricesResponse_reservedInstances.Add(reservedInstance);
			}
			describeReservedInstancePricesResponse.ReservedInstances = describeReservedInstancePricesResponse_reservedInstances;
        
			return describeReservedInstancePricesResponse;
        }
    }
}
