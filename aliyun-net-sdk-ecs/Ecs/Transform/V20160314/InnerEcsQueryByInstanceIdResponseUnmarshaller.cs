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
    public class InnerEcsQueryByInstanceIdResponseUnmarshaller
    {
        public static InnerEcsQueryByInstanceIdResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryByInstanceIdResponse innerEcsQueryByInstanceIdResponse = new InnerEcsQueryByInstanceIdResponse();

			innerEcsQueryByInstanceIdResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryByInstanceIdResponse.RequestId = context.StringValue("InnerEcsQueryByInstanceId.RequestId");

			InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_ErrorCode errorCode = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryByInstanceId.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryByInstanceId.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryByInstanceId.ErrorCode.isSuccess");
			innerEcsQueryByInstanceIdResponse.ErrorCode = errorCode;

			InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data data = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data();
			data.Recoverable = context.BooleanValue("InnerEcsQueryByInstanceId.Data.recoverable");
			data.EipInstanceId = context.StringValue("InnerEcsQueryByInstanceId.Data.eipInstanceId");
			data.IsWin = context.BooleanValue("InnerEcsQueryByInstanceId.Data.isWin");
			data.GmtRelease = context.StringValue("InnerEcsQueryByInstanceId.Data.gmtRelease");
			data.SerialNumber = context.StringValue("InnerEcsQueryByInstanceId.Data.serialNumber");
			data.InstanceTypeGeneration = context.StringValue("InnerEcsQueryByInstanceId.Data.instanceTypeGeneration");
			data.IntranetRx = context.IntegerValue("InnerEcsQueryByInstanceId.Data.intranetRx");
			data.ImageProductCode = context.StringValue("InnerEcsQueryByInstanceId.Data.imageProductCode");
			data.EcsBusinessStatus = context.StringValue("InnerEcsQueryByInstanceId.Data.ecsBusinessStatus");
			data.Description = context.StringValue("InnerEcsQueryByInstanceId.Data.description");
			data.InternetIp = context.StringValue("InnerEcsQueryByInstanceId.Data.internetIp");
			data.ImageNo = context.StringValue("InnerEcsQueryByInstanceId.Data.imageNo");
			data.InternetRx = context.IntegerValue("InnerEcsQueryByInstanceId.Data.internetRx");
			data.Status = context.StringValue("InnerEcsQueryByInstanceId.Data.status");
			data.ImageName = context.StringValue("InnerEcsQueryByInstanceId.Data.imageName");
			data.OsType = context.StringValue("InnerEcsQueryByInstanceId.Data.osType");
			data.Hostname = context.StringValue("InnerEcsQueryByInstanceId.Data.hostname");
			data.EipBandwidth = context.IntegerValue("InnerEcsQueryByInstanceId.Data.eipBandwidth");
			data.NetWorkType = context.StringValue("InnerEcsQueryByInstanceId.Data.netWorkType");
			data.NatIp = context.StringValue("InnerEcsQueryByInstanceId.Data.natIp");
			data.InstanceType = context.StringValue("InnerEcsQueryByInstanceId.Data.instanceType");
			data.RecoverPolicy = context.StringValue("InnerEcsQueryByInstanceId.Data.recoverPolicy");
			data.IoOptimized = context.BooleanValue("InnerEcsQueryByInstanceId.Data.ioOptimized");
			data.OsName = context.StringValue("InnerEcsQueryByInstanceId.Data.osName");
			data.IntranetIp = context.StringValue("InnerEcsQueryByInstanceId.Data.intranetIp");
			data.Eip = context.StringValue("InnerEcsQueryByInstanceId.Data.eip");
			data.GmtModified = context.StringValue("InnerEcsQueryByInstanceId.Data.gmtModified");
			data.IopsSize = context.IntegerValue("InnerEcsQueryByInstanceId.Data.iopsSize");
			data.SystemDiskCategory = context.StringValue("InnerEcsQueryByInstanceId.Data.systemDiskCategory");
			data.IntranetTx = context.IntegerValue("InnerEcsQueryByInstanceId.Data.intranetTx");
			data.GmtStarted = context.StringValue("InnerEcsQueryByInstanceId.Data.gmtStarted");
			data.GmtSync = context.StringValue("InnerEcsQueryByInstanceId.Data.gmtSync");
			data.Cores = context.IntegerValue("InnerEcsQueryByInstanceId.Data.cores");
			data.AliUid = context.LongValue("InnerEcsQueryByInstanceId.Data.aliUid");
			data.ImageId = context.LongValue("InnerEcsQueryByInstanceId.Data.imageId");
			data.GmtCreated = context.StringValue("InnerEcsQueryByInstanceId.Data.gmtCreated");
			data.GroupNo = context.StringValue("InnerEcsQueryByInstanceId.Data.groupNo");
			data.VpcInstanceId = context.StringValue("InnerEcsQueryByInstanceId.Data.vpcInstanceId");
			data.Bid = context.StringValue("InnerEcsQueryByInstanceId.Data.bid");
			data.AgentId = context.IntegerValue("InnerEcsQueryByInstanceId.Data.agentId");
			data.RealHostname = context.StringValue("InnerEcsQueryByInstanceId.Data.realHostname");
			data.InstanceId = context.StringValue("InnerEcsQueryByInstanceId.Data.instanceId");
			data.InstanceTypeFamily = context.StringValue("InnerEcsQueryByInstanceId.Data.instanceTypeFamily");
			data.NetworkValidation = context.BooleanValue("InnerEcsQueryByInstanceId.Data.networkValidation");
			data.ZoneId = context.LongValue("InnerEcsQueryByInstanceId.Data.zoneId");
			data.Memory = context.IntegerValue("InnerEcsQueryByInstanceId.Data.memory");
			data.InternetTx = context.IntegerValue("InnerEcsQueryByInstanceId.Data.internetTx");
			data.VswitchInstanceId = context.StringValue("InnerEcsQueryByInstanceId.Data.vswitchInstanceId");
			data.ImageType = context.StringValue("InnerEcsQueryByInstanceId.Data.imageType");
			data.IzId = context.LongValue("InnerEcsQueryByInstanceId.Data.izId");
			data.DiskSize = context.IntegerValue("InnerEcsQueryByInstanceId.Data.diskSize");

			InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Region region = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Region();
			region.Id = context.LongValue("InnerEcsQueryByInstanceId.Data.Region.id");
			region.IsActive = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.isActive");
			region.RegionEnName = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.regionEnName");
			region.RegionNoAlias = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.regionNoAlias");
			region.RegionName = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.regionName");
			region.RegionMemo = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.regionMemo");
			region.RegionNo = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.regionNo");

			InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Region.InnerEcsQueryByInstanceId_Attributes attributes = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Region.InnerEcsQueryByInstanceId_Attributes();
			attributes.Support_image_copy = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.Attributes.support_image_copy");
			attributes.Internal_use = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.Attributes.internal_use");
			attributes.Ak_name = context.StringValue("InnerEcsQueryByInstanceId.Data.Region.Attributes.ak_name");
			region.Attributes = attributes;
			data.Region = region;

			InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Iz iz = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Iz();
			iz.RegionNo = context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.regionNo");
			iz.Status = context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.status");
			iz.No = context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.no");
			iz.EnName = context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.enName");
			iz.CnName = context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.cnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInstanceId.Data.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInstanceId.Data.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInstanceId.Data.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Iz.InnerEcsQueryByInstanceId_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Iz.InnerEcsQueryByInstanceId_IzResourceModelItem>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel.Length"); i++) {
				InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Iz.InnerEcsQueryByInstanceId_IzResourceModelItem izResourceModelItem = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Iz.InnerEcsQueryByInstanceId_IzResourceModelItem();
				izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].supportIoOptimized");

				List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

				List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

				List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

				List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

				List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

				List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

				List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceModelItem);
			}
			iz.IzResourceModel = iz_izResourceModel;
			data.Iz = iz;

			InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Zone zone = new InnerEcsQueryByInstanceIdResponse.InnerEcsQueryByInstanceId_Data.InnerEcsQueryByInstanceId_Zone();
			zone.ZoneMemo = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.zoneMemo");
			zone.IsWritable = context.BooleanValue("InnerEcsQueryByInstanceId.Data.Zone.isWritable");
			zone.ZoneName = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.zoneName");
			zone.ZoneNoAlias = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.zoneNoAlias");
			zone.IsActive = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.isActive");
			zone.Id = context.LongValue("InnerEcsQueryByInstanceId.Data.Zone.id");
			zone.ZoneEnName = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.zoneEnName");
			zone.ZoneNo = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.zoneNo");
			zone.RouteIpSegment = context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.routeIpSegment");
			zone.RegionId = context.LongValue("InnerEcsQueryByInstanceId.Data.Zone.regionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInstanceId.Data.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryByInstanceId.Data.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			data.Zone = zone;
			innerEcsQueryByInstanceIdResponse.Data = data;
        
			return innerEcsQueryByInstanceIdResponse;
        }
    }
}
