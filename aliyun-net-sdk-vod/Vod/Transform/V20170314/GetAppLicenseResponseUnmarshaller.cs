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
    public class GetAppLicenseResponseUnmarshaller
    {
        public static GetAppLicenseResponse Unmarshall(UnmarshallerContext context)
        {
			GetAppLicenseResponse getAppLicenseResponse = new GetAppLicenseResponse();

			getAppLicenseResponse.HttpResponse = context.HttpResponse;
			getAppLicenseResponse.RequestId = context.StringValue("GetAppLicense.RequestId");

			GetAppLicenseResponse.GetAppLicense_AppLicense appLicense = new GetAppLicenseResponse.GetAppLicense_AppLicense();
			appLicense.LicenseId = context.LongValue("GetAppLicense.AppLicense.LicenseId");
			appLicense.CreationTime = context.StringValue("GetAppLicense.AppLicense.CreationTime");
			appLicense.ContractNo = context.StringValue("GetAppLicense.AppLicense.ContractNo");
			appLicense.AppName = context.StringValue("GetAppLicense.AppLicense.AppName");
			appLicense.BundleId = context.StringValue("GetAppLicense.AppLicense.BundleId");
			appLicense.PackageName = context.StringValue("GetAppLicense.AppLicense.PackageName");
			appLicense.LicenseSignature = context.StringValue("GetAppLicense.AppLicense.LicenseSignature");
			appLicense.Type = context.StringValue("GetAppLicense.AppLicense.Type");
			appLicense.Feature = context.StringValue("GetAppLicense.AppLicense.Feature");
			appLicense.ExpiredOn = context.StringValue("GetAppLicense.AppLicense.ExpiredOn");
			appLicense.Status = context.StringValue("GetAppLicense.AppLicense.Status");
			appLicense.SdkIds = context.StringValue("GetAppLicense.AppLicense.SdkIds");
			appLicense.AccountId = context.LongValue("GetAppLicense.AppLicense.AccountId");
			appLicense.CustomerId = context.LongValue("GetAppLicense.AppLicense.CustomerId");
			getAppLicenseResponse.AppLicense = appLicense;
        
			return getAppLicenseResponse;
        }
    }
}
