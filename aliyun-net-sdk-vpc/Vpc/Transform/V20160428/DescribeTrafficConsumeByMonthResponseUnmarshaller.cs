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
    public class DescribeTrafficConsumeByMonthResponseUnmarshaller
    {
        public static DescribeTrafficConsumeByMonthResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrafficConsumeByMonthResponse describeTrafficConsumeByMonthResponse = new DescribeTrafficConsumeByMonthResponse();

			describeTrafficConsumeByMonthResponse.HttpResponse = context.HttpResponse;
			describeTrafficConsumeByMonthResponse.RequestId = context.StringValue("DescribeTrafficConsumeByMonth.RequestId");

			List<DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary> describeTrafficConsumeByMonthResponse_productTrafficConsumeSummaryList = new List<DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary>();
			for (int i = 0; i < context.Length("DescribeTrafficConsumeByMonth.ProductTrafficConsumeSummaryList.Length"); i++) {
				DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary productTrafficConsumeSummary = new DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary();
				productTrafficConsumeSummary.ProductName = context.StringValue("DescribeTrafficConsumeByMonth.ProductTrafficConsumeSummaryList["+ i +"].ProductName");

				List<DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary.DescribeTrafficConsumeByMonth_RegionConsumeSummary> productTrafficConsumeSummary_regionConsumeSummaryList = new List<DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary.DescribeTrafficConsumeByMonth_RegionConsumeSummary>();
				for (int j = 0; j < context.Length("DescribeTrafficConsumeByMonth.ProductTrafficConsumeSummaryList["+ i +"].RegionConsumeSummaryList.Length"); j++) {
					DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary.DescribeTrafficConsumeByMonth_RegionConsumeSummary regionConsumeSummary = new DescribeTrafficConsumeByMonthResponse.DescribeTrafficConsumeByMonth_ProductTrafficConsumeSummary.DescribeTrafficConsumeByMonth_RegionConsumeSummary();
					regionConsumeSummary.Region = context.StringValue("DescribeTrafficConsumeByMonth.ProductTrafficConsumeSummaryList["+ i +"].RegionConsumeSummaryList["+ j +"].Region");
					regionConsumeSummary.MonthTrafficSummary = context.StringValue("DescribeTrafficConsumeByMonth.ProductTrafficConsumeSummaryList["+ i +"].RegionConsumeSummaryList["+ j +"].MonthTrafficSummary");

					productTrafficConsumeSummary_regionConsumeSummaryList.Add(regionConsumeSummary);
				}
				productTrafficConsumeSummary.RegionConsumeSummaryList = productTrafficConsumeSummary_regionConsumeSummaryList;

				describeTrafficConsumeByMonthResponse_productTrafficConsumeSummaryList.Add(productTrafficConsumeSummary);
			}
			describeTrafficConsumeByMonthResponse.ProductTrafficConsumeSummaryList = describeTrafficConsumeByMonthResponse_productTrafficConsumeSummaryList;
        
			return describeTrafficConsumeByMonthResponse;
        }
    }
}
