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
    public class AddMediaInfoResponseUnmarshaller
    {
        public static AddMediaInfoResponse Unmarshall(UnmarshallerContext context)
        {
			AddMediaInfoResponse addMediaInfoResponse = new AddMediaInfoResponse();

			addMediaInfoResponse.HttpResponse = context.HttpResponse;
			addMediaInfoResponse.RequestId = context.StringValue("AddMediaInfo.RequestId");
			addMediaInfoResponse.VideoId = context.StringValue("AddMediaInfo.VideoId");
			addMediaInfoResponse.UploadKey = context.StringValue("AddMediaInfo.UploadKey");

			AddMediaInfoResponse.AddMediaInfo_UploadAddress uploadAddress = new AddMediaInfoResponse.AddMediaInfo_UploadAddress();
			uploadAddress.AccessKeyId = context.StringValue("AddMediaInfo.UploadAddress.AccessKeyId");
			uploadAddress.AccessKeySecret = context.StringValue("AddMediaInfo.UploadAddress.AccessKeySecret");
			uploadAddress.Bucket = context.StringValue("AddMediaInfo.UploadAddress.Bucket");
			uploadAddress.EndPoint = context.StringValue("AddMediaInfo.UploadAddress.EndPoint");
			uploadAddress.Expiration = context.StringValue("AddMediaInfo.UploadAddress.Expiration");
			uploadAddress.FileName = context.StringValue("AddMediaInfo.UploadAddress.FileName");
			uploadAddress.SecurityToken = context.StringValue("AddMediaInfo.UploadAddress.SecurityToken");
			addMediaInfoResponse.UploadAddress = uploadAddress;
        
			return addMediaInfoResponse;
        }
    }
}
