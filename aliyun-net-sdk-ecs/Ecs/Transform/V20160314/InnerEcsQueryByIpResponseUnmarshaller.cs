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
    public class InnerEcsQueryByIpResponseUnmarshaller
    {
        public static InnerEcsQueryByIpResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryByIpResponse innerEcsQueryByIpResponse = new InnerEcsQueryByIpResponse();

			innerEcsQueryByIpResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryByIpResponse.RequestId = context.StringValue("InnerEcsQueryByIp.RequestId");
			innerEcsQueryByIpResponse.Count = context.IntegerValue("InnerEcsQueryByIp.count");

			InnerEcsQueryByIpResponse.InnerEcsQueryByIp_ErrorCode errorCode = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryByIp.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryByIp.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryByIp.ErrorCode.isSuccess");
			innerEcsQueryByIpResponse.ErrorCode = errorCode;

			List<InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item> innerEcsQueryByIpResponse_data = new List<InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item>();
			for (int i = 0; i < context.Length("InnerEcsQueryByIp.Data.Length"); i++) {
				InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item item = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item();
				item.Recoverable = context.BooleanValue("InnerEcsQueryByIp.Data["+ i +"].recoverable");
				item.EipInstanceId = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].eipInstanceId");
				item.IsWin = context.BooleanValue("InnerEcsQueryByIp.Data["+ i +"].isWin");
				item.GmtRelease = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].gmtRelease");
				item.SerialNumber = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].serialNumber");
				item.InstanceTypeGeneration = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].instanceTypeGeneration");
				item.IntranetRx = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].intranetRx");
				item.ImageProductCode = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].imageProductCode");
				item.EcsBusinessStatus = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].ecsBusinessStatus");
				item.Description = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].description");
				item.InternetIp = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].internetIp");
				item.ImageNo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].imageNo");
				item.InternetRx = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].internetRx");
				item.Status = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].status");
				item.ImageName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].imageName");
				item.OsType = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].osType");
				item.Hostname = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].hostname");
				item.EipBandwidth = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].eipBandwidth");
				item.NetWorkType = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].netWorkType");
				item.NatIp = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].natIp");
				item.InstanceType = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].instanceType");
				item.RecoverPolicy = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].recoverPolicy");
				item.IoOptimized = context.BooleanValue("InnerEcsQueryByIp.Data["+ i +"].ioOptimized");
				item.OsName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].osName");
				item.IntranetIp = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].intranetIp");
				item.Eip = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].eip");
				item.GmtModified = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].gmtModified");
				item.IopsSize = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].iopsSize");
				item.SystemDiskCategory = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].systemDiskCategory");
				item.IntranetTx = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].intranetTx");
				item.GmtStarted = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].gmtStarted");
				item.GmtSync = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].gmtSync");
				item.Cores = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].cores");
				item.AliUid = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].aliUid");
				item.ImageId = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].imageId");
				item.GmtCreated = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].gmtCreated");
				item.GroupNo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].groupNo");
				item.VpcInstanceId = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].vpcInstanceId");
				item.Bid = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].bid");
				item.AgentId = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].agentId");
				item.RealHostname = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].realHostname");
				item.InstanceId = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].instanceId");
				item.InstanceTypeFamily = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].instanceTypeFamily");
				item.NetworkValidation = context.BooleanValue("InnerEcsQueryByIp.Data["+ i +"].networkValidation");
				item.ZoneId = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].zoneId");
				item.Memory = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].memory");
				item.InternetTx = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].internetTx");
				item.VswitchInstanceId = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].vswitchInstanceId");
				item.ImageType = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].imageType");
				item.IzId = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].izId");
				item.DiskSize = context.IntegerValue("InnerEcsQueryByIp.Data["+ i +"].diskSize");

				InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Region region = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Region();
				region.Id = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].Region.id");
				region.IsActive = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.isActive");
				region.RegionEnName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.regionEnName");
				region.RegionNoAlias = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.regionNoAlias");
				region.RegionName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.regionName");
				region.RegionMemo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.regionMemo");
				region.RegionNo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.regionNo");

				InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Region.InnerEcsQueryByIp_Attributes attributes = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Region.InnerEcsQueryByIp_Attributes();
				attributes.Support_image_copy = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.Attributes.support_image_copy");
				attributes.Internal_use = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.Attributes.internal_use");
				attributes.Ak_name = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Region.Attributes.ak_name");
				region.Attributes = attributes;
				item.Region = region;

				InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Iz iz = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Iz();
				iz.RegionNo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.regionNo");
				iz.Status = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.status");
				iz.No = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.no");
				iz.EnName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.enName");
				iz.CnName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.cnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Iz.InnerEcsQueryByIp_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Iz.InnerEcsQueryByIp_IzResourceModelItem>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Iz.InnerEcsQueryByIp_IzResourceModelItem izResourceModelItem = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Iz.InnerEcsQueryByIp_IzResourceModelItem();
					izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].supportIoOptimized");

					List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

					List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

					List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

					List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

					List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

					List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

					List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceModelItem);
				}
				iz.IzResourceModel = iz_izResourceModel;
				item.Iz = iz;

				InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Zone zone = new InnerEcsQueryByIpResponse.InnerEcsQueryByIp_Item.InnerEcsQueryByIp_Zone();
				zone.ZoneMemo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.zoneMemo");
				zone.IsWritable = context.BooleanValue("InnerEcsQueryByIp.Data["+ i +"].Zone.isWritable");
				zone.ZoneName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.zoneName");
				zone.ZoneNoAlias = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.zoneNoAlias");
				zone.IsActive = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.isActive");
				zone.Id = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].Zone.id");
				zone.ZoneEnName = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.zoneEnName");
				zone.ZoneNo = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.zoneNo");
				zone.RouteIpSegment = context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.routeIpSegment");
				zone.RegionId = context.LongValue("InnerEcsQueryByIp.Data["+ i +"].Zone.regionId");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIp.Data["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryByIp.Data["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
				item.Zone = zone;

				innerEcsQueryByIpResponse_data.Add(item);
			}
			innerEcsQueryByIpResponse.Data = innerEcsQueryByIpResponse_data;
        
			return innerEcsQueryByIpResponse;
        }
    }
}
