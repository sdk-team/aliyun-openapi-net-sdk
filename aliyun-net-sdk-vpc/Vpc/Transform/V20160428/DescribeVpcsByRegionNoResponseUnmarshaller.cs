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
    public class DescribeVpcsByRegionNoResponseUnmarshaller
    {
        public static DescribeVpcsByRegionNoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpcsByRegionNoResponse describeVpcsByRegionNoResponse = new DescribeVpcsByRegionNoResponse();

			describeVpcsByRegionNoResponse.HttpResponse = context.HttpResponse;
			describeVpcsByRegionNoResponse.RequestId = context.StringValue("DescribeVpcsByRegionNo.RequestId");

			List<DescribeVpcsByRegionNoResponse.DescribeVpcsByRegionNo_Vpc> describeVpcsByRegionNoResponse_data = new List<DescribeVpcsByRegionNoResponse.DescribeVpcsByRegionNo_Vpc>();
			for (int i = 0; i < context.Length("DescribeVpcsByRegionNo.Data.Length"); i++) {
				DescribeVpcsByRegionNoResponse.DescribeVpcsByRegionNo_Vpc vpc = new DescribeVpcsByRegionNoResponse.DescribeVpcsByRegionNo_Vpc();
				vpc.Text = context.StringValue("DescribeVpcsByRegionNo.Data["+ i +"].Text");
				vpc._Value = context.StringValue("DescribeVpcsByRegionNo.Data["+ i +"].Value");

				describeVpcsByRegionNoResponse_data.Add(vpc);
			}
			describeVpcsByRegionNoResponse.Data = describeVpcsByRegionNoResponse_data;
        
			return describeVpcsByRegionNoResponse;
        }
    }
}
