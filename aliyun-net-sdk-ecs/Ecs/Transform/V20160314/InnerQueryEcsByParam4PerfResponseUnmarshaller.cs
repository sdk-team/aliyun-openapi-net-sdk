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
    public class InnerQueryEcsByParam4PerfResponseUnmarshaller
    {
        public static InnerQueryEcsByParam4PerfResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsByParam4PerfResponse innerQueryEcsByParam4PerfResponse = new InnerQueryEcsByParam4PerfResponse();

			innerQueryEcsByParam4PerfResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsByParam4PerfResponse.RequestId = context.StringValue("InnerQueryEcsByParam4Perf.RequestId");
			innerQueryEcsByParam4PerfResponse.PageNumber = context.IntegerValue("InnerQueryEcsByParam4Perf.PageNumber");
			innerQueryEcsByParam4PerfResponse.PageSize = context.IntegerValue("InnerQueryEcsByParam4Perf.PageSize");

			List<InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance> innerQueryEcsByParam4PerfResponse_ecsInstances = new List<InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance>();
			for (int i = 0; i < context.Length("InnerQueryEcsByParam4Perf.EcsInstances.Length"); i++) {
				InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance ecsInstance = new InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance();
				ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Recoverable");
				ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].EipInstanceId");
				ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IsWin");
				ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].GmtRelease");
				ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].SerialNumber");
				ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InstanceTypeGeneration");
				ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IntranetRx");
				ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].ImageProductCode");
				ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].EcsBusinessStatus");
				ecsInstance.Description = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Description");
				ecsInstance.InternetIp = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InternetIp");
				ecsInstance.ImageNo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].ImageNo");
				ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InternetRx");
				ecsInstance.Status = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Status");
				ecsInstance.ImageName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].ImageName");
				ecsInstance.OsType = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].OsType");
				ecsInstance.Hostname = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Hostname");
				ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].EipBandwidth");
				ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].NetWorkType");
				ecsInstance.NatIp = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].NatIp");
				ecsInstance.InstanceType = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InstanceType");
				ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].RecoverPolicy");
				ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IoOptimized");
				ecsInstance.OsName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].OsName");
				ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IntranetIp");
				ecsInstance.Eip = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Eip");
				ecsInstance.GmtModified = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].GmtModified");
				ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IopsSize");
				ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].SystemDiskCategory");
				ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IntranetTx");
				ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].GmtStarted");
				ecsInstance.GmtSync = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].GmtSync");
				ecsInstance.Cores = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Cores");
				ecsInstance.AliUid = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].AliUid");
				ecsInstance.ImageId = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].ImageId");
				ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].GmtCreated");
				ecsInstance.GroupNo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].GroupNo");
				ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].VpcInstanceId");
				ecsInstance.Bid = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Bid");
				ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].AgentId");
				ecsInstance.RealHostname = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].RealHostname");
				ecsInstance.InstanceId = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InstanceId");
				ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InstanceTypeFamily");
				ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].NetworkValidation");
				ecsInstance.ZoneId = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].ZoneId");
				ecsInstance.Memory = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Memory");
				ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].InternetTx");
				ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].VswitchInstanceId");
				ecsInstance.ImageType = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].ImageType");
				ecsInstance.IzId = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].IzId");
				ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].DiskSize");

				InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Region region = new InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Region();
				region.Id = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.Id");
				region.IsActive = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.IsActive");
				region.RegionEnName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.RegionEnName");
				region.RegionNoAlias = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.RegionNoAlias");
				region.RegionName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.RegionName");
				region.RegionMemo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.RegionMemo");
				region.RegionNo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.RegionNo");

				InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Region.InnerQueryEcsByParam4Perf_Attributes attributes = new InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Region.InnerQueryEcsByParam4Perf_Attributes();
				attributes.SupportImageCopy = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.Attributes.SupportImageCopy");
				attributes.InternalUse = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.Attributes.InternalUse");
				attributes.AkName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Region.Attributes.AkName");
				region.Attributes = attributes;
				ecsInstance.Region = region;

				InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Iz iz = new InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Iz();
				iz.RegionNo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.RegionNo");
				iz.Status = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.Status");
				iz.No = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.No");
				iz.EnName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.EnName");
				iz.CnName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.CnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Iz.InnerQueryEcsByParam4Perf_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Iz.InnerQueryEcsByParam4Perf_IzResourceMode>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Iz.InnerQueryEcsByParam4Perf_IzResourceMode izResourceMode = new InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Iz.InnerQueryEcsByParam4Perf_IzResourceMode();
					izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportIoOptimized");

					List<string> izResourceMode_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

					List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

					List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

					List<string> izResourceMode_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

					List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

					List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

					List<string> izResourceMode_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceMode);
				}
				iz.IzResourceModel = iz_izResourceModel;
				ecsInstance.Iz = iz;

				InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Zone zone = new InnerQueryEcsByParam4PerfResponse.InnerQueryEcsByParam4Perf_EcsInstance.InnerQueryEcsByParam4Perf_Zone();
				zone.ZoneMemo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.ZoneMemo");
				zone.IsWritable = context.BooleanValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.IsWritable");
				zone.ZoneName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.ZoneName");
				zone.ZoneNoAlias = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.ZoneNoAlias");
				zone.IsActive = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.IsActive");
				zone.Id = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.Id");
				zone.ZoneEnName = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.ZoneEnName");
				zone.ZoneNo = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.ZoneNo");
				zone.RouteIpSegment = context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.RouteIpSegment");
				zone.RegionId = context.LongValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.RegionId");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsByParam4Perf.EcsInstances["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
				ecsInstance.Zone = zone;

				innerQueryEcsByParam4PerfResponse_ecsInstances.Add(ecsInstance);
			}
			innerQueryEcsByParam4PerfResponse.EcsInstances = innerQueryEcsByParam4PerfResponse_ecsInstances;
        
			return innerQueryEcsByParam4PerfResponse;
        }
    }
}
