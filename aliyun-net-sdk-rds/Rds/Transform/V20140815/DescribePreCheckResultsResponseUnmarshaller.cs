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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribePreCheckResultsResponseUnmarshaller
    {
        public static DescribePreCheckResultsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePreCheckResultsResponse describePreCheckResultsResponse = new DescribePreCheckResultsResponse();

			describePreCheckResultsResponse.HttpResponse = context.HttpResponse;
			describePreCheckResultsResponse.RequestId = context.StringValue("DescribePreCheckResults.RequestId");
			describePreCheckResultsResponse.DBInstanceId = context.StringValue("DescribePreCheckResults.DBInstanceId");

			List<DescribePreCheckResultsResponse.DescribePreCheckResults_PreCheckResult> describePreCheckResultsResponse_items = new List<DescribePreCheckResultsResponse.DescribePreCheckResults_PreCheckResult>();
			for (int i = 0; i < context.Length("DescribePreCheckResults.Items.Length"); i++) {
				DescribePreCheckResultsResponse.DescribePreCheckResults_PreCheckResult preCheckResult = new DescribePreCheckResultsResponse.DescribePreCheckResults_PreCheckResult();
				preCheckResult.PreCheckName = context.StringValue("DescribePreCheckResults.Items["+ i +"].PreCheckName");
				preCheckResult.PreCheckResult = context.StringValue("DescribePreCheckResults.Items["+ i +"].PreCheckResult");
				preCheckResult.FailReasion = context.StringValue("DescribePreCheckResults.Items["+ i +"].FailReasion");
				preCheckResult.RepairMethod = context.StringValue("DescribePreCheckResults.Items["+ i +"].RepairMethod");

				describePreCheckResultsResponse_items.Add(preCheckResult);
			}
			describePreCheckResultsResponse.Items = describePreCheckResultsResponse_items;
        
			return describePreCheckResultsResponse;
        }
    }
}
