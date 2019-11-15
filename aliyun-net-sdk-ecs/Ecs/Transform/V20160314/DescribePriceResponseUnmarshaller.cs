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
    public class DescribePriceResponseUnmarshaller
    {
        public static DescribePriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePriceResponse describePriceResponse = new DescribePriceResponse();

			describePriceResponse.HttpResponse = context.HttpResponse;
			describePriceResponse.RequestId = context.StringValue("DescribePrice.RequestId");

			DescribePriceResponse.DescribePrice_PriceInfo priceInfo = new DescribePriceResponse.DescribePrice_PriceInfo();

			List<string> priceInfo_orderParams = new List<string>();
			for (int i = 0; i < context.Length("DescribePrice.PriceInfo.OrderParams.Length"); i++) {
				priceInfo_orderParams.Add(context.StringValue("DescribePrice.PriceInfo.OrderParams["+ i +"]"));
			}
			priceInfo.OrderParams = priceInfo_orderParams;

			DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Order order = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Order();
			order.OriginalPrice = context.FloatValue("DescribePrice.PriceInfo.Order.OriginalPrice");
			order.DiscountPrice = context.FloatValue("DescribePrice.PriceInfo.Order.DiscountPrice");
			order.SpotInstanceTypePrice = context.FloatValue("DescribePrice.PriceInfo.Order.SpotInstanceTypePrice");
			order.SpotInstanceTypeOriginalPrice = context.FloatValue("DescribePrice.PriceInfo.Order.SpotInstanceTypeOriginalPrice");
			order.TradePrice = context.FloatValue("DescribePrice.PriceInfo.Order.TradePrice");
			order.Currency = context.StringValue("DescribePrice.PriceInfo.Order.Currency");

			List<string> order_ruleIdSet = new List<string>();
			for (int i = 0; i < context.Length("DescribePrice.PriceInfo.Order.RuleIdSet.Length"); i++) {
				order_ruleIdSet.Add(context.StringValue("DescribePrice.PriceInfo.Order.RuleIdSet["+ i +"]"));
			}
			order.RuleIdSet = order_ruleIdSet;

			List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Order.DescribePrice_Coupon> order_coupons = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Order.DescribePrice_Coupon>();
			for (int i = 0; i < context.Length("DescribePrice.PriceInfo.Order.Coupons.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Order.DescribePrice_Coupon coupon = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Order.DescribePrice_Coupon();
				coupon.CouponNo = context.StringValue("DescribePrice.PriceInfo.Order.Coupons["+ i +"].CouponNo");
				coupon.Name = context.StringValue("DescribePrice.PriceInfo.Order.Coupons["+ i +"].Name");
				coupon.Description = context.StringValue("DescribePrice.PriceInfo.Order.Coupons["+ i +"].Description");
				coupon.DiscountOff = context.FloatValue("DescribePrice.PriceInfo.Order.Coupons["+ i +"].DiscountOff");
				coupon.IsSelected = context.BooleanValue("DescribePrice.PriceInfo.Order.Coupons["+ i +"].IsSelected");

				List<string> coupon_ruleIdSet1 = new List<string>();
				for (int j = 0; j < context.Length("DescribePrice.PriceInfo.Order.Coupons["+ i +"].RuleIdSet.Length"); j++) {
					coupon_ruleIdSet1.Add(context.StringValue("DescribePrice.PriceInfo.Order.Coupons["+ i +"].RuleIdSet["+ j +"]"));
				}
				coupon.RuleIdSet1 = coupon_ruleIdSet1;

				order_coupons.Add(coupon);
			}
			order.Coupons = order_coupons;
			priceInfo.Order = order;

			DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_PriceWarning priceWarning = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_PriceWarning();
			priceWarning.Code = context.StringValue("DescribePrice.PriceInfo.PriceWarning.Code");
			priceWarning.Msg = context.StringValue("DescribePrice.PriceInfo.PriceWarning.Msg");
			priceInfo.PriceWarning = priceWarning;

			List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule> priceInfo_rules = new List<DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule>();
			for (int i = 0; i < context.Length("DescribePrice.PriceInfo.Rules.Length"); i++) {
				DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule rule = new DescribePriceResponse.DescribePrice_PriceInfo.DescribePrice_Rule();
				rule.RuleId = context.LongValue("DescribePrice.PriceInfo.Rules["+ i +"].RuleId");
				rule.Title = context.StringValue("DescribePrice.PriceInfo.Rules["+ i +"].Title");
				rule.Name = context.StringValue("DescribePrice.PriceInfo.Rules["+ i +"].Name");

				priceInfo_rules.Add(rule);
			}
			priceInfo.Rules = priceInfo_rules;
			describePriceResponse.PriceInfo = priceInfo;
        
			return describePriceResponse;
        }
    }
}
