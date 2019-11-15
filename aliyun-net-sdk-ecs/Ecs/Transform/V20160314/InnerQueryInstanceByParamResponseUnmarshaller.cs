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
    public class InnerQueryInstanceByParamResponseUnmarshaller
    {
        public static InnerQueryInstanceByParamResponse Unmarshall(UnmarshallerContext context)
        {
			InnerQueryInstanceByParamResponse innerQueryInstanceByParamResponse = new InnerQueryInstanceByParamResponse();

			innerQueryInstanceByParamResponse.HttpResponse = context.HttpResponse;
			innerQueryInstanceByParamResponse.RequestId = context.StringValue("InnerQueryInstanceByParam.RequestId");
			innerQueryInstanceByParamResponse.TotalCount = context.IntegerValue("InnerQueryInstanceByParam.TotalCount");
			innerQueryInstanceByParamResponse.PageNumber = context.IntegerValue("InnerQueryInstanceByParam.PageNumber");
			innerQueryInstanceByParamResponse.PageSize = context.IntegerValue("InnerQueryInstanceByParam.PageSize");

			List<InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel> innerQueryInstanceByParamResponse_instanceAsyncModels = new List<InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel>();
			for (int i = 0; i < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels.Length"); i++) {
				InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel instanceAsyncModel = new InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel();
				instanceAsyncModel.ImageType = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].ImageType");
				instanceAsyncModel.RecoverPolicy = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].RecoverPolicy");
				instanceAsyncModel.BusinessStatus = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].BusinessStatus");
				instanceAsyncModel.IntranetIp = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].IntranetIp");
				instanceAsyncModel.DiskSize = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].DiskSize");
				instanceAsyncModel.OsName = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].OsName");
				instanceAsyncModel.IzId = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].IzId");
				instanceAsyncModel.IoOptimized = context.BooleanValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].IoOptimized");
				instanceAsyncModel.Status = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Status");
				instanceAsyncModel.ImageName = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].ImageName");
				instanceAsyncModel.InternetRx = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].InternetRx");
				instanceAsyncModel.InternetTx = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].InternetTx");
				instanceAsyncModel.ZoneId = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].ZoneId");
				instanceAsyncModel.Memory = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Memory");
				instanceAsyncModel.Hostname = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Hostname");
				instanceAsyncModel.AgentId = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].AgentId");
				instanceAsyncModel.InstanceId = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].InstanceId");
				instanceAsyncModel.OsType = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].OsType");
				instanceAsyncModel.EcsBusinessStatus = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].EcsBusinessStatus");
				instanceAsyncModel.GroupNo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].GroupNo");
				instanceAsyncModel.Id = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Id");
				instanceAsyncModel.ImageId = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].ImageId");
				instanceAsyncModel.GmtCreated = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].GmtCreated");
				instanceAsyncModel.InternetIp = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].InternetIp");
				instanceAsyncModel.Bid = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Bid");
				instanceAsyncModel.ImageNo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].ImageNo");
				instanceAsyncModel.GmtModified = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].GmtModified");
				instanceAsyncModel.IsWin = context.BooleanValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].IsWin");
				instanceAsyncModel.Recoverable = context.BooleanValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Recoverable");
				instanceAsyncModel.ImagePc = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].ImagePc");
				instanceAsyncModel.IntranetRx = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].IntranetRx");
				instanceAsyncModel.AliUid = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].AliUid");
				instanceAsyncModel.GmtStarted = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].GmtStarted");
				instanceAsyncModel.IntranetTx = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].IntranetTx");
				instanceAsyncModel.Cores = context.IntegerValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Cores");
				instanceAsyncModel.GmtSync = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].GmtSync");
				instanceAsyncModel.SystemDiskCategory = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].SystemDiskCategory");
				instanceAsyncModel.GmtRelease = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].GmtRelease");

				InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Zone zone = new InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Zone();
				zone.ZoneNo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.ZoneNo");
				zone.Id = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.Id");
				zone.IsActive = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.IsActive");
				zone.ZoneNoAlias = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.ZoneNoAlias");
				zone.RegionId = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.RegionId");
				zone.RouteIpSegment = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.RouteIpSegment");
				zone.ZoneMemo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.ZoneMemo");
				zone.ZoneName = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.ZoneName");
				zone.IsWritable = context.BooleanValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.IsWritable");
				zone.AvailableZoneID = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.AvailableZoneID");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;

				List<string> zone_networkType = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.NetworkType.Length"); j++) {
					zone_networkType.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.NetworkType["+ j +"]"));
				}
				zone.NetworkType = zone_networkType;

				List<string> zone_diskType = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.DiskType.Length"); j++) {
					zone_diskType.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Zone.DiskType["+ j +"]"));
				}
				zone.DiskType = zone_diskType;
				instanceAsyncModel.Zone = zone;

				InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Iz iz = new InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Iz();
				iz.RegionNo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.RegionNo");
				iz.Status = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.Status");
				iz.No = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.No");
				iz.EnName = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.EnName");
				iz.CnName = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.CnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Iz.InnerQueryInstanceByParam_IzResourceMode> iz_izResourceModel = new List<InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Iz.InnerQueryInstanceByParam_IzResourceMode>();
				for (int j = 0; j < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Iz.InnerQueryInstanceByParam_IzResourceMode izResourceMode = new InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Iz.InnerQueryInstanceByParam_IzResourceMode();
					izResourceMode.SupportIoOptimized = context.BooleanValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportIoOptimized");

					List<string> izResourceMode_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceMode_allowedResourceCreation.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceMode.AllowedResourceCreation = izResourceMode_allowedResourceCreation;

					List<string> izResourceMode_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceMode_supportedDataDiskCategories.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedDataDiskCategories = izResourceMode_supportedDataDiskCategories;

					List<string> izResourceMode_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceMode_supportedInstanceGenerations1.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceMode.SupportedInstanceGenerations1 = izResourceMode_supportedInstanceGenerations1;

					List<string> izResourceMode_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceMode_supportedNetworkCategories.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceMode.SupportedNetworkCategories = izResourceMode_supportedNetworkCategories;

					List<string> izResourceMode_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceMode_supportedSystemDiskCategories.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceMode.SupportedSystemDiskCategories = izResourceMode_supportedSystemDiskCategories;

					List<string> izResourceMode_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceMode_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypeFamilies2 = izResourceMode_supportedInstanceTypeFamilies2;

					List<string> izResourceMode_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceMode_supportedInstanceTypes.Add(context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceMode.SupportedInstanceTypes = izResourceMode_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceMode);
				}
				iz.IzResourceModel = iz_izResourceModel;
				instanceAsyncModel.Iz = iz;

				InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Region region = new InnerQueryInstanceByParamResponse.InnerQueryInstanceByParam_InstanceAsyncModel.InnerQueryInstanceByParam_Region();
				region.RegionNoAlias = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Region.RegionNoAlias");
				region.RegionNo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Region.RegionNo");
				region.RegionName = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Region.RegionName");
				region.RegionMemo = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Region.RegionMemo");
				region.Id = context.LongValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Region.Id");
				region.IsActive = context.StringValue("InnerQueryInstanceByParam.InstanceAsyncModels["+ i +"].Region.IsActive");
				instanceAsyncModel.Region = region;

				innerQueryInstanceByParamResponse_instanceAsyncModels.Add(instanceAsyncModel);
			}
			innerQueryInstanceByParamResponse.InstanceAsyncModels = innerQueryInstanceByParamResponse_instanceAsyncModels;
        
			return innerQueryInstanceByParamResponse;
        }
    }
}
