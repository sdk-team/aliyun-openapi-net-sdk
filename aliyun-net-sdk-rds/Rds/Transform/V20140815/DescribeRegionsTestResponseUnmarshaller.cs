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
    public class DescribeRegionsTestResponseUnmarshaller
    {
        public static DescribeRegionsTestResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsTestResponse describeRegionsTestResponse = new DescribeRegionsTestResponse();

			describeRegionsTestResponse.HttpResponse = context.HttpResponse;
			describeRegionsTestResponse.RequestId = context.StringValue("DescribeRegionsTest.RequestId");

			List<DescribeRegionsTestResponse.DescribeRegionsTest_RDSRegion> describeRegionsTestResponse_regions = new List<DescribeRegionsTestResponse.DescribeRegionsTest_RDSRegion>();
			for (int i = 0; i < context.Length("DescribeRegionsTest.Regions.Length"); i++) {
				DescribeRegionsTestResponse.DescribeRegionsTest_RDSRegion rDSRegion = new DescribeRegionsTestResponse.DescribeRegionsTest_RDSRegion();
				rDSRegion.RegionId = context.StringValue("DescribeRegionsTest.Regions["+ i +"].RegionId");
				rDSRegion.ZoneId = context.StringValue("DescribeRegionsTest.Regions["+ i +"].ZoneId");

				describeRegionsTestResponse_regions.Add(rDSRegion);
			}
			describeRegionsTestResponse.Regions = describeRegionsTestResponse_regions;
        
			return describeRegionsTestResponse;
        }
    }
}
