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
    public class InnerQueryEcsByInstanceIdResponseUnmarshaller
    {
        public static InnerQueryEcsByInstanceIdResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsByInstanceIdResponse innerQueryEcsByInstanceIdResponse = new InnerQueryEcsByInstanceIdResponse();

			innerQueryEcsByInstanceIdResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsByInstanceIdResponse.RequestId = context.StringValue("InnerQueryEcsByInstanceId.RequestId");

			InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance ecsInstance = new InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance();
			ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsByInstanceId.EcsInstance.Recoverable");
			ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.EipInstanceId");
			ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsByInstanceId.EcsInstance.IsWin");
			ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.GmtRelease");
			ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.SerialNumber");
			ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.InstanceTypeGeneration");
			ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.IntranetRx");
			ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.ImageProductCode");
			ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.EcsBusinessStatus");
			ecsInstance.Description = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Description");
			ecsInstance.InternetIp = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.InternetIp");
			ecsInstance.ImageNo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.ImageNo");
			ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.InternetRx");
			ecsInstance.Status = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Status");
			ecsInstance.ImageName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.ImageName");
			ecsInstance.OsType = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.OsType");
			ecsInstance.Hostname = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Hostname");
			ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.EipBandwidth");
			ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.NetWorkType");
			ecsInstance.NatIp = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.NatIp");
			ecsInstance.InstanceType = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.InstanceType");
			ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.RecoverPolicy");
			ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsByInstanceId.EcsInstance.IoOptimized");
			ecsInstance.OsName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.OsName");
			ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.IntranetIp");
			ecsInstance.Eip = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Eip");
			ecsInstance.GmtModified = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.GmtModified");
			ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.IopsSize");
			ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.SystemDiskCategory");
			ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.IntranetTx");
			ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.GmtStarted");
			ecsInstance.GmtSync = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.GmtSync");
			ecsInstance.Cores = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.Cores");
			ecsInstance.AliUid = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.AliUid");
			ecsInstance.ImageId = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.ImageId");
			ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.GmtCreated");
			ecsInstance.GroupNo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.GroupNo");
			ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.VpcInstanceId");
			ecsInstance.Bid = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Bid");
			ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.AgentId");
			ecsInstance.RealHostname = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.RealHostname");
			ecsInstance.InstanceId = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.InstanceId");
			ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.InstanceTypeFamily");
			ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsByInstanceId.EcsInstance.NetworkValidation");
			ecsInstance.ZoneId = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.ZoneId");
			ecsInstance.Memory = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.Memory");
			ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.InternetTx");
			ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.VswitchInstanceId");
			ecsInstance.ImageType = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.ImageType");
			ecsInstance.IzId = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.IzId");
			ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsByInstanceId.EcsInstance.DiskSize");

			InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Region region = new InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Region();
			region.Id = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.Region.Id");
			region.IsActive = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.IsActive");
			region.RegionEnName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.RegionEnName");
			region.RegionNoAlias = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.RegionNoAlias");
			region.RegionName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.RegionName");
			region.RegionMemo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.RegionMemo");
			region.RegionNo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.RegionNo");

			InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Region.InnerQueryEcsByInstanceId_Attributes attributes = new InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Region.InnerQueryEcsByInstanceId_Attributes();
			attributes.SupportImageCopy = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.Attributes.SupportImageCopy");
			attributes.InternalUse = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.Attributes.InternalUse");
			attributes.AkName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Region.Attributes.AkName");
			region.Attributes = attributes;
			ecsInstance.Region = region;

			InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Iz iz = new InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Iz();
			iz.RegionNo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.RegionNo");
			iz.Status = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.Status");
			iz.No = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.No");
			iz.EnName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.EnName");
			iz.CnName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.CnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Iz.InnerQueryEcsByInstanceId_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Iz.InnerQueryEcsByInstanceId_IzResourceMode>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel.Length"); i++) {
				InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Iz.InnerQueryEcsByInstanceId_IzResourceMode izResourceMode = new InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Iz.InnerQueryEcsByInstanceId_IzResourceMode();
				izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportIoOptimized");

				List<string> izResourceMode_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

				List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

				List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

				List<string> izResourceMode_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

				List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

				List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

				List<string> izResourceMode_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceMode);
			}
			iz.IzResourceModel = iz_izResourceModel;
			ecsInstance.Iz = iz;

			InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Zone zone = new InnerQueryEcsByInstanceIdResponse.InnerQueryEcsByInstanceId_EcsInstance.InnerQueryEcsByInstanceId_Zone();
			zone.ZoneMemo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.ZoneMemo");
			zone.IsWritable = context.BooleanValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.IsWritable");
			zone.ZoneName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.ZoneName");
			zone.ZoneNoAlias = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.ZoneNoAlias");
			zone.IsActive = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.IsActive");
			zone.Id = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.Id");
			zone.ZoneEnName = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.ZoneEnName");
			zone.ZoneNo = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.ZoneNo");
			zone.RouteIpSegment = context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.RouteIpSegment");
			zone.RegionId = context.LongValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.RegionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInstanceId.EcsInstance.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsByInstanceId.EcsInstance.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			ecsInstance.Zone = zone;
			innerQueryEcsByInstanceIdResponse.EcsInstance = ecsInstance;
        
			return innerQueryEcsByInstanceIdResponse;
        }
    }
}
