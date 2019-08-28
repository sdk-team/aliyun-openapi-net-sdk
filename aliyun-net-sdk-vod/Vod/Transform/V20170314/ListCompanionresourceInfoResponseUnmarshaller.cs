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
    public class ListCompanionresourceInfoResponseUnmarshaller
    {
        public static ListCompanionresourceInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListCompanionresourceInfoResponse listCompanionresourceInfoResponse = new ListCompanionresourceInfoResponse();

			listCompanionresourceInfoResponse.HttpResponse = context.HttpResponse;
			listCompanionresourceInfoResponse.RequestId = context.StringValue("ListCompanionresourceInfo.RequestId");

			List<ListCompanionresourceInfoResponse.ListCompanionresourceInfo_CompanionResourceInfo> listCompanionresourceInfoResponse_companionResourceInfos = new List<ListCompanionresourceInfoResponse.ListCompanionresourceInfo_CompanionResourceInfo>();
			for (int i = 0; i < context.Length("ListCompanionresourceInfo.CompanionResourceInfos.Length"); i++) {
				ListCompanionresourceInfoResponse.ListCompanionresourceInfo_CompanionResourceInfo companionResourceInfo = new ListCompanionresourceInfoResponse.ListCompanionresourceInfo_CompanionResourceInfo();
				companionResourceInfo.CompanionResourceId = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].CompanionResourceId");
				companionResourceInfo.CompanionResourceType = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].CompanionResourceType");
				companionResourceInfo.CreationTime = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].CreationTime");
				companionResourceInfo.MediaFileUrl = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].MediaFileUrl");
				companionResourceInfo.ResourceName = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].ResourceName");
				companionResourceInfo.ResourceTags = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].ResourceTags");
				companionResourceInfo.CompanionResourceConfig = context.StringValue("ListCompanionresourceInfo.CompanionResourceInfos["+ i +"].CompanionResourceConfig");

				listCompanionresourceInfoResponse_companionResourceInfos.Add(companionResourceInfo);
			}
			listCompanionresourceInfoResponse.CompanionResourceInfos = listCompanionresourceInfoResponse_companionResourceInfos;
        
			return listCompanionresourceInfoResponse;
        }
    }
}
