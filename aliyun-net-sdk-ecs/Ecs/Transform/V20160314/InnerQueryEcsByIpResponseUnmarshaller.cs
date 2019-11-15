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
    public class InnerQueryEcsByIpResponseUnmarshaller
    {
        public static InnerQueryEcsByIpResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsByIpResponse innerQueryEcsByIpResponse = new InnerQueryEcsByIpResponse();

			innerQueryEcsByIpResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsByIpResponse.RequestId = context.StringValue("InnerQueryEcsByIp.RequestId");
			innerQueryEcsByIpResponse.PageNumber = context.IntegerValue("InnerQueryEcsByIp.PageNumber");
			innerQueryEcsByIpResponse.PageSize = context.IntegerValue("InnerQueryEcsByIp.PageSize");

			List<InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance> innerQueryEcsByIpResponse_ecsInstances = new List<InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance>();
			for (int i = 0; i < context.Length("InnerQueryEcsByIp.EcsInstances.Length"); i++) {
				InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance ecsInstance = new InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance();
				ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Recoverable");
				ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].EipInstanceId");
				ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IsWin");
				ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].GmtRelease");
				ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].SerialNumber");
				ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InstanceTypeGeneration");
				ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IntranetRx");
				ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].ImageProductCode");
				ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].EcsBusinessStatus");
				ecsInstance.Description = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Description");
				ecsInstance.InternetIp = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InternetIp");
				ecsInstance.ImageNo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].ImageNo");
				ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InternetRx");
				ecsInstance.Status = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Status");
				ecsInstance.ImageName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].ImageName");
				ecsInstance.OsType = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].OsType");
				ecsInstance.Hostname = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Hostname");
				ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].EipBandwidth");
				ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].NetWorkType");
				ecsInstance.NatIp = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].NatIp");
				ecsInstance.InstanceType = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InstanceType");
				ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].RecoverPolicy");
				ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IoOptimized");
				ecsInstance.OsName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].OsName");
				ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IntranetIp");
				ecsInstance.Eip = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Eip");
				ecsInstance.GmtModified = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].GmtModified");
				ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IopsSize");
				ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].SystemDiskCategory");
				ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IntranetTx");
				ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].GmtStarted");
				ecsInstance.GmtSync = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].GmtSync");
				ecsInstance.Cores = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Cores");
				ecsInstance.AliUid = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].AliUid");
				ecsInstance.ImageId = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].ImageId");
				ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].GmtCreated");
				ecsInstance.GroupNo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].GroupNo");
				ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].VpcInstanceId");
				ecsInstance.Bid = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Bid");
				ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].AgentId");
				ecsInstance.RealHostname = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].RealHostname");
				ecsInstance.InstanceId = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InstanceId");
				ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InstanceTypeFamily");
				ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsByIp.EcsInstances["+ i +"].NetworkValidation");
				ecsInstance.ZoneId = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].ZoneId");
				ecsInstance.Memory = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Memory");
				ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].InternetTx");
				ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].VswitchInstanceId");
				ecsInstance.ImageType = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].ImageType");
				ecsInstance.IzId = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].IzId");
				ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsByIp.EcsInstances["+ i +"].DiskSize");

				InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Region region = new InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Region();
				region.Id = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.Id");
				region.IsActive = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.IsActive");
				region.RegionEnName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.RegionEnName");
				region.RegionNoAlias = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.RegionNoAlias");
				region.RegionName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.RegionName");
				region.RegionMemo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.RegionMemo");
				region.RegionNo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.RegionNo");

				InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Region.InnerQueryEcsByIp_Attributes attributes = new InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Region.InnerQueryEcsByIp_Attributes();
				attributes.SupportImageCopy = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.Attributes.SupportImageCopy");
				attributes.InternalUse = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.Attributes.InternalUse");
				attributes.AkName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Region.Attributes.AkName");
				region.Attributes = attributes;
				ecsInstance.Region = region;

				InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Iz iz = new InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Iz();
				iz.RegionNo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.RegionNo");
				iz.Status = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.Status");
				iz.No = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.No");
				iz.EnName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.EnName");
				iz.CnName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.CnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Iz.InnerQueryEcsByIp_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Iz.InnerQueryEcsByIp_IzResourceMode>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Iz.InnerQueryEcsByIp_IzResourceMode izResourceMode = new InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Iz.InnerQueryEcsByIp_IzResourceMode();
					izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportIoOptimized");

					List<string> izResourceMode_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

					List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

					List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

					List<string> izResourceMode_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

					List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

					List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

					List<string> izResourceMode_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceMode);
				}
				iz.IzResourceModel = iz_izResourceModel;
				ecsInstance.Iz = iz;

				InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Zone zone = new InnerQueryEcsByIpResponse.InnerQueryEcsByIp_EcsInstance.InnerQueryEcsByIp_Zone();
				zone.ZoneMemo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.ZoneMemo");
				zone.IsWritable = context.BooleanValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.IsWritable");
				zone.ZoneName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.ZoneName");
				zone.ZoneNoAlias = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.ZoneNoAlias");
				zone.IsActive = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.IsActive");
				zone.Id = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.Id");
				zone.ZoneEnName = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.ZoneEnName");
				zone.ZoneNo = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.ZoneNo");
				zone.RouteIpSegment = context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.RouteIpSegment");
				zone.RegionId = context.LongValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.RegionId");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsByIp.EcsInstances["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
				ecsInstance.Zone = zone;

				innerQueryEcsByIpResponse_ecsInstances.Add(ecsInstance);
			}
			innerQueryEcsByIpResponse.EcsInstances = innerQueryEcsByIpResponse_ecsInstances;
        
			return innerQueryEcsByIpResponse;
        }
    }
}
