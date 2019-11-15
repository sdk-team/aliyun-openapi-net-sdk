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
    public class InnerGroupDetailResponseUnmarshaller
    {
        public static InnerGroupDetailResponse Unmarshall(UnmarshallerContext context)
        {
			InnerGroupDetailResponse innerGroupDetailResponse = new InnerGroupDetailResponse();

			innerGroupDetailResponse.HttpResponse = context.HttpResponse;
			innerGroupDetailResponse.RequestId = context.StringValue("InnerGroupDetail.RequestId");

			InnerGroupDetailResponse.InnerGroupDetail_ErrorCode errorCode = new InnerGroupDetailResponse.InnerGroupDetail_ErrorCode();
			errorCode.Code = context.StringValue("InnerGroupDetail.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerGroupDetail.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerGroupDetail.ErrorCode.isSuccess");
			innerGroupDetailResponse.ErrorCode = errorCode;

			InnerGroupDetailResponse.InnerGroupDetail_Data data = new InnerGroupDetailResponse.InnerGroupDetail_Data();
			data.EcsCount = context.IntegerValue("InnerGroupDetail.Data.ecsCount");
			data.VpcInstanceId = context.StringValue("InnerGroupDetail.Data.vpcInstanceId");
			data.GroupDesc = context.StringValue("InnerGroupDetail.Data.groupDesc");
			data.RegionNo = context.StringValue("InnerGroupDetail.Data.regionNo");
			data.GroupName = context.StringValue("InnerGroupDetail.Data.groupName");
			data.GmtCreated = context.StringValue("InnerGroupDetail.Data.gmtCreated");
			data.GroupNo = context.StringValue("InnerGroupDetail.Data.groupNo");
			data.GmtModified = context.StringValue("InnerGroupDetail.Data.gmtModified");

			List<InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Permission> data_permissions = new List<InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Permission>();
			for (int i = 0; i < context.Length("InnerGroupDetail.Data.Permissions.Length"); i++) {
				InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Permission permission = new InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Permission();
				permission.PortRange = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].portRange");
				permission.DestCidrIp = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].destCidrIp");
				permission.Direction = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].direction");
				permission.Nic = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].nic");
				permission.SourceGroupOwnerUserAccount = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].sourceGroupOwnerUserAccount");
				permission.Policy = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].policy");
				permission.IpProtocal = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].ipProtocal");
				permission.DestGroupNo = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].destGroupNo");
				permission.DestGroupOwnerUserAccount = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].destGroupOwnerUserAccount");
				permission.SourceGroupNo = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].sourceGroupNo");
				permission.Level = context.IntegerValue("InnerGroupDetail.Data.Permissions["+ i +"].level");
				permission.SourceCidrIp = context.StringValue("InnerGroupDetail.Data.Permissions["+ i +"].sourceCidrIp");

				data_permissions.Add(permission);
			}
			data.Permissions = data_permissions;

			List<InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Tag> data_tags = new List<InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Tag>();
			for (int i = 0; i < context.Length("InnerGroupDetail.Data.Tags.Length"); i++) {
				InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Tag tag = new InnerGroupDetailResponse.InnerGroupDetail_Data.InnerGroupDetail_Tag();
				tag.Key = context.StringValue("InnerGroupDetail.Data.Tags["+ i +"].key");
				tag._Value = context.StringValue("InnerGroupDetail.Data.Tags["+ i +"].value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;
			innerGroupDetailResponse.Data = data;
        
			return innerGroupDetailResponse;
        }
    }
}
