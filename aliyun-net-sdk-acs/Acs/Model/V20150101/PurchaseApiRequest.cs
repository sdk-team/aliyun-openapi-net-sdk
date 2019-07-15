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
using Aliyun.Acs.Acs.Transform;
using Aliyun.Acs.Acs.Transform.V20150101;

namespace Aliyun.Acs.Acs.Model.V20150101
{
    public class PurchaseApiRequest : RoaAcsRequest<PurchaseApiResponse>
    {
        public PurchaseApiRequest()
            : base("Acs", "2015-01-01", "PurchaseApi", "12334", "openAPI")
        {
			UriPattern = "/Api/PurchaseApi";
			Method = MethodType.POST;
        }

		private string serviceDate;

		private long? quota;

		private string orgCode;

		private string purchaseProduct;

		private string channel;

		private string purchaseVersion;

		private string purchaseApiName;

		private string billingType;

		public string ServiceDate
		{
			get
			{
				return serviceDate;
			}
			set	
			{
				serviceDate = value;
				DictionaryUtil.Add(QueryParameters, "ServiceDate", value);
			}
		}

		public long? Quota
		{
			get
			{
				return quota;
			}
			set	
			{
				quota = value;
				DictionaryUtil.Add(QueryParameters, "Quota", value.ToString());
			}
		}

		public string OrgCode
		{
			get
			{
				return orgCode;
			}
			set	
			{
				orgCode = value;
				DictionaryUtil.Add(QueryParameters, "OrgCode", value);
			}
		}

		public string PurchaseProduct
		{
			get
			{
				return purchaseProduct;
			}
			set	
			{
				purchaseProduct = value;
				DictionaryUtil.Add(QueryParameters, "PurchaseProduct", value);
			}
		}

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value);
			}
		}

		public string PurchaseVersion
		{
			get
			{
				return purchaseVersion;
			}
			set	
			{
				purchaseVersion = value;
				DictionaryUtil.Add(QueryParameters, "PurchaseVersion", value);
			}
		}

		public string PurchaseApiName
		{
			get
			{
				return purchaseApiName;
			}
			set	
			{
				purchaseApiName = value;
				DictionaryUtil.Add(QueryParameters, "PurchaseApiName", value);
			}
		}

		public string BillingType
		{
			get
			{
				return billingType;
			}
			set	
			{
				billingType = value;
				DictionaryUtil.Add(QueryParameters, "BillingType", value);
			}
		}

        public override PurchaseApiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PurchaseApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
