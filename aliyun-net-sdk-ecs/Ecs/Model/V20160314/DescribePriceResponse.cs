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
	public class DescribePriceResponse : AcsResponse
	{

		private string requestId;

		private DescribePrice_PriceInfo priceInfo;

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

		public DescribePrice_PriceInfo PriceInfo
		{
			get
			{
				return priceInfo;
			}
			set	
			{
				priceInfo = value;
			}
		}

		public class DescribePrice_PriceInfo
		{

			private List<DescribePrice_Rule> rules;

			private List<string> orderParams;

			private DescribePrice_Order order;

			private DescribePrice_PriceWarning priceWarning;

			public List<DescribePrice_Rule> Rules
			{
				get
				{
					return rules;
				}
				set	
				{
					rules = value;
				}
			}

			public List<string> OrderParams
			{
				get
				{
					return orderParams;
				}
				set	
				{
					orderParams = value;
				}
			}

			public DescribePrice_Order Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}

			public DescribePrice_PriceWarning PriceWarning
			{
				get
				{
					return priceWarning;
				}
				set	
				{
					priceWarning = value;
				}
			}

			public class DescribePrice_Rule
			{

				private long? ruleId;

				private string title;

				private string name;

				public long? RuleId
				{
					get
					{
						return ruleId;
					}
					set	
					{
						ruleId = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}
			}

			public class DescribePrice_Order
			{

				private float? originalPrice;

				private float? discountPrice;

				private float? spotInstanceTypePrice;

				private float? spotInstanceTypeOriginalPrice;

				private float? tradePrice;

				private string currency;

				private List<DescribePrice_Coupon> coupons;

				private List<string> ruleIdSet;

				public float? OriginalPrice
				{
					get
					{
						return originalPrice;
					}
					set	
					{
						originalPrice = value;
					}
				}

				public float? DiscountPrice
				{
					get
					{
						return discountPrice;
					}
					set	
					{
						discountPrice = value;
					}
				}

				public float? SpotInstanceTypePrice
				{
					get
					{
						return spotInstanceTypePrice;
					}
					set	
					{
						spotInstanceTypePrice = value;
					}
				}

				public float? SpotInstanceTypeOriginalPrice
				{
					get
					{
						return spotInstanceTypeOriginalPrice;
					}
					set	
					{
						spotInstanceTypeOriginalPrice = value;
					}
				}

				public float? TradePrice
				{
					get
					{
						return tradePrice;
					}
					set	
					{
						tradePrice = value;
					}
				}

				public string Currency
				{
					get
					{
						return currency;
					}
					set	
					{
						currency = value;
					}
				}

				public List<DescribePrice_Coupon> Coupons
				{
					get
					{
						return coupons;
					}
					set	
					{
						coupons = value;
					}
				}

				public List<string> RuleIdSet
				{
					get
					{
						return ruleIdSet;
					}
					set	
					{
						ruleIdSet = value;
					}
				}

				public class DescribePrice_Coupon
				{

					private string couponNo;

					private string name;

					private string description;

					private float? discountOff;

					private bool? isSelected;

					private List<string> ruleIdSet1;

					public string CouponNo
					{
						get
						{
							return couponNo;
						}
						set	
						{
							couponNo = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
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

					public float? DiscountOff
					{
						get
						{
							return discountOff;
						}
						set	
						{
							discountOff = value;
						}
					}

					public bool? IsSelected
					{
						get
						{
							return isSelected;
						}
						set	
						{
							isSelected = value;
						}
					}

					public List<string> RuleIdSet1
					{
						get
						{
							return ruleIdSet1;
						}
						set	
						{
							ruleIdSet1 = value;
						}
					}
				}
			}

			public class DescribePrice_PriceWarning
			{

				private string code;

				private string msg;

				public string Code
				{
					get
					{
						return code;
					}
					set	
					{
						code = value;
					}
				}

				public string Msg
				{
					get
					{
						return msg;
					}
					set	
					{
						msg = value;
					}
				}
			}
		}
	}
}
