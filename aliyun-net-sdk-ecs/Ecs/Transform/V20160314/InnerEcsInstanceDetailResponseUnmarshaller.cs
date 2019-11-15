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
    public class InnerEcsInstanceDetailResponseUnmarshaller
    {
        public static InnerEcsInstanceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsInstanceDetailResponse innerEcsInstanceDetailResponse = new InnerEcsInstanceDetailResponse();

			innerEcsInstanceDetailResponse.HttpResponse = context.HttpResponse;
			innerEcsInstanceDetailResponse.RequestId = context.StringValue("InnerEcsInstanceDetail.RequestId");

			InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_ErrorCode errorCode = new InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsInstanceDetail.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsInstanceDetail.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsInstanceDetail.ErrorCode.isSuccess");
			innerEcsInstanceDetailResponse.ErrorCode = errorCode;

			InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data data = new InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data();
			data.InternetTx = context.IntegerValue("InnerEcsInstanceDetail.Data.internetTx");
			data.VswitchInstanceId = context.StringValue("InnerEcsInstanceDetail.Data.vswitchInstanceId");
			data.InstanceTypeFamily = context.StringValue("InnerEcsInstanceDetail.Data.instanceTypeFamily");
			data.NetworkValidation = context.BooleanValue("InnerEcsInstanceDetail.Data.networkValidation");
			data.RegionNo = context.StringValue("InnerEcsInstanceDetail.Data.regionNo");
			data.InstanceName = context.StringValue("InnerEcsInstanceDetail.Data.instanceName");
			data.BusinessStatus = context.StringValue("InnerEcsInstanceDetail.Data.businessStatus");
			data.Eip = context.StringValue("InnerEcsInstanceDetail.Data.eip");
			data.AliUid = context.LongValue("InnerEcsInstanceDetail.Data.aliUid");
			data.HouyiStatus = context.StringValue("InnerEcsInstanceDetail.Data.houyiStatus");
			data.IntranetTx = context.IntegerValue("InnerEcsInstanceDetail.Data.intranetTx");
			data.Cores = context.IntegerValue("InnerEcsInstanceDetail.Data.cores");
			data.InnerIp = context.StringValue("InnerEcsInstanceDetail.Data.innerIp");
			data.EcsName = context.StringValue("InnerEcsInstanceDetail.Data.ecsName");
			data.Bps = context.IntegerValue("InnerEcsInstanceDetail.Data.bps");
			data.VpcInstanceId = context.StringValue("InnerEcsInstanceDetail.Data.vpcInstanceId");
			data.Id = context.LongValue("InnerEcsInstanceDetail.Data.id");
			data.Bid = context.StringValue("InnerEcsInstanceDetail.Data.bid");
			data.Mem = context.IntegerValue("InnerEcsInstanceDetail.Data.mem");
			data.Status = context.StringValue("InnerEcsInstanceDetail.Data.status");
			data.InternetRx = context.IntegerValue("InnerEcsInstanceDetail.Data.internetRx");
			data.Hostname = context.StringValue("InnerEcsInstanceDetail.Data.hostname");
			data.EipBandwidth = context.IntegerValue("InnerEcsInstanceDetail.Data.eipBandwidth");
			data.ZoneNo = context.StringValue("InnerEcsInstanceDetail.Data.zoneNo");
			data.NatIp = context.StringValue("InnerEcsInstanceDetail.Data.natIp");
			data.InstanceType = context.StringValue("InnerEcsInstanceDetail.Data.instanceType");
			data.NetWorkType = context.StringValue("InnerEcsInstanceDetail.Data.netWorkType");
			data.DeviceAvailable = context.BooleanValue("InnerEcsInstanceDetail.Data.deviceAvailable");
			data.IoOptimized = context.BooleanValue("InnerEcsInstanceDetail.Data.ioOptimized");
			data.SystemDeviceCategory = context.StringValue("InnerEcsInstanceDetail.Data.systemDeviceCategory");
			data.Disk = context.IntegerValue("InnerEcsInstanceDetail.Data.disk");
			data.SecurityControl = context.StringValue("InnerEcsInstanceDetail.Data.securityControl");
			data.EipInstanceId = context.StringValue("InnerEcsInstanceDetail.Data.eipInstanceId");
			data.IntranetRx = context.IntegerValue("InnerEcsInstanceDetail.Data.intranetRx");
			data.IzNo = context.StringValue("InnerEcsInstanceDetail.Data.izNo");
			data.SerialNumber = context.StringValue("InnerEcsInstanceDetail.Data.serialNumber");
			data.RealZoneNo = context.StringValue("InnerEcsInstanceDetail.Data.realZoneNo");
			data.Description = context.StringValue("InnerEcsInstanceDetail.Data.description");
			data.CreationTime = context.StringValue("InnerEcsInstanceDetail.Data.creationTime");

			InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_PublicIp publicIp = new InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_PublicIp();
			publicIp.AssignIp = context.StringValue("InnerEcsInstanceDetail.Data.PublicIp.assignIp");
			publicIp.BindIp = context.StringValue("InnerEcsInstanceDetail.Data.PublicIp.bindIp");
			publicIp.AssignNatIp = context.StringValue("InnerEcsInstanceDetail.Data.PublicIp.assignNatIp");
			data.PublicIp = publicIp;

			InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Img img = new InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Img();
			img.Name = context.StringValue("InnerEcsInstanceDetail.Data.Img.name");
			img.ImageNo = context.StringValue("InnerEcsInstanceDetail.Data.Img.imageNo");
			data.Img = img;

			List<InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Tag> data_tags = new List<InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Tag>();
			for (int i = 0; i < context.Length("InnerEcsInstanceDetail.Data.Tags.Length"); i++) {
				InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Tag tag = new InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Tag();
				tag.Key = context.StringValue("InnerEcsInstanceDetail.Data.Tags["+ i +"].key");
				tag._Value = context.StringValue("InnerEcsInstanceDetail.Data.Tags["+ i +"].value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;

			List<InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Group> data_groups = new List<InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Group>();
			for (int i = 0; i < context.Length("InnerEcsInstanceDetail.Data.Groups.Length"); i++) {
				InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Group group = new InnerEcsInstanceDetailResponse.InnerEcsInstanceDetail_Data.InnerEcsInstanceDetail_Group();
				group.GroupDesc = context.StringValue("InnerEcsInstanceDetail.Data.Groups["+ i +"].groupDesc");
				group.GroupNo = context.StringValue("InnerEcsInstanceDetail.Data.Groups["+ i +"].groupNo");
				group.GroupName = context.StringValue("InnerEcsInstanceDetail.Data.Groups["+ i +"].groupName");

				data_groups.Add(group);
			}
			data.Groups = data_groups;
			innerEcsInstanceDetailResponse.Data = data;
        
			return innerEcsInstanceDetailResponse;
        }
    }
}
