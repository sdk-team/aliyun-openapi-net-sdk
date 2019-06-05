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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeGrantRulesToCbnResponseUnmarshaller
    {
        public static DescribeGrantRulesToCbnResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGrantRulesToCbnResponse describeGrantRulesToCbnResponse = new DescribeGrantRulesToCbnResponse();

			describeGrantRulesToCbnResponse.HttpResponse = context.HttpResponse;
			describeGrantRulesToCbnResponse.RequestId = context.StringValue("DescribeGrantRulesToCbn.RequestId");
			describeGrantRulesToCbnResponse.TotalCount = context.IntegerValue("DescribeGrantRulesToCbn.TotalCount");
			describeGrantRulesToCbnResponse.PageNumber = context.IntegerValue("DescribeGrantRulesToCbn.PageNumber");
			describeGrantRulesToCbnResponse.PageSize = context.IntegerValue("DescribeGrantRulesToCbn.PageSize");

			List<DescribeGrantRulesToCbnResponse.DescribeGrantRulesToCbn_CbnGrantRule> describeGrantRulesToCbnResponse_cbnGrantRules = new List<DescribeGrantRulesToCbnResponse.DescribeGrantRulesToCbn_CbnGrantRule>();
			for (int i = 0; i < context.Length("DescribeGrantRulesToCbn.CbnGrantRules.Length"); i++) {
				DescribeGrantRulesToCbnResponse.DescribeGrantRulesToCbn_CbnGrantRule cbnGrantRule = new DescribeGrantRulesToCbnResponse.DescribeGrantRulesToCbn_CbnGrantRule();
				cbnGrantRule.CbnInstanceId = context.StringValue("DescribeGrantRulesToCbn.CbnGrantRules["+ i +"].CbnInstanceId");
				cbnGrantRule.CbnOwnerId = context.LongValue("DescribeGrantRulesToCbn.CbnGrantRules["+ i +"].CbnOwnerId");
				cbnGrantRule.CreationTime = context.StringValue("DescribeGrantRulesToCbn.CbnGrantRules["+ i +"].CreationTime");

				describeGrantRulesToCbnResponse_cbnGrantRules.Add(cbnGrantRule);
			}
			describeGrantRulesToCbnResponse.CbnGrantRules = describeGrantRulesToCbnResponse_cbnGrantRules;
        
			return describeGrantRulesToCbnResponse;
        }
    }
}
