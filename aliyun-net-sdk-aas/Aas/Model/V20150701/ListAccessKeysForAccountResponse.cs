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

namespace Aliyun.Acs.Aas.Model.V20150701
{
	public class ListAccessKeysForAccountResponse : AcsResponse
	{

		private string requestId;

		private string pK;

		private List<ListAccessKeysForAccount_AccessKey> accessKeys;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string PK
		{
			get
			{
				return pK;
			}
			set	
			{
				pK = value;
			}
		}

		public List<ListAccessKeysForAccount_AccessKey> AccessKeys
		{
			get
			{
				return accessKeys;
			}
			set	
			{
				accessKeys = value;
			}
		}

		public class ListAccessKeysForAccount_AccessKey
		{

			private string createTime;

			private string accessKeyId;

			private string accessKeySecret;

			private string accessKeyStatus;

			private string accessKeyType;

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}

			public string AccessKeySecret
			{
				get
				{
					return accessKeySecret;
				}
				set	
				{
					accessKeySecret = value;
				}
			}

			public string AccessKeyStatus
			{
				get
				{
					return accessKeyStatus;
				}
				set	
				{
					accessKeyStatus = value;
				}
			}

			public string AccessKeyType
			{
				get
				{
					return accessKeyType;
				}
				set	
				{
					accessKeyType = value;
				}
			}
		}
	}
}
