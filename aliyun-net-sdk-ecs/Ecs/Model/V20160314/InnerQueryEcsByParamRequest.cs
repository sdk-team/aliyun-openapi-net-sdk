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
    public class InnerQueryEcsByParamRequest : RpcAcsRequest<InnerQueryEcsByParamResponse>
    {
        public InnerQueryEcsByParamRequest()
            : base("Ecs", "2016-03-14", "InnerQueryEcsByParam", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? startOfInternetTx;

		private string ecsIds;

		private long? resourceOwnerId;

		private string izNo;

		private string internetIp;

		private string channel;

		private bool? notSyncHouyi;

		private string imgPc;

		private string instanceTypeId;

		private string _operator;

		private string vswInstanceId;

		private string hostname;

		private string zoneNo;

		private int? cores;

		private string exclusionEcsIds;

		private string proxyId;

		private string order;

		private int? agentId;

		private string imageType;

		private int? endOfInternetTx;

		private long? ownerId;

		private string instanceIds;

		private long? zoneId;

		private long? izId;

		private string status;

		private string intranetIp;

		private bool? orderType;

		private long? imageId;

		private bool? ioOptimized;

		private string vpcInstanceId;

		private int? pageNumber;

		private int? mem;

		private string bizStatus;

		private int? pageSize;

		private long? aliUid;

		private string systemDeviceCategory;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string token;

		private string regionNo;

		private string ecsNetworkType;

		private string appKey;

		private string bid;

		public int? StartOfInternetTx
		{
			get
			{
				return startOfInternetTx;
			}
			set	
			{
				startOfInternetTx = value;
				DictionaryUtil.Add(QueryParameters, "startOfInternetTx", value.ToString());
			}
		}

		public string EcsIds
		{
			get
			{
				return ecsIds;
			}
			set	
			{
				ecsIds = value;
				DictionaryUtil.Add(QueryParameters, "ecsIds", value);
			}
		}

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

		public string InternetIp
		{
			get
			{
				return internetIp;
			}
			set	
			{
				internetIp = value;
				DictionaryUtil.Add(QueryParameters, "internetIp", value);
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

		public bool? NotSyncHouyi
		{
			get
			{
				return notSyncHouyi;
			}
			set	
			{
				notSyncHouyi = value;
				DictionaryUtil.Add(QueryParameters, "notSyncHouyi", value.ToString());
			}
		}

		public string ImgPc
		{
			get
			{
				return imgPc;
			}
			set	
			{
				imgPc = value;
				DictionaryUtil.Add(QueryParameters, "imgPc", value);
			}
		}

		public string InstanceTypeId
		{
			get
			{
				return instanceTypeId;
			}
			set	
			{
				instanceTypeId = value;
				DictionaryUtil.Add(QueryParameters, "instanceTypeId", value);
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

		public string Hostname
		{
			get
			{
				return hostname;
			}
			set	
			{
				hostname = value;
				DictionaryUtil.Add(QueryParameters, "hostname", value);
			}
		}

		public string ZoneNo
		{
			get
			{
				return zoneNo;
			}
			set	
			{
				zoneNo = value;
				DictionaryUtil.Add(QueryParameters, "zoneNo", value);
			}
		}

		public int? Cores
		{
			get
			{
				return cores;
			}
			set	
			{
				cores = value;
				DictionaryUtil.Add(QueryParameters, "cores", value.ToString());
			}
		}

		public string ExclusionEcsIds
		{
			get
			{
				return exclusionEcsIds;
			}
			set	
			{
				exclusionEcsIds = value;
				DictionaryUtil.Add(QueryParameters, "exclusionEcsIds", value);
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

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "order", value);
			}
		}

		public int? AgentId
		{
			get
			{
				return agentId;
			}
			set	
			{
				agentId = value;
				DictionaryUtil.Add(QueryParameters, "agentId", value.ToString());
			}
		}

		public string ImageType
		{
			get
			{
				return imageType;
			}
			set	
			{
				imageType = value;
				DictionaryUtil.Add(QueryParameters, "imageType", value);
			}
		}

		public int? EndOfInternetTx
		{
			get
			{
				return endOfInternetTx;
			}
			set	
			{
				endOfInternetTx = value;
				DictionaryUtil.Add(QueryParameters, "endOfInternetTx", value.ToString());
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

		public long? ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "zoneId", value.ToString());
			}
		}

		public long? IzId
		{
			get
			{
				return izId;
			}
			set	
			{
				izId = value;
				DictionaryUtil.Add(QueryParameters, "izId", value.ToString());
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

		public string IntranetIp
		{
			get
			{
				return intranetIp;
			}
			set	
			{
				intranetIp = value;
				DictionaryUtil.Add(QueryParameters, "intranetIp", value);
			}
		}

		public bool? OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "orderType", value.ToString());
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

		public int? Mem
		{
			get
			{
				return mem;
			}
			set	
			{
				mem = value;
				DictionaryUtil.Add(QueryParameters, "mem", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public string SystemDeviceCategory
		{
			get
			{
				return systemDeviceCategory;
			}
			set	
			{
				systemDeviceCategory = value;
				DictionaryUtil.Add(QueryParameters, "systemDeviceCategory", value);
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

        public override InnerQueryEcsByParamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InnerQueryEcsByParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
