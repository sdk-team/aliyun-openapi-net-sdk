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
    public class DescribeBandwidthPriceResponseUnmarshaller
    {
        public static DescribeBandwidthPriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBandwidthPriceResponse describeBandwidthPriceResponse = new DescribeBandwidthPriceResponse();

			describeBandwidthPriceResponse.HttpResponse = context.HttpResponse;
			describeBandwidthPriceResponse.RequestId = context.StringValue("DescribeBandwidthPrice.RequestId");

			DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo priceInfo = new DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo();

			DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo.DescribeBandwidthPrice_Order order = new DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo.DescribeBandwidthPrice_Order();
			order.OriginalPrice = context.FloatValue("DescribeBandwidthPrice.PriceInfo.Order.OriginalPrice");
			order.DiscountPrice = context.FloatValue("DescribeBandwidthPrice.PriceInfo.Order.DiscountPrice");
			order.TradePrice = context.FloatValue("DescribeBandwidthPrice.PriceInfo.Order.TradePrice");
			order.Currency = context.StringValue("DescribeBandwidthPrice.PriceInfo.Order.Currency");

			List<string> order_ruleIdSet = new List<string>();
			for (int i = 0; i < context.Length("DescribeBandwidthPrice.PriceInfo.Order.RuleIdSet.Length"); i++) {
				order_ruleIdSet.Add(context.StringValue("DescribeBandwidthPrice.PriceInfo.Order.RuleIdSet["+ i +"]"));
			}
			order.RuleIdSet = order_ruleIdSet;
			priceInfo.Order = order;

			List<DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo.DescribeBandwidthPrice_Rule> priceInfo_rules = new List<DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo.DescribeBandwidthPrice_Rule>();
			for (int i = 0; i < context.Length("DescribeBandwidthPrice.PriceInfo.Rules.Length"); i++) {
				DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo.DescribeBandwidthPrice_Rule rule = new DescribeBandwidthPriceResponse.DescribeBandwidthPrice_PriceInfo.DescribeBandwidthPrice_Rule();
				rule.RuleId = context.LongValue("DescribeBandwidthPrice.PriceInfo.Rules["+ i +"].RuleId");
				rule.Title = context.StringValue("DescribeBandwidthPrice.PriceInfo.Rules["+ i +"].Title");
				rule.Name = context.StringValue("DescribeBandwidthPrice.PriceInfo.Rules["+ i +"].Name");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			describeBandwidthPriceResponse.PriceInfo = priceInfo;
        
			return describeBandwidthPriceResponse;
        }
    }
}
