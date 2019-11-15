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
    public class InnerQueryEcsBySerialNumberResponseUnmarshaller
    {
        public static InnerQueryEcsBySerialNumberResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsBySerialNumberResponse innerQueryEcsBySerialNumberResponse = new InnerQueryEcsBySerialNumberResponse();

			innerQueryEcsBySerialNumberResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsBySerialNumberResponse.RequestId = context.StringValue("InnerQueryEcsBySerialNumber.RequestId");

			InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance ecsInstance = new InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance();
			ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsBySerialNumber.EcsInstance.Recoverable");
			ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.EipInstanceId");
			ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsBySerialNumber.EcsInstance.IsWin");
			ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.GmtRelease");
			ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.SerialNumber");
			ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.InstanceTypeGeneration");
			ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.IntranetRx");
			ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.ImageProductCode");
			ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.EcsBusinessStatus");
			ecsInstance.Description = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Description");
			ecsInstance.InternetIp = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.InternetIp");
			ecsInstance.ImageNo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.ImageNo");
			ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.InternetRx");
			ecsInstance.Status = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Status");
			ecsInstance.ImageName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.ImageName");
			ecsInstance.OsType = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.OsType");
			ecsInstance.Hostname = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Hostname");
			ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.EipBandwidth");
			ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.NetWorkType");
			ecsInstance.NatIp = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.NatIp");
			ecsInstance.InstanceType = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.InstanceType");
			ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.RecoverPolicy");
			ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsBySerialNumber.EcsInstance.IoOptimized");
			ecsInstance.OsName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.OsName");
			ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.IntranetIp");
			ecsInstance.Eip = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Eip");
			ecsInstance.GmtModified = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.GmtModified");
			ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.IopsSize");
			ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.SystemDiskCategory");
			ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.IntranetTx");
			ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.GmtStarted");
			ecsInstance.GmtSync = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.GmtSync");
			ecsInstance.Cores = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.Cores");
			ecsInstance.AliUid = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.AliUid");
			ecsInstance.ImageId = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.ImageId");
			ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.GmtCreated");
			ecsInstance.GroupNo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.GroupNo");
			ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.VpcInstanceId");
			ecsInstance.Bid = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Bid");
			ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.AgentId");
			ecsInstance.RealHostname = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.RealHostname");
			ecsInstance.InstanceId = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.InstanceId");
			ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.InstanceTypeFamily");
			ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsBySerialNumber.EcsInstance.NetworkValidation");
			ecsInstance.ZoneId = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.ZoneId");
			ecsInstance.Memory = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.Memory");
			ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.InternetTx");
			ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.VswitchInstanceId");
			ecsInstance.ImageType = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.ImageType");
			ecsInstance.IzId = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.IzId");
			ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsBySerialNumber.EcsInstance.DiskSize");

			InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Region region = new InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Region();
			region.Id = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.Id");
			region.IsActive = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.IsActive");
			region.RegionEnName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.RegionEnName");
			region.RegionNoAlias = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.RegionNoAlias");
			region.RegionName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.RegionName");
			region.RegionMemo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.RegionMemo");
			region.RegionNo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.RegionNo");

			InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Region.InnerQueryEcsBySerialNumber_Attributes attributes = new InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Region.InnerQueryEcsBySerialNumber_Attributes();
			attributes.SupportImageCopy = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.Attributes.SupportImageCopy");
			attributes.InternalUse = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.Attributes.InternalUse");
			attributes.AkName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Region.Attributes.AkName");
			region.Attributes = attributes;
			ecsInstance.Region = region;

			InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Iz iz = new InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Iz();
			iz.RegionNo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.RegionNo");
			iz.Status = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.Status");
			iz.No = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.No");
			iz.EnName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.EnName");
			iz.CnName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.CnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Iz.InnerQueryEcsBySerialNumber_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Iz.InnerQueryEcsBySerialNumber_IzResourceMode>();
			for (int i = 0; i < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel.Length"); i++) {
				InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Iz.InnerQueryEcsBySerialNumber_IzResourceMode izResourceMode = new InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Iz.InnerQueryEcsBySerialNumber_IzResourceMode();
				izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportIoOptimized");

				List<string> izResourceMode_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

				List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

				List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

				List<string> izResourceMode_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

				List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

				List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

				List<string> izResourceMode_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceMode);
			}
			iz.IzResourceModel = iz_izResourceModel;
			ecsInstance.Iz = iz;

			InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Zone zone = new InnerQueryEcsBySerialNumberResponse.InnerQueryEcsBySerialNumber_EcsInstance.InnerQueryEcsBySerialNumber_Zone();
			zone.ZoneMemo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.ZoneMemo");
			zone.IsWritable = context.BooleanValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.IsWritable");
			zone.ZoneName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.ZoneName");
			zone.ZoneNoAlias = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.ZoneNoAlias");
			zone.IsActive = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.IsActive");
			zone.Id = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.Id");
			zone.ZoneEnName = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.ZoneEnName");
			zone.ZoneNo = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.ZoneNo");
			zone.RouteIpSegment = context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.RouteIpSegment");
			zone.RegionId = context.LongValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.RegionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsBySerialNumber.EcsInstance.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsBySerialNumber.EcsInstance.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			ecsInstance.Zone = zone;
			innerQueryEcsBySerialNumberResponse.EcsInstance = ecsInstance;
        
			return innerQueryEcsBySerialNumberResponse;
        }
    }
}
