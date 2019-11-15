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
    public class DefaultVPCDescribePriceResponseUnmarshaller
    {
        public static DefaultVPCDescribePriceResponse Unmarshall(UnmarshallerContext context)
        {
			DefaultVPCDescribePriceResponse defaultVPCDescribePriceResponse = new DefaultVPCDescribePriceResponse();

			defaultVPCDescribePriceResponse.HttpResponse = context.HttpResponse;
			defaultVPCDescribePriceResponse.RequestId = context.StringValue("DefaultVPCDescribePrice.RequestId");

			DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo priceInfo = new DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo();

			DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo.DefaultVPCDescribePrice_Order order = new DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo.DefaultVPCDescribePrice_Order();
			order.OriginalPrice = context.FloatValue("DefaultVPCDescribePrice.PriceInfo.Order.OriginalPrice");
			order.DiscountPrice = context.FloatValue("DefaultVPCDescribePrice.PriceInfo.Order.DiscountPrice");
			order.TradePrice = context.FloatValue("DefaultVPCDescribePrice.PriceInfo.Order.TradePrice");
			order.Currency = context.StringValue("DefaultVPCDescribePrice.PriceInfo.Order.Currency");

			List<string> order_ruleIdSet = new List<string>();
			for (int i = 0; i < context.Length("DefaultVPCDescribePrice.PriceInfo.Order.RuleIdSet.Length"); i++) {
				order_ruleIdSet.Add(context.StringValue("DefaultVPCDescribePrice.PriceInfo.Order.RuleIdSet["+ i +"]"));
			}
			order.RuleIdSet = order_ruleIdSet;
			priceInfo.Order = order;

			List<DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo.DefaultVPCDescribePrice_Rule> priceInfo_rules = new List<DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo.DefaultVPCDescribePrice_Rule>();
			for (int i = 0; i < context.Length("DefaultVPCDescribePrice.PriceInfo.Rules.Length"); i++) {
				DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo.DefaultVPCDescribePrice_Rule rule = new DefaultVPCDescribePriceResponse.DefaultVPCDescribePrice_PriceInfo.DefaultVPCDescribePrice_Rule();
				rule.RuleId = context.LongValue("DefaultVPCDescribePrice.PriceInfo.Rules["+ i +"].RuleId");
				rule.Title = context.StringValue("DefaultVPCDescribePrice.PriceInfo.Rules["+ i +"].Title");
				rule.Name = context.StringValue("DefaultVPCDescribePrice.PriceInfo.Rules["+ i +"].Name");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			defaultVPCDescribePriceResponse.PriceInfo = priceInfo;
        
			return defaultVPCDescribePriceResponse;
        }
    }
}
