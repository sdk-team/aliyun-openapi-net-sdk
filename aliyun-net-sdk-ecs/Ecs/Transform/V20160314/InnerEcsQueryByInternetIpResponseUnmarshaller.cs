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
    public class InnerEcsQueryByInternetIpResponseUnmarshaller
    {
        public static InnerEcsQueryByInternetIpResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryByInternetIpResponse innerEcsQueryByInternetIpResponse = new InnerEcsQueryByInternetIpResponse();

			innerEcsQueryByInternetIpResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryByInternetIpResponse.RequestId = context.StringValue("InnerEcsQueryByInternetIp.RequestId");

			InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_ErrorCode errorCode = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryByInternetIp.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryByInternetIp.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryByInternetIp.ErrorCode.isSuccess");
			innerEcsQueryByInternetIpResponse.ErrorCode = errorCode;

			InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data data = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data();
			data.Recoverable = context.BooleanValue("InnerEcsQueryByInternetIp.Data.recoverable");
			data.EipInstanceId = context.StringValue("InnerEcsQueryByInternetIp.Data.eipInstanceId");
			data.IsWin = context.BooleanValue("InnerEcsQueryByInternetIp.Data.isWin");
			data.GmtRelease = context.StringValue("InnerEcsQueryByInternetIp.Data.gmtRelease");
			data.SerialNumber = context.StringValue("InnerEcsQueryByInternetIp.Data.serialNumber");
			data.InstanceTypeGeneration = context.StringValue("InnerEcsQueryByInternetIp.Data.instanceTypeGeneration");
			data.IntranetRx = context.IntegerValue("InnerEcsQueryByInternetIp.Data.intranetRx");
			data.ImageProductCode = context.StringValue("InnerEcsQueryByInternetIp.Data.imageProductCode");
			data.EcsBusinessStatus = context.StringValue("InnerEcsQueryByInternetIp.Data.ecsBusinessStatus");
			data.Description = context.StringValue("InnerEcsQueryByInternetIp.Data.description");
			data.InternetIp = context.StringValue("InnerEcsQueryByInternetIp.Data.internetIp");
			data.ImageNo = context.StringValue("InnerEcsQueryByInternetIp.Data.imageNo");
			data.InternetRx = context.IntegerValue("InnerEcsQueryByInternetIp.Data.internetRx");
			data.Status = context.StringValue("InnerEcsQueryByInternetIp.Data.status");
			data.ImageName = context.StringValue("InnerEcsQueryByInternetIp.Data.imageName");
			data.OsType = context.StringValue("InnerEcsQueryByInternetIp.Data.osType");
			data.Hostname = context.StringValue("InnerEcsQueryByInternetIp.Data.hostname");
			data.EipBandwidth = context.IntegerValue("InnerEcsQueryByInternetIp.Data.eipBandwidth");
			data.NetWorkType = context.StringValue("InnerEcsQueryByInternetIp.Data.netWorkType");
			data.NatIp = context.StringValue("InnerEcsQueryByInternetIp.Data.natIp");
			data.InstanceType = context.StringValue("InnerEcsQueryByInternetIp.Data.instanceType");
			data.RecoverPolicy = context.StringValue("InnerEcsQueryByInternetIp.Data.recoverPolicy");
			data.IoOptimized = context.BooleanValue("InnerEcsQueryByInternetIp.Data.ioOptimized");
			data.OsName = context.StringValue("InnerEcsQueryByInternetIp.Data.osName");
			data.IntranetIp = context.StringValue("InnerEcsQueryByInternetIp.Data.intranetIp");
			data.Eip = context.StringValue("InnerEcsQueryByInternetIp.Data.eip");
			data.GmtModified = context.StringValue("InnerEcsQueryByInternetIp.Data.gmtModified");
			data.IopsSize = context.IntegerValue("InnerEcsQueryByInternetIp.Data.iopsSize");
			data.SystemDiskCategory = context.StringValue("InnerEcsQueryByInternetIp.Data.systemDiskCategory");
			data.IntranetTx = context.IntegerValue("InnerEcsQueryByInternetIp.Data.intranetTx");
			data.GmtStarted = context.StringValue("InnerEcsQueryByInternetIp.Data.gmtStarted");
			data.GmtSync = context.StringValue("InnerEcsQueryByInternetIp.Data.gmtSync");
			data.Cores = context.IntegerValue("InnerEcsQueryByInternetIp.Data.cores");
			data.AliUid = context.LongValue("InnerEcsQueryByInternetIp.Data.aliUid");
			data.ImageId = context.LongValue("InnerEcsQueryByInternetIp.Data.imageId");
			data.GmtCreated = context.StringValue("InnerEcsQueryByInternetIp.Data.gmtCreated");
			data.GroupNo = context.StringValue("InnerEcsQueryByInternetIp.Data.groupNo");
			data.VpcInstanceId = context.StringValue("InnerEcsQueryByInternetIp.Data.vpcInstanceId");
			data.Bid = context.StringValue("InnerEcsQueryByInternetIp.Data.bid");
			data.AgentId = context.IntegerValue("InnerEcsQueryByInternetIp.Data.agentId");
			data.RealHostname = context.StringValue("InnerEcsQueryByInternetIp.Data.realHostname");
			data.InstanceId = context.StringValue("InnerEcsQueryByInternetIp.Data.instanceId");
			data.InstanceTypeFamily = context.StringValue("InnerEcsQueryByInternetIp.Data.instanceTypeFamily");
			data.NetworkValidation = context.BooleanValue("InnerEcsQueryByInternetIp.Data.networkValidation");
			data.ZoneId = context.LongValue("InnerEcsQueryByInternetIp.Data.zoneId");
			data.Memory = context.IntegerValue("InnerEcsQueryByInternetIp.Data.memory");
			data.InternetTx = context.IntegerValue("InnerEcsQueryByInternetIp.Data.internetTx");
			data.VswitchInstanceId = context.StringValue("InnerEcsQueryByInternetIp.Data.vswitchInstanceId");
			data.ImageType = context.StringValue("InnerEcsQueryByInternetIp.Data.imageType");
			data.IzId = context.LongValue("InnerEcsQueryByInternetIp.Data.izId");
			data.DiskSize = context.IntegerValue("InnerEcsQueryByInternetIp.Data.diskSize");

			InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Region region = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Region();
			region.Id = context.LongValue("InnerEcsQueryByInternetIp.Data.Region.id");
			region.IsActive = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.isActive");
			region.RegionEnName = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.regionEnName");
			region.RegionNoAlias = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.regionNoAlias");
			region.RegionName = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.regionName");
			region.RegionMemo = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.regionMemo");
			region.RegionNo = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.regionNo");

			InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Region.InnerEcsQueryByInternetIp_Attributes attributes = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Region.InnerEcsQueryByInternetIp_Attributes();
			attributes.Support_image_copy = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.Attributes.support_image_copy");
			attributes.Internal_use = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.Attributes.internal_use");
			attributes.Ak_name = context.StringValue("InnerEcsQueryByInternetIp.Data.Region.Attributes.ak_name");
			region.Attributes = attributes;
			data.Region = region;

			InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Iz iz = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Iz();
			iz.RegionNo = context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.regionNo");
			iz.Status = context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.status");
			iz.No = context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.no");
			iz.EnName = context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.enName");
			iz.CnName = context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.cnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInternetIp.Data.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInternetIp.Data.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInternetIp.Data.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Iz.InnerEcsQueryByInternetIp_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Iz.InnerEcsQueryByInternetIp_IzResourceModelItem>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel.Length"); i++) {
				InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Iz.InnerEcsQueryByInternetIp_IzResourceModelItem izResourceModelItem = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Iz.InnerEcsQueryByInternetIp_IzResourceModelItem();
				izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].supportIoOptimized");

				List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

				List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

				List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

				List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

				List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

				List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

				List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceModelItem);
			}
			iz.IzResourceModel = iz_izResourceModel;
			data.Iz = iz;

			InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Zone zone = new InnerEcsQueryByInternetIpResponse.InnerEcsQueryByInternetIp_Data.InnerEcsQueryByInternetIp_Zone();
			zone.ZoneMemo = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.zoneMemo");
			zone.IsWritable = context.BooleanValue("InnerEcsQueryByInternetIp.Data.Zone.isWritable");
			zone.ZoneName = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.zoneName");
			zone.ZoneNoAlias = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.zoneNoAlias");
			zone.IsActive = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.isActive");
			zone.Id = context.LongValue("InnerEcsQueryByInternetIp.Data.Zone.id");
			zone.ZoneEnName = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.zoneEnName");
			zone.ZoneNo = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.zoneNo");
			zone.RouteIpSegment = context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.routeIpSegment");
			zone.RegionId = context.LongValue("InnerEcsQueryByInternetIp.Data.Zone.regionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByInternetIp.Data.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryByInternetIp.Data.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			data.Zone = zone;
			innerEcsQueryByInternetIpResponse.Data = data;
        
			return innerEcsQueryByInternetIpResponse;
        }
    }
}
