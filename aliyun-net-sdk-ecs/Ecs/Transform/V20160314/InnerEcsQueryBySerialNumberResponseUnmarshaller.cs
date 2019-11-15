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
    public class InnerEcsQueryBySerialNumberResponseUnmarshaller
    {
        public static InnerEcsQueryBySerialNumberResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryBySerialNumberResponse innerEcsQueryBySerialNumberResponse = new InnerEcsQueryBySerialNumberResponse();

			innerEcsQueryBySerialNumberResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryBySerialNumberResponse.RequestId = context.StringValue("InnerEcsQueryBySerialNumber.RequestId");

			InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_ErrorCode errorCode = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryBySerialNumber.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryBySerialNumber.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryBySerialNumber.ErrorCode.isSuccess");
			innerEcsQueryBySerialNumberResponse.ErrorCode = errorCode;

			InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data data = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data();
			data.Recoverable = context.BooleanValue("InnerEcsQueryBySerialNumber.Data.recoverable");
			data.EipInstanceId = context.StringValue("InnerEcsQueryBySerialNumber.Data.eipInstanceId");
			data.IsWin = context.BooleanValue("InnerEcsQueryBySerialNumber.Data.isWin");
			data.GmtRelease = context.StringValue("InnerEcsQueryBySerialNumber.Data.gmtRelease");
			data.SerialNumber = context.StringValue("InnerEcsQueryBySerialNumber.Data.serialNumber");
			data.InstanceTypeGeneration = context.StringValue("InnerEcsQueryBySerialNumber.Data.instanceTypeGeneration");
			data.IntranetRx = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.intranetRx");
			data.ImageProductCode = context.StringValue("InnerEcsQueryBySerialNumber.Data.imageProductCode");
			data.EcsBusinessStatus = context.StringValue("InnerEcsQueryBySerialNumber.Data.ecsBusinessStatus");
			data.Description = context.StringValue("InnerEcsQueryBySerialNumber.Data.description");
			data.InternetIp = context.StringValue("InnerEcsQueryBySerialNumber.Data.internetIp");
			data.ImageNo = context.StringValue("InnerEcsQueryBySerialNumber.Data.imageNo");
			data.InternetRx = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.internetRx");
			data.Status = context.StringValue("InnerEcsQueryBySerialNumber.Data.status");
			data.ImageName = context.StringValue("InnerEcsQueryBySerialNumber.Data.imageName");
			data.OsType = context.StringValue("InnerEcsQueryBySerialNumber.Data.osType");
			data.Hostname = context.StringValue("InnerEcsQueryBySerialNumber.Data.hostname");
			data.EipBandwidth = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.eipBandwidth");
			data.NetWorkType = context.StringValue("InnerEcsQueryBySerialNumber.Data.netWorkType");
			data.NatIp = context.StringValue("InnerEcsQueryBySerialNumber.Data.natIp");
			data.InstanceType = context.StringValue("InnerEcsQueryBySerialNumber.Data.instanceType");
			data.RecoverPolicy = context.StringValue("InnerEcsQueryBySerialNumber.Data.recoverPolicy");
			data.IoOptimized = context.BooleanValue("InnerEcsQueryBySerialNumber.Data.ioOptimized");
			data.OsName = context.StringValue("InnerEcsQueryBySerialNumber.Data.osName");
			data.IntranetIp = context.StringValue("InnerEcsQueryBySerialNumber.Data.intranetIp");
			data.Eip = context.StringValue("InnerEcsQueryBySerialNumber.Data.eip");
			data.GmtModified = context.StringValue("InnerEcsQueryBySerialNumber.Data.gmtModified");
			data.IopsSize = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.iopsSize");
			data.SystemDiskCategory = context.StringValue("InnerEcsQueryBySerialNumber.Data.systemDiskCategory");
			data.IntranetTx = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.intranetTx");
			data.GmtStarted = context.StringValue("InnerEcsQueryBySerialNumber.Data.gmtStarted");
			data.GmtSync = context.StringValue("InnerEcsQueryBySerialNumber.Data.gmtSync");
			data.Cores = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.cores");
			data.AliUid = context.LongValue("InnerEcsQueryBySerialNumber.Data.aliUid");
			data.ImageId = context.LongValue("InnerEcsQueryBySerialNumber.Data.imageId");
			data.GmtCreated = context.StringValue("InnerEcsQueryBySerialNumber.Data.gmtCreated");
			data.GroupNo = context.StringValue("InnerEcsQueryBySerialNumber.Data.groupNo");
			data.VpcInstanceId = context.StringValue("InnerEcsQueryBySerialNumber.Data.vpcInstanceId");
			data.Bid = context.StringValue("InnerEcsQueryBySerialNumber.Data.bid");
			data.AgentId = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.agentId");
			data.RealHostname = context.StringValue("InnerEcsQueryBySerialNumber.Data.realHostname");
			data.InstanceId = context.StringValue("InnerEcsQueryBySerialNumber.Data.instanceId");
			data.InstanceTypeFamily = context.StringValue("InnerEcsQueryBySerialNumber.Data.instanceTypeFamily");
			data.NetworkValidation = context.BooleanValue("InnerEcsQueryBySerialNumber.Data.networkValidation");
			data.ZoneId = context.LongValue("InnerEcsQueryBySerialNumber.Data.zoneId");
			data.Memory = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.memory");
			data.InternetTx = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.internetTx");
			data.VswitchInstanceId = context.StringValue("InnerEcsQueryBySerialNumber.Data.vswitchInstanceId");
			data.ImageType = context.StringValue("InnerEcsQueryBySerialNumber.Data.imageType");
			data.IzId = context.LongValue("InnerEcsQueryBySerialNumber.Data.izId");
			data.DiskSize = context.IntegerValue("InnerEcsQueryBySerialNumber.Data.diskSize");

			InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Region region = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Region();
			region.Id = context.LongValue("InnerEcsQueryBySerialNumber.Data.Region.id");
			region.IsActive = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.isActive");
			region.RegionEnName = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.regionEnName");
			region.RegionNoAlias = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.regionNoAlias");
			region.RegionName = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.regionName");
			region.RegionMemo = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.regionMemo");
			region.RegionNo = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.regionNo");

			InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Region.InnerEcsQueryBySerialNumber_Attributes attributes = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Region.InnerEcsQueryBySerialNumber_Attributes();
			attributes.Support_image_copy = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.Attributes.support_image_copy");
			attributes.Internal_use = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.Attributes.internal_use");
			attributes.Ak_name = context.StringValue("InnerEcsQueryBySerialNumber.Data.Region.Attributes.ak_name");
			region.Attributes = attributes;
			data.Region = region;

			InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Iz iz = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Iz();
			iz.RegionNo = context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.regionNo");
			iz.Status = context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.status");
			iz.No = context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.no");
			iz.EnName = context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.enName");
			iz.CnName = context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.cnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Iz.InnerEcsQueryBySerialNumber_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Iz.InnerEcsQueryBySerialNumber_IzResourceModelItem>();
			for (int i = 0; i < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel.Length"); i++) {
				InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Iz.InnerEcsQueryBySerialNumber_IzResourceModelItem izResourceModelItem = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Iz.InnerEcsQueryBySerialNumber_IzResourceModelItem();
				izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].supportIoOptimized");

				List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

				List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

				List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

				List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

				List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

				List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

				List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceModelItem);
			}
			iz.IzResourceModel = iz_izResourceModel;
			data.Iz = iz;

			InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Zone zone = new InnerEcsQueryBySerialNumberResponse.InnerEcsQueryBySerialNumber_Data.InnerEcsQueryBySerialNumber_Zone();
			zone.ZoneMemo = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.zoneMemo");
			zone.IsWritable = context.BooleanValue("InnerEcsQueryBySerialNumber.Data.Zone.isWritable");
			zone.ZoneName = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.zoneName");
			zone.ZoneNoAlias = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.zoneNoAlias");
			zone.IsActive = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.isActive");
			zone.Id = context.LongValue("InnerEcsQueryBySerialNumber.Data.Zone.id");
			zone.ZoneEnName = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.zoneEnName");
			zone.ZoneNo = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.zoneNo");
			zone.RouteIpSegment = context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.routeIpSegment");
			zone.RegionId = context.LongValue("InnerEcsQueryBySerialNumber.Data.Zone.regionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryBySerialNumber.Data.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryBySerialNumber.Data.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			data.Zone = zone;
			innerEcsQueryBySerialNumberResponse.Data = data;
        
			return innerEcsQueryBySerialNumberResponse;
        }
    }
}
