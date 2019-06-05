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
    public class DescribePublicIpAddressResponseUnmarshaller
    {
        public static DescribePublicIpAddressResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePublicIpAddressResponse describePublicIpAddressResponse = new DescribePublicIpAddressResponse();

			describePublicIpAddressResponse.HttpResponse = context.HttpResponse;
			describePublicIpAddressResponse.RequestId = context.StringValue("DescribePublicIpAddress.RequestId");
			describePublicIpAddressResponse.Code = context.StringValue("DescribePublicIpAddress.Code");
			describePublicIpAddressResponse.Message = context.StringValue("DescribePublicIpAddress.Message");
			describePublicIpAddressResponse.Success = context.BooleanValue("DescribePublicIpAddress.Success");
			describePublicIpAddressResponse.PublicIpAddress = context.StringValue("DescribePublicIpAddress.PublicIpAddress");
			describePublicIpAddressResponse.RegionId = context.StringValue("DescribePublicIpAddress.RegionId");
			describePublicIpAddressResponse.PageNumber = context.IntegerValue("DescribePublicIpAddress.PageNumber");
			describePublicIpAddressResponse.PageSize = context.IntegerValue("DescribePublicIpAddress.PageSize");
			describePublicIpAddressResponse.TotalCount = context.IntegerValue("DescribePublicIpAddress.TotalCount");
        
			return describePublicIpAddressResponse;
        }
    }
}
