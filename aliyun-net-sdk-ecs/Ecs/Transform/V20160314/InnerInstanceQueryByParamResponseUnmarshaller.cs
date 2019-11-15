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
    public class InnerInstanceQueryByParamResponseUnmarshaller
    {
        public static InnerInstanceQueryByParamResponse Unmarshall(UnmarshallerContext context)
        {
			InnerInstanceQueryByParamResponse innerInstanceQueryByParamResponse = new InnerInstanceQueryByParamResponse();

			innerInstanceQueryByParamResponse.HttpResponse = context.HttpResponse;
			innerInstanceQueryByParamResponse.RequestId = context.StringValue("InnerInstanceQueryByParam.RequestId");
			innerInstanceQueryByParamResponse.Count = context.IntegerValue("InnerInstanceQueryByParam.count");
			innerInstanceQueryByParamResponse.PageNo = context.IntegerValue("InnerInstanceQueryByParam.pageNo");
			innerInstanceQueryByParamResponse.PageSize = context.IntegerValue("InnerInstanceQueryByParam.pageSize");

			InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_ErrorCode errorCode = new InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_ErrorCode();
			errorCode.Code = context.StringValue("InnerInstanceQueryByParam.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerInstanceQueryByParam.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerInstanceQueryByParam.ErrorCode.isSuccess");
			innerInstanceQueryByParamResponse.ErrorCode = errorCode;

			List<InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item> innerInstanceQueryByParamResponse_data = new List<InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item>();
			for (int i = 0; i < context.Length("InnerInstanceQueryByParam.Data.Length"); i++) {
				InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item item = new InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item();
				item.ImageType = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].imageType");
				item.RecoverPolicy = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].recoverPolicy");
				item.BusinessStatus = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].businessStatus");
				item.IntranetIp = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].intranetIp");
				item.DiskSize = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].diskSize");
				item.OsName = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].osName");
				item.IzId = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].izId");
				item.IoOptimized = context.BooleanValue("InnerInstanceQueryByParam.Data["+ i +"].ioOptimized");
				item.Status = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].status");
				item.ImageName = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].imageName");
				item.InternetRx = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].internetRx");
				item.InternetTx = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].internetTx");
				item.ZoneId = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].zoneId");
				item.Memory = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].memory");
				item.Hostname = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].hostname");
				item.AgentId = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].agentId");
				item.InstanceId = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].instanceId");
				item.OsType = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].osType");
				item.EcsBusinessStatus = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].ecsBusinessStatus");
				item.GroupNo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].groupNo");
				item.Id = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].id");
				item.ImageId = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].imageId");
				item.GmtCreated = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].gmtCreated");
				item.InternetIp = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].internetIp");
				item.Bid = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].bid");
				item.ImageNo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].imageNo");
				item.GmtModified = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].gmtModified");
				item.IsWin = context.BooleanValue("InnerInstanceQueryByParam.Data["+ i +"].isWin");
				item.Recoverable = context.BooleanValue("InnerInstanceQueryByParam.Data["+ i +"].recoverable");
				item.ImagePc = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].imagePc");
				item.IntranetRx = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].intranetRx");
				item.AliUid = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].aliUid");
				item.GmtStarted = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].gmtStarted");
				item.IntranetTx = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].intranetTx");
				item.Cores = context.IntegerValue("InnerInstanceQueryByParam.Data["+ i +"].cores");
				item.GmtSync = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].gmtSync");
				item.SystemDiskCategory = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].systemDiskCategory");
				item.GmtRelease = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].gmtRelease");

				InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Zone zone = new InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Zone();
				zone.ZoneNo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.zoneNo");
				zone.Id = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.id");
				zone.IsActive = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.isActive");
				zone.ZoneNoAlias = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.zoneNoAlias");
				zone.RegionId = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.regionId");
				zone.RouteIpSegment = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.routeIpSegment");
				zone.ZoneMemo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.zoneMemo");
				zone.ZoneName = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.zoneName");
				zone.IsWritable = context.BooleanValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.isWritable");
				zone.AvailableZoneID = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.availableZoneID");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;

				List<string> zone_networkType = new List<string>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Zone.NetworkType.Length"); j++) {
					zone_networkType.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.NetworkType["+ j +"]"));
				}
				zone.NetworkType = zone_networkType;

				List<string> zone_diskType = new List<string>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Zone.DiskType.Length"); j++) {
					zone_diskType.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Zone.DiskType["+ j +"]"));
				}
				zone.DiskType = zone_diskType;
				item.Zone = zone;

				InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Iz iz = new InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Iz();
				iz.RegionNo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.regionNo");
				iz.Status = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.status");
				iz.No = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.no");
				iz.EnName = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.enName");
				iz.CnName = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.cnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Iz.InnerInstanceQueryByParam_IzResourceModelItem> iz_izResourceModel = new List<InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Iz.InnerInstanceQueryByParam_IzResourceModelItem>();
				for (int j = 0; j < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Iz.InnerInstanceQueryByParam_IzResourceModelItem izResourceModelItem = new InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Iz.InnerInstanceQueryByParam_IzResourceModelItem();
					izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].supportIoOptimized");

					List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

					List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

					List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

					List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

					List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

					List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

					List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceModelItem);
				}
				iz.IzResourceModel = iz_izResourceModel;
				item.Iz = iz;

				InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Region region = new InnerInstanceQueryByParamResponse.InnerInstanceQueryByParam_Item.InnerInstanceQueryByParam_Region();
				region.RegionNoAlias = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Region.regionNoAlias");
				region.RegionNo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Region.regionNo");
				region.RegionName = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Region.regionName");
				region.RegionMemo = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Region.regionMemo");
				region.Id = context.LongValue("InnerInstanceQueryByParam.Data["+ i +"].Region.id");
				region.IsActive = context.StringValue("InnerInstanceQueryByParam.Data["+ i +"].Region.isActive");
				item.Region = region;

				innerInstanceQueryByParamResponse_data.Add(item);
			}
			innerInstanceQueryByParamResponse.Data = innerInstanceQueryByParamResponse_data;
        
			return innerInstanceQueryByParamResponse;
        }
    }
}
