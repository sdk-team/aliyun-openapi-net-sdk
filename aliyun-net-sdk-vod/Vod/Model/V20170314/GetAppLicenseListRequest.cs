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
    public class GetAppLicenseListRequest : RpcAcsRequest<GetAppLicenseListResponse>
    {
        public GetAppLicenseListRequest()
            : base("vod", "2017-03-14", "GetAppLicenseList", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string endCreationTime;

		private string contractNo;

		private string bundleId;

		private string packageName;

		private string startCreationTime;

		private string endExpiredTime;

		private string ownerId;

		private string type;

		private string sdkIds;

		private string startExpiredTime;

		private long? accountId;

		private string appName;

		private string feature;

		private long? pageNo;

		private long? customerId;

		private long? pageSize;

		private string sortBy;

		private string status;

		public string EndCreationTime
		{
			get
			{
				return endCreationTime;
			}
			set	
			{
				endCreationTime = value;
				DictionaryUtil.Add(QueryParameters, "EndCreationTime", value);
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
				DictionaryUtil.Add(QueryParameters, "ContractNo", value);
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

		public string StartCreationTime
		{
			get
			{
				return startCreationTime;
			}
			set	
			{
				startCreationTime = value;
				DictionaryUtil.Add(QueryParameters, "StartCreationTime", value);
			}
		}

		public string EndExpiredTime
		{
			get
			{
				return endExpiredTime;
			}
			set	
			{
				endExpiredTime = value;
				DictionaryUtil.Add(QueryParameters, "EndExpiredTime", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
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
				DictionaryUtil.Add(QueryParameters, "SdkIds", value);
			}
		}

		public string StartExpiredTime
		{
			get
			{
				return startExpiredTime;
			}
			set	
			{
				startExpiredTime = value;
				DictionaryUtil.Add(QueryParameters, "StartExpiredTime", value);
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
				DictionaryUtil.Add(QueryParameters, "AccountId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "AppName", value);
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
				DictionaryUtil.Add(QueryParameters, "Feature", value);
			}
		}

		public long? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "CustomerId", value.ToString());
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string SortBy
		{
			get
			{
				return sortBy;
			}
			set	
			{
				sortBy = value;
				DictionaryUtil.Add(QueryParameters, "SortBy", value);
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
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override GetAppLicenseListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAppLicenseListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
