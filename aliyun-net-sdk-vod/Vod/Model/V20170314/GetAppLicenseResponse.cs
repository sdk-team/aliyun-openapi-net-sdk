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

namespace Aliyun.Acs.vod.Model.V20170314
{
	public class GetAppLicenseResponse : AcsResponse
	{

		private string requestId;

		private GetAppLicense_AppLicense appLicense;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetAppLicense_AppLicense AppLicense
		{
			get
			{
				return appLicense;
			}
			set	
			{
				appLicense = value;
			}
		}

		public class GetAppLicense_AppLicense
		{

			private long? licenseId;

			private string creationTime;

			private string contractNo;

			private string appName;

			private string bundleId;

			private string packageName;

			private string licenseSignature;

			private string type;

			private string feature;

			private string expiredOn;

			private string status;

			private string sdkIds;

			private long? accountId;

			private long? customerId;

			public long? LicenseId
			{
				get
				{
					return licenseId;
				}
				set	
				{
					licenseId = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ContractNo
			{
				get
				{
					return contractNo;
				}
				set	
				{
					contractNo = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
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
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Feature
			{
				get
				{
					return feature;
				}
				set	
				{
					feature = value;
				}
			}

			public string ExpiredOn
			{
				get
				{
					return expiredOn;
				}
				set	
				{
					expiredOn = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string SdkIds
			{
				get
				{
					return sdkIds;
				}
				set	
				{
					sdkIds = value;
				}
			}

			public long? AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public long? CustomerId
			{
				get
				{
					return customerId;
				}
				set	
				{
					customerId = value;
				}
			}
		}
	}
}
