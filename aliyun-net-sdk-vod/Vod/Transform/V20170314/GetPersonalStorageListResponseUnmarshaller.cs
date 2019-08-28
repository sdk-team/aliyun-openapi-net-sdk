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
    public class GetPersonalStorageListResponseUnmarshaller
    {
        public static GetPersonalStorageListResponse Unmarshall(UnmarshallerContext context)
        {
			GetPersonalStorageListResponse getPersonalStorageListResponse = new GetPersonalStorageListResponse();

			getPersonalStorageListResponse.HttpResponse = context.HttpResponse;
			getPersonalStorageListResponse.RequestId = context.StringValue("GetPersonalStorageList.RequestId");

			List<GetPersonalStorageListResponse.GetPersonalStorageList_StorageInfo> getPersonalStorageListResponse_storageInfoList = new List<GetPersonalStorageListResponse.GetPersonalStorageList_StorageInfo>();
			for (int i = 0; i < context.Length("GetPersonalStorageList.StorageInfoList.Length"); i++) {
				GetPersonalStorageListResponse.GetPersonalStorageList_StorageInfo storageInfo = new GetPersonalStorageListResponse.GetPersonalStorageList_StorageInfo();
				storageInfo.Location = context.StringValue("GetPersonalStorageList.StorageInfoList["+ i +"].Location");
				storageInfo.GmtCreate = context.StringValue("GetPersonalStorageList.StorageInfoList["+ i +"].GmtCreate");
				storageInfo.OwnerId = context.LongValue("GetPersonalStorageList.StorageInfoList["+ i +"].OwnerId");
				storageInfo.StorageClass = context.StringValue("GetPersonalStorageList.StorageInfoList["+ i +"].StorageClass");
				storageInfo.ExtranetEndpoint = context.StringValue("GetPersonalStorageList.StorageInfoList["+ i +"].ExtranetEndpoint");
				storageInfo.IntranetEndpoint = context.StringValue("GetPersonalStorageList.StorageInfoList["+ i +"].IntranetEndpoint");
				storageInfo.StorageACL = context.StringValue("GetPersonalStorageList.StorageInfoList["+ i +"].StorageACL");

				getPersonalStorageListResponse_storageInfoList.Add(storageInfo);
			}
			getPersonalStorageListResponse.StorageInfoList = getPersonalStorageListResponse_storageInfoList;
        
			return getPersonalStorageListResponse;
        }
    }
}
