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
    public class InnerQueryEcsByParamResponseUnmarshaller
    {
        public static InnerQueryEcsByParamResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryEcsByParamResponse innerQueryEcsByParamResponse = new InnerQueryEcsByParamResponse();

			innerQueryEcsByParamResponse.HttpResponse = context.HttpResponse;
			innerQueryEcsByParamResponse.RequestId = context.StringValue("InnerQueryEcsByParam.RequestId");
			innerQueryEcsByParamResponse.PageNumber = context.IntegerValue("InnerQueryEcsByParam.PageNumber");
			innerQueryEcsByParamResponse.PageSize = context.IntegerValue("InnerQueryEcsByParam.PageSize");

			List<InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance> innerQueryEcsByParamResponse_ecsInstances = new List<InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance>();
			for (int i = 0; i < context.Length("InnerQueryEcsByParam.EcsInstances.Length"); i++) {
				InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance ecsInstance = new InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance();
				ecsInstance.Recoverable = context.BooleanValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Recoverable");
				ecsInstance.EipInstanceId = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].EipInstanceId");
				ecsInstance.IsWin = context.BooleanValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IsWin");
				ecsInstance.GmtRelease = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].GmtRelease");
				ecsInstance.SerialNumber = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].SerialNumber");
				ecsInstance.InstanceTypeGeneration = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InstanceTypeGeneration");
				ecsInstance.IntranetRx = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IntranetRx");
				ecsInstance.ImageProductCode = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].ImageProductCode");
				ecsInstance.EcsBusinessStatus = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].EcsBusinessStatus");
				ecsInstance.Description = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Description");
				ecsInstance.InternetIp = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InternetIp");
				ecsInstance.ImageNo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].ImageNo");
				ecsInstance.InternetRx = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InternetRx");
				ecsInstance.Status = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Status");
				ecsInstance.ImageName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].ImageName");
				ecsInstance.OsType = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].OsType");
				ecsInstance.Hostname = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Hostname");
				ecsInstance.EipBandwidth = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].EipBandwidth");
				ecsInstance.NetWorkType = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].NetWorkType");
				ecsInstance.NatIp = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].NatIp");
				ecsInstance.InstanceType = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InstanceType");
				ecsInstance.RecoverPolicy = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].RecoverPolicy");
				ecsInstance.IoOptimized = context.BooleanValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IoOptimized");
				ecsInstance.OsName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].OsName");
				ecsInstance.IntranetIp = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IntranetIp");
				ecsInstance.Eip = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Eip");
				ecsInstance.GmtModified = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].GmtModified");
				ecsInstance.IopsSize = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IopsSize");
				ecsInstance.SystemDiskCategory = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].SystemDiskCategory");
				ecsInstance.IntranetTx = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IntranetTx");
				ecsInstance.GmtStarted = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].GmtStarted");
				ecsInstance.GmtSync = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].GmtSync");
				ecsInstance.Cores = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Cores");
				ecsInstance.AliUid = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].AliUid");
				ecsInstance.ImageId = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].ImageId");
				ecsInstance.GmtCreated = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].GmtCreated");
				ecsInstance.GroupNo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].GroupNo");
				ecsInstance.VpcInstanceId = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].VpcInstanceId");
				ecsInstance.Bid = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Bid");
				ecsInstance.AgentId = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].AgentId");
				ecsInstance.RealHostname = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].RealHostname");
				ecsInstance.InstanceId = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InstanceId");
				ecsInstance.InstanceTypeFamily = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InstanceTypeFamily");
				ecsInstance.NetworkValidation = context.BooleanValue("InnerQueryEcsByParam.EcsInstances["+ i +"].NetworkValidation");
				ecsInstance.ZoneId = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].ZoneId");
				ecsInstance.Memory = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Memory");
				ecsInstance.InternetTx = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].InternetTx");
				ecsInstance.VswitchInstanceId = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].VswitchInstanceId");
				ecsInstance.ImageType = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].ImageType");
				ecsInstance.IzId = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].IzId");
				ecsInstance.DiskSize = context.IntegerValue("InnerQueryEcsByParam.EcsInstances["+ i +"].DiskSize");

				InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Region region = new InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Region();
				region.Id = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.Id");
				region.IsActive = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.IsActive");
				region.RegionEnName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.RegionEnName");
				region.RegionNoAlias = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.RegionNoAlias");
				region.RegionName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.RegionName");
				region.RegionMemo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.RegionMemo");
				region.RegionNo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.RegionNo");

				InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Region.InnerQueryEcsByParam_Attributes attributes = new InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Region.InnerQueryEcsByParam_Attributes();
				attributes.SupportImageCopy = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.Attributes.SupportImageCopy");
				attributes.InternalUse = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.Attributes.InternalUse");
				attributes.AkName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Region.Attributes.AkName");
				region.Attributes = attributes;
				ecsInstance.Region = region;

				InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Iz iz = new InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Iz();
				iz.RegionNo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.RegionNo");
				iz.Status = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.Status");
				iz.No = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.No");
				iz.EnName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.EnName");
				iz.CnName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.CnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Iz.InnerQueryEcsByParam_IzResourceMode> iz_izResourceModel = new List<InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Iz.InnerQueryEcsByParam_IzResourceMode>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Iz.InnerQueryEcsByParam_IzResourceMode izResourceMode = new InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Iz.InnerQueryEcsByParam_IzResourceMode();
					izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportIoOptimized");

					List<string> izResourceMode_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

					List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

					List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

					List<string> izResourceMode_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

					List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

					List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

					List<string> izResourceMode_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceMode);
				}
				iz.IzResourceModel = iz_izResourceModel;
				ecsInstance.Iz = iz;

				InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Zone zone = new InnerQueryEcsByParamResponse.InnerQueryEcsByParam_EcsInstance.InnerQueryEcsByParam_Zone();
				zone.ZoneMemo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.ZoneMemo");
				zone.IsWritable = context.BooleanValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.IsWritable");
				zone.ZoneName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.ZoneName");
				zone.ZoneNoAlias = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.ZoneNoAlias");
				zone.IsActive = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.IsActive");
				zone.Id = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.Id");
				zone.ZoneEnName = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.ZoneEnName");
				zone.ZoneNo = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.ZoneNo");
				zone.RouteIpSegment = context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.RouteIpSegment");
				zone.RegionId = context.LongValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.RegionId");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryEcsByParam.EcsInstances["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
				ecsInstance.Zone = zone;

				innerQueryEcsByParamResponse_ecsInstances.Add(ecsInstance);
			}
			innerQueryEcsByParamResponse.EcsInstances = innerQueryEcsByParamResponse_ecsInstances;
        
			return innerQueryEcsByParamResponse;
        }
    }
}
