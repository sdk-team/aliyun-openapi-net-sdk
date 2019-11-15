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
    public class InnerEcsInstanceQueryByParamRequest : RpcAcsRequest<InnerEcsInstanceQueryByParamResponse>
    {
        public InnerEcsInstanceQueryByParamRequest()
            : base("Ecs", "2016-03-14", "InnerEcsInstanceQueryByParam", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string izNo;

		private string channel;

		private string _operator;

		private string vswInstanceId;

		private bool? deviceAvailable;

		private string publicIps;

		private string proxyId;

		private long? ownerId;

		private string tags;

		private string instanceIds;

		private int? pageNo;

		private string fuzzyInstanceName;

		private string status;

		private long? imageId;

		private bool? isNeedDetail;

		private bool? ioOptimized;

		private string vpcInstanceId;

		private string innerIps;

		private string bizStatus;

		private int? pageSize;

		private string instanceType;

		private long? aliUid;

		private string privateIps;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string instanceTypeFamily;

		private string token;

		private string ecsNetworkType;

		private string regionNo;

		private bool? async;

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

		public string IzNo
		{
			get
			{
				return izNo;
			}
			set	
			{
				izNo = value;
				DictionaryUtil.Add(QueryParameters, "izNo", value);
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

		public string VswInstanceId
		{
			get
			{
				return vswInstanceId;
			}
			set	
			{
				vswInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "vswInstanceId", value);
			}
		}

		public bool? DeviceAvailable
		{
			get
			{
				return deviceAvailable;
			}
			set	
			{
				deviceAvailable = value;
				DictionaryUtil.Add(QueryParameters, "deviceAvailable", value.ToString());
			}
		}

		public string PublicIps
		{
			get
			{
				return publicIps;
			}
			set	
			{
				publicIps = value;
				DictionaryUtil.Add(QueryParameters, "publicIps", value);
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

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "tags", value);
			}
		}

		public string InstanceIds
		{
			get
			{
				return instanceIds;
			}
			set	
			{
				instanceIds = value;
				DictionaryUtil.Add(QueryParameters, "instanceIds", value);
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "pageNo", value.ToString());
			}
		}

		public string FuzzyInstanceName
		{
			get
			{
				return fuzzyInstanceName;
			}
			set	
			{
				fuzzyInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "fuzzyInstanceName", value);
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

		public long? ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "imageId", value.ToString());
			}
		}

		public bool? IsNeedDetail
		{
			get
			{
				return isNeedDetail;
			}
			set	
			{
				isNeedDetail = value;
				DictionaryUtil.Add(QueryParameters, "isNeedDetail", value.ToString());
			}
		}

		public bool? IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "ioOptimized", value.ToString());
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

		public string InnerIps
		{
			get
			{
				return innerIps;
			}
			set	
			{
				innerIps = value;
				DictionaryUtil.Add(QueryParameters, "innerIps", value);
			}
		}

		public string BizStatus
		{
			get
			{
				return bizStatus;
			}
			set	
			{
				bizStatus = value;
				DictionaryUtil.Add(QueryParameters, "bizStatus", value);
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
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "instanceType", value);
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

		public string PrivateIps
		{
			get
			{
				return privateIps;
			}
			set	
			{
				privateIps = value;
				DictionaryUtil.Add(QueryParameters, "privateIps", value);
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

		public string InstanceTypeFamily
		{
			get
			{
				return instanceTypeFamily;
			}
			set	
			{
				instanceTypeFamily = value;
				DictionaryUtil.Add(QueryParameters, "instanceTypeFamily", value);
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

		public string EcsNetworkType
		{
			get
			{
				return ecsNetworkType;
			}
			set	
			{
				ecsNetworkType = value;
				DictionaryUtil.Add(QueryParameters, "ecsNetworkType", value);
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

        public override InnerEcsInstanceQueryByParamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InnerEcsInstanceQueryByParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
