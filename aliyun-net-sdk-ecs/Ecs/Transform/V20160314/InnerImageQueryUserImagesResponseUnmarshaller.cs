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
    public class InnerImageQueryUserImagesResponseUnmarshaller
    {
        public static InnerImageQueryUserImagesResponse Unmarshall(UnmarshallerContext context)
        {
			InnerImageQueryUserImagesResponse innerImageQueryUserImagesResponse = new InnerImageQueryUserImagesResponse();

			innerImageQueryUserImagesResponse.HttpResponse = context.HttpResponse;
			innerImageQueryUserImagesResponse.RequestId = context.StringValue("InnerImageQueryUserImages.RequestId");
			innerImageQueryUserImagesResponse.Count = context.IntegerValue("InnerImageQueryUserImages.count");
			innerImageQueryUserImagesResponse.PageNo = context.IntegerValue("InnerImageQueryUserImages.pageNo");
			innerImageQueryUserImagesResponse.PageSize = context.IntegerValue("InnerImageQueryUserImages.pageSize");

			InnerImageQueryUserImagesResponse.InnerImageQueryUserImages_ErrorCode errorCode = new InnerImageQueryUserImagesResponse.InnerImageQueryUserImages_ErrorCode();
			errorCode.Code = context.StringValue("InnerImageQueryUserImages.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerImageQueryUserImages.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerImageQueryUserImages.ErrorCode.isSuccess");
			innerImageQueryUserImagesResponse.ErrorCode = errorCode;

			List<InnerImageQueryUserImagesResponse.InnerImageQueryUserImages_Item> innerImageQueryUserImagesResponse_data = new List<InnerImageQueryUserImagesResponse.InnerImageQueryUserImages_Item>();
			for (int i = 0; i < context.Length("InnerImageQueryUserImages.Data.Length"); i++) {
				InnerImageQueryUserImagesResponse.InnerImageQueryUserImages_Item item = new InnerImageQueryUserImagesResponse.InnerImageQueryUserImages_Item();
				item.Kind = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].kind");
				item.Version = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].version");
				item.WindowsOS = context.BooleanValue("InnerImageQueryUserImages.Data["+ i +"].windowsOS");
				item.AliUid = context.LongValue("InnerImageQueryUserImages.Data["+ i +"].aliUid");
				item.Type = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].type");
				item.GmtRelease = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].gmtRelease");
				item.MinMemory = context.IntegerValue("InnerImageQueryUserImages.Data["+ i +"].minMemory");
				item.OsTypeId = context.LongValue("InnerImageQueryUserImages.Data["+ i +"].osTypeId");
				item.MaxCpu = context.IntegerValue("InnerImageQueryUserImages.Data["+ i +"].maxCpu");
				item.MinCpu = context.IntegerValue("InnerImageQueryUserImages.Data["+ i +"].minCpu");
				item.Remark = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].remark");
				item.GmtModified = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].gmtModified");
				item.ImageNo = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].imageNo");
				item.Bid = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].bid");
				item.OsBit = context.IntegerValue("InnerImageQueryUserImages.Data["+ i +"].osBit");
				item.GmtCreated = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].gmtCreated");
				item.Id = context.LongValue("InnerImageQueryUserImages.Data["+ i +"].id");
				item.OsMemo = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].osMemo");
				item.ImageSize = context.IntegerValue("InnerImageQueryUserImages.Data["+ i +"].imageSize");
				item.IsPublic = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].isPublic");
				item.RegionNo = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].regionNo");
				item.MaxMemory = context.IntegerValue("InnerImageQueryUserImages.Data["+ i +"].maxMemory");
				item.SnapshotNo = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].snapshotNo");
				item.Status = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].status");
				item.ImageName = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].imageName");
				item.Platform = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].platform");
				item.OsName = context.StringValue("InnerImageQueryUserImages.Data["+ i +"].osName");

				innerImageQueryUserImagesResponse_data.Add(item);
			}
			innerImageQueryUserImagesResponse.Data = innerImageQueryUserImagesResponse_data;
        
			return innerImageQueryUserImagesResponse;
        }
    }
}
