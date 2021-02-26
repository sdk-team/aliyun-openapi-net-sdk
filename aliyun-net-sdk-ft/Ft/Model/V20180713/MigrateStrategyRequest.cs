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
    public class MigrateStrategyRequest : RpcAcsRequest<MigrateStrategyResponse>
    {
        public MigrateStrategyRequest()
            : base("Ft", "2018-07-13", "MigrateStrategy")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string apiName;

		private string productName;

		private long? bucUid;

		private long? step;

		private string bucName;

		private string env;

		private string bucEmpId;

		private string versionName;

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

		public long? BucUid
		{
			get
			{
				return bucUid;
			}
			set	
			{
				bucUid = value;
				DictionaryUtil.Add(QueryParameters, "BucUid", value.ToString());
			}
		}

		public long? Step
		{
			get
			{
				return step;
			}
			set	
			{
				step = value;
				DictionaryUtil.Add(QueryParameters, "Step", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override MigrateStrategyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MigrateStrategyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
