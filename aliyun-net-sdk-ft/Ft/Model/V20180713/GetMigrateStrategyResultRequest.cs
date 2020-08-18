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
using Aliyun.Acs.Ft;
using Aliyun.Acs.Ft.Transform;
using Aliyun.Acs.Ft.Transform.V20180713;

namespace Aliyun.Acs.Ft.Model.V20180713
{
    public class GetMigrateStrategyResultRequest : RpcAcsRequest<GetMigrateStrategyResultResponse>
    {
        public GetMigrateStrategyResultRequest()
            : base("Ft", "2018-07-13", "GetMigrateStrategyResult")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string parentName;

		private int? currentPage;

		private string bucName;

		private string env;

		private string type;

		private string bucEmpId;

		private string strategyName;

		private string apiName;

		private string flowSpecial;

		private int? pageSize;

		private string productName;

		private string bucUid;

		private string versionName;

		private string status;

		public string ParentName
		{
			get
			{
				return parentName;
			}
			set	
			{
				parentName = value;
				DictionaryUtil.Add(QueryParameters, "parentName", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public string BucName
		{
			get
			{
				return bucName;
			}
			set	
			{
				bucName = value;
				DictionaryUtil.Add(QueryParameters, "BucName", value);
			}
		}

		public string Env
		{
			get
			{
				return env;
			}
			set	
			{
				env = value;
				DictionaryUtil.Add(QueryParameters, "Env", value);
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
				DictionaryUtil.Add(QueryParameters, "type", value);
			}
		}

		public string BucEmpId
		{
			get
			{
				return bucEmpId;
			}
			set	
			{
				bucEmpId = value;
				DictionaryUtil.Add(QueryParameters, "BucEmpId", value);
			}
		}

		public string StrategyName
		{
			get
			{
				return strategyName;
			}
			set	
			{
				strategyName = value;
				DictionaryUtil.Add(BodyParameters, "strategyName", value);
			}
		}

		public string ApiName
		{
			get
			{
				return apiName;
			}
			set	
			{
				apiName = value;
				DictionaryUtil.Add(QueryParameters, "ApiName", value);
			}
		}

		public string FlowSpecial
		{
			get
			{
				return flowSpecial;
			}
			set	
			{
				flowSpecial = value;
				DictionaryUtil.Add(QueryParameters, "flowSpecial", value);
			}
		}

		public int? PageSize
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

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
				DictionaryUtil.Add(QueryParameters, "ProductName", value);
			}
		}

		public string BucUid
		{
			get
			{
				return bucUid;
			}
			set	
			{
				bucUid = value;
				DictionaryUtil.Add(QueryParameters, "BucUid", value);
			}
		}

		public string VersionName
		{
			get
			{
				return versionName;
			}
			set	
			{
				versionName = value;
				DictionaryUtil.Add(QueryParameters, "VersionName", value);
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
				DictionaryUtil.Add(QueryParameters, "status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetMigrateStrategyResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetMigrateStrategyResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
