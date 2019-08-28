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
    public class CreateUploadMediaFileResponseUnmarshaller
    {
        public static CreateUploadMediaFileResponse Unmarshall(UnmarshallerContext context)
        {
			CreateUploadMediaFileResponse createUploadMediaFileResponse = new CreateUploadMediaFileResponse();

			createUploadMediaFileResponse.HttpResponse = context.HttpResponse;
			createUploadMediaFileResponse.RequestId = context.StringValue("CreateUploadMediaFile.RequestId");

			CreateUploadMediaFileResponse.CreateUploadMediaFile_MediaFileInfo mediaFileInfo = new CreateUploadMediaFileResponse.CreateUploadMediaFile_MediaFileInfo();
			mediaFileInfo.MediaFileId = context.StringValue("CreateUploadMediaFile.MediaFileInfo.MediaFileId");
			mediaFileInfo.MediaId = context.StringValue("CreateUploadMediaFile.MediaFileInfo.MediaId");
			mediaFileInfo.UserData = context.StringValue("CreateUploadMediaFile.MediaFileInfo.UserData");
			mediaFileInfo.MediaFilePath = context.StringValue("CreateUploadMediaFile.MediaFileInfo.MediaFilePath");
			mediaFileInfo.MediaFileAuth = context.StringValue("CreateUploadMediaFile.MediaFileInfo.MediaFileAuth");
			mediaFileInfo.MediaFileURL = context.StringValue("CreateUploadMediaFile.MediaFileInfo.MediaFileURL");
			createUploadMediaFileResponse.MediaFileInfo = mediaFileInfo;
        
			return createUploadMediaFileResponse;
        }
    }
}
