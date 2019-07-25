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
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class StartArchiveSQLLogRequest : RpcAcsRequest<StartArchiveSQLLogResponse>
    {
        public StartArchiveSQLLogRequest()
            : base("Rds", "2014-08-15", "StartArchiveSQLLog")
        {
        }

		private long? resourceOwnerId;

		private string database;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string endTime;

		private string dBInstanceId;

		private string startTime;

		private long? ownerId;

		private string user;

		private string queryKeywords;

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

		public string Database
		{
			get
			{
				return database;
			}
			set	
			{
				database = value;
				DictionaryUtil.Add(QueryParameters, "Database", value);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
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

		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
				DictionaryUtil.Add(QueryParameters, "User", value);
			}
		}

		public string QueryKeywords
		{
			get
			{
				return queryKeywords;
			}
			set	
			{
				queryKeywords = value;
				DictionaryUtil.Add(QueryParameters, "QueryKeywords", value);
			}
		}

        public override StartArchiveSQLLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartArchiveSQLLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
