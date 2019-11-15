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
    public class DescribeDedicatedHostTypesResponseUnmarshaller
    {
        public static DescribeDedicatedHostTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostTypesResponse describeDedicatedHostTypesResponse = new DescribeDedicatedHostTypesResponse();

			describeDedicatedHostTypesResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostTypesResponse.RequestId = context.StringValue("DescribeDedicatedHostTypes.RequestId");

			List<DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType> describeDedicatedHostTypesResponse_dedicatedHostTypes = new List<DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType>();
			for (int i = 0; i < context.Length("DescribeDedicatedHostTypes.DedicatedHostTypes.Length"); i++) {
				DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType dedicatedHostType = new DescribeDedicatedHostTypesResponse.DescribeDedicatedHostTypes_DedicatedHostType();
				dedicatedHostType.DedicatedHostType = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].DedicatedHostType");
				dedicatedHostType.Generation = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].Generation");
				dedicatedHostType.TotalSockets = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalSockets");
				dedicatedHostType.TotalVcpus = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalVcpus");
				dedicatedHostType.TotalPhysicalCores = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].TotalPhysicalCores");
				dedicatedHostType.MemorySize = context.FloatValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].MemorySize");
				dedicatedHostType.LocalStorageCapacity = context.LongValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageCapacity");
				dedicatedHostType.LocalStorageAmount = context.IntegerValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageAmount");
				dedicatedHostType.LocalStorageCategory = context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].LocalStorageCategory");

				List<string> dedicatedHostType_supportInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportInstanceTypeFamilies.Length"); j++) {
					dedicatedHostType_supportInstanceTypeFamilies.Add(context.StringValue("DescribeDedicatedHostTypes.DedicatedHostTypes["+ i +"].SupportInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHostType.SupportInstanceTypeFamilies = dedicatedHostType_supportInstanceTypeFamilies;

				describeDedicatedHostTypesResponse_dedicatedHostTypes.Add(dedicatedHostType);
			}
			describeDedicatedHostTypesResponse.DedicatedHostTypes = describeDedicatedHostTypesResponse_dedicatedHostTypes;
        
			return describeDedicatedHostTypesResponse;
        }
    }
}
