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
    public class DescribeAccountLimitsResponseUnmarshaller
    {
        public static DescribeAccountLimitsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountLimitsResponse describeAccountLimitsResponse = new DescribeAccountLimitsResponse();

			describeAccountLimitsResponse.HttpResponse = context.HttpResponse;
			describeAccountLimitsResponse.RequestId = context.StringValue("DescribeAccountLimits.RequestId");

			List<DescribeAccountLimitsResponse.DescribeAccountLimits_AccountLimit> describeAccountLimitsResponse_accountLimitTypeSet = new List<DescribeAccountLimitsResponse.DescribeAccountLimits_AccountLimit>();
			for (int i = 0; i < context.Length("DescribeAccountLimits.AccountLimitTypeSet.Length"); i++) {
				DescribeAccountLimitsResponse.DescribeAccountLimits_AccountLimit accountLimit = new DescribeAccountLimitsResponse.DescribeAccountLimits_AccountLimit();
				accountLimit.LimitName = context.StringValue("DescribeAccountLimits.AccountLimitTypeSet["+ i +"].LimitName");

				List<string> accountLimit_limitValueSet = new List<string>();
				for (int j = 0; j < context.Length("DescribeAccountLimits.AccountLimitTypeSet["+ i +"].LimitValueSet.Length"); j++) {
					accountLimit_limitValueSet.Add(context.StringValue("DescribeAccountLimits.AccountLimitTypeSet["+ i +"].LimitValueSet["+ j +"]"));
				}
				accountLimit.LimitValueSet = accountLimit_limitValueSet;

				describeAccountLimitsResponse_accountLimitTypeSet.Add(accountLimit);
			}
			describeAccountLimitsResponse.AccountLimitTypeSet = describeAccountLimitsResponse_accountLimitTypeSet;
        
			return describeAccountLimitsResponse;
        }
    }
}
