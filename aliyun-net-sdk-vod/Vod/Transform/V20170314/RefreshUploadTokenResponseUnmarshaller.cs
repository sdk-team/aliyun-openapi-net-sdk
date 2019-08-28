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
    public class RefreshUploadTokenResponseUnmarshaller
    {
        public static RefreshUploadTokenResponse Unmarshall(UnmarshallerContext context)
        {
			RefreshUploadTokenResponse refreshUploadTokenResponse = new RefreshUploadTokenResponse();

			refreshUploadTokenResponse.HttpResponse = context.HttpResponse;
			refreshUploadTokenResponse.RequestId = context.StringValue("RefreshUploadToken.RequestId");
			refreshUploadTokenResponse.UploadKey = context.StringValue("RefreshUploadToken.UploadKey");

			RefreshUploadTokenResponse.RefreshUploadToken_UploadAddress uploadAddress = new RefreshUploadTokenResponse.RefreshUploadToken_UploadAddress();
			uploadAddress.AccessKeyId = context.StringValue("RefreshUploadToken.UploadAddress.AccessKeyId");
			uploadAddress.AccessKeySecret = context.StringValue("RefreshUploadToken.UploadAddress.AccessKeySecret");
			uploadAddress.Expiration = context.StringValue("RefreshUploadToken.UploadAddress.Expiration");
			uploadAddress.SecurityToken = context.StringValue("RefreshUploadToken.UploadAddress.SecurityToken");
			refreshUploadTokenResponse.UploadAddress = uploadAddress;
        
			return refreshUploadTokenResponse;
        }
    }
}
