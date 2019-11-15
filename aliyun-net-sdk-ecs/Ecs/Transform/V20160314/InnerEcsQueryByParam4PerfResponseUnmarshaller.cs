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
    public class InnerEcsQueryByParam4PerfResponseUnmarshaller
    {
        public static InnerEcsQueryByParam4PerfResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryByParam4PerfResponse innerEcsQueryByParam4PerfResponse = new InnerEcsQueryByParam4PerfResponse();

			innerEcsQueryByParam4PerfResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryByParam4PerfResponse.RequestId = context.StringValue("InnerEcsQueryByParam4Perf.RequestId");
			innerEcsQueryByParam4PerfResponse.Count = context.IntegerValue("InnerEcsQueryByParam4Perf.count");
			innerEcsQueryByParam4PerfResponse.PageNo = context.IntegerValue("InnerEcsQueryByParam4Perf.pageNo");
			innerEcsQueryByParam4PerfResponse.PageSize = context.IntegerValue("InnerEcsQueryByParam4Perf.pageSize");

			InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_ErrorCode errorCode = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryByParam4Perf.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryByParam4Perf.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryByParam4Perf.ErrorCode.isSuccess");
			innerEcsQueryByParam4PerfResponse.ErrorCode = errorCode;

			List<InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item> innerEcsQueryByParam4PerfResponse_data = new List<InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item>();
			for (int i = 0; i < context.Length("InnerEcsQueryByParam4Perf.Data.Length"); i++) {
				InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item item = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item();
				item.Recoverable = context.BooleanValue("InnerEcsQueryByParam4Perf.Data["+ i +"].recoverable");
				item.EipInstanceId = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].eipInstanceId");
				item.IsWin = context.BooleanValue("InnerEcsQueryByParam4Perf.Data["+ i +"].isWin");
				item.GmtRelease = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].gmtRelease");
				item.SerialNumber = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].serialNumber");
				item.InstanceTypeGeneration = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].instanceTypeGeneration");
				item.IntranetRx = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].intranetRx");
				item.ImageProductCode = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].imageProductCode");
				item.EcsBusinessStatus = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].ecsBusinessStatus");
				item.Description = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].description");
				item.InternetIp = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].internetIp");
				item.ImageNo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].imageNo");
				item.InternetRx = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].internetRx");
				item.Status = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].status");
				item.ImageName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].imageName");
				item.OsType = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].osType");
				item.Hostname = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].hostname");
				item.EipBandwidth = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].eipBandwidth");
				item.NetWorkType = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].netWorkType");
				item.NatIp = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].natIp");
				item.InstanceType = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].instanceType");
				item.RecoverPolicy = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].recoverPolicy");
				item.IoOptimized = context.BooleanValue("InnerEcsQueryByParam4Perf.Data["+ i +"].ioOptimized");
				item.OsName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].osName");
				item.IntranetIp = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].intranetIp");
				item.Eip = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].eip");
				item.GmtModified = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].gmtModified");
				item.IopsSize = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].iopsSize");
				item.SystemDiskCategory = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].systemDiskCategory");
				item.IntranetTx = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].intranetTx");
				item.GmtStarted = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].gmtStarted");
				item.GmtSync = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].gmtSync");
				item.Cores = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].cores");
				item.AliUid = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].aliUid");
				item.ImageId = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].imageId");
				item.GmtCreated = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].gmtCreated");
				item.GroupNo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].groupNo");
				item.VpcInstanceId = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].vpcInstanceId");
				item.Bid = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].bid");
				item.AgentId = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].agentId");
				item.RealHostname = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].realHostname");
				item.InstanceId = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].instanceId");
				item.InstanceTypeFamily = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].instanceTypeFamily");
				item.NetworkValidation = context.BooleanValue("InnerEcsQueryByParam4Perf.Data["+ i +"].networkValidation");
				item.ZoneId = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].zoneId");
				item.Memory = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].memory");
				item.InternetTx = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].internetTx");
				item.VswitchInstanceId = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].vswitchInstanceId");
				item.ImageType = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].imageType");
				item.IzId = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].izId");
				item.DiskSize = context.IntegerValue("InnerEcsQueryByParam4Perf.Data["+ i +"].diskSize");

				InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Region region = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Region();
				region.Id = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.id");
				region.IsActive = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.isActive");
				region.RegionEnName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.regionEnName");
				region.RegionNoAlias = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.regionNoAlias");
				region.RegionName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.regionName");
				region.RegionMemo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.regionMemo");
				region.RegionNo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.regionNo");

				InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Region.InnerEcsQueryByParam4Perf_Attributes attributes = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Region.InnerEcsQueryByParam4Perf_Attributes();
				attributes.Support_image_copy = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.Attributes.support_image_copy");
				attributes.Internal_use = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.Attributes.internal_use");
				attributes.Ak_name = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Region.Attributes.ak_name");
				region.Attributes = attributes;
				item.Region = region;

				InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Iz iz = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Iz();
				iz.RegionNo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.regionNo");
				iz.Status = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.status");
				iz.No = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.no");
				iz.EnName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.enName");
				iz.CnName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.cnName");

				List<string> iz_supportedInstanceGenerations = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.SupportedInstanceGenerations.Length"); j++) {
					iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.SupportedInstanceGenerations["+ j +"]"));
				}
				iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

				List<string> iz_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.SupportedInstanceTypeFamilies.Length"); j++) {
					iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.SupportedInstanceTypeFamilies["+ j +"]"));
				}
				iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

				List<string> iz_supportedInstanceTypeNames = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.SupportedInstanceTypeNames.Length"); j++) {
					iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.SupportedInstanceTypeNames["+ j +"]"));
				}
				iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

				List<InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Iz.InnerEcsQueryByParam4Perf_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Iz.InnerEcsQueryByParam4Perf_IzResourceModelItem>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel.Length"); j++) {
					InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Iz.InnerEcsQueryByParam4Perf_IzResourceModelItem izResourceModelItem = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Iz.InnerEcsQueryByParam4Perf_IzResourceModelItem();
					izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].supportIoOptimized");

					List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation.Length"); k++) {
						izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].AllowedResourceCreation["+ k +"]"));
					}
					izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

					List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories.Length"); k++) {
						izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedDataDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

					List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations.Length"); k++) {
						izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceGenerations["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

					List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories.Length"); k++) {
						izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedNetworkCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

					List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories.Length"); k++) {
						izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedSystemDiskCategories["+ k +"]"));
					}
					izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

					List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies.Length"); k++) {
						izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypeFamilies["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

					List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
					for (int k = 0; k < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes.Length"); k++) {
						izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Iz.IzResourceModel["+ j +"].SupportedInstanceTypes["+ k +"]"));
					}
					izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

					iz_izResourceModel.Add(izResourceModelItem);
				}
				iz.IzResourceModel = iz_izResourceModel;
				item.Iz = iz;

				InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Zone zone = new InnerEcsQueryByParam4PerfResponse.InnerEcsQueryByParam4Perf_Item.InnerEcsQueryByParam4Perf_Zone();
				zone.ZoneMemo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.zoneMemo");
				zone.IsWritable = context.BooleanValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.isWritable");
				zone.ZoneName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.zoneName");
				zone.ZoneNoAlias = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.zoneNoAlias");
				zone.IsActive = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.isActive");
				zone.Id = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.id");
				zone.ZoneEnName = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.zoneEnName");
				zone.ZoneNo = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.zoneNo");
				zone.RouteIpSegment = context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.routeIpSegment");
				zone.RegionId = context.LongValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.regionId");

				List<string> zone_supportedDeviceCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.SupportedDeviceCategories.Length"); j++) {
					zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryByParam4Perf.Data["+ i +"].Zone.SupportedDeviceCategories["+ j +"]"));
				}
				zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
				item.Zone = zone;

				innerEcsQueryByParam4PerfResponse_data.Add(item);
			}
			innerEcsQueryByParam4PerfResponse.Data = innerEcsQueryByParam4PerfResponse_data;
        
			return innerEcsQueryByParam4PerfResponse;
        }
    }
}
