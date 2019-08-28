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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170314;

namespace Aliyun.Acs.vod.Model.V20170314
{
    public class AuthorizeAppLicenseRequest : RpcAcsRequest<AuthorizeAppLicenseResponse>
    {
        public AuthorizeAppLicenseRequest()
            : base("vod", "2017-03-14", "AuthorizeAppLicense", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? sdkVersionCode;

		private long? licenseVersion;

		private long? sdkCode;

		private string bundleId;

		private string packageName;

		private string sign;

		private string ownerId;

		private string nonce;

		private long? platform;

		private string licenseSignature;

		private string sdkVersion;

		private long? time;

		public long? SdkVersionCode
		{
			get
			{
				return sdkVersionCode;
			}
			set	
			{
				sdkVersionCode = value;
				DictionaryUtil.Add(QueryParameters, "SdkVersionCode", value.ToString());
			}
		}

		public long? LicenseVersion
		{
			get
			{
				return licenseVersion;
			}
			set	
			{
				licenseVersion = value;
				DictionaryUtil.Add(QueryParameters, "LicenseVersion", value.ToString());
			}
		}

		public long? SdkCode
		{
			get
			{
				return sdkCode;
			}
			set	
			{
				sdkCode = value;
				DictionaryUtil.Add(QueryParameters, "SdkCode", value.ToString());
			}
		}

		public string BundleId
		{
			get
			{
				return bundleId;
			}
			set	
			{
				bundleId = value;
				DictionaryUtil.Add(QueryParameters, "BundleId", value);
			}
		}

		public string PackageName
		{
			get
			{
				return packageName;
			}
			set	
			{
				packageName = value;
				DictionaryUtil.Add(QueryParameters, "PackageName", value);
			}
		}

		public string Sign
		{
			get
			{
				return sign;
			}
			set	
			{
				sign = value;
				DictionaryUtil.Add(QueryParameters, "Sign", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string Nonce
		{
			get
			{
				return nonce;
			}
			set	
			{
				nonce = value;
				DictionaryUtil.Add(QueryParameters, "Nonce", value);
			}
		}

		public long? Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value.ToString());
			}
		}

		public string LicenseSignature
		{
			get
			{
				return licenseSignature;
			}
			set	
			{
				licenseSignature = value;
				DictionaryUtil.Add(QueryParameters, "LicenseSignature", value);
			}
		}

		public string SdkVersion
		{
			get
			{
				return sdkVersion;
			}
			set	
			{
				sdkVersion = value;
				DictionaryUtil.Add(QueryParameters, "SdkVersion", value);
			}
		}

		public long? Time
		{
			get
			{
				return time;
			}
			set	
			{
				time = value;
				DictionaryUtil.Add(QueryParameters, "Time", value.ToString());
			}
		}

        public override AuthorizeAppLicenseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AuthorizeAppLicenseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
