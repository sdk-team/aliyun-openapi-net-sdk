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
    public class GetStorageRegionListResponseUnmarshaller
    {
        public static GetStorageRegionListResponse Unmarshall(UnmarshallerContext context)
        {
			GetStorageRegionListResponse getStorageRegionListResponse = new GetStorageRegionListResponse();

			getStorageRegionListResponse.HttpResponse = context.HttpResponse;
			getStorageRegionListResponse.RequestId = context.StringValue("GetStorageRegionList.RequestId");

			List<GetStorageRegionListResponse.GetStorageRegionList_Region> getStorageRegionListResponse_regionList = new List<GetStorageRegionListResponse.GetStorageRegionList_Region>();
			for (int i = 0; i < context.Length("GetStorageRegionList.RegionList.Length"); i++) {
				GetStorageRegionListResponse.GetStorageRegionList_Region region = new GetStorageRegionListResponse.GetStorageRegionList_Region();
				region.RegionID = context.StringValue("GetStorageRegionList.RegionList["+ i +"].RegionID");

				getStorageRegionListResponse_regionList.Add(region);
			}
			getStorageRegionListResponse.RegionList = getStorageRegionListResponse_regionList;
        
			return getStorageRegionListResponse;
        }
    }
}
