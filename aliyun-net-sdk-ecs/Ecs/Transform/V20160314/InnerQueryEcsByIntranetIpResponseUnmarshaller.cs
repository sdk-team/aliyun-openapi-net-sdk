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
    public class InnerQueryEcsByIntranetIpResponseUnmarshaller
    {
        public static InnerQueryEcsByIntranetIpResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsByIntranetIpResponse innerQueryEcsByIntranetIpResponse = new InnerQueryEcsByIntranetIpResponse();

			innerQueryEcsByIntranetIpResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsByIntranetIpResponse.RequestId = context.StringValue("InnerQueryEcsByIntranetIp.RequestId");

			InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance ecsInstance = new InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance();
			ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsByIntranetIp.EcsInstance.Recoverable");
			ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.EipInstanceId");
			ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsByIntranetIp.EcsInstance.IsWin");
			ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.GmtRelease");
			ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.SerialNumber");
			ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.InstanceTypeGeneration");
			ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.IntranetRx");
			ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.ImageProductCode");
			ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.EcsBusinessStatus");
			ecsInstance.Description = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Description");
			ecsInstance.InternetIp = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.InternetIp");
			ecsInstance.ImageNo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.ImageNo");
			ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.InternetRx");
			ecsInstance.Status = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Status");
			ecsInstance.ImageName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.ImageName");
			ecsInstance.OsType = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.OsType");
			ecsInstance.Hostname = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Hostname");
			ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.EipBandwidth");
			ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.NetWorkType");
			ecsInstance.NatIp = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.NatIp");
			ecsInstance.InstanceType = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.InstanceType");
			ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.RecoverPolicy");
			ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsByIntranetIp.EcsInstance.IoOptimized");
			ecsInstance.OsName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.OsName");
			ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.IntranetIp");
			ecsInstance.Eip = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Eip");
			ecsInstance.GmtModified = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.GmtModified");
			ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.IopsSize");
			ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.SystemDiskCategory");
			ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.IntranetTx");
			ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.GmtStarted");
			ecsInstance.GmtSync = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.GmtSync");
			ecsInstance.Cores = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.Cores");
			ecsInstance.AliUid = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.AliUid");
			ecsInstance.ImageId = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.ImageId");
			ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.GmtCreated");
			ecsInstance.GroupNo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.GroupNo");
			ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.VpcInstanceId");
			ecsInstance.Bid = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Bid");
			ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.AgentId");
			ecsInstance.RealHostname = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.RealHostname");
			ecsInstance.InstanceId = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.InstanceId");
			ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.InstanceTypeFamily");
			ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsByIntranetIp.EcsInstance.NetworkValidation");
			ecsInstance.ZoneId = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.ZoneId");
			ecsInstance.Memory = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.Memory");
			ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.InternetTx");
			ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.VswitchInstanceId");
			ecsInstance.ImageType = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.ImageType");
			ecsInstance.IzId = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.IzId");
			ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsByIntranetIp.EcsInstance.DiskSize");

			InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Region region = new InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Region();
			region.Id = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.Id");
			region.IsActive = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.IsActive");
			region.RegionEnName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.RegionEnName");
			region.RegionNoAlias = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.RegionNoAlias");
			region.RegionName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.RegionName");
			region.RegionMemo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.RegionMemo");
			region.RegionNo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.RegionNo");

			InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Region.InnerQueryEcsByIntranetIp_Attributes attributes = new InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Region.InnerQueryEcsByIntranetIp_Attributes();
			attributes.SupportImageCopy = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.Attributes.SupportImageCopy");
			attributes.InternalUse = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.Attributes.InternalUse");
			attributes.AkName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Region.Attributes.AkName");
			region.Attributes = attributes;
			ecsInstance.Region = region;

			InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Iz iz = new InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Iz();
			iz.RegionNo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.RegionNo");
			iz.Status = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.Status");
			iz.No = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.No");
			iz.EnName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.EnName");
			iz.CnName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.CnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Iz.InnerQueryEcsByIntranetIp_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Iz.InnerQueryEcsByIntranetIp_IzResourceMode>();
			for (int i = 0; i < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel.Length"); i++) {
				InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Iz.InnerQueryEcsByIntranetIp_IzResourceMode izResourceMode = new InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Iz.InnerQueryEcsByIntranetIp_IzResourceMode();
				izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportIoOptimized");

				List<string> izResourceMode_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

				List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

				List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

				List<string> izResourceMode_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

				List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

				List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

				List<string> izResourceMode_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceMode);
			}
			iz.IzResourceModel = iz_izResourceModel;
			ecsInstance.Iz = iz;

			InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Zone zone = new InnerQueryEcsByIntranetIpResponse.InnerQueryEcsByIntranetIp_EcsInstance.InnerQueryEcsByIntranetIp_Zone();
			zone.ZoneMemo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.ZoneMemo");
			zone.IsWritable = context.BooleanValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.IsWritable");
			zone.ZoneName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.ZoneName");
			zone.ZoneNoAlias = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.ZoneNoAlias");
			zone.IsActive = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.IsActive");
			zone.Id = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.Id");
			zone.ZoneEnName = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.ZoneEnName");
			zone.ZoneNo = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.ZoneNo");
			zone.RouteIpSegment = context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.RouteIpSegment");
			zone.RegionId = context.LongValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.RegionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerQueryEcsByIntranetIp.EcsInstance.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsByIntranetIp.EcsInstance.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			ecsInstance.Zone = zone;
			innerQueryEcsByIntranetIpResponse.EcsInstance = ecsInstance;
        
			return innerQueryEcsByIntranetIpResponse;
        }
    }
}
