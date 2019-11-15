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
    public class InnerEcsInstanceQueryByParamResponseUnmarshaller
    {
        public static InnerEcsInstanceQueryByParamResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsInstanceQueryByParamResponse innerEcsInstanceQueryByParamResponse = new InnerEcsInstanceQueryByParamResponse();

			innerEcsInstanceQueryByParamResponse.HttpResponse = context.HttpResponse;
			innerEcsInstanceQueryByParamResponse.RequestId = context.StringValue("InnerEcsInstanceQueryByParam.RequestId");
			innerEcsInstanceQueryByParamResponse.Count = context.IntegerValue("InnerEcsInstanceQueryByParam.count");
			innerEcsInstanceQueryByParamResponse.PageNo = context.IntegerValue("InnerEcsInstanceQueryByParam.pageNo");
			innerEcsInstanceQueryByParamResponse.PageSize = context.IntegerValue("InnerEcsInstanceQueryByParam.pageSize");

			InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_ErrorCode errorCode = new InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsInstanceQueryByParam.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsInstanceQueryByParam.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsInstanceQueryByParam.ErrorCode.isSuccess");
			innerEcsInstanceQueryByParamResponse.ErrorCode = errorCode;

			List<InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item> innerEcsInstanceQueryByParamResponse_data = new List<InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item>();
			for (int i = 0; i < context.Length("InnerEcsInstanceQueryByParam.Data.Length"); i++) {
				InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item item = new InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item();
				item.InternetTx = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].internetTx");
				item.VswitchInstanceId = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].vswitchInstanceId");
				item.InstanceTypeFamily = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].instanceTypeFamily");
				item.NetworkValidation = context.BooleanValue("InnerEcsInstanceQueryByParam.Data["+ i +"].networkValidation");
				item.RegionNo = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].regionNo");
				item.InstanceName = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].instanceName");
				item.BusinessStatus = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].businessStatus");
				item.Eip = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].eip");
				item.AliUid = context.LongValue("InnerEcsInstanceQueryByParam.Data["+ i +"].aliUid");
				item.HouyiStatus = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].houyiStatus");
				item.IntranetTx = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].intranetTx");
				item.Cores = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].cores");
				item.InnerIp = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].innerIp");
				item.EcsName = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].ecsName");
				item.Bps = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].bps");
				item.VpcInstanceId = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].vpcInstanceId");
				item.Id = context.LongValue("InnerEcsInstanceQueryByParam.Data["+ i +"].id");
				item.Bid = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].bid");
				item.Mem = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].mem");
				item.Status = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].status");
				item.InternetRx = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].internetRx");
				item.Hostname = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].hostname");
				item.EipBandwidth = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].eipBandwidth");
				item.ZoneNo = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].zoneNo");
				item.NatIp = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].natIp");
				item.InstanceType = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].instanceType");
				item.NetWorkType = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].netWorkType");
				item.DeviceAvailable = context.BooleanValue("InnerEcsInstanceQueryByParam.Data["+ i +"].deviceAvailable");
				item.IoOptimized = context.BooleanValue("InnerEcsInstanceQueryByParam.Data["+ i +"].ioOptimized");
				item.SystemDeviceCategory = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].systemDeviceCategory");
				item.Disk = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].disk");
				item.SecurityControl = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].securityControl");
				item.EipInstanceId = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].eipInstanceId");
				item.IntranetRx = context.IntegerValue("InnerEcsInstanceQueryByParam.Data["+ i +"].intranetRx");
				item.IzNo = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].izNo");
				item.SerialNumber = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].serialNumber");
				item.RealZoneNo = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].realZoneNo");
				item.Description = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].description");
				item.CreationTime = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].creationTime");

				InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_PublicIp publicIp = new InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_PublicIp();
				publicIp.AssignIp = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].PublicIp.assignIp");
				publicIp.BindIp = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].PublicIp.bindIp");
				publicIp.AssignNatIp = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].PublicIp.assignNatIp");
				item.PublicIp = publicIp;

				InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Img img = new InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Img();
				img.Name = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Img.name");
				img.ImageNo = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Img.imageNo");
				item.Img = img;

				List<InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Tag> item_tags = new List<InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Tag>();
				for (int j = 0; j < context.Length("InnerEcsInstanceQueryByParam.Data["+ i +"].Tags.Length"); j++) {
					InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Tag tag = new InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Tag();
					tag.Key = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Tags["+ j +"].key");
					tag._Value = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Tags["+ j +"].value");

					item_tags.Add(tag);
				}
				item.Tags = item_tags;

				List<InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Group> item_groups = new List<InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Group>();
				for (int j = 0; j < context.Length("InnerEcsInstanceQueryByParam.Data["+ i +"].Groups.Length"); j++) {
					InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Group group = new InnerEcsInstanceQueryByParamResponse.InnerEcsInstanceQueryByParam_Item.InnerEcsInstanceQueryByParam_Group();
					group.GroupDesc = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Groups["+ j +"].groupDesc");
					group.GroupNo = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Groups["+ j +"].groupNo");
					group.GroupName = context.StringValue("InnerEcsInstanceQueryByParam.Data["+ i +"].Groups["+ j +"].groupName");

					item_groups.Add(group);
				}
				item.Groups = item_groups;

				innerEcsInstanceQueryByParamResponse_data.Add(item);
			}
			innerEcsInstanceQueryByParamResponse.Data = innerEcsInstanceQueryByParamResponse_data;
        
			return innerEcsInstanceQueryByParamResponse;
        }
    }
}
