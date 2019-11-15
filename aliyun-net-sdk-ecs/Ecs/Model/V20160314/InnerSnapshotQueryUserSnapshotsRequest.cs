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
    public class InnerSnapshotQueryUserSnapshotsRequest : RpcAcsRequest<InnerSnapshotQueryUserSnapshotsResponse>
    {
        public InnerSnapshotQueryUserSnapshotsRequest()
            : base("Ecs", "2016-03-14", "InnerSnapshotQueryUserSnapshots", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string ecsIds;

		private long? resourceOwnerId;

		private string snapshotIds;

		private string channel;

		private string deviceNo;

		private string _operator;

		private string deviceType;

		private string gmtCreatedBegin;

		private bool? createFinished;

		private string quoteType;

		private string proxyId;

		private long? ownerId;

		private int? pageNo;

		private string ids;

		private string snapshotNickName;

		private string aliUids;

		private string ecsSnapshotStatus;

		private string fuzzySnapshotName;

		private int? pageSize;

		private string diskId;

		private string ecsSnapshotTypes;

		private string gmtCreatedEnd;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string excludeSnapshotIds;

		private string diskType;

		private string token;

		private string regionNo;

		private int? snapshotSizeLowLimit;

		private string appKey;

		private int? snapshotSizeLimit;

		private bool? isSyncHouyi;

		private string bid;

		private string snapshotNos;

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

		public string SnapshotIds
		{
			get
			{
				return snapshotIds;
			}
			set	
			{
				snapshotIds = value;
				DictionaryUtil.Add(QueryParameters, "snapshotIds", value);
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

		public string DeviceNo
		{
			get
			{
				return deviceNo;
			}
			set	
			{
				deviceNo = value;
				DictionaryUtil.Add(QueryParameters, "deviceNo", value);
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

		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(QueryParameters, "deviceType", value);
			}
		}

		public string GmtCreatedBegin
		{
			get
			{
				return gmtCreatedBegin;
			}
			set	
			{
				gmtCreatedBegin = value;
				DictionaryUtil.Add(QueryParameters, "gmtCreatedBegin", value);
			}
		}

		public bool? CreateFinished
		{
			get
			{
				return createFinished;
			}
			set	
			{
				createFinished = value;
				DictionaryUtil.Add(QueryParameters, "createFinished", value.ToString());
			}
		}

		public string QuoteType
		{
			get
			{
				return quoteType;
			}
			set	
			{
				quoteType = value;
				DictionaryUtil.Add(QueryParameters, "quoteType", value);
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

		public string Ids
		{
			get
			{
				return ids;
			}
			set	
			{
				ids = value;
				DictionaryUtil.Add(QueryParameters, "ids", value);
			}
		}

		public string SnapshotNickName
		{
			get
			{
				return snapshotNickName;
			}
			set	
			{
				snapshotNickName = value;
				DictionaryUtil.Add(QueryParameters, "snapshotNickName", value);
			}
		}

		public string AliUids
		{
			get
			{
				return aliUids;
			}
			set	
			{
				aliUids = value;
				DictionaryUtil.Add(QueryParameters, "aliUids", value);
			}
		}

		public string EcsSnapshotStatus
		{
			get
			{
				return ecsSnapshotStatus;
			}
			set	
			{
				ecsSnapshotStatus = value;
				DictionaryUtil.Add(QueryParameters, "ecsSnapshotStatus", value);
			}
		}

		public string FuzzySnapshotName
		{
			get
			{
				return fuzzySnapshotName;
			}
			set	
			{
				fuzzySnapshotName = value;
				DictionaryUtil.Add(QueryParameters, "fuzzySnapshotName", value);
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

		public string DiskId
		{
			get
			{
				return diskId;
			}
			set	
			{
				diskId = value;
				DictionaryUtil.Add(QueryParameters, "diskId", value);
			}
		}

		public string EcsSnapshotTypes
		{
			get
			{
				return ecsSnapshotTypes;
			}
			set	
			{
				ecsSnapshotTypes = value;
				DictionaryUtil.Add(QueryParameters, "ecsSnapshotTypes", value);
			}
		}

		public string GmtCreatedEnd
		{
			get
			{
				return gmtCreatedEnd;
			}
			set	
			{
				gmtCreatedEnd = value;
				DictionaryUtil.Add(QueryParameters, "gmtCreatedEnd", value);
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

		public string ExcludeSnapshotIds
		{
			get
			{
				return excludeSnapshotIds;
			}
			set	
			{
				excludeSnapshotIds = value;
				DictionaryUtil.Add(QueryParameters, "excludeSnapshotIds", value);
			}
		}

		public string DiskType
		{
			get
			{
				return diskType;
			}
			set	
			{
				diskType = value;
				DictionaryUtil.Add(QueryParameters, "diskType", value);
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

		public int? SnapshotSizeLowLimit
		{
			get
			{
				return snapshotSizeLowLimit;
			}
			set	
			{
				snapshotSizeLowLimit = value;
				DictionaryUtil.Add(QueryParameters, "snapshotSizeLowLimit", value.ToString());
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

		public int? SnapshotSizeLimit
		{
			get
			{
				return snapshotSizeLimit;
			}
			set	
			{
				snapshotSizeLimit = value;
				DictionaryUtil.Add(QueryParameters, "snapshotSizeLimit", value.ToString());
			}
		}

		public bool? IsSyncHouyi
		{
			get
			{
				return isSyncHouyi;
			}
			set	
			{
				isSyncHouyi = value;
				DictionaryUtil.Add(QueryParameters, "isSyncHouyi", value.ToString());
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

		public string SnapshotNos
		{
			get
			{
				return snapshotNos;
			}
			set	
			{
				snapshotNos = value;
				DictionaryUtil.Add(QueryParameters, "snapshotNos", value);
			}
		}

        public override InnerSnapshotQueryUserSnapshotsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InnerSnapshotQueryUserSnapshotsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
