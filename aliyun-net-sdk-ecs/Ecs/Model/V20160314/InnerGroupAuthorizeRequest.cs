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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20160314;

namespace Aliyun.Acs.Ecs.Model.V20160314
{
    public class InnerGroupAuthorizeRequest : RpcAcsRequest<InnerGroupAuthorizeResponse>
    {
        public InnerGroupAuthorizeRequest()
            : base("Ecs", "2016-03-14", "InnerGroupAuthorize", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string channel;

		private string nic;

		private string vpcInstanceId;

		private string _operator;

		private long? aliUid;

		private string proxyId;

		private string policy;

		private string sourceGroupNo;

		private string portRange;

		private string resourceOwnerAccount;

		private int? level;

		private string ipProtocol;

		private string ownerAccount;

		private string sourceCidrIp;

		private long? ownerId;

		private string destCidrIp;

		private string token;

		private string regionNo;

		private long? sourceGroupOwnerAliUid;

		private bool? async;

		private long? sourceGroupId;

		private string appKey;

		private string bid;

		private string groupNo;

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

		public string Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "channel", value);
			}
		}

		public string Nic
		{
			get
			{
				return nic;
			}
			set	
			{
				nic = value;
				DictionaryUtil.Add(QueryParameters, "nic", value);
			}
		}

		public string VpcInstanceId
		{
			get
			{
				return vpcInstanceId;
			}
			set	
			{
				vpcInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "vpcInstanceId", value);
			}
		}

		public string _Operator
		{
			get
			{
				return _operator;
			}
			set	
			{
				_operator = value;
				DictionaryUtil.Add(QueryParameters, "operator", value);
			}
		}

		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
				DictionaryUtil.Add(QueryParameters, "aliUid", value.ToString());
			}
		}

		public string ProxyId
		{
			get
			{
				return proxyId;
			}
			set	
			{
				proxyId = value;
				DictionaryUtil.Add(QueryParameters, "proxyId", value);
			}
		}

		public string Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
				DictionaryUtil.Add(QueryParameters, "policy", value);
			}
		}

		public string SourceGroupNo
		{
			get
			{
				return sourceGroupNo;
			}
			set	
			{
				sourceGroupNo = value;
				DictionaryUtil.Add(QueryParameters, "sourceGroupNo", value);
			}
		}

		public string PortRange
		{
			get
			{
				return portRange;
			}
			set	
			{
				portRange = value;
				DictionaryUtil.Add(QueryParameters, "portRange", value);
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

		public int? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "level", value.ToString());
			}
		}

		public string IpProtocol
		{
			get
			{
				return ipProtocol;
			}
			set	
			{
				ipProtocol = value;
				DictionaryUtil.Add(QueryParameters, "ipProtocol", value);
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

		public string SourceCidrIp
		{
			get
			{
				return sourceCidrIp;
			}
			set	
			{
				sourceCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "sourceCidrIp", value);
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

		public string DestCidrIp
		{
			get
			{
				return destCidrIp;
			}
			set	
			{
				destCidrIp = value;
				DictionaryUtil.Add(QueryParameters, "destCidrIp", value);
			}
		}

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "token", value);
			}
		}

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "regionNo", value);
			}
		}

		public long? SourceGroupOwnerAliUid
		{
			get
			{
				return sourceGroupOwnerAliUid;
			}
			set	
			{
				sourceGroupOwnerAliUid = value;
				DictionaryUtil.Add(QueryParameters, "sourceGroupOwnerAliUid", value.ToString());
			}
		}

		public bool? Async
		{
			get
			{
				return async;
			}
			set	
			{
				async = value;
				DictionaryUtil.Add(QueryParameters, "async", value.ToString());
			}
		}

		public long? SourceGroupId
		{
			get
			{
				return sourceGroupId;
			}
			set	
			{
				sourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "sourceGroupId", value.ToString());
			}
		}

		public string AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "appKey", value);
			}
		}

		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "bid", value);
			}
		}

		public string GroupNo
		{
			get
			{
				return groupNo;
			}
			set	
			{
				groupNo = value;
				DictionaryUtil.Add(QueryParameters, "groupNo", value);
			}
		}

        public override InnerGroupAuthorizeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InnerGroupAuthorizeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
