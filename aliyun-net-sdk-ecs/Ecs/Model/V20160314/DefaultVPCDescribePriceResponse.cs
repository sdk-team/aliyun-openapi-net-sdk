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
	public class DefaultVPCDescribePriceResponse : AcsResponse
	{

		private string requestId;

		private DefaultVPCDescribePrice_PriceInfo priceInfo;

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

		public DefaultVPCDescribePrice_PriceInfo PriceInfo
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

		public class DefaultVPCDescribePrice_PriceInfo
		{

			private List<DefaultVPCDescribePrice_Rule> rules;

			private DefaultVPCDescribePrice_Order order;

			public List<DefaultVPCDescribePrice_Rule> Rules
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

			public DefaultVPCDescribePrice_Order Order
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

			public class DefaultVPCDescribePrice_Rule
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

			public class DefaultVPCDescribePrice_Order
			{

				private float? originalPrice;

				private float? discountPrice;

				private float? tradePrice;

				private string currency;

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
			}
		}
	}
}
