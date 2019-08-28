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
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class GetStorageListResponseUnmarshaller
    {
        public static GetStorageListResponse Unmarshall(UnmarshallerContext context)
        {
			GetStorageListResponse getStorageListResponse = new GetStorageListResponse();

			getStorageListResponse.HttpResponse = context.HttpResponse;
			getStorageListResponse.RequestId = context.StringValue("GetStorageList.RequestId");
			getStorageListResponse.PageSize = context.IntegerValue("GetStorageList.PageSize");
			getStorageListResponse.PageNumber = context.IntegerValue("GetStorageList.PageNumber");
			getStorageListResponse.TotalCount = context.IntegerValue("GetStorageList.TotalCount");

			List<GetStorageListResponse.GetStorageList_Storage> getStorageListResponse_storageList = new List<GetStorageListResponse.GetStorageList_Storage>();
			for (int i = 0; i < context.Length("GetStorageList.StorageList.Length"); i++) {
				GetStorageListResponse.GetStorageList_Storage storage = new GetStorageListResponse.GetStorageList_Storage();
				storage.GmtCreate = context.StringValue("GetStorageList.StorageList["+ i +"].GmtCreate");
				storage.GmtModified = context.StringValue("GetStorageList.StorageList["+ i +"].GmtModified");
				storage.GroupId = context.StringValue("GetStorageList.StorageList["+ i +"].GroupId");
				storage.Location = context.StringValue("GetStorageList.StorageList["+ i +"].Location");
				storage.Type = context.IntegerValue("GetStorageList.StorageList["+ i +"].Type");
				storage.Region = context.StringValue("GetStorageList.StorageList["+ i +"].Region");
				storage.Status = context.IntegerValue("GetStorageList.StorageList["+ i +"].Status");
				storage.StorageUsage = context.IntegerValue("GetStorageList.StorageList["+ i +"].StorageUsage");
				storage.DefaultUpload = context.BooleanValue("GetStorageList.StorageList["+ i +"].DefaultUpload");

				getStorageListResponse_storageList.Add(storage);
			}
			getStorageListResponse.StorageList = getStorageListResponse_storageList;
        
			return getStorageListResponse;
        }
    }
}
