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
    public class GetLaunchTemplateDataResponseUnmarshaller
    {
        public static GetLaunchTemplateDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetLaunchTemplateDataResponse getLaunchTemplateDataResponse = new GetLaunchTemplateDataResponse();

			getLaunchTemplateDataResponse.HttpResponse = context.HttpResponse;
			getLaunchTemplateDataResponse.RequestId = context.StringValue("GetLaunchTemplateData.RequestId");

			GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData launchTemplateData = new GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData();
			launchTemplateData.ImageId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.ImageId");
			launchTemplateData.ImageOwnerAlias = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.ImageOwnerAlias");
			launchTemplateData.InstanceType = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.InstanceType");
			launchTemplateData.SecurityGroupId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.SecurityGroupId");
			launchTemplateData.VpcId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.VpcId");
			launchTemplateData.VSwitchId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.VSwitchId");
			launchTemplateData.InstanceName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.InstanceName");
			launchTemplateData.Description = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.Description");
			launchTemplateData.InternetMaxBandwidthIn = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.InternetMaxBandwidthIn");
			launchTemplateData.InternetMaxBandwidthOut = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.InternetMaxBandwidthOut");
			launchTemplateData.HostName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.HostName");
			launchTemplateData.ZoneId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.ZoneId");
			launchTemplateData.SystemDiskSize = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.SystemDisk.Size");
			launchTemplateData.SystemDiskCategory = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.SystemDisk.Category");
			launchTemplateData.SystemDiskDiskName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.SystemDisk.DiskName");
			launchTemplateData.SystemDiskDescription = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.SystemDisk.Description");
			launchTemplateData.SystemDiskIops = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.SystemDisk.Iops");
			launchTemplateData.IoOptimized = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.IoOptimized");
			launchTemplateData.InstanceChargeType = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.InstanceChargeType");
			launchTemplateData.Period = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.Period");
			launchTemplateData.InternetChargeType = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.InternetChargeType");
			launchTemplateData.EnableVmOsConfig = context.BooleanValue("GetLaunchTemplateData.LaunchTemplateData.EnableVmOsConfig");
			launchTemplateData.NetworkType = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.NetworkType");
			launchTemplateData.UserData = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.UserData");
			launchTemplateData.KeyPairName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.KeyPairName");
			launchTemplateData.RamRoleName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.RamRoleName");
			launchTemplateData.AutoReleaseTime = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.AutoReleaseTime");
			launchTemplateData.SpotStrategy = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.SpotStrategy");
			launchTemplateData.SpotPriceLimit = context.FloatValue("GetLaunchTemplateData.LaunchTemplateData.SpotPriceLimit");
			launchTemplateData.SpotDuration = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.SpotDuration");
			launchTemplateData.ResourceGroupId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.ResourceGroupId");
			launchTemplateData.SecurityEnhancementStrategy = context.BooleanValue("GetLaunchTemplateData.LaunchTemplateData.SecurityEnhancementStrategy");

			List<GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_DataDisk> launchTemplateData_dataDisks = new List<GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_DataDisk>();
			for (int i = 0; i < context.Length("GetLaunchTemplateData.LaunchTemplateData.DataDisks.Length"); i++) {
				GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_DataDisk dataDisk = new GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_DataDisk();
				dataDisk.Size = context.IntegerValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].Size");
				dataDisk.SnapshotId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].SnapshotId");
				dataDisk.Category = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].Category");
				dataDisk.Encrypted = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].Encrypted");
				dataDisk.DiskName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].DiskName");
				dataDisk.Description = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].Description");
				dataDisk.DeleteWithInstance = context.BooleanValue("GetLaunchTemplateData.LaunchTemplateData.DataDisks["+ i +"].DeleteWithInstance");

				launchTemplateData_dataDisks.Add(dataDisk);
			}
			launchTemplateData.DataDisks = launchTemplateData_dataDisks;

			List<GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_NetworkInterface> launchTemplateData_networkInterfaces = new List<GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_NetworkInterface>();
			for (int i = 0; i < context.Length("GetLaunchTemplateData.LaunchTemplateData.NetworkInterfaces.Length"); i++) {
				GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_NetworkInterface networkInterface = new GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_NetworkInterface();
				networkInterface.PrimaryIpAddress = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.NetworkInterfaces["+ i +"].PrimaryIpAddress");
				networkInterface.VSwitchId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.NetworkInterfaces["+ i +"].VSwitchId");
				networkInterface.SecurityGroupId = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.NetworkInterfaces["+ i +"].SecurityGroupId");
				networkInterface.NetworkInterfaceName = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.NetworkInterfaces["+ i +"].NetworkInterfaceName");
				networkInterface.Description = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.NetworkInterfaces["+ i +"].Description");

				launchTemplateData_networkInterfaces.Add(networkInterface);
			}
			launchTemplateData.NetworkInterfaces = launchTemplateData_networkInterfaces;

			List<GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_InstanceTag> launchTemplateData_tags = new List<GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_InstanceTag>();
			for (int i = 0; i < context.Length("GetLaunchTemplateData.LaunchTemplateData.Tags.Length"); i++) {
				GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_InstanceTag instanceTag = new GetLaunchTemplateDataResponse.GetLaunchTemplateData_LaunchTemplateData.GetLaunchTemplateData_InstanceTag();
				instanceTag.Key = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.Tags["+ i +"].Key");
				instanceTag._Value = context.StringValue("GetLaunchTemplateData.LaunchTemplateData.Tags["+ i +"].Value");

				launchTemplateData_tags.Add(instanceTag);
			}
			launchTemplateData.Tags = launchTemplateData_tags;
			getLaunchTemplateDataResponse.LaunchTemplateData = launchTemplateData;
        
			return getLaunchTemplateDataResponse;
        }
    }
}
