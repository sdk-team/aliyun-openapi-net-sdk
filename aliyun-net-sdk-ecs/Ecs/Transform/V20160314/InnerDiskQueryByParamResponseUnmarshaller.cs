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
    public class InnerDiskQueryByParamResponseUnmarshaller
    {
        public static InnerDiskQueryByParamResponse Unmarshall(UnmarshallerContext context)
        {
			InnerDiskQueryByParamResponse innerDiskQueryByParamResponse = new InnerDiskQueryByParamResponse();

			innerDiskQueryByParamResponse.HttpResponse = context.HttpResponse;
			innerDiskQueryByParamResponse.RequestId = context.StringValue("InnerDiskQueryByParam.RequestId");
			innerDiskQueryByParamResponse.Count = context.IntegerValue("InnerDiskQueryByParam.count");
			innerDiskQueryByParamResponse.PageNo = context.IntegerValue("InnerDiskQueryByParam.pageNo");
			innerDiskQueryByParamResponse.PageSize = context.IntegerValue("InnerDiskQueryByParam.pageSize");

			InnerDiskQueryByParamResponse.InnerDiskQueryByParam_ErrorCode errorCode = new InnerDiskQueryByParamResponse.InnerDiskQueryByParam_ErrorCode();
			errorCode.Code = context.StringValue("InnerDiskQueryByParam.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerDiskQueryByParam.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerDiskQueryByParam.ErrorCode.isSuccess");
			innerDiskQueryByParamResponse.ErrorCode = errorCode;

			List<InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item> innerDiskQueryByParamResponse_data = new List<InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item>();
			for (int i = 0; i < context.Length("InnerDiskQueryByParam.Data.Length"); i++) {
				InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item item = new InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item();
				item.Seq = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].seq");
				item.EnableAutoSnapshot = context.BooleanValue("InnerDiskQueryByParam.Data["+ i +"].enableAutoSnapshot");
				item.Active = context.BooleanValue("InnerDiskQueryByParam.Data["+ i +"].active");
				item.DiskSize = context.IntegerValue("InnerDiskQueryByParam.Data["+ i +"].diskSize");
				item.DiskDesc = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].diskDesc");
				item.BusinessStatus = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].businessStatus");
				item.ZoneNo = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].zoneNo");
				item.RegionNo = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].regionNo");
				item.DiskCategory = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].diskCategory");
				item.SnapshotNo = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].snapshotNo");
				item.HouyiDiskId = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].houyiDiskId");
				item.DiskName = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].diskName");
				item.ProductCode = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].productCode");
				item.MountPoint = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].mountPoint");
				item.DeleteAutoSnapshot = context.BooleanValue("InnerDiskQueryByParam.Data["+ i +"].deleteAutoSnapshot");
				item.ImageNo = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].imageNo");
				item.Id = context.LongValue("InnerDiskQueryByParam.Data["+ i +"].id");
				item.Bootable = context.BooleanValue("InnerDiskQueryByParam.Data["+ i +"].bootable");
				item.DeleteWithInstance = context.BooleanValue("InnerDiskQueryByParam.Data["+ i +"].deleteWithInstance");
				item.DiskType = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].diskType");
				item.EcsInstanceId = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].ecsInstanceId");
				item.LastAttachTime = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].lastAttachTime");
				item.LastDetachTime = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].lastDetachTime");
				item.IzNo = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].izNo");
				item.Portable = context.BooleanValue("InnerDiskQueryByParam.Data["+ i +"].portable");
				item.IopsSize = context.IntegerValue("InnerDiskQueryByParam.Data["+ i +"].iopsSize");
				item.AutoSnapshotPolicyId = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].autoSnapshotPolicyId");

				List<InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item.InnerDiskQueryByParam_Tag> item_tags = new List<InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item.InnerDiskQueryByParam_Tag>();
				for (int j = 0; j < context.Length("InnerDiskQueryByParam.Data["+ i +"].Tags.Length"); j++) {
					InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item.InnerDiskQueryByParam_Tag tag = new InnerDiskQueryByParamResponse.InnerDiskQueryByParam_Item.InnerDiskQueryByParam_Tag();
					tag.Key = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].Tags["+ j +"].key");
					tag._Value = context.StringValue("InnerDiskQueryByParam.Data["+ i +"].Tags["+ j +"].value");

					item_tags.Add(tag);
				}
				item.Tags = item_tags;

				innerDiskQueryByParamResponse_data.Add(item);
			}
			innerDiskQueryByParamResponse.Data = innerDiskQueryByParamResponse_data;
        
			return innerDiskQueryByParamResponse;
        }
    }
}
