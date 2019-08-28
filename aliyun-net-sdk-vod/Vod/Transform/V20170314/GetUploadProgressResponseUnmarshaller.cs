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
    public class GetUploadProgressResponseUnmarshaller
    {
        public static GetUploadProgressResponse Unmarshall(UnmarshallerContext context)
        {
			GetUploadProgressResponse getUploadProgressResponse = new GetUploadProgressResponse();

			getUploadProgressResponse.HttpResponse = context.HttpResponse;
			getUploadProgressResponse.RequestId = context.StringValue("GetUploadProgress.RequestId");

			GetUploadProgressResponse.GetUploadProgress_UploadProgress uploadProgress = new GetUploadProgressResponse.GetUploadProgress_UploadProgress();

			List<GetUploadProgressResponse.GetUploadProgress_UploadProgress.GetUploadProgress_UploadProgressListItem> uploadProgress_uploadProgressList = new List<GetUploadProgressResponse.GetUploadProgress_UploadProgress.GetUploadProgress_UploadProgressListItem>();
			for (int i = 0; i < context.Length("GetUploadProgress.UploadProgress.UploadProgressList.Length"); i++) {
				GetUploadProgressResponse.GetUploadProgress_UploadProgress.GetUploadProgress_UploadProgressListItem uploadProgressListItem = new GetUploadProgressResponse.GetUploadProgress_UploadProgress.GetUploadProgress_UploadProgressListItem();
				uploadProgressListItem.Source = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].Source");
				uploadProgressListItem.ClientId = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].ClientId");
				uploadProgressListItem.BusinessType = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].BusinessType");
				uploadProgressListItem.TerminalType = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].TerminalType");
				uploadProgressListItem.DeviceModel = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].DeviceModel");
				uploadProgressListItem.AppVersion = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].AppVersion");
				uploadProgressListItem.AuthTimestamp = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].AuthTimestamp");
				uploadProgressListItem.AuthInfo = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].AuthInfo");
				uploadProgressListItem.FileName = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].FileName");
				uploadProgressListItem.FileSize = context.LongValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].FileSize");
				uploadProgressListItem.FileCreateTime = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].FileCreateTime");
				uploadProgressListItem.FileHash = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].FileHash");
				uploadProgressListItem.UploadSpeed = context.FloatValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].UploadSpeed");
				uploadProgressListItem.UploadRatio = context.FloatValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].UploadRatio");
				uploadProgressListItem.UploadId = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].UploadId");
				uploadProgressListItem.DonePartsCount = context.IntegerValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].DonePartsCount");
				uploadProgressListItem.TotalPart = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].TotalPart");
				uploadProgressListItem.PartSize = context.LongValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].PartSize");
				uploadProgressListItem.UploadPoint = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].UploadPoint");
				uploadProgressListItem.UploadAddress = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].UploadAddress");
				uploadProgressListItem.VideoId = context.StringValue("GetUploadProgress.UploadProgress.UploadProgressList["+ i +"].VideoId");

				uploadProgress_uploadProgressList.Add(uploadProgressListItem);
			}
			uploadProgress.UploadProgressList = uploadProgress_uploadProgressList;
			getUploadProgressResponse.UploadProgress = uploadProgress;
        
			return getUploadProgressResponse;
        }
    }
}
