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
    public class DescribeDedicatedHostsResponseUnmarshaller
    {
        public static DescribeDedicatedHostsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostsResponse describeDedicatedHostsResponse = new DescribeDedicatedHostsResponse();

			describeDedicatedHostsResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostsResponse.RequestId = context.StringValue("DescribeDedicatedHosts.RequestId");
			describeDedicatedHostsResponse.TotalCount = context.IntegerValue("DescribeDedicatedHosts.TotalCount");
			describeDedicatedHostsResponse.PageNumber = context.IntegerValue("DescribeDedicatedHosts.PageNumber");
			describeDedicatedHostsResponse.PageSize = context.IntegerValue("DescribeDedicatedHosts.PageSize");

			List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost> describeDedicatedHostsResponse_dedicatedHosts = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost>();
			for (int i = 0; i < context.Length("DescribeDedicatedHosts.DedicatedHosts.Length"); i++) {
				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost dedicatedHost = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost();
				dedicatedHost.DedicatedHostId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostId");
				dedicatedHost.RegionId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].RegionId");
				dedicatedHost.ZoneId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ZoneId");
				dedicatedHost.DedicatedHostName = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostName");
				dedicatedHost.MachineId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].MachineId");
				dedicatedHost.Description = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Description");
				dedicatedHost.DedicatedHostType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].DedicatedHostType");
				dedicatedHost.TotalSockets = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].TotalSockets");
				dedicatedHost.TotalPhysicalCores = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].TotalPhysicalCores");
				dedicatedHost.AutoPlacement = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AutoPlacement");
				dedicatedHost.Status = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Status");
				dedicatedHost.CreationTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].CreationTime");
				dedicatedHost.ChargeType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ChargeType");
				dedicatedHost.SaleCycle = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SaleCycle");
				dedicatedHost.ExpiredTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].ExpiredTime");
				dedicatedHost.AutoReleaseTime = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].AutoReleaseTime");

				List<string> dedicatedHost_supportInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportInstanceTypeFamilies.Length"); j++) {
					dedicatedHost_supportInstanceTypeFamilies.Add(context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].SupportInstanceTypeFamilies["+ j +"]"));
				}
				dedicatedHost.SupportInstanceTypeFamilies = dedicatedHost_supportInstanceTypeFamilies;

				DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Capacity capacity = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Capacity();
				capacity.TotalVcpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalVcpus");
				capacity.AvailableVcpus = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableVcpus");
				capacity.TotalMemory = context.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalMemory");
				capacity.AvailableMemory = context.FloatValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableMemory");
				capacity.TotalLocalStorage = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.TotalLocalStorage");
				capacity.AvailableLocalStorage = context.IntegerValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.AvailableLocalStorage");
				capacity.LocalStorageCategory = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Capacity.LocalStorageCategory");
				dedicatedHost.Capacity = capacity;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance> dedicatedHost_instances = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance instance = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_Instance();
					instance.InstanceId = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances["+ j +"].InstanceId");
					instance.InstanceType = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].Instances["+ j +"].InstanceType");

					dedicatedHost_instances.Add(instance);
				}
				dedicatedHost.Instances = dedicatedHost_instances;

				List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock> dedicatedHost_operationLocks = new List<DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock>();
				for (int j = 0; j < context.Length("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OperationLocks.Length"); j++) {
					DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock operationLock = new DescribeDedicatedHostsResponse.DescribeDedicatedHosts_DedicatedHost.DescribeDedicatedHosts_OperationLock();
					operationLock.LockReason = context.StringValue("DescribeDedicatedHosts.DedicatedHosts["+ i +"].OperationLocks["+ j +"].LockReason");

					dedicatedHost_operationLocks.Add(operationLock);
				}
				dedicatedHost.OperationLocks = dedicatedHost_operationLocks;

				describeDedicatedHostsResponse_dedicatedHosts.Add(dedicatedHost);
			}
			describeDedicatedHostsResponse.DedicatedHosts = describeDedicatedHostsResponse_dedicatedHosts;
        
			return describeDedicatedHostsResponse;
        }
    }
}
