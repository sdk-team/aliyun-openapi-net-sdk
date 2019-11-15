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
    public class InnerEcsQueryByIntranetIpResponseUnmarshaller
    {
        public static InnerEcsQueryByIntranetIpResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsQueryByIntranetIpResponse innerEcsQueryByIntranetIpResponse = new InnerEcsQueryByIntranetIpResponse();

			innerEcsQueryByIntranetIpResponse.HttpResponse = context.HttpResponse;
			innerEcsQueryByIntranetIpResponse.RequestId = context.StringValue("InnerEcsQueryByIntranetIp.RequestId");

			InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_ErrorCode errorCode = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsQueryByIntranetIp.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsQueryByIntranetIp.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsQueryByIntranetIp.ErrorCode.isSuccess");
			innerEcsQueryByIntranetIpResponse.ErrorCode = errorCode;

			InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data data = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data();
			data.Recoverable = context.BooleanValue("InnerEcsQueryByIntranetIp.Data.recoverable");
			data.EipInstanceId = context.StringValue("InnerEcsQueryByIntranetIp.Data.eipInstanceId");
			data.IsWin = context.BooleanValue("InnerEcsQueryByIntranetIp.Data.isWin");
			data.GmtRelease = context.StringValue("InnerEcsQueryByIntranetIp.Data.gmtRelease");
			data.SerialNumber = context.StringValue("InnerEcsQueryByIntranetIp.Data.serialNumber");
			data.InstanceTypeGeneration = context.StringValue("InnerEcsQueryByIntranetIp.Data.instanceTypeGeneration");
			data.IntranetRx = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.intranetRx");
			data.ImageProductCode = context.StringValue("InnerEcsQueryByIntranetIp.Data.imageProductCode");
			data.EcsBusinessStatus = context.StringValue("InnerEcsQueryByIntranetIp.Data.ecsBusinessStatus");
			data.Description = context.StringValue("InnerEcsQueryByIntranetIp.Data.description");
			data.InternetIp = context.StringValue("InnerEcsQueryByIntranetIp.Data.internetIp");
			data.ImageNo = context.StringValue("InnerEcsQueryByIntranetIp.Data.imageNo");
			data.InternetRx = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.internetRx");
			data.Status = context.StringValue("InnerEcsQueryByIntranetIp.Data.status");
			data.ImageName = context.StringValue("InnerEcsQueryByIntranetIp.Data.imageName");
			data.OsType = context.StringValue("InnerEcsQueryByIntranetIp.Data.osType");
			data.Hostname = context.StringValue("InnerEcsQueryByIntranetIp.Data.hostname");
			data.EipBandwidth = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.eipBandwidth");
			data.NetWorkType = context.StringValue("InnerEcsQueryByIntranetIp.Data.netWorkType");
			data.NatIp = context.StringValue("InnerEcsQueryByIntranetIp.Data.natIp");
			data.InstanceType = context.StringValue("InnerEcsQueryByIntranetIp.Data.instanceType");
			data.RecoverPolicy = context.StringValue("InnerEcsQueryByIntranetIp.Data.recoverPolicy");
			data.IoOptimized = context.BooleanValue("InnerEcsQueryByIntranetIp.Data.ioOptimized");
			data.OsName = context.StringValue("InnerEcsQueryByIntranetIp.Data.osName");
			data.IntranetIp = context.StringValue("InnerEcsQueryByIntranetIp.Data.intranetIp");
			data.Eip = context.StringValue("InnerEcsQueryByIntranetIp.Data.eip");
			data.GmtModified = context.StringValue("InnerEcsQueryByIntranetIp.Data.gmtModified");
			data.IopsSize = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.iopsSize");
			data.SystemDiskCategory = context.StringValue("InnerEcsQueryByIntranetIp.Data.systemDiskCategory");
			data.IntranetTx = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.intranetTx");
			data.GmtStarted = context.StringValue("InnerEcsQueryByIntranetIp.Data.gmtStarted");
			data.GmtSync = context.StringValue("InnerEcsQueryByIntranetIp.Data.gmtSync");
			data.Cores = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.cores");
			data.AliUid = context.LongValue("InnerEcsQueryByIntranetIp.Data.aliUid");
			data.ImageId = context.LongValue("InnerEcsQueryByIntranetIp.Data.imageId");
			data.GmtCreated = context.StringValue("InnerEcsQueryByIntranetIp.Data.gmtCreated");
			data.GroupNo = context.StringValue("InnerEcsQueryByIntranetIp.Data.groupNo");
			data.VpcInstanceId = context.StringValue("InnerEcsQueryByIntranetIp.Data.vpcInstanceId");
			data.Bid = context.StringValue("InnerEcsQueryByIntranetIp.Data.bid");
			data.AgentId = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.agentId");
			data.RealHostname = context.StringValue("InnerEcsQueryByIntranetIp.Data.realHostname");
			data.InstanceId = context.StringValue("InnerEcsQueryByIntranetIp.Data.instanceId");
			data.InstanceTypeFamily = context.StringValue("InnerEcsQueryByIntranetIp.Data.instanceTypeFamily");
			data.NetworkValidation = context.BooleanValue("InnerEcsQueryByIntranetIp.Data.networkValidation");
			data.ZoneId = context.LongValue("InnerEcsQueryByIntranetIp.Data.zoneId");
			data.Memory = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.memory");
			data.InternetTx = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.internetTx");
			data.VswitchInstanceId = context.StringValue("InnerEcsQueryByIntranetIp.Data.vswitchInstanceId");
			data.ImageType = context.StringValue("InnerEcsQueryByIntranetIp.Data.imageType");
			data.IzId = context.LongValue("InnerEcsQueryByIntranetIp.Data.izId");
			data.DiskSize = context.IntegerValue("InnerEcsQueryByIntranetIp.Data.diskSize");

			InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Region region = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Region();
			region.Id = context.LongValue("InnerEcsQueryByIntranetIp.Data.Region.id");
			region.IsActive = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.isActive");
			region.RegionEnName = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.regionEnName");
			region.RegionNoAlias = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.regionNoAlias");
			region.RegionName = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.regionName");
			region.RegionMemo = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.regionMemo");
			region.RegionNo = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.regionNo");

			InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Region.InnerEcsQueryByIntranetIp_Attributes attributes = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Region.InnerEcsQueryByIntranetIp_Attributes();
			attributes.Support_image_copy = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.Attributes.support_image_copy");
			attributes.Internal_use = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.Attributes.internal_use");
			attributes.Ak_name = context.StringValue("InnerEcsQueryByIntranetIp.Data.Region.Attributes.ak_name");
			region.Attributes = attributes;
			data.Region = region;

			InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Iz iz = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Iz();
			iz.RegionNo = context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.regionNo");
			iz.Status = context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.status");
			iz.No = context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.no");
			iz.EnName = context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.enName");
			iz.CnName = context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.cnName");

			List<string> iz_supportedInstanceGenerations = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.SupportedInstanceGenerations.Length"); i++) {
				iz_supportedInstanceGenerations.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.SupportedInstanceGenerations["+ i +"]"));
			}
			iz.SupportedInstanceGenerations = iz_supportedInstanceGenerations;

			List<string> iz_supportedInstanceTypeFamilies = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.SupportedInstanceTypeFamilies.Length"); i++) {
				iz_supportedInstanceTypeFamilies.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.SupportedInstanceTypeFamilies["+ i +"]"));
			}
			iz.SupportedInstanceTypeFamilies = iz_supportedInstanceTypeFamilies;

			List<string> iz_supportedInstanceTypeNames = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.SupportedInstanceTypeNames.Length"); i++) {
				iz_supportedInstanceTypeNames.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.SupportedInstanceTypeNames["+ i +"]"));
			}
			iz.SupportedInstanceTypeNames = iz_supportedInstanceTypeNames;

			List<InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Iz.InnerEcsQueryByIntranetIp_IzResourceModelItem> iz_izResourceModel = new List<InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Iz.InnerEcsQueryByIntranetIp_IzResourceModelItem>();
			for (int i = 0; i < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel.Length"); i++) {
				InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Iz.InnerEcsQueryByIntranetIp_IzResourceModelItem izResourceModelItem = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Iz.InnerEcsQueryByIntranetIp_IzResourceModelItem();
				izResourceModelItem.SupportIoOptimized = context.BooleanValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].supportIoOptimized");

				List<string> izResourceModelItem_allowedResourceCreation = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation.Length"); j++) {
					izResourceModelItem_allowedResourceCreation.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].AllowedResourceCreation["+ j +"]"));
				}
				izResourceModelItem.AllowedResourceCreation = izResourceModelItem_allowedResourceCreation;

				List<string> izResourceModelItem_supportedDataDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories.Length"); j++) {
					izResourceModelItem_supportedDataDiskCategories.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedDataDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedDataDiskCategories = izResourceModelItem_supportedDataDiskCategories;

				List<string> izResourceModelItem_supportedInstanceGenerations1 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations.Length"); j++) {
					izResourceModelItem_supportedInstanceGenerations1.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceGenerations["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceGenerations1 = izResourceModelItem_supportedInstanceGenerations1;

				List<string> izResourceModelItem_supportedNetworkCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories.Length"); j++) {
					izResourceModelItem_supportedNetworkCategories.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedNetworkCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedNetworkCategories = izResourceModelItem_supportedNetworkCategories;

				List<string> izResourceModelItem_supportedSystemDiskCategories = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories.Length"); j++) {
					izResourceModelItem_supportedSystemDiskCategories.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedSystemDiskCategories["+ j +"]"));
				}
				izResourceModelItem.SupportedSystemDiskCategories = izResourceModelItem_supportedSystemDiskCategories;

				List<string> izResourceModelItem_supportedInstanceTypeFamilies2 = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					izResourceModelItem_supportedInstanceTypeFamilies2.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypeFamilies2 = izResourceModelItem_supportedInstanceTypeFamilies2;

				List<string> izResourceModelItem_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes.Length"); j++) {
					izResourceModelItem_supportedInstanceTypes.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Iz.IzResourceModel["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				izResourceModelItem.SupportedInstanceTypes = izResourceModelItem_supportedInstanceTypes;

				iz_izResourceModel.Add(izResourceModelItem);
			}
			iz.IzResourceModel = iz_izResourceModel;
			data.Iz = iz;

			InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Zone zone = new InnerEcsQueryByIntranetIpResponse.InnerEcsQueryByIntranetIp_Data.InnerEcsQueryByIntranetIp_Zone();
			zone.ZoneMemo = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.zoneMemo");
			zone.IsWritable = context.BooleanValue("InnerEcsQueryByIntranetIp.Data.Zone.isWritable");
			zone.ZoneName = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.zoneName");
			zone.ZoneNoAlias = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.zoneNoAlias");
			zone.IsActive = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.isActive");
			zone.Id = context.LongValue("InnerEcsQueryByIntranetIp.Data.Zone.id");
			zone.ZoneEnName = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.zoneEnName");
			zone.ZoneNo = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.zoneNo");
			zone.RouteIpSegment = context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.routeIpSegment");
			zone.RegionId = context.LongValue("InnerEcsQueryByIntranetIp.Data.Zone.regionId");

			List<string> zone_supportedDeviceCategories = new List<string>();
			for (int i = 0; i < context.Length("InnerEcsQueryByIntranetIp.Data.Zone.SupportedDeviceCategories.Length"); i++) {
				zone_supportedDeviceCategories.Add(context.StringValue("InnerEcsQueryByIntranetIp.Data.Zone.SupportedDeviceCategories["+ i +"]"));
			}
			zone.SupportedDeviceCategories = zone_supportedDeviceCategories;
			data.Zone = zone;
			innerEcsQueryByIntranetIpResponse.Data = data;
        
			return innerEcsQueryByIntranetIpResponse;
        }
    }
}
