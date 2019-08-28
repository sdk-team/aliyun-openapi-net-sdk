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
    public class GetAppLicenseListResponseUnmarshaller
    {
        public static GetAppLicenseListResponse Unmarshall(UnmarshallerContext context)
        {
			GetAppLicenseListResponse getAppLicenseListResponse = new GetAppLicenseListResponse();

			getAppLicenseListResponse.HttpResponse = context.HttpResponse;
			getAppLicenseListResponse.RequestId = context.StringValue("GetAppLicenseList.RequestId");
			getAppLicenseListResponse.Total = context.LongValue("GetAppLicenseList.Total");

			List<GetAppLicenseListResponse.GetAppLicenseList_AppLicense> getAppLicenseListResponse_appLicenseList = new List<GetAppLicenseListResponse.GetAppLicenseList_AppLicense>();
			for (int i = 0; i < context.Length("GetAppLicenseList.AppLicenseList.Length"); i++) {
				GetAppLicenseListResponse.GetAppLicenseList_AppLicense appLicense = new GetAppLicenseListResponse.GetAppLicenseList_AppLicense();
				appLicense.LicenseId = context.LongValue("GetAppLicenseList.AppLicenseList["+ i +"].LicenseId");
				appLicense.CreationTime = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].CreationTime");
				appLicense.ContractNo = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].ContractNo");
				appLicense.AppName = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].AppName");
				appLicense.BundleId = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].BundleId");
				appLicense.PackageName = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].PackageName");
				appLicense.LicenseSignature = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].LicenseSignature");
				appLicense.Type = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].Type");
				appLicense.Feature = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].Feature");
				appLicense.ExpiredOn = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].ExpiredOn");
				appLicense.Status = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].Status");
				appLicense.SdkIds = context.StringValue("GetAppLicenseList.AppLicenseList["+ i +"].SdkIds");
				appLicense.AccountId = context.LongValue("GetAppLicenseList.AppLicenseList["+ i +"].AccountId");
				appLicense.CustomerId = context.LongValue("GetAppLicenseList.AppLicenseList["+ i +"].CustomerId");

				getAppLicenseListResponse_appLicenseList.Add(appLicense);
			}
			getAppLicenseListResponse.AppLicenseList = getAppLicenseListResponse_appLicenseList;
        
			return getAppLicenseListResponse;
        }
    }
}
