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
    public class DescribeEipAddressesByBwpResponseUnmarshaller
    {
        public static DescribeEipAddressesByBwpResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEipAddressesByBwpResponse describeEipAddressesByBwpResponse = new DescribeEipAddressesByBwpResponse();

			describeEipAddressesByBwpResponse.HttpResponse = context.HttpResponse;
			describeEipAddressesByBwpResponse.RequestId = context.StringValue("DescribeEipAddressesByBwp.RequestId");
			describeEipAddressesByBwpResponse.TotalCount = context.IntegerValue("DescribeEipAddressesByBwp.TotalCount");
			describeEipAddressesByBwpResponse.PageNumber = context.IntegerValue("DescribeEipAddressesByBwp.PageNumber");
			describeEipAddressesByBwpResponse.PageSize = context.IntegerValue("DescribeEipAddressesByBwp.PageSize");

			List<DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress> describeEipAddressesByBwpResponse_eipAddresses = new List<DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress>();
			for (int i = 0; i < context.Length("DescribeEipAddressesByBwp.EipAddresses.Length"); i++) {
				DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress eipAddress = new DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress();
				eipAddress.RegionId = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].RegionId");
				eipAddress.IpAddress = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].IpAddress");
				eipAddress.AllocationId = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].AllocationId");
				eipAddress.Status = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].Status");
				eipAddress.InstanceId = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].InstanceId");
				eipAddress.Bandwidth = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].Bandwidth");
				eipAddress.ISP = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].ISP");
				eipAddress.EipBandwidth = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].EipBandwidth");
				eipAddress.InternetChargeType = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].InternetChargeType");
				eipAddress.AllocationTime = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].AllocationTime");
				eipAddress.InstanceType = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].InstanceType");
				eipAddress.InstanceRegionId = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].InstanceRegionId");
				eipAddress.ChargeType = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].ChargeType");
				eipAddress.ExpiredTime = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].ExpiredTime");
				eipAddress.Name = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].Name");
				eipAddress.Descritpion = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].Descritpion");
				eipAddress.BandwidthPackageId = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].BandwidthPackageId");
				eipAddress.BandwidthPackageType = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].BandwidthPackageType");

				List<string> eipAddress_availableRegions = new List<string>();
				for (int j = 0; j < context.Length("DescribeEipAddressesByBwp.EipAddresses["+ i +"].AvailableRegions.Length"); j++) {
					eipAddress_availableRegions.Add(context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].AvailableRegions["+ j +"]"));
				}
				eipAddress.AvailableRegions = eipAddress_availableRegions;

				List<DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress.DescribeEipAddressesByBwp_LockReason> eipAddress_operationLocks = new List<DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress.DescribeEipAddressesByBwp_LockReason>();
				for (int j = 0; j < context.Length("DescribeEipAddressesByBwp.EipAddresses["+ i +"].OperationLocks.Length"); j++) {
					DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress.DescribeEipAddressesByBwp_LockReason lockReason = new DescribeEipAddressesByBwpResponse.DescribeEipAddressesByBwp_EipAddress.DescribeEipAddressesByBwp_LockReason();
					lockReason.LockReason = context.StringValue("DescribeEipAddressesByBwp.EipAddresses["+ i +"].OperationLocks["+ j +"].LockReason");

					eipAddress_operationLocks.Add(lockReason);
				}
				eipAddress.OperationLocks = eipAddress_operationLocks;

				describeEipAddressesByBwpResponse_eipAddresses.Add(eipAddress);
			}
			describeEipAddressesByBwpResponse.EipAddresses = describeEipAddressesByBwpResponse_eipAddresses;
        
			return describeEipAddressesByBwpResponse;
        }
    }
}
