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
    public class InnerEcsQueryByParamResponseUnmarshaller
    {
        public static InnerEcsQueryByParamResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryByParamResponse innerEcsQueryByParamResponse = new InnerEcsQueryByParamResponse();

			innerEcsQueryByParamResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryByParamResponse.RequestId = context.StringValue("InnerEcsQueryByParam.RequestId");
			innerEcsQueryByParamResponse.Count = context.IntegerValue("InnerEcsQueryByParam.count");
			innerEcsQueryByParamResponse.PageNo = context.IntegerValue("InnerEcsQueryByParam.pageNo");
			innerEcsQueryByParamResponse.PageSize = context.IntegerValue("InnerEcsQueryByParam.pageSize");

			InnerEcsQueryByParamResponse.InnerEcsQueryByParam_ErrorCode errorCode = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryByParam.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryByParam.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryByParam.ErrorCode.isSuccess");
			innerEcsQueryByParamResponse.ErrorCode = errorCode;

			List<InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item> innerEcsQueryByParamResponse_data = new List<InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item>();
			for (int i = 0; i < context.Length("InnerEcsQueryByParam.Data.Length"); i++) {
				InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item item = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item();
				item.Recoverable = context.BooleanValue("InnerEcsQueryByParam.Data["+ i +"].recoverable");
				item.EipInstanceId = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].eipInstanceId");
				item.IsWin = context.BooleanValue("InnerEcsQueryByParam.Data["+ i +"].isWin");
				item.GmtRelease = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].gmtRelease");
				item.SerialNumber = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].serialNumber");
				item.InstanceTypeGeneration = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].instanceTypeGeneration");
				item.IntranetRx = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].intranetRx");
				item.ImageProductCode = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].imageProductCode");
				item.EcsBusinessStatus = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].ecsBusinessStatus");
				item.Description = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].description");
				item.InternetIp = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].internetIp");
				item.ImageNo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].imageNo");
				item.InternetRx = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].internetRx");
				item.Status = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].status");
				item.ImageName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].imageName");
				item.OsType = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].osType");
				item.Hostname = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].hostname");
				item.EipBandwidth = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].eipBandwidth");
				item.NetWorkType = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].netWorkType");
				item.NatIp = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].natIp");
				item.InstanceType = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].instanceType");
				item.RecoverPolicy = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].recoverPolicy");
				item.IoOptimized = context.BooleanValue("InnerEcsQueryByParam.Data["+ i +"].ioOptimized");
				item.OsName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].osName");
				item.IntranetIp = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].intranetIp");
				item.Eip = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].eip");
				item.GmtModified = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].gmtModified");
				item.IopsSize = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].iopsSize");
				item.SystemDiskCategory = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].systemDiskCategory");
				item.IntranetTx = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].intranetTx");
				item.GmtStarted = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].gmtStarted");
				item.GmtSync = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].gmtSync");
				item.Cores = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].cores");
				item.AliUid = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].aliUid");
				item.ImageId = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].imageId");
				item.GmtCreated = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].gmtCreated");
				item.GroupNo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].groupNo");
				item.VpcInstanceId = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].vpcInstanceId");
				item.Bid = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].bid");
				item.AgentId = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].agentId");
				item.RealHostname = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].realHostname");
				item.InstanceId = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].instanceId");
				item.InstanceTypeFamily = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].instanceTypeFamily");
				item.NetworkValidation = context.BooleanValue("InnerEcsQueryByParam.Data["+ i +"].networkValidation");
				item.ZoneId = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].zoneId");
				item.Memory = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].memory");
				item.InternetTx = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].internetTx");
				item.VswitchInstanceId = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].vswitchInstanceId");
				item.ImageType = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].imageType");
				item.IzId = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].izId");
				item.DiskSize = context.IntegerValue("InnerEcsQueryByParam.Data["+ i +"].diskSize");

				InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Region region = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Region();
				region.Id = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].Region.id");
				region.IsActive = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.isActive");
				region.RegionEnName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.regionEnName");
				region.RegionNoAlias = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.regionNoAlias");
				region.RegionName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.regionName");
				region.RegionMemo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.regionMemo");
				region.RegionNo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.regionNo");

				InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Region.InnerEcsQueryByParam_Attributes attributes = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Region.InnerEcsQueryByParam_Attributes();
				attributes.Support_image_copy = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.Attributes.support_image_copy");
				attributes.Internal_use = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.Attributes.internal_use");
				attributes.Ak_name = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Region.Attributes.ak_name");
				region.Attributes = attributes;
				item.Region = region;

				InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Iz iz = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Iz();
				iz.RegionNo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.regionNo");
				iz.Status = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.status");
				iz.No = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.no");
				iz.EnName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.enName");
				iz.CnName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.cnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Iz.InnerEcsQueryByParam_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Iz.InnerEcsQueryByParam_IzResourceModelItem>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Iz.InnerEcsQueryByParam_IzResourceModelItem izResourceModelItem = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Iz.InnerEcsQueryByParam_IzResourceModelItem();
					izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].supportIoOptimized");

					List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

					List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

					List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

					List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

					List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

					List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

					List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceModelItem);
				}
				iz.IzResourceModel = iz_izResourceModel;
				item.Iz = iz;

				InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Zone zone = new InnerEcsQueryByParamResponse.InnerEcsQueryByParam_Item.InnerEcsQueryByParam_Zone();
				zone.ZoneMemo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.zoneMemo");
				zone.IsWritable = context.BooleanValue("InnerEcsQueryByParam.Data["+ i +"].Zone.isWritable");
				zone.ZoneName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.zoneName");
				zone.ZoneNoAlias = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.zoneNoAlias");
				zone.IsActive = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.isActive");
				zone.Id = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].Zone.id");
				zone.ZoneEnName = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.zoneEnName");
				zone.ZoneNo = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.zoneNo");
				zone.RouteIpSegment = context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.routeIpSegment");
				zone.RegionId = context.LongValue("InnerEcsQueryByParam.Data["+ i +"].Zone.regionId");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam.Data["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryByParam.Data["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
				item.Zone = zone;

				innerEcsQueryByParamResponse_data.Add(item);
			}
			innerEcsQueryByParamResponse.Data = innerEcsQueryByParamResponse_data;
        
			return innerEcsQueryByParamResponse;
        }
    }
}
