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
    public class GetStorageInfoResponseUnmarshaller
    {
        public static GetStorageInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetStorageInfoResponse getStorageInfoResponse = new GetStorageInfoResponse();

			getStorageInfoResponse.HttpResponse = context.HttpResponse;
			getStorageInfoResponse.RequestId = context.StringValue("GetStorageInfo.RequestId");
			getStorageInfoResponse.StorageACL = context.StringValue("GetStorageInfo.StorageACL");

			GetStorageInfoResponse.GetStorageInfo_Storage storage = new GetStorageInfoResponse.GetStorageInfo_Storage();
			storage.GmtCreate = context.StringValue("GetStorageInfo.Storage.GmtCreate");
			storage.GmtModified = context.StringValue("GetStorageInfo.Storage.GmtModified");
			storage.GroupId = context.StringValue("GetStorageInfo.Storage.GroupId");
			storage.Location = context.StringValue("GetStorageInfo.Storage.Location");
			storage.Type = context.IntegerValue("GetStorageInfo.Storage.Type");
			storage.Region = context.StringValue("GetStorageInfo.Storage.Region");
			storage.Status = context.IntegerValue("GetStorageInfo.Storage.Status");
			storage.StorageUsage = context.IntegerValue("GetStorageInfo.Storage.StorageUsage");
			storage.DefaultUpload = context.BooleanValue("GetStorageInfo.Storage.DefaultUpload");
			getStorageInfoResponse.Storage = storage;

			List<GetStorageInfoResponse.GetStorageInfo_DomainInfo> getStorageInfoResponse_domainInfoList = new List<GetStorageInfoResponse.GetStorageInfo_DomainInfo>();
			for (int i = 0; i < context.Length("GetStorageInfo.DomainInfoList.Length"); i++) {
				GetStorageInfoResponse.GetStorageInfo_DomainInfo domainInfo = new GetStorageInfoResponse.GetStorageInfo_DomainInfo();
				domainInfo.DomainName = context.StringValue("GetStorageInfo.DomainInfoList["+ i +"].DomainName");
				domainInfo.DomainStatus = context.StringValue("GetStorageInfo.DomainInfoList["+ i +"].DomainStatus");
				domainInfo.DomainCname = context.StringValue("GetStorageInfo.DomainInfoList["+ i +"].DomainCname");
				domainInfo.DefaultPlay = context.BooleanValue("GetStorageInfo.DomainInfoList["+ i +"].DefaultPlay");

				getStorageInfoResponse_domainInfoList.Add(domainInfo);
			}
			getStorageInfoResponse.DomainInfoList = getStorageInfoResponse_domainInfoList;
        
			return getStorageInfoResponse;
        }
    }
}
