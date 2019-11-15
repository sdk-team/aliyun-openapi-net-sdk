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
    public class InnerQueryEcsByInternetIpResponseUnmarshaller
    {
        public static InnerQueryEcsByInternetIpResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsByInternetIpResponse innerQueryEcsByInternetIpResponse = new InnerQueryEcsByInternetIpResponse();

			innerQueryEcsByInternetIpResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsByInternetIpResponse.RequestId = context.StringValue("InnerQueryEcsByInternetIp.RequestId");

			InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance ecsInstance = new InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance();
			ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsByInternetIp.EcsInstance.Recoverable");
			ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.EipInstanceId");
			ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsByInternetIp.EcsInstance.IsWin");
			ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.GmtRelease");
			ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.SerialNumber");
			ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.InstanceTypeGeneration");
			ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.IntranetRx");
			ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.ImageProductCode");
			ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.EcsBusinessStatus");
			ecsInstance.Description = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Description");
			ecsInstance.InternetIp = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.InternetIp");
			ecsInstance.ImageNo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.ImageNo");
			ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.InternetRx");
			ecsInstance.Status = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Status");
			ecsInstance.ImageName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.ImageName");
			ecsInstance.OsType = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.OsType");
			ecsInstance.Hostname = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Hostname");
			ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.EipBandwidth");
			ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.NetWorkType");
			ecsInstance.NatIp = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.NatIp");
			ecsInstance.InstanceType = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.InstanceType");
			ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.RecoverPolicy");
			ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsByInternetIp.EcsInstance.IoOptimized");
			ecsInstance.OsName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.OsName");
			ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.IntranetIp");
			ecsInstance.Eip = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Eip");
			ecsInstance.GmtModified = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.GmtModified");
			ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.IopsSize");
			ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.SystemDiskCategory");
			ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.IntranetTx");
			ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.GmtStarted");
			ecsInstance.GmtSync = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.GmtSync");
			ecsInstance.Cores = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.Cores");
			ecsInstance.AliUid = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.AliUid");
			ecsInstance.ImageId = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.ImageId");
			ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.GmtCreated");
			ecsInstance.GroupNo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.GroupNo");
			ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.VpcInstanceId");
			ecsInstance.Bid = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Bid");
			ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.AgentId");
			ecsInstance.RealHostname = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.RealHostname");
			ecsInstance.InstanceId = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.InstanceId");
			ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.InstanceTypeFamily");
			ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsByInternetIp.EcsInstance.NetworkValidation");
			ecsInstance.ZoneId = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.ZoneId");
			ecsInstance.Memory = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.Memory");
			ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.InternetTx");
			ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.VswitchInstanceId");
			ecsInstance.ImageType = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.ImageType");
			ecsInstance.IzId = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.IzId");
			ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsByInternetIp.EcsInstance.DiskSize");

			InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Region region = new InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Region();
			region.Id = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.Region.Id");
			region.IsActive = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.IsActive");
			region.RegionEnName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.RegionEnName");
			region.RegionNoAlias = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.RegionNoAlias");
			region.RegionName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.RegionName");
			region.RegionMemo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.RegionMemo");
			region.RegionNo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.RegionNo");

			InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Region.InnerQueryEcsByInternetIp_Attributes attributes = new InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Region.InnerQueryEcsByInternetIp_Attributes();
			attributes.SupportImageCopy = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.Attributes.SupportImageCopy");
			attributes.InternalUse = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.Attributes.InternalUse");
			attributes.AkName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Region.Attributes.AkName");
			region.Attributes = attributes;
			ecsInstance.Region = region;

			InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Iz iz = new InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Iz();
			iz.RegionNo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.RegionNo");
			iz.Status = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.Status");
			iz.No = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.No");
			iz.EnName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.EnName");
			iz.CnName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.CnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Iz.InnerQueryEcsByInternetIp_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Iz.InnerQueryEcsByInternetIp_IzResourceMode>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel.Length"); i++) {
				InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Iz.InnerQueryEcsByInternetIp_IzResourceMode izResourceMode = new InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Iz.InnerQueryEcsByInternetIp_IzResourceMode();
				izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportIoOptimized");

				List<string> izResourceMode_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

				List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

				List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

				List<string> izResourceMode_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

				List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

				List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

				List<string> izResourceMode_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceMode);
			}
			iz.IzResourceModel = iz_izResourceModel;
			ecsInstance.Iz = iz;

			InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Zone zone = new InnerQueryEcsByInternetIpResponse.InnerQueryEcsByInternetIp_EcsInstance.InnerQueryEcsByInternetIp_Zone();
			zone.ZoneMemo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.ZoneMemo");
			zone.IsWritable = context.BooleanValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.IsWritable");
			zone.ZoneName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.ZoneName");
			zone.ZoneNoAlias = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.ZoneNoAlias");
			zone.IsActive = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.IsActive");
			zone.Id = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.Id");
			zone.ZoneEnName = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.ZoneEnName");
			zone.ZoneNo = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.ZoneNo");
			zone.RouteIpSegment = context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.RouteIpSegment");
			zone.RegionId = context.LongValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.RegionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByInternetIp.EcsInstance.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsByInternetIp.EcsInstance.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			ecsInstance.Zone = zone;
			innerQueryEcsByInternetIpResponse.EcsInstance = ecsInstance;
        
			return innerQueryEcsByInternetIpResponse;
        }
    }
}
