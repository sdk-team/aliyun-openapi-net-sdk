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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeEipAddressesByBwpRequest : RpcAcsRequest<DescribeEipAddressesByBwpResponse>
    {
        public DescribeEipAddressesByBwpRequest()
            : base("Vpc", "2016-04-28", "DescribeEipAddressesByBwp")
        {
        }

		private long? resourceOwnerId;

		private string iSP;

		private int? pageNumber;

		private int? pageSize;

		private string bandwidthPackageId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ISP
		{
			get
			{
				return iSP;
			}
			set	
			{
				iSP = value;
				DictionaryUtil.Add(QueryParameters, "ISP", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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

		public string BandwidthPackageId
		{
			get
			{
				return bandwidthPackageId;
			}
			set	
			{
				bandwidthPackageId = value;
				DictionaryUtil.Add(QueryParameters, "BandwidthPackageId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override DescribeEipAddressesByBwpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeEipAddressesByBwpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
