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
    public class DescribeReservedInstancePriceResponseUnmarshaller
    {
        public static DescribeReservedInstancePriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReservedInstancePriceResponse describeReservedInstancePriceResponse = new DescribeReservedInstancePriceResponse();

			describeReservedInstancePriceResponse.HttpResponse = context.HttpResponse;
			describeReservedInstancePriceResponse.RequestId = context.StringValue("DescribeReservedInstancePrice.RequestId");

			DescribeReservedInstancePriceResponse.DescribeReservedInstancePrice_PriceInfo priceInfo = new DescribeReservedInstancePriceResponse.DescribeReservedInstancePrice_PriceInfo();

			DescribeReservedInstancePriceResponse.DescribeReservedInstancePrice_PriceInfo.DescribeReservedInstancePrice_Order order = new DescribeReservedInstancePriceResponse.DescribeReservedInstancePrice_PriceInfo.DescribeReservedInstancePrice_Order();
			order.ReservedInstanceHourPrice = context.FloatValue("DescribeReservedInstancePrice.PriceInfo.Order.ReservedInstanceHourPrice");
			order.TradePrice = context.FloatValue("DescribeReservedInstancePrice.PriceInfo.Order.TradePrice");
			order.Currency = context.StringValue("DescribeReservedInstancePrice.PriceInfo.Order.Currency");
			priceInfo.Order = order;
			describeReservedInstancePriceResponse.PriceInfo = priceInfo;
        
			return describeReservedInstancePriceResponse;
        }
    }
}
