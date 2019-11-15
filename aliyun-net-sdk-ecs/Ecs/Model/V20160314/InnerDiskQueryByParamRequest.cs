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
    public class InnerDiskQueryByParamRequest : RpcAcsRequest<InnerDiskQueryByParamResponse>
    {
        public InnerDiskQueryByParamRequest()
            : base("Ecs", "2016-03-14", "InnerDiskQueryByParam", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string izNo;

		private string prePayEcsInstanceIds;

		private string autoSnapshotPolicyId;

		private string channel;

		private string _operator;

		private string excludeStatus;

		private string diskName;

		private bool? deleteAutoSnapshot;

		private string snapshotNo;

		private string proxyId;

		private string ecsInstanceId;

		private bool? enableAutoSnapshot;

		private bool? active;

		private string imageNo;

		private string createTimeFrom;

		private bool? portable;

		private long? ownerId;

		private string tags;

		private string instanceIds;

		private int? pageNo;

		private string createTimeTo;

		private string status;

		private string fuzzyDiskName;

		private string diskCategory;

		private int? pageSize;

		private long? aliUid;

		private bool? deleteWithInstance;

		private string postPayEcsInstanceIds;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private bool? enableAutomatedSnapshotPolicy;

		private string diskType;

		private string token;

		private string regionNo;

		private bool? async;

		private string appKey;

		private string bid;

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

		public string PrePayEcsInstanceIds
		{
			get
			{
				return prePayEcsInstanceIds;
			}
			set	
			{
				prePayEcsInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "prePayEcsInstanceIds", value);
			}
		}

		public string AutoSnapshotPolicyId
		{
			get
			{
				return autoSnapshotPolicyId;
			}
			set	
			{
				autoSnapshotPolicyId = value;
				DictionaryUtil.Add(QueryParameters, "autoSnapshotPolicyId", value);
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

		public string ExcludeStatus
		{
			get
			{
				return excludeStatus;
			}
			set	
			{
				excludeStatus = value;
				DictionaryUtil.Add(QueryParameters, "excludeStatus", value);
			}
		}

		public string DiskName
		{
			get
			{
				return diskName;
			}
			set	
			{
				diskName = value;
				DictionaryUtil.Add(QueryParameters, "diskName", value);
			}
		}

		public bool? DeleteAutoSnapshot
		{
			get
			{
				return deleteAutoSnapshot;
			}
			set	
			{
				deleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "deleteAutoSnapshot", value.ToString());
			}
		}

		public string SnapshotNo
		{
			get
			{
				return snapshotNo;
			}
			set	
			{
				snapshotNo = value;
				DictionaryUtil.Add(QueryParameters, "snapshotNo", value);
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

		public string EcsInstanceId
		{
			get
			{
				return ecsInstanceId;
			}
			set	
			{
				ecsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ecsInstanceId", value);
			}
		}

		public bool? EnableAutoSnapshot
		{
			get
			{
				return enableAutoSnapshot;
			}
			set	
			{
				enableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "enableAutoSnapshot", value.ToString());
			}
		}

		public bool? Active
		{
			get
			{
				return active;
			}
			set	
			{
				active = value;
				DictionaryUtil.Add(QueryParameters, "active", value.ToString());
			}
		}

		public string ImageNo
		{
			get
			{
				return imageNo;
			}
			set	
			{
				imageNo = value;
				DictionaryUtil.Add(QueryParameters, "imageNo", value);
			}
		}

		public string CreateTimeFrom
		{
			get
			{
				return createTimeFrom;
			}
			set	
			{
				createTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "createTimeFrom", value);
			}
		}

		public bool? Portable
		{
			get
			{
				return portable;
			}
			set	
			{
				portable = value;
				DictionaryUtil.Add(QueryParameters, "portable", value.ToString());
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

		public string CreateTimeTo
		{
			get
			{
				return createTimeTo;
			}
			set	
			{
				createTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "createTimeTo", value);
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

		public string FuzzyDiskName
		{
			get
			{
				return fuzzyDiskName;
			}
			set	
			{
				fuzzyDiskName = value;
				DictionaryUtil.Add(QueryParameters, "fuzzyDiskName", value);
			}
		}

		public string DiskCategory
		{
			get
			{
				return diskCategory;
			}
			set	
			{
				diskCategory = value;
				DictionaryUtil.Add(QueryParameters, "diskCategory", value);
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

		public bool? DeleteWithInstance
		{
			get
			{
				return deleteWithInstance;
			}
			set	
			{
				deleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "deleteWithInstance", value.ToString());
			}
		}

		public string PostPayEcsInstanceIds
		{
			get
			{
				return postPayEcsInstanceIds;
			}
			set	
			{
				postPayEcsInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "postPayEcsInstanceIds", value);
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

		public bool? EnableAutomatedSnapshotPolicy
		{
			get
			{
				return enableAutomatedSnapshotPolicy;
			}
			set	
			{
				enableAutomatedSnapshotPolicy = value;
				DictionaryUtil.Add(QueryParameters, "enableAutomatedSnapshotPolicy", value.ToString());
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

        public override InnerDiskQueryByParamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InnerDiskQueryByParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
